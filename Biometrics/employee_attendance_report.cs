using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Biometrics
{
    public partial class employee_attendance_report : Form
    {
        private readonly employeeDB_connection employeeDbConnection = new employeeDB_connection();

        public employee_attendance_report()
        {
            employeeDbConnection.employee_connString();
            InitializeComponent();
        }

        private void employee_attendance_report_Load(object sender, EventArgs e)
        {
            PopulateSearchCategories();
            ConfigureAttendanceGrid();
            LoadAttendanceReport();
        }

        private void PopulateSearchCategories()
        {
            searchby_combobox.Items.Clear();
            searchby_combobox.Items.Add("Employee ID");
            searchby_combobox.Items.Add("Employee Name");
            searchby_combobox.Items.Add("Date of Time In");
            searchby_combobox.Items.Add("Date of Time Out");
            searchby_combobox.SelectedIndex = 0;
        }

        private void ConfigureAttendanceGrid()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAttendanceReport(string? searchValue = null, string? searchCategory = null)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(employeeDbConnection.employee_connectionString);
                using SqlCommand command = new SqlCommand(BuildAttendanceReportQuery(searchValue, searchCategory), connection);

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    AddSearchParameters(command, searchValue.Trim(), searchCategory);
                }

                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                FormatAttendanceGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance report: " + ex.Message);
            }
        }

        private static string BuildAttendanceReportQuery(string? searchValue, string? searchCategory)
        {
            string query = @"
                SELECT
                a.attendance_id AS [Attendance ID],
                a.emp_id AS [Employee ID],
                CONCAT(
                e.emp_fname,
                CASE WHEN ISNULL(e.emp_mname, '') = '' THEN '' ELSE ' ' + e.emp_mname END,
                ' ',
                e.emp_surname
                ) AS [Employee Name],
                e.emp_department AS [Department],   
                a.log_date AS [Log Date],
                a.time_in AS [Time In],
                a.time_out AS [Time Out],
                a.attendance_status AS [Attendance Status],
                a.verification_mode AS [Verification Mode]
                FROM attendanceTbl a
                INNER JOIN pos_empRegTbl e ON a.emp_id = e.emp_id";

            if (string.IsNullOrWhiteSpace(searchValue) || string.IsNullOrWhiteSpace(searchCategory))
            {
                return query + " ORDER BY a.attendance_id DESC";
            }

            return searchCategory switch
            {
                "Employee ID" => query + " WHERE a.emp_id LIKE @searchText ORDER BY a.attendance_id DESC",
                "Employee Name" => query + @"
                WHERE
                e.emp_fname LIKE @searchText OR
                e.emp_mname LIKE @searchText OR
                e.emp_surname LIKE @searchText OR
                CONCAT(
                e.emp_fname,
                CASE WHEN ISNULL(e.emp_mname, '') = '' THEN '' ELSE ' ' + e.emp_mname END,
                ' ',
                e.emp_surname
                ) LIKE @searchText
                ORDER BY a.attendance_id DESC",
                "Date of Time In" => query + " WHERE CAST(a.time_in AS date) = @searchDate ORDER BY a.attendance_id DESC",
                "Date of Time Out" => query + " WHERE CAST(a.time_out AS date) = @searchDate ORDER BY a.attendance_id DESC",
                _ => query + " ORDER BY a.attendance_id DESC"
            };
        }

        private static void AddSearchParameters(SqlCommand command, string searchValue, string? searchCategory)
        {
            switch (searchCategory)
            {
                case "Employee ID":
                case "Employee Name":
                    command.Parameters.AddWithValue("@searchText", "%" + searchValue + "%");
                    break;
                case "Date of Time In":
                case "Date of Time Out":
                    if (!DateTime.TryParse(searchValue, out DateTime parsedDate))
                    {
                        throw new ArgumentException("Please enter a valid date.");
                    }

                    command.Parameters.AddWithValue("@searchDate", parsedDate.Date);
                    break;
            }
        }

        private void FormatAttendanceGrid()
        {
            if (dataGridView1.Columns.Contains("Attendance ID"))
            {
                dataGridView1.Columns["Attendance ID"].FillWeight = 70;
            }

            if (dataGridView1.Columns.Contains("Employee ID"))
            {
                dataGridView1.Columns["Employee ID"].FillWeight = 90;
            }

            if (dataGridView1.Columns.Contains("Employee Name"))
            {
                dataGridView1.Columns["Employee Name"].FillWeight = 160;
            }
        }

        private void search_employee_button_Click(object sender, EventArgs e)
        {
            string searchValue = search_employee_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                LoadAttendanceReport();
                return;
            }

            try
            {
                LoadAttendanceReport(searchValue, searchby_combobox.Text);

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No attendance record found.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + " Use a format like 04/15/2026.");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_employee_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            search_employee_button.PerformClick();
        }
    }
}
