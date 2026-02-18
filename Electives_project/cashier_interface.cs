using System.Data.SqlClient;

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

            //this.AcceptButton = enter_button;
            this.Shown += cashier_interface_Load;

            // Link the CheckBox events to refresh totals instantly when clicked
            senior_discount_checkbox.CheckedChanged += (s, e) => RefreshUI();
            pwd_discount_checkboc.CheckedChanged += (s, e) => RefreshUI();
        }

        private void SetupNumpad()
        {
            // Attaching event to all numpad buttons dynamically
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
        }

        private void RefreshUI()
        {
            bool isDiscounted = senior_discount_checkbox.Checked || pwd_discount_checkboc.Checked;
            var calc = helper.GetCalculations(isDiscounted);

            subtotal_txtbox.Text = calc.subtotal.ToString("N2");
            discount_txtbox.Text = calc.discount.ToString("N2");
            total_txtbox.Text = calc.total.ToString("N2");
        }

        private void SearchAndAddProduct(string barcodeOrName)
        {
            db.cashier_connString();
            // Search by Barcode primarily, but supports Name as fallback
            db.cashier_sql = "SELECT product_name, unit_price FROM Product WHERE barcode = @input OR product_name = @input";
            db.cashier_cmd();
            db.cashier_sql_command.Parameters.AddWithValue("@input", barcodeOrName);

            using (SqlDataReader reader = db.cashier_sql_command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader["product_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["unit_price"]);

                    // Display current item
                    scanned_item_name_txtbox.Text = name;
                    scanned_item_price_txtbox.Text = price.ToString("N2");

                    // Add to the helper list and refresh the screen
                    helper.AddToTransaction(name, price);
                    RefreshUI();
                }
                else
                {
                    MessageBox.Show("Barcode/Product not found.");
                }
            }
            db.cashier_sql_connection.Close();
        }

        private void ProcessScan(string input)
        {
            db.cashier_connString(); //
            db.cashier_sql = "SELECT product_name, unit_price FROM Product WHERE barcode = @input OR product_name = @input";
            db.cashier_cmd();
            db.cashier_sql_command.Parameters.AddWithValue("@input", input);

            using (SqlDataReader reader = db.cashier_sql_command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader["product_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["unit_price"]);

                    scanned_item_name_txtbox.Text = name;
                    scanned_item_price_txtbox.Text = price.ToString("N2");

                    helper.AddToTransaction(name, price);
                    RefreshUI();
                }
                else { MessageBox.Show("Product not found."); }
            }
            db.cashier_sql_connection.Close();
        }

        private void scanned_item_name_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(scanned_item_name_txtbox.Text))
            {
                ProcessScan(scanned_item_name_txtbox.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void circlePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cashier_interface_Load(object sender, EventArgs e)
        {
            barcode_txtbox.Focus();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(scanned_item_name_txtbox.Text))
            {
                // Only clear the active input boxes
                scanned_item_name_txtbox.Clear();
                scanned_item_price_txtbox.Clear();
            }
            else
            {
                // Reset the entire transaction "stack"
                helper.ClearTransaction();
                items_scanned_lisbox.Items.Clear();
                items_txtbox.Clear();
                RefreshUI(); // Resets totals to 0.00
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (scanned_item_name_txtbox.Text.Length > 0)
            {
                scanned_item_name_txtbox.Text = scanned_item_name_txtbox.Text.Remove(scanned_item_name_txtbox.Text.Length - 1);
            }
            // Part B: If no text is being typed, remove the selected item from the ListBox
            else if (items_scanned_lisbox.SelectedIndex != -1)
            {
                int indexToRemove = items_scanned_lisbox.SelectedIndex;
                helper.ItemNames.RemoveAt(indexToRemove);
                helper.ItemPrices.RemoveAt(indexToRemove);
                RefreshUI();
            }
            // Part C: Fallback - just remove the very last item scanned
            else if (helper.ItemNames.Count > 0)
            {
                helper.RemoveLastItem();
                RefreshUI();
            }
        }

        private void process_payment_button_Click(object sender, EventArgs e)
        {
            if (!cash_checkbox.Checked)
            {
                MessageBox.Show("Please select 'Cash' payment method.");
                return;
            }
            MessageBox.Show("Payment Successful!");
            helper.ClearTransaction();
            RefreshUI();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string input = barcode_txtbox.Text.Trim();
            if (string.IsNullOrEmpty(input)) return;

            db.cashier_connString(); //
            db.cashier_sql = "SELECT product_name, unit_price FROM Product WHERE barcode = @input OR product_name = @input";
            db.cashier_cmd();
            db.cashier_sql_command.Parameters.AddWithValue("@input", input);

            using (SqlDataReader reader = db.cashier_sql_command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader["product_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["unit_price"]);

                    // 1. Update current item display
                    scanned_item_name_txtbox.Text = name;
                    scanned_item_price_txtbox.Text = price.ToString("N2");

                    // 2. Add to Helper Memory
                    helper.AddToTransaction(name, price);

                    // 3. STACK in ListBox (items_scanned_lisbox)
                    items_scanned_lisbox.Items.Add($"{name} - {price:N2}");

                    // 4. STACK in TextBox (items_txtbox)
                    items_txtbox.Text = helper.ItemNames.Count.ToString();

                    // 5. Update the math (Subtotal/Total)
                    RefreshUI();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            db.cashier_sql_connection.Close();

            barcode_txtbox.Focus();
        }
    }
}
