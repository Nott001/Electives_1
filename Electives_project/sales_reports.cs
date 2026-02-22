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
    public partial class sales_reports : Form
    {
        // Use the existing connection class
        cashier_connection db = new cashier_connection();
        public sales_reports()
        {
            InitializeComponent();
            // Initialize the ComboBox with the required search categories
            if (optionCombo.Items.Count == 0)
            {
                optionCombo.Items.Add("Sale ID");
                optionCombo.Items.Add("Date (YYYY-MM-DD)");
                optionCombo.Items.Add("Cashier ID");
                optionCombo.Items.Add("Cashier Name");
                optionCombo.SelectedIndex = 0;
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string input = optionInputTxtbox.Text.Trim();
            string selectedOption = optionCombo.SelectedItem.ToString();

            // Base SQL query joining Sale and Cashier tables
            string sql = @"SELECT s.sale_id AS [Sale ID], 
                                  s.sale_datetime AS [Date/Time], 
                                  c.full_name AS [Cashier Name], 
                                  s.total_amount AS [Total Amount]
                           FROM Sale s
                           JOIN Cashier c ON s.cashier_id = c.cashier_id";

            // Add filter based on selection
            if (!string.IsNullOrEmpty(input))
            {
                if (selectedOption == "Sale ID")
                    sql += " WHERE s.sale_id = @input";
                else if (selectedOption == "Date (YYYY-MM-DD)")
                    sql += " WHERE CAST(s.sale_datetime AS DATE) = @input";
                else if (selectedOption == "Cashier ID")
                    sql += " WHERE s.cashier_id = @input";
                else if (selectedOption == "Cashier Name")
                    sql += " WHERE c.full_name LIKE @input";
            }

            try
            {
                db.cashier_connString(); // Open connection
                db.cashier_cmd(sql);     // Prepare command

                if (!string.IsNullOrEmpty(input))
                {
                    // Use wildcards for name search
                    string paramValue = (selectedOption == "Cashier Name") ? "%" + input + "%" : input;
                    db.cashier_sql_command.Parameters.AddWithValue("@input", paramValue);
                }

                // Fill the DataGridView
                SqlDataAdapter da = new SqlDataAdapter(db.cashier_sql_command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_sale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            finally
            {
                if (db.cashier_sql_connection != null)
                    db.cashier_sql_connection.Close();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_sale_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_sale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            try
            {
                // Get the Sale ID from the selected row
                int saleId = Convert.ToInt32(dataGridView_sale.Rows[e.RowIndex].Cells["Sale ID"].Value);

                db.cashier_connString(); //

                // --- PART 1: LOAD SALE ITEMS ---
                string itemSql = @"SELECT p.product_name AS [Item], 
                                  si.quantity AS [Qty], 
                                  si.unit_price AS [Price],
                                  si.subtotal AS [Subtotal]
                           FROM Sale_Item si
                           JOIN Product p ON si.product_id = p.product_id
                           WHERE si.sale_id = @sid";

                db.cashier_cmd(itemSql); //
                db.cashier_sql_command.Parameters.AddWithValue("@sid", saleId); //

                SqlDataAdapter daItems = new SqlDataAdapter(db.cashier_sql_command);
                DataTable dtItems = new DataTable();
                daItems.Fill(dtItems);
                dataGridView_sale_item.DataSource = dtItems; //

                // --- PART 2: LOAD PAYMENT DETAILS (New Section) ---
                // Clear parameters before the next command
                db.cashier_sql_command.Parameters.Clear();

                string paymentSql = @"SELECT payment_method AS [Method], 
                                     amount_paid AS [Amount], 
                                     payment_datetime AS [Paid At] 
                              FROM Payment 
                              WHERE sale_id = @sid";

                db.cashier_cmd(paymentSql); //
                db.cashier_sql_command.Parameters.AddWithValue("@sid", saleId);

                SqlDataAdapter daPay = new SqlDataAdapter(db.cashier_sql_command);
                DataTable dtPay = new DataTable();
                daPay.Fill(dtPay);

                // Display results in your third DataGridView
                dataGridView_payment.DataSource = dtPay;
                dataGridView_payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message); //
            }
            finally
            {
                if (db.cashier_sql_connection != null)
                    db.cashier_sql_connection.Close(); //
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // 1. Check if a row is actually selected in the Sales grid
            if (dataGridView_sale.SelectedRows.Count > 0 || dataGridView_sale.CurrentRow != null)
            {
                // Get the Sale ID from the selected row
                // We use the column name "Sale ID" as defined in your search query
                int rowIndex = dataGridView_sale.CurrentCell.RowIndex;
                string saleIdValue = dataGridView_sale.Rows[rowIndex].Cells["Sale ID"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Sale #{saleIdValue}?\n\nThis will also permanently remove all associated items and payment records.",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        db.cashier_connString(); //

                        // 2. Delete the Sale record
                        // This triggers the ON DELETE CASCADE for Sale_Item and Payment tables
                        string sql = "DELETE FROM Sale WHERE sale_id = @sid";
                        db.cashier_cmd(sql); //
                        db.cashier_sql_command.Parameters.AddWithValue("@sid", saleIdValue);

                        db.cashier_sql_command.ExecuteNonQuery();
                        db.cashier_sql_connection.Close();

                        // 3. Refresh the UI
                        MessageBox.Show("Sale record and all associated data deleted successfully.");

                        // Clear the detail grids since the parent no longer exists
                        dataGridView_sale_item.DataSource = null;
                        dataGridView_payment.DataSource = null;

                        // Re-run the search to update the main sales grid
                        search_button_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting sale: " + ex.Message);
                    }
                    finally
                    {
                        if (db.cashier_sql_connection.State == ConnectionState.Open)
                            db.cashier_sql_connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a sale in the grid first.");
            }
        }
    }
}
