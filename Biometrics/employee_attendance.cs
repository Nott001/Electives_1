using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using libzkfpcsharp;
using Microsoft.Data.SqlClient;

namespace Biometrics
{
    public partial class employee_attendance : Form
    {
        private const int MatchThreshold = 60;

        private readonly employeeDB_connection employeeDbConnection = new employeeDB_connection();
        private readonly System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();

        private IntPtr _deviceHandle = IntPtr.Zero;
        private IntPtr _dbHandle = IntPtr.Zero;
        private bool _deviceOpen;
        private bool _scanInProgress;
        private int _imgWidth;
        private int _imgHeight;
        private byte[]? _imgBuffer;

        public employee_attendance()
        {
            employeeDbConnection.employee_connString();
            InitializeComponent();
        }

        private string DefaultPicturePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employee_pictures", "Default_pfp.jpg");

        private string DefaultFingerprintPicturePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fingerprint_pictures", "default_fingerprint.png");

        private void employee_attendance_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Enabled = false;

            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            clockTimer.Start();
            UpdateClock();

            LoadEmployeePicture(DefaultPicturePath);
            LoadFingerprintPicture(null);
            RefreshAttendanceGrid();
            BeginListeningForFingerprint();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            clockTimer.Stop();
            CloseScanner();
            base.OnFormClosing(e);
        }

        private void clockTimer_Tick(object? sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            current_time_label.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private bool OpenScanner()
        {
            if (_deviceOpen)
            {
                return true;
            }

            int initResult = zkfp2.Init();
            if (initResult != zkfp.ZKFP_ERR_OK)
            {
                MessageBox.Show("Fingerprint SDK initialization failed.");
                return false;
            }

            _deviceHandle = zkfp2.OpenDevice(0);
            if (_deviceHandle == IntPtr.Zero)
            {
                zkfp2.Terminate();
                MessageBox.Show("Fingerprint scanner not found.");
                return false;
            }

            _dbHandle = zkfp2.DBInit();
            if (_dbHandle == IntPtr.Zero)
            {
                zkfp2.CloseDevice(_deviceHandle);
                zkfp2.Terminate();
                _deviceHandle = IntPtr.Zero;
                MessageBox.Show("Failed to initialize fingerprint matching engine.");
                return false;
            }

            byte[] paramBuffer = new byte[4];
            int paramLength = 4;

            zkfp2.GetParameters(_deviceHandle, 1, paramBuffer, ref paramLength);
            _imgWidth = BitConverter.ToInt32(paramBuffer, 0);

            paramLength = 4;
            zkfp2.GetParameters(_deviceHandle, 2, paramBuffer, ref paramLength);
            _imgHeight = BitConverter.ToInt32(paramBuffer, 0);

            _imgBuffer = new byte[_imgWidth * _imgHeight];
            _deviceOpen = true;
            return true;
        }

        private void CloseScanner()
        {
            if (_dbHandle != IntPtr.Zero)
            {
                zkfp2.DBFree(_dbHandle);
                _dbHandle = IntPtr.Zero;
            }

            if (_deviceHandle != IntPtr.Zero)
            {
                zkfp2.CloseDevice(_deviceHandle);
                _deviceHandle = IntPtr.Zero;
            }

            if (_deviceOpen)
            {
                zkfp2.Terminate();
                _deviceOpen = false;
            }
        }

        private void BeginListeningForFingerprint()
        {
            if (_scanInProgress || IsDisposed || !IsHandleCreated)
            {
                return;
            }

            if (!OpenScanner())
            {
                return;
            }

            _scanInProgress = true;
            CaptureAttendanceFingerprint();
        }

        private void CaptureAttendanceFingerprint()
        {
            if (!_deviceOpen || _imgBuffer == null)
            {
                _scanInProgress = false;
                return;
            }

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (_, args) =>
            {
                byte[] templateBuffer = new byte[2048];
                int templateLength = templateBuffer.Length;
                int captureResult;

                do
                {
                    templateLength = templateBuffer.Length;
                    captureResult = zkfp2.AcquireFingerprint(_deviceHandle, _imgBuffer, templateBuffer, ref templateLength);

                    if (captureResult == zkfp.ZKFP_ERR_OK)
                    {
                        break;
                    }

                    Thread.Sleep(200);
                }
                while (_deviceOpen && _scanInProgress);

                args.Result = new object[] { captureResult, templateBuffer, templateLength };
            };

            worker.RunWorkerCompleted += (_, args) =>
            {
                _scanInProgress = false;

                if (args.Error != null || args.Result is not object[] result)
                {
                    MessageBox.Show("Fingerprint capture failed.");
                    BeginListeningForFingerprint();
                    return;
                }

                int captureResult = (int)result[0];
                byte[] templateBuffer = (byte[])result[1];
                int templateLength = (int)result[2];

                if (captureResult != zkfp.ZKFP_ERR_OK)
                {
                    MessageBox.Show("Fingerprint capture stopped. Please try again.");
                    BeginListeningForFingerprint();
                    return;
                }

                byte[] capturedTemplate = new byte[templateLength];
                Array.Copy(templateBuffer, capturedTemplate, templateLength);

                EmployeeMatchResult? match = FindMatchingEmployee(capturedTemplate);
                if (match == null)
                {
                    MessageBox.Show("No registered fingerprint matched this scan.");
                    ClearEmployeeDisplay();
                    BeginListeningForFingerprint();
                    return;
                }

                DisplayEmployee(match);
                RecordAttendance(match.EmpId);
                BeginListeningForFingerprint();
            };

            worker.RunWorkerAsync();
        }

        private EmployeeMatchResult? FindMatchingEmployee(byte[] capturedTemplate)
        {
            using SqlConnection connection = new SqlConnection(employeeDbConnection.employee_connectionString);
            connection.Open();

            const string selectSql = @"
SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_department, picpath, Fingerprint_picpath, FingerprintTemplate
FROM pos_empRegTbl
WHERE FingerprintTemplate IS NOT NULL";

            using SqlCommand command = new SqlCommand(selectSql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            EmployeeMatchResult? bestMatch = null;

            while (reader.Read())
            {
                byte[] storedTemplate = (byte[])reader["FingerprintTemplate"];
                int score = zkfp2.DBMatch(_dbHandle, capturedTemplate, storedTemplate);

                if (score < MatchThreshold)
                {
                    continue;
                }

                if (bestMatch == null || score > bestMatch.Score)
                {
                    bestMatch = new EmployeeMatchResult
                    {
                        EmpId = reader["emp_id"].ToString() ?? string.Empty,
                        FirstName = reader["emp_fname"].ToString() ?? string.Empty,
                        MiddleName = reader["emp_mname"].ToString() ?? string.Empty,
                        Surname = reader["emp_surname"].ToString() ?? string.Empty,
                        Department = reader["emp_department"].ToString() ?? string.Empty,
                        PicturePath = reader["picpath"].ToString() ?? string.Empty,
                        FingerprintPicturePath = reader["Fingerprint_picpath"].ToString() ?? string.Empty,
                        Score = score
                    };
                }
            }

            return bestMatch;
        }

        private void DisplayEmployee(EmployeeMatchResult employee)
        {
            textBox1.Text = employee.EmpId;
            textBox2.Text = employee.FirstName;
            textBox3.Text = employee.MiddleName;
            textBox4.Text = employee.Surname;
            department_box.Text = employee.Department;
            LoadEmployeePicture(employee.PicturePath);
            LoadFingerprintPicture(employee.FingerprintPicturePath);
        }

        private void ClearEmployeeDisplay()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            department_box.Clear();
            time_in_txtbox.Clear();
            timeout_txtbox.Clear();
            LoadEmployeePicture(DefaultPicturePath);
            LoadFingerprintPicture(null);
        }

        private void LoadEmployeePicture(string? imagePath)
        {
            employee_pictureBox.Image?.Dispose();

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                employee_pictureBox.Image = Image.FromFile(imagePath);
                employee_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

            if (File.Exists(DefaultPicturePath))
            {
                employee_pictureBox.Image = Image.FromFile(DefaultPicturePath);
                employee_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                employee_pictureBox.Image = null;
            }
        }

        private void LoadFingerprintPicture(string? imagePath)
        {
            fingerprint_pictureBox.Image?.Dispose();

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                fingerprint_pictureBox.Image = Image.FromFile(imagePath);
                fingerprint_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            if (File.Exists(DefaultFingerprintPicturePath))
            {
                fingerprint_pictureBox.Image = Image.FromFile(DefaultFingerprintPicturePath);
                fingerprint_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                fingerprint_pictureBox.Image = null;
            }
        }

        private void RecordAttendance(string empId)
        {
            using SqlConnection connection = new SqlConnection(employeeDbConnection.employee_connectionString);
            connection.Open();

            DateTime now = DateTime.Now;
            DateTime today = now.Date;

            const string selectSql = @"
SELECT TOP 1 attendance_id, time_in, time_out
FROM attendanceTbl
WHERE emp_id = @emp_id AND log_date = @log_date
ORDER BY attendance_id DESC";

            using SqlCommand selectCommand = new SqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@emp_id", empId);
            selectCommand.Parameters.AddWithValue("@log_date", today);

            int? attendanceId = null;
            DateTime? timeIn = null;
            DateTime? timeOut = null;

            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    attendanceId = Convert.ToInt32(reader["attendance_id"]);
                    if (reader["time_in"] != DBNull.Value)
                    {
                        timeIn = Convert.ToDateTime(reader["time_in"]);
                    }

                    if (reader["time_out"] != DBNull.Value)
                    {
                        timeOut = Convert.ToDateTime(reader["time_out"]);
                    }
                }
            }

            if (attendanceId == null || timeOut != null)
            {
                const string insertSql = @"
INSERT INTO attendanceTbl (emp_id, log_date, time_in, attendance_status, verification_mode)
VALUES (@emp_id, @log_date, @time_in, @attendance_status, @verification_mode)";

                using SqlCommand insertCommand = new SqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@emp_id", empId);
                insertCommand.Parameters.AddWithValue("@log_date", today);
                insertCommand.Parameters.AddWithValue("@time_in", now);
                insertCommand.Parameters.AddWithValue("@attendance_status", "Time In");
                insertCommand.Parameters.AddWithValue("@verification_mode", "Biometric");
                insertCommand.ExecuteNonQuery();

                time_in_txtbox.Text = now.ToString("hh:mm:ss tt");
                timeout_txtbox.Clear();
                MessageBox.Show("Time in recorded.");
            }
            else
            {
                const string updateSql = @"
UPDATE attendanceTbl
SET time_out = @time_out,
    attendance_status = @attendance_status
WHERE attendance_id = @attendance_id";

                using SqlCommand updateCommand = new SqlCommand(updateSql, connection);
                updateCommand.Parameters.AddWithValue("@time_out", now);
                updateCommand.Parameters.AddWithValue("@attendance_status", "Time Out");
                updateCommand.Parameters.AddWithValue("@attendance_id", attendanceId.Value);
                updateCommand.ExecuteNonQuery();

                time_in_txtbox.Text = timeIn?.ToString("hh:mm:ss tt") ?? string.Empty;
                timeout_txtbox.Text = now.ToString("hh:mm:ss tt");
                MessageBox.Show("Time out recorded.");
            }

            RefreshAttendanceGrid();
        }

        private void RefreshAttendanceGrid()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(employeeDbConnection.employee_connectionString);
                using SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT attendance_id, emp_id, log_date, time_in, time_out, attendance_status, verification_mode FROM attendanceTbl ORDER BY attendance_id DESC",
                    connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private sealed class EmployeeMatchResult
        {
            public string EmpId { get; set; } = string.Empty;
            public string FirstName { get; set; } = string.Empty;
            public string MiddleName { get; set; } = string.Empty;
            public string Surname { get; set; } = string.Empty;
            public string Department { get; set; } = string.Empty;
            public string PicturePath { get; set; } = string.Empty;
            public string FingerprintPicturePath { get; set; } = string.Empty;
            public int Score { get; set; }
        }
    }
}
