using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using libzkfpcsharp;
using Microsoft.Data.SqlClient;

namespace Biometrics
{
    public partial class employee_registration : Form
    {
        private const int CapturesNeeded = 3;

        private readonly employeeDB_connection emp_db_connect = new employeeDB_connection();

        private string picpath = string.Empty;
        private string fingerprintImagePath = string.Empty;
        private IntPtr _deviceHandle = IntPtr.Zero;
        private IntPtr _dbHandle = IntPtr.Zero;
        private bool _deviceOpen;
        private bool _scanInProgress;
        private int _imgWidth;
        private int _imgHeight;
        private byte[]? _imgBuffer;
        private int _capturesDone;
        private readonly byte[][] _partials = new byte[CapturesNeeded][];
        private byte[]? _selectedFingerprintTemplate;

        public employee_registration()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }

        private string DefaultPicturePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employee_pictures", "Default_pfp.jpg");

        private string FingerprintImageDirectory =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fingerprint_pictures");

        private void employee_registration_Load(object sender, EventArgs e)
        {
            for (int age = 18; age <= 60; age++)
            {
                age_comboBox.Items.Add(age.ToString());
            }

            if (age_comboBox.Items.Count > 0)
            {
                age_comboBox.SelectedIndex = 0;
            }

            gender_comboBox.Items.Add("Male");
            gender_comboBox.Items.Add("Female");
            status_comboBox.Items.Add("Single");
            status_comboBox.Items.Add("Married");

            pic_path_box.Hide();
            fingerprint_image_txtbox.Hide();
            dataGridView1.DataError += dataGridView1_DataError;

            LoadDefaultEmployeePicture();
            ResetFingerprintState(clearSelectedFingerprint: true);
            SetFingerprintButtonStates();
            RefreshEmployeeGrid();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseScanner();
            base.OnFormClosing(e);
        }

        private void cleartextboxes()
        {
            gender_comboBox.SelectedIndex = -1;
            status_comboBox.SelectedIndex = -1;
            age_comboBox.SelectedIndex = -1;

            college_graduated_date.Value = DateTime.Today;
            emp_hired_date.Value = DateTime.Today;

            emp_idTxtBox.Clear();
            first_name_box.Clear();
            middle_name_box.Clear();
            surname_box.Clear();
            sss_num_box.Clear();
            tin_num_box.Clear();
            philhealth_num_box.Clear();
            pagibig_num_box.Clear();
            height_box.Clear();
            weight_box.Clear();
            years_stay_box.Clear();
            house_num_box.Clear();
            subd_name_box.Clear();
            phase_num_box.Clear();
            street_box.Clear();
            barangay_box.Clear();
            municipality_box.Clear();
            city_box.Clear();
            province_box.Clear();
            country_box.Clear();
            zipcode_box.Clear();
            college_school_box.Clear();
            college_school_address_box.Clear();
            college_course_box.Clear();
            position_box.Clear();
            emp_status_box.Clear();
            department_box.Clear();
            pic_path_box.Clear();
            fingerprint_image_txtbox.Clear();

            picpath = string.Empty;
            fingerprintImagePath = string.Empty;

            LoadDefaultEmployeePicture();
            ResetFingerprintState(clearSelectedFingerprint: true);
            emp_idTxtBox.Focus();
        }

        private void LoadDefaultEmployeePicture()
        {
            LoadEmployeePicture(DefaultPicturePath);
        }

        private void LoadEmployeePicture(string? imagePath)
        {
            employee_picturebox.Image?.Dispose();

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                employee_picturebox.Image = Image.FromFile(imagePath);
                return;
            }

            if (File.Exists(DefaultPicturePath))
            {
                employee_picturebox.Image = Image.FromFile(DefaultPicturePath);
            }
            else
            {
                employee_picturebox.Image = null;
            }
        }

        private void LoadFingerprintImage(string? imagePath)
        {
            fingerprint_picturebox.Image?.Dispose();

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                fingerprint_picturebox.Image = Image.FromFile(imagePath);
                fingerprint_picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            fingerprint_picturebox.Image = null;
        }

        private void RefreshEmployeeGrid()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(emp_db_connect.employee_connectionString);
                using SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM pos_empRegTbl", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                ConfigureEmployeeGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ConfigureEmployeeGrid()
        {
            string[] hiddenColumns =
            {
                "FingerprintTemplate",
                "Fingerprint_picpath"
            };

            foreach (string columnName in hiddenColumns)
            {
                if (dataGridView1.Columns.Contains(columnName))
                {
                    dataGridView1.Columns[columnName].Visible = false;
                }
            }
        }

        private void dataGridView1_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void ShowFingerprintStatus(string message)
        {
            label38.Text = message;
        }

        private void SetFingerprintButtonStates()
        {
            scan_fingerprint_button.Enabled = !_scanInProgress;
            retry_scan_button.Enabled = _deviceOpen && !_scanInProgress;
            delete_fingerprint_button.Enabled = !_scanInProgress && _selectedFingerprintTemplate != null;
        }

        private void ResetCaptureState()
        {
            _capturesDone = 0;
            _scanInProgress = false;
            Array.Clear(_partials, 0, _partials.Length);
        }

        private void ResetFingerprintState(bool clearSelectedFingerprint)
        {
            ResetCaptureState();

            if (clearSelectedFingerprint)
            {
                _selectedFingerprintTemplate = null;
                fingerprintImagePath = string.Empty;
                fingerprint_image_txtbox.Clear();
            }

            fingerprint_picturebox.Image?.Dispose();
            fingerprint_picturebox.Image = null;

            ShowFingerprintStatus(_selectedFingerprintTemplate == null
                ? "No fingerprint selected."
                : "Fingerprint selected and ready to save.");
            SetFingerprintButtonStates();
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
            ShowFingerprintStatus("Scanner connected. Ready to scan.");
            SetFingerprintButtonStates();
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

        private void RenderFingerprintImage(byte[] rawGray, int width, int height)
        {
            try
            {
                Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
                ColorPalette palette = bitmap.Palette;

                for (int index = 0; index < 256; index++)
                {
                    palette.Entries[index] = Color.FromArgb(index, index, index);
                }

                bitmap.Palette = palette;

                BitmapData bitmapData = bitmap.LockBits(
                    new Rectangle(0, 0, width, height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format8bppIndexed);

                System.Runtime.InteropServices.Marshal.Copy(rawGray, 0, bitmapData.Scan0, rawGray.Length);
                bitmap.UnlockBits(bitmapData);

                fingerprint_picturebox.Image?.Dispose();
                fingerprint_picturebox.Image = bitmap;
                fingerprint_picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("Unable to display the scanned fingerprint image.");
            }
        }

        private void SaveThirdFingerprintImage()
        {
            if (fingerprint_picturebox.Image == null || string.IsNullOrWhiteSpace(emp_idTxtBox.Text))
            {
                return;
            }

            Directory.CreateDirectory(FingerprintImageDirectory);
            string fileName = $"{emp_idTxtBox.Text.Trim()}_fingerprint_3.png";
            string filePath = Path.Combine(FingerprintImageDirectory, fileName);

            using Bitmap bitmapCopy = new Bitmap(fingerprint_picturebox.Image);
            bitmapCopy.Save(filePath, ImageFormat.Png);

            fingerprintImagePath = filePath;
            fingerprint_image_txtbox.Text = filePath;
        }

        private void EnsureFingerprintImagePath()
        {
            if (_selectedFingerprintTemplate == null)
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(fingerprintImagePath) && File.Exists(fingerprintImagePath))
            {
                fingerprint_image_txtbox.Text = fingerprintImagePath;
                return;
            }

            SaveThirdFingerprintImage();
        }

        private void MergeTemplates()
        {
            byte[] mergedTemplate = new byte[2048];
            int mergedLength = mergedTemplate.Length;

            int mergeResult = zkfp2.DBMerge(
                _dbHandle,
                _partials[0],
                _partials[1],
                _partials[2],
                mergedTemplate,
                ref mergedLength);

            if (mergeResult != zkfp.ZKFP_ERR_OK)
            {
                ResetCaptureState();
                ShowFingerprintStatus($"Fingerprint merge failed. Error code: {mergeResult}");
                SetFingerprintButtonStates();
                return;
            }

            _selectedFingerprintTemplate = new byte[mergedLength];
            Array.Copy(mergedTemplate, _selectedFingerprintTemplate, mergedLength);
            _scanInProgress = false;
            ShowFingerprintStatus("Fingerprint captured successfully. Ready to save with employee information.");
            SetFingerprintButtonStates();
        }

        private void CaptureNextSample()
        {
            if (!_deviceOpen || _imgBuffer == null)
            {
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
                if (args.Error != null || args.Result is not object[] result)
                {
                    _scanInProgress = false;
                    ShowFingerprintStatus("Fingerprint capture failed.");
                    SetFingerprintButtonStates();
                    return;
                }

                int captureResult = (int)result[0];
                byte[] templateBuffer = (byte[])result[1];
                int templateLength = (int)result[2];

                if (captureResult != zkfp.ZKFP_ERR_OK)
                {
                    _scanInProgress = false;
                    ShowFingerprintStatus("Fingerprint capture stopped. Click Scan Fingerprint to try again.");
                    SetFingerprintButtonStates();
                    return;
                }

                _partials[_capturesDone] = new byte[templateLength];
                Array.Copy(templateBuffer, _partials[_capturesDone], templateLength);
                _capturesDone++;

                RenderFingerprintImage(_imgBuffer, _imgWidth, _imgHeight);

                if (_capturesDone < CapturesNeeded)
                {
                    ShowFingerprintStatus($"Lift and place the same finger again. ({_capturesDone} of {CapturesNeeded})");
                    CaptureNextSample();
                    return;
                }

                SaveThirdFingerprintImage();
                MergeTemplates();
            };

            worker.RunWorkerAsync();
        }

        private void StartFingerprintScan()
        {
            if (!OpenScanner())
            {
                return;
            }

            ResetCaptureState();
            _selectedFingerprintTemplate = null;
            fingerprintImagePath = string.Empty;
            fingerprint_image_txtbox.Clear();
            _scanInProgress = true;
            ShowFingerprintStatus("Place the finger on the scanner. (1 of 3)");
            SetFingerprintButtonStates();
            CaptureNextSample();
        }

        private bool ValidateFingerprintBeforeAdd()
        {
            if (_selectedFingerprintTemplate != null)
            {
                return true;
            }

            MessageBox.Show(
                "Scan a fingerprint first before registering a new employee.",
                "Fingerprint Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        private void scan_fingerprint_button_Click(object sender, EventArgs e)
        {
            StartFingerprintScan();
        }

        private void retry_scan_button_Click(object sender, EventArgs e)
        {
            if (!_deviceOpen && !OpenScanner())
            {
                return;
            }

            StartFingerprintScan();
        }

        private void delete_fingerprint_button_Click(object sender, EventArgs e)
        {
            ResetFingerprintState(clearSelectedFingerprint: true);
        }

        private void emp_timecard_button_Click(object sender, EventArgs e)
        {
            employee_attendance emp_attendance = new employee_attendance();
            emp_attendance.ShowDialog();
        }

        private void attendance_rec_button_Click(object sender, EventArgs e)
        {
            employee_attendance_report attendance_report = new employee_attendance_report();
            attendance_report.ShowDialog();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (!ValidateFingerprintBeforeAdd())
            {
                return;
            }

            try
            {
                EnsureFingerprintImagePath();

                using SqlConnection connection = new SqlConnection(emp_db_connect.employee_connectionString);
                connection.Open();

                const string insertSql = @"
INSERT INTO pos_empRegTbl (
    emp_id,
    emp_fname,
    emp_mname,
    emp_surname,
    emp_age,
    emp_gender,
    emp_sss_no,
    emp_tin_no,
    emp_philhealth_no,
    emp_pagibig_no,
    emp_status,
    emp_height,
    emp_weight,
    add_years_stay,
    add_house_no,
    add_subdivision_name,
    add_phase_number,
    add_street,
    add_barangay,
    add_municipality,
    add_city,
    add_province,
    add_country,
    add_zipcode,
    college_school_name,
    college_address,
    college_course,
    college_year_grad,
    position,
    emp_work_status,
    emp_date_hired,
    emp_department,
    picpath,
    FingerprintTemplate,
    Fingerprint_picpath
)
VALUES (
    @emp_id,
    @emp_fname,
    @emp_mname,
    @emp_surname,
    @emp_age,
    @emp_gender,
    @emp_sss_no,
    @emp_tin_no,
    @emp_philhealth_no,
    @emp_pagibig_no,
    @emp_status,
    @emp_height,
    @emp_weight,
    @add_years_stay,
    @add_house_no,
    @add_subdivision_name,
    @add_phase_number,
    @add_street,
    @add_barangay,
    @add_municipality,
    @add_city,
    @add_province,
    @add_country,
    @add_zipcode,
    @college_school_name,
    @college_address,
    @college_course,
    @college_year_grad,
    @position,
    @emp_work_status,
    @emp_date_hired,
    @emp_department,
    @picpath,
    @FingerprintTemplate,
    @Fingerprint_picpath
)";

                using SqlCommand command = new SqlCommand(insertSql, connection);
                AddEmployeeParameters(command, includeFingerprint: true);
                command.ExecuteNonQuery();

                RefreshEmployeeGrid();
                MessageBox.Show("Employee successfully added.");
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureFingerprintImagePath();

                using SqlConnection connection = new SqlConnection(emp_db_connect.employee_connectionString);
                connection.Open();

                string updateSql = @"
UPDATE pos_empRegTbl SET
    emp_fname = @emp_fname,
    emp_mname = @emp_mname,
    emp_surname = @emp_surname,
    emp_age = @emp_age,
    emp_gender = @emp_gender,
    emp_sss_no = @emp_sss_no,
    emp_tin_no = @emp_tin_no,
    emp_philhealth_no = @emp_philhealth_no,
    emp_pagibig_no = @emp_pagibig_no,
    emp_status = @emp_status,
    emp_height = @emp_height,
    emp_weight = @emp_weight,
    add_years_stay = @add_years_stay,
    add_house_no = @add_house_no,
    add_subdivision_name = @add_subdivision_name,
    add_phase_number = @add_phase_number,
    add_street = @add_street,
    add_barangay = @add_barangay,
    add_municipality = @add_municipality,
    add_city = @add_city,
    add_province = @add_province,
    add_country = @add_country,
    add_zipcode = @add_zipcode,
    college_school_name = @college_school_name,
    college_address = @college_address,
    college_course = @college_course,
    college_year_grad = @college_year_grad,
    position = @position,
    emp_work_status = @emp_work_status,
    emp_date_hired = @emp_date_hired,
    emp_department = @emp_department,
    picpath = @picpath";

                if (_selectedFingerprintTemplate != null)
                {
                    updateSql += ", FingerprintTemplate = @FingerprintTemplate, Fingerprint_picpath = @Fingerprint_picpath";
                }

                updateSql += " WHERE emp_id = @emp_id";

                using SqlCommand command = new SqlCommand(updateSql, connection);
                AddEmployeeParameters(command, includeFingerprint: _selectedFingerprintTemplate != null);
                command.ExecuteNonQuery();

                RefreshEmployeeGrid();
                MessageBox.Show("Record updated successfully.");
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddEmployeeParameters(SqlCommand command, bool includeFingerprint)
        {
            command.Parameters.AddWithValue("@emp_id", emp_idTxtBox.Text.Trim());
            command.Parameters.AddWithValue("@emp_fname", first_name_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_mname", middle_name_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_surname", surname_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_age", ParseNullableInt(age_comboBox.Text));
            command.Parameters.AddWithValue("@emp_gender", gender_comboBox.Text.Trim());
            command.Parameters.AddWithValue("@emp_sss_no", sss_num_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_tin_no", tin_num_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_philhealth_no", philhealth_num_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_pagibig_no", pagibig_num_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_status", status_comboBox.Text.Trim());
            command.Parameters.AddWithValue("@emp_height", height_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_weight", weight_box.Text.Trim());
            command.Parameters.AddWithValue("@add_years_stay", years_stay_box.Text.Trim());
            command.Parameters.AddWithValue("@add_house_no", house_num_box.Text.Trim());
            command.Parameters.AddWithValue("@add_subdivision_name", subd_name_box.Text.Trim());
            command.Parameters.AddWithValue("@add_phase_number", phase_num_box.Text.Trim());
            command.Parameters.AddWithValue("@add_street", street_box.Text.Trim());
            command.Parameters.AddWithValue("@add_barangay", barangay_box.Text.Trim());
            command.Parameters.AddWithValue("@add_municipality", municipality_box.Text.Trim());
            command.Parameters.AddWithValue("@add_city", city_box.Text.Trim());
            command.Parameters.AddWithValue("@add_province", province_box.Text.Trim());
            command.Parameters.AddWithValue("@add_country", country_box.Text.Trim());
            command.Parameters.AddWithValue("@add_zipcode", zipcode_box.Text.Trim());
            command.Parameters.AddWithValue("@college_school_name", college_school_box.Text.Trim());
            command.Parameters.AddWithValue("@college_address", college_school_address_box.Text.Trim());
            command.Parameters.AddWithValue("@college_course", college_course_box.Text.Trim());
            command.Parameters.AddWithValue("@college_year_grad", college_graduated_date.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@position", position_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_work_status", emp_status_box.Text.Trim());
            command.Parameters.AddWithValue("@emp_date_hired", emp_hired_date.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@emp_department", department_box.Text.Trim());
            command.Parameters.AddWithValue("@picpath", pic_path_box.Text.Trim());

            if (includeFingerprint)
            {
                command.Parameters.Add("@FingerprintTemplate", SqlDbType.VarBinary).Value =
                    _selectedFingerprintTemplate ?? Array.Empty<byte>();
                command.Parameters.AddWithValue("@Fingerprint_picpath", fingerprintImagePath);
            }
        }

        private static object ParseNullableInt(string value)
        {
            return int.TryParse(value, out int parsedValue) ? parsedValue : DBNull.Value;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(emp_db_connect.employee_connectionString);
                connection.Open();
                using SqlCommand command = new SqlCommand(
                    "DELETE FROM pos_empRegTbl WHERE emp_id = @emp_id",
                    connection);
                command.Parameters.AddWithValue("@emp_id", emp_idTxtBox.Text.Trim());
                command.ExecuteNonQuery();

                RefreshEmployeeGrid();
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(emp_db_connect.employee_connectionString);
                connection.Open();
                using SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT * FROM pos_empRegTbl WHERE emp_id = @emp_id",
                    connection);
                adapter.SelectCommand.Parameters.AddWithValue("@emp_id", emp_idTxtBox.Text.Trim());

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                ConfigureEmployeeGrid();

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No record found for this Employee ID.");
                    return;
                }

                DataRow row = table.Rows[0];

                first_name_box.Text = row["emp_fname"].ToString();
                middle_name_box.Text = row["emp_mname"].ToString();
                surname_box.Text = row["emp_surname"].ToString();
                age_comboBox.Text = row["emp_age"].ToString();
                gender_comboBox.Text = row["emp_gender"].ToString();
                status_comboBox.Text = row["emp_status"].ToString();
                emp_status_box.Text = row["emp_work_status"].ToString();
                position_box.Text = row["position"].ToString();
                department_box.Text = row["emp_department"].ToString();
                sss_num_box.Text = row["emp_sss_no"].ToString();
                tin_num_box.Text = row["emp_tin_no"].ToString();
                philhealth_num_box.Text = row["emp_philhealth_no"].ToString();
                pagibig_num_box.Text = row["emp_pagibig_no"].ToString();
                height_box.Text = row["emp_height"].ToString();
                weight_box.Text = row["emp_weight"].ToString();
                years_stay_box.Text = row["add_years_stay"].ToString();
                house_num_box.Text = row["add_house_no"].ToString();
                subd_name_box.Text = row["add_subdivision_name"].ToString();
                phase_num_box.Text = row["add_phase_number"].ToString();
                street_box.Text = row["add_street"].ToString();
                barangay_box.Text = row["add_barangay"].ToString();
                municipality_box.Text = row["add_municipality"].ToString();
                city_box.Text = row["add_city"].ToString();
                province_box.Text = row["add_province"].ToString();
                country_box.Text = row["add_country"].ToString();
                zipcode_box.Text = row["add_zipcode"].ToString();
                college_school_box.Text = row["college_school_name"].ToString();
                college_school_address_box.Text = row["college_address"].ToString();
                college_course_box.Text = row["college_course"].ToString();
                pic_path_box.Text = row["picpath"].ToString();
                fingerprint_image_txtbox.Text = row["Fingerprint_picpath"].ToString();
                fingerprintImagePath = fingerprint_image_txtbox.Text;

                if (DateTime.TryParse(row["college_year_grad"].ToString(), out DateTime collegeDate))
                {
                    college_graduated_date.Value = collegeDate;
                }

                if (DateTime.TryParse(row["emp_date_hired"].ToString(), out DateTime hireDate))
                {
                    emp_hired_date.Value = hireDate;
                }

                LoadEmployeePicture(pic_path_box.Text);

                if (row["FingerprintTemplate"] == DBNull.Value)
                {
                    ResetFingerprintState(clearSelectedFingerprint: true);
                    ShowFingerprintStatus("No fingerprint selected.");
                }
                else
                {
                    LoadFingerprintImage(fingerprint_image_txtbox.Text);
                    ShowFingerprintStatus("Fingerprint already saved for this employee.");
                    SetFingerprintButtonStates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                picpath = openFileDialog1.FileName;
                pic_path_box.Text = picpath;
                LoadEmployeePicture(picpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
