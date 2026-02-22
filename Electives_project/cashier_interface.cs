using System.Data;
using System.Data.SqlClient;
using ZXing.QrCode.Internal;

namespace Electives_project
{
    public partial class cashier_interface : Form
    {
        cashier_connection db = new cashier_connection();
        cashier_helperclass helper = new cashier_helperclass();

        public cashier_interface()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetupNumpad();

            // Ensure barcode textbox is focused on start
            this.Shown += cashier_interface_Load;

            // Mutually exclusive discount logic: Senior OR PWD (not both)
            senior_discount_checkbox.CheckedChanged += (s, e) =>
            {
                if (senior_discount_checkbox.Checked) pwd_discount_checkbox.Checked = false;
                RefreshTotals();
            };
            pwd_discount_checkbox.CheckedChanged += (s, e) =>
            {
                if (pwd_discount_checkbox.Checked) senior_discount_checkbox.Checked = false;
                RefreshTotals();
            };

            // Voucher/Coupon can be used with either
            coupons_discount_checkbox.CheckedChanged += (s, e) => RefreshTotals();
        }

        private void cashier_interface_Load(object sender, EventArgs e)
        {
            barcode_txtbox.Focus();
        }

        private void SetupNumpad()
        {
            num0_button.Click += (s, e) => barcode_txtbox.AppendText("0");
            num1_button.Click += (s, e) => barcode_txtbox.AppendText("1");
            num2_button.Click += (s, e) => barcode_txtbox.AppendText("2");
            num3_button.Click += (s, e) => barcode_txtbox.AppendText("3");
            num4_button.Click += (s, e) => barcode_txtbox.AppendText("4");
            num5_button.Click += (s, e) => barcode_txtbox.AppendText("5");
            num6_button.Click += (s, e) => barcode_txtbox.AppendText("6");
            num7_button.Click += (s, e) => barcode_txtbox.AppendText("7");
            num8_button.Click += (s, e) => barcode_txtbox.AppendText("8");
            num9_button.Click += (s, e) => barcode_txtbox.AppendText("9");
            clear_button.Click += (s, e) => barcode_txtbox.Clear();
            delete_button.Click += (s, e) =>
            {
                if (barcode_txtbox.Text.Length > 0)
                    barcode_txtbox.Text = barcode_txtbox.Text.Substring(0, barcode_txtbox.Text.Length - 1);
            };
            enter_button.Click += (s, e) => ProcessAutomaticScan(barcode_txtbox.Text.Trim());
        }


        private void ProcessAutomaticScan(string code)
        {
            if (string.IsNullOrEmpty(code)) return;

            try
            {
                db.cashier_connString();

                // 1. Find the product details
                db.cashier_cmd("SELECT product_id, product_name, unit_price FROM Product WHERE barcode = @code");
                db.cashier_sql_command.Parameters.AddWithValue("@code", code);

                int prodId = 0;
                decimal price = 0;

                using (SqlDataReader reader = db.cashier_sql_command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        prodId = (int)reader["product_id"];
                        price = (decimal)reader["unit_price"];
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                        return;
                    }
                }

                // 2. Create Sale header if this is the first item
                if (helper.CurrentSaleId == -1)
                {
                    db.cashier_cmd("INSERT INTO Sale (cashier_id, total_amount, sale_datetime) OUTPUT INSERTED.sale_id VALUES (@cid, 0, GETDATE())");
                    db.cashier_sql_command.Parameters.AddWithValue("@cid", cashier_helperclass.LoggedInCashierId);
                    helper.CurrentSaleId = (int)db.cashier_sql_command.ExecuteScalar();
                }

                // 3. Automated Quantity Stacking (Update if exists, else Insert)
                db.cashier_cmd(@"
                    IF EXISTS (SELECT 1 FROM Sale_Item WHERE sale_id = @sid AND product_id = @pid)
                        UPDATE Sale_Item SET quantity = quantity + 1, subtotal = (quantity + 1) * unit_price 
                        WHERE sale_id = @sid AND product_id = @pid
                    ELSE
                        INSERT INTO Sale_Item (sale_id, product_id, quantity, unit_price, subtotal) 
                        VALUES (@sid, @pid, 1, @price, @price)");

                db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                db.cashier_sql_command.Parameters.AddWithValue("@pid", prodId);
                db.cashier_sql_command.Parameters.AddWithValue("@price", price);
                db.cashier_sql_command.ExecuteNonQuery();

                db.cashier_sql_connection.Close();

                LoadDataGridView(); // Display products in grid
                RefreshTotals();    // Calculate totals
                barcode_txtbox.Clear();
                barcode_txtbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Scan Error: " + ex.Message);
            }
        }

        private void LoadDataGridView()
        {
            db.cashier_connString();

            db.cashier_cmd(@"
                SELECT 
                    p.product_id,
                    p.product_name AS [Product Name], 
                    si.quantity AS [Quantity], 
                    si.subtotal AS [Price]
                FROM Sale_Item si
                JOIN Product p ON si.product_id = p.product_id
                WHERE si.sale_id = @sid");

            db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);

            SqlDataAdapter da = new SqlDataAdapter(db.cashier_sql_command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // 👇 hide internal ID column
            dataGridView1.Columns["product_id"].Visible = false;

            db.cashier_sql_connection.Close();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void circlePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            barcode_txtbox.Clear();
            barcode_txtbox.Focus();
        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get values from selected row
                int productId = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["product_id"].Value);

                string productName =
                    dataGridView1.SelectedRows[0].Cells["Product Name"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to remove {productName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        db.cashier_connString();

                        // ✅ DELETE using product_id (NO SUBQUERY)
                        string sql = @"DELETE FROM Sale_Item
                               WHERE sale_id = @sid
                               AND product_id = @pid";

                        db.cashier_cmd(sql);

                        db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                        db.cashier_sql_command.Parameters.AddWithValue("@pid", productId);

                        db.cashier_sql_command.ExecuteNonQuery();
                        db.cashier_sql_connection.Close();

                        // Refresh UI
                        LoadDataGridView();
                        RefreshTotals();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the table to delete.");
            }
        }

        private void process_payment_button_Click(object sender, EventArgs e)
        {
            // Payment Method Validation
            string method = "";
            if (cash_checkbox.Checked) method = "cash";
            else if (card_checkbox.Checked) method = "card";
            else if (QR_checkbox.Checked) method = "gcash";

            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please select a payment method (Cash, Card, or QR) first.");
                return;
            }

            if (helper.CurrentSaleId == -1)
            {
                MessageBox.Show("No transaction started yet.");
                return;
            }

            db.cashier_connString();

            db.cashier_cmd("SELECT COUNT(*) FROM Sale_Item WHERE sale_id = @sid");
            db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);

            int itemCount = (int)db.cashier_sql_command.ExecuteScalar();
            db.cashier_sql_connection.Close();

            if (itemCount == 0)
            {
                MessageBox.Show("No items scanned yet.");
                return;
            }

            try
            {
                db.cashier_connString();

                // 1. Finalize the Sale table with the calculated total
                db.cashier_cmd("UPDATE Sale SET total_amount = @total WHERE sale_id = @sid");
                db.cashier_sql_command.Parameters.AddWithValue("@total", decimal.Parse(total_txtbox.Text));
                db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                db.cashier_sql_command.ExecuteNonQuery();

                // 2. Automatically create Payment entry
                db.cashier_cmd("INSERT INTO Payment (sale_id, payment_method, amount_paid) VALUES (@sid, @method, @paid)");
                db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                db.cashier_sql_command.Parameters.AddWithValue("@method", method);
                db.cashier_sql_command.Parameters.AddWithValue("@paid", decimal.Parse(total_txtbox.Text));
                db.cashier_sql_command.ExecuteNonQuery();

                db.cashier_cmd(@"UPDATE Product 
                 SET stock_quantity = stock_quantity - si.quantity
                 FROM Product p
                 JOIN Sale_Item si ON p.product_id = si.product_id
                 WHERE si.sale_id = @sid");
                db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                db.cashier_sql_command.ExecuteNonQuery();
                db.cashier_sql_connection.Close();

                receipt_print receipt = new receipt_print();

                receipt.total_items_txtbox.Text = total_txtbox.Text;
                receipt.subtotal_txtbox.Text = subtotal_txtbox.Text;
                receipt.discount_txtbox.Text = discount_txtbox.Text;
                receipt.vat_txtbox.Text = vat_txtbox.Text;
                receipt.total_amount_txtbox.Text = total_txtbox.Text;
                receipt.LoadItems(dataGridView1);

                receipt.ShowDialog();

                MessageBox.Show("Transaction Processed Successfully!");
                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Processing Error: " + ex.Message);
            }
        }



        private void barcode_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ProcessAutomaticScan(barcode_txtbox.Text.Trim());
            }
        }

        private void RefreshTotals()
        {
            if (helper.CurrentSaleId == -1) return;

            db.cashier_connString();
            db.cashier_cmd("SELECT SUM(subtotal), SUM(quantity) FROM Sale_Item WHERE sale_id = @sid");
            db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);

            using (SqlDataReader r = db.cashier_sql_command.ExecuteReader())
            {
                if (r.Read())
                {
                    decimal subtotal = r[0] == DBNull.Value ? 0m : (decimal)r[0];
                    int totalItems = r[1] == DBNull.Value ? 0 : Convert.ToInt32(r[1]);

                    items_txtbox.Text = totalItems.ToString();

                    var calc = helper.GetCalculations(
                        subtotal,
                        senior_discount_checkbox.Checked,
                        pwd_discount_checkbox.Checked,
                        coupons_discount_checkbox.Checked
                    );

                    subtotal_txtbox.Text = calc.subtotal.ToString("N2");
                    discount_txtbox.Text = calc.discount.ToString("N2");
                    total_txtbox.Text = calc.total.ToString("N2");
                    vat_txtbox.Text = calc.vat.ToString("N2");
                }
            }
            db.cashier_sql_connection.Close();
        }

        private void ResetForm()
        {
            helper.CurrentSaleId = -1;
            dataGridView1.DataSource = null;
            subtotal_txtbox.Clear();
            discount_txtbox.Clear();
            total_txtbox.Clear();
            items_txtbox.Clear();
            barcode_txtbox.Clear();
            vat_txtbox.Clear();
            senior_discount_checkbox.Checked = false;
            pwd_discount_checkbox.Checked = false;
            coupons_discount_checkbox.Checked = false;
            cash_checkbox.Checked = false;
            card_checkbox.Checked = false;
            QR_checkbox.Checked = false;
            barcode_txtbox.Focus();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_transaction_button_Click(object sender, EventArgs e)
        {
            // 1. Check if there is an active transaction to cancel
            if (helper.CurrentSaleId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel and delete this transaction?",
                                                    "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.cashier_connString();

                        // 2. Delete the Sale record. 
                        // Due to ON DELETE CASCADE in your SQL, this also deletes all Sale_Items.
                        db.cashier_cmd("DELETE FROM Sale WHERE sale_id = @sid");
                        db.cashier_sql_command.Parameters.AddWithValue("@sid", helper.CurrentSaleId);
                        db.cashier_sql_command.ExecuteNonQuery();

                        db.cashier_sql_connection.Close();

                        // 3. Clear the UI and reset the helper class
                        ResetForm();
                        MessageBox.Show("Transaction cancelled successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error cancelling transaction: " + ex.Message);
                    }
                }
            }
            else
            {
                // If no items were scanned yet, just clear any text in the barcode box
                barcode_txtbox.Clear();
                MessageBox.Show("No active transaction to cancel.");
            }
        }
    }
}
