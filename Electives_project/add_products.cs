using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
using System.IO;

namespace Electives_project
{
    public partial class add_products : Form
    {
        // Connection string for your local Microsoft SQL Server
        inventory_connection inventory_connect = new inventory_connection();
        private int barcodeClickCount = 0;

        private Random rng = new Random();


        public add_products()
        {
            InitializeComponent();
            SetupPictureBoxClicks();
            LoadDataGrid(); // Load existing products on startup
        }

        private void SetupPictureBoxClicks()
        {
            // Allow users to click picture boxes to browse files
            product_picBox1.Click += (s, e) => add_products_helper.SelectProductImage(product_picBox1, picpath1_txtbox);
            product_picBox2.Click += (s, e) => add_products_helper.SelectProductImage(product_picBox2, picpath2_txtbox);
            product_picBox3.Click += (s, e) => add_products_helper.SelectProductImage(product_picBox3, picpath3_txtbox);
            product_picBox4.Click += (s, e) => add_products_helper.SelectProductImage(product_picBox4, picpath4_txtbox);
        }

        // Refreshes the DataGridView with the latest products from the database
        private void LoadDataGrid()
        {
            inventory_connect.inventory_connString();
            inventory_connect.inventory_sql = "SELECT * FROM Product ORDER BY created_at DESC";
            inventory_connect.inventory_cmd();
            inventory_connect.inventory_sqladapterSelect();
            inventory_connect.inventory_sqldatasetSELECT();
            dataGridView1.DataSource = inventory_connect.inventory_sql_dataset.Tables["Product"];
            inventory_connect.inventory_sql_connection.Close();
        }


        private void exit_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_products_button_Click_1(object sender, EventArgs e)
        {
            TextBox[] names = { product_name_txtbox1, product_name_txtbox2, product_name_txtbox3, product_name_txtbox4 };
            TextBox[] barcodes = { barcode_txtbox1, barcode_txtbox2, barcode_txtbox3, barcode_txtbox4 };
            TextBox[] prices = { price_txtbox1, price_txtbox2, price_txtbox3, price_txtbox4 };
            TextBox[] stocks = { stocks_txtbox1, stocks_txtbox2, stocks_txtbox3, stocks_txtbox4 };
            TextBox[] productPaths = { picpath1_txtbox, picpath2_txtbox, picpath3_txtbox, picpath4_txtbox };
            TextBox[] barcodePaths = { barcode_picpath1, barcode_picpath2, barcode_picpath3, barcode_picpath4 };
            TextBox[] manufacturer = { manu_txtbox1, manu_txtbox2, manu_txtbox3, manu_txtbox4 };
            DateTimePicker[] manDates = { man_date_picker1, man_date_picker2, man_date_picker3, man_date_picker4 };
            DateTimePicker[] expDates = { exp_date_picker1, exp_date_picker2, exp_date_picker3, exp_date_picker4 };

            int successCount = 0;

            for (int i = 0; i < 4; i++)
            {
                // 1. Check if the row is entirely empty (User didn't intend to add this one)
                bool isRowEmpty = string.IsNullOrWhiteSpace(names[i].Text) &&
                                  string.IsNullOrWhiteSpace(barcodes[i].Text) &&
                                  string.IsNullOrWhiteSpace(prices[i].Text) &&
                                  string.IsNullOrWhiteSpace(stocks[i].Text);

                if (isRowEmpty) continue; // Skip this row and move to the next

                // 2. If NOT empty, check if ANY required field is missing
                if (string.IsNullOrWhiteSpace(names[i].Text) ||
                    string.IsNullOrWhiteSpace(barcodes[i].Text) ||
                    string.IsNullOrWhiteSpace(prices[i].Text) ||
                    string.IsNullOrWhiteSpace(stocks[i].Text) ||
                    string.IsNullOrWhiteSpace(manufacturer[i].Text))
                {
                    MessageBox.Show($"Product {i + 1} has incomplete information. Please fill all fields or clear the row.");
                    return; // Stop the entire process so the user can fix the error
                }

                // 3. Validate numeric formats to prevent crashes during Parse
                if (!decimal.TryParse(prices[i].Text, out _) || !int.TryParse(stocks[i].Text, out _))
                {
                    MessageBox.Show($"Product {i + 1} has invalid Price or Stock format.");
                    return;
                }

                // 4. Proceed with Database Insertion
                try
                {
                    inventory_connect.inventory_connString();
                    inventory_connect.inventory_sql = "INSERT INTO Product (barcode, product_name, unit_price, stock_quantity, expiration_date," +
                        "manufacturing_date, created_at, product_picpath, barcode_picpath, manufacturer) " +
                        "VALUES (@barcode, @name, @price, @stock, @expdate, @mandate, @created, @ppath, @bpath, @man)";
                    inventory_connect.inventory_cmd();
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@barcode", barcodes[i].Text);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@name", names[i].Text);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@price", decimal.Parse(prices[i].Text));
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@stock", int.Parse(stocks[i].Text));
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@expdate", expDates[i].Value.Date);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@mandate", manDates[i].Value.Date);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@created", DateTime.Now);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@ppath", productPaths[i].Text);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@bpath", barcodePaths[i].Text);
                    inventory_connect.inventory_sql_command.Parameters.AddWithValue("@man", manufacturer[i].Text);

                    inventory_connect.inventory_sql_command.ExecuteNonQuery();
                    successCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving Product {i + 1}: " + ex.Message);
                }
                finally
                {
                    inventory_connect.inventory_sql_connection.Close();
                }
            }

            if (successCount > 0)
            {
                MessageBox.Show($"{successCount} product(s) added successfully!");
                LoadDataGrid();
            }

            add_products_helper.ClearPictureBox(barcode_picbox1);
            add_products_helper.ClearPictureBox(barcode_picbox2);
            add_products_helper.ClearPictureBox(barcode_picbox3);
            add_products_helper.ClearPictureBox(barcode_picbox4);
            add_products_helper.ClearPictureBox(product_picBox1);
            add_products_helper.ClearPictureBox(product_picBox2);
            add_products_helper.ClearPictureBox(product_picBox3);
            add_products_helper.ClearPictureBox(product_picBox4);
        }



        private void generate_barcode_button_Click_1(object sender, EventArgs e)
        {
            PictureBox[] pics = { barcode_picbox1, barcode_picbox2, barcode_picbox3, barcode_picbox4 };
            TextBox[] codes = { barcode_txtbox1, barcode_txtbox2, barcode_txtbox3, barcode_txtbox4 };
            TextBox[] paths = { barcode_picpath1, barcode_picpath2, barcode_picpath3, barcode_picpath4 };

            barcodeClickCount++;

            // 5th click clears everything
            if (barcodeClickCount > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pics[i].Image != null)
                    {
                        pics[i].Image.Dispose();
                        pics[i].Image = null;
                    }

                    codes[i].Clear();
                    paths[i].Clear();
                }

                barcodeClickCount = 0;
                MessageBox.Show("All barcodes cleared.");
                return;
            }

            int index = barcodeClickCount - 1;

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 80,
                    Width = 200
                }
            };

            // Use the shared Random object
            string randomValue = rng.Next(10000000, 99999999).ToString();

            codes[index].Text = randomValue;

            Bitmap barcodeBitmap = writer.Write(randomValue);
            pics[index].Image = barcodeBitmap;

            // Save barcode image
            string folderPath = @"C:\Users\karlr\source\repos\Electives_1\Electives_project\Barcode Pictures";

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, randomValue + ".png");

            barcodeBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            paths[index].Text = filePath;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_management inventory_man = new Inventory_management();
            inventory_man.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearControls(this);
        }

        private void product_picBox1_Click(object sender, EventArgs e)
        {

        }

        private void remove_product_pic1_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(product_picBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(product_picBox2);
        }

        private void remove_product_pic3_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(product_picBox3);
        }

        private void remove_product_pic4_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(product_picBox4);
        }

        private void remove_barcode_pic1_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(barcode_picbox1);
        }

        private void remove_barcode_pic2_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(barcode_picbox2);
        }

        private void remove_barcode_pic3_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(barcode_picbox3);
        }

        private void remove_barcode_pic4_Click(object sender, EventArgs e)
        {
            add_products_helper.ClearPictureBox(barcode_picbox4);
        }
    }
}