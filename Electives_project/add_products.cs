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

            // DateTimePickers for dates
            DateTimePicker[] manDates = { man_date_picker1, man_date_picker2, man_date_picker3, man_date_picker4 };
            DateTimePicker[] expDates = { exp_date_picker1, exp_date_picker2, exp_date_picker3, exp_date_picker4 };

            inventory_connect.inventory_connString();
            int successCount = 0;

            try
            {
                for (int i = 0; i < 4; i++)
                {
                    if (!string.IsNullOrWhiteSpace(names[i].Text))
                    {
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
                        inventory_connect.inventory_sql_command.Parameters.AddWithValue("@ppath", productPaths[i].Text); // Save product path
                        inventory_connect.inventory_sql_command.Parameters.AddWithValue("@bpath", barcodePaths[i].Text); // Save barcode path
                        inventory_connect.inventory_sql_command.Parameters.AddWithValue("@man", manufacturer[i].Text);

                        inventory_connect.inventory_sql_command.ExecuteNonQuery();
                        successCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                inventory_connect.inventory_sql_connection.Close(); //
            }
            if (successCount > 0) LoadDataGrid();
        }



        private void generate_barcode_button_Click_1(object sender, EventArgs e)
        {
            PictureBox[] pics = { barcode_picbox1, barcode_picbox2, barcode_picbox3, barcode_picbox4 };
            TextBox[] codes = { barcode_txtbox1, barcode_txtbox2, barcode_txtbox3, barcode_txtbox4 };
            TextBox[] paths = { barcode_picpath1, barcode_picpath2, barcode_picpath3, barcode_picpath4 };

            barcodeClickCount++;

            if (barcodeClickCount > 4) // 5th click clears all
            {
                for (int i = 0; i < 4; i++)
                {
                    pics[i].Image = null;
                    codes[i].Text = "";
                    paths[i].Text = "";
                }
                barcodeClickCount = 0;
                MessageBox.Show("All barcodes cleared.");
                return;
            }

            // Generate one barcode for the current product index
            int index = barcodeClickCount - 1;
            var writer = new BarcodeWriter { Format = BarcodeFormat.CODE_128, Options = new EncodingOptions { Height = 80, Width = 200 } };
            string randomValue = new Random().Next(10000000, 99999999).ToString();

            codes[index].Text = randomValue;
            Bitmap barcodeBitmap = writer.Write(randomValue);
            pics[index].Image = barcodeBitmap;

            // Save barcode image to local folder
            string folderPath = @"C:\Users\karlr\source\repos\Electives_1\Electives_project\Barcode Pictures";
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, randomValue + ".png");
            barcodeBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            paths[index].Text = filePath; // Save path for database entry
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
    }
}