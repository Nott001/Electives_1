using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electives_project
{
    public partial class cashier_login : Form
    {
        employee_connection cashier_connection = new employee_connection();

        public cashier_login()
        {
            InitializeComponent();
        }

        private void cashier_login_Load(object sender, EventArgs e)
        {


        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user = username_box.Text.Trim();
            string pass = passwordbox.Text.Trim();

            // Basic validation to save database resources
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Username and Password are required.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Open the connection using your employee_connection class
                cashier_connection.cashier_connString();

                // 2. Setup the query using your database schema column names
                cashier_connection.cashier_sql = "SELECT cashier_id, full_name FROM Cashier " +
                                                 "WHERE username = @user AND password_hash = @pass AND status = 'active'";

                cashier_connection.cashier_cmd();
                cashier_connection.cashier_sql_command.Parameters.AddWithValue("@user", user);
                cashier_connection.cashier_sql_command.Parameters.AddWithValue("@pass", pass);

                // 3. Execute the reader
                using (SqlDataReader reader = cashier_connection.cashier_sql_command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Login Success!
                        string name = reader["full_name"].ToString();
                        MessageBox.Show("Welcome, " + name + "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Navigate to the interface
                        cashier_interface mainForm = new cashier_interface();
                        mainForm.Show();
                        mainForm.cashier_name_txtbox.Text = name;
                    }
                    else
                    {
                        // Login Failure
                        MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
            finally
            {
                // Always close the connection
                cashier_connection.cashier_sql_connection.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            username_box.Clear();
            passwordbox.Clear();
            username_box.Focus();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
