using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Electives_project
{
    public partial class Inventory_management : Form
    {
        inventory_connection db = new inventory_connection();
        private string selectedImagePath = "";

        public Inventory_management()
        {
            InitializeComponent();
            LoadInitialData();
            SetupSearch();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            // 1. Manually link the events here to ensure they are connected
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            this.product_image_picturebox.Click += new EventHandler(product_image_picturebox_Click);

            // 2. Set Grid Properties for better selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            db.inventory_connString();
            db.inventory_sql = "SELECT * FROM Product"; // This ensures columns are named exactly as in SQL
            db.inventory_cmd();
            db.inventory_sqladapterSelect();
            db.inventory_sqldatasetSELECT();
            dataGridView1.DataSource = db.inventory_sql_dataset.Tables["Product"];
            db.inventory_sql_connection.Close();
        }

        private void Inventory_management_Load(object sender, EventArgs e)
        {
            product_image_picturebox.Click += (s, e) => add_products_helper.SelectProductImage(product_image_picturebox, picpath_txtbox);
        }

        private void SetupSearch()
        {
            // Populate the search category combobox
            searchby_combobox.Items.Clear();
            searchby_combobox.Items.Add("Product ID");
            searchby_combobox.Items.Add("Product Name");
            searchby_combobox.SelectedIndex = 1; // Default to Name
        }

        private void RefreshGrid(string query)
        {
            db.inventory_connString(); //
            db.inventory_sql = query;
            db.inventory_cmd();
            db.inventory_sqladapterSelect();
            db.inventory_sqldatasetSELECT();
            dataGridView1.DataSource = db.inventory_sql_dataset.Tables["Product"];
            db.inventory_sql_connection.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Debug Message: Delete this line once it works
                    // MessageBox.Show("Click detected on product: " + row.Cells["product_name"].Value.ToString());

                    // 1. Fill TextBoxes using Exact Database Column Names
                    product_id_txtbox.Text = row.Cells["product_id"].Value.ToString();
                    product_name_txtbox.Text = row.Cells["product_name"].Value.ToString();
                    price_txtbox.Text = row.Cells["unit_price"].Value.ToString();
                    stocks_txtbox.Text = row.Cells["stock_quantity"].Value.ToString();

                    // 2. Get Image Path
                    string imagePath = row.Cells["product_picpath"].Value?.ToString();
                    selectedImagePath = imagePath;

                    // 3. Load Image safely
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        using (var stream = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            product_image_picturebox.Image = Image.FromStream(stream);
                        }
                        product_image_picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        product_image_picturebox.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Make sure your DataGrid column names match your SQL table. \n" + ex.Message);
                }
            }
        }

        private void search_product_button_Click(object sender, EventArgs e)
        {
            string searchValue = search_product_txtbox.Text.Trim();
            string query = "SELECT * FROM Product";

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (searchby_combobox.Text == "Product ID")
                {
                    query = $"SELECT * FROM Product WHERE product_id = '{searchValue}'";
                }
                else // Search by Name with partial match (LIKE)
                {
                    query = $"SELECT * FROM Product WHERE product_name LIKE '%{searchValue}%'";
                }
            }
            RefreshGrid(query);
        }

        private void update_button_box_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                DataGridViewRow currentRow = dataGridView1.CurrentRow;
                int id = Convert.ToInt32(currentRow.Cells["product_id"].Value);

                db.inventory_connString();
                // Update specific product based on the current row's data
                db.inventory_sql = "UPDATE Product SET product_name = @name, unit_price = @price, " +
                                   "stock_quantity = @stock, manufacturer = @manu,  WHERE product_id = @id";

                db.inventory_cmd();
                db.inventory_sql_command.Parameters.AddWithValue("@name", currentRow.Cells["product_name"].Value);
                db.inventory_sql_command.Parameters.AddWithValue("@price", currentRow.Cells["unit_price"].Value);
                db.inventory_sql_command.Parameters.AddWithValue("@stock", currentRow.Cells["stock_quantity"].Value);
                db.inventory_sql_command.Parameters.AddWithValue("@id", id);

                db.inventory_sql_command.ExecuteNonQuery();
                db.inventory_sql_connection.Close();

                MessageBox.Show("Product updated successfully!");
                LoadInitialData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(product_id_txtbox.Text)) return;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.inventory_connString();
                db.inventory_sql = "DELETE FROM Product WHERE product_id = @id";
                db.inventory_cmd();
                db.inventory_sql_command.Parameters.AddWithValue("@id", product_id_txtbox.Text);
                db.inventory_sql_command.ExecuteNonQuery();
                db.inventory_sql_connection.Close();

                MessageBox.Show("Product deleted.");
                LoadInitialData();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_new_products_button_Click(object sender, EventArgs e)
        {
            add_products add_products_button = new add_products();
            add_products_button.ShowDialog();
            this.Close();
        }

        private void product_image_picturebox_Click(object sender, EventArgs e)
        {
        }
    }
}
