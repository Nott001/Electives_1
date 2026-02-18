namespace Electives_project
{
    partial class Inventory_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            search_product_txtbox = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label1 = new Label();
            search_product_button = new Button();
            update_button_box = new Button();
            delete_button = new Button();
            add_new_products_button = new Button();
            searchby_combobox = new ComboBox();
            exit_button = new Button();
            groupBox3 = new GroupBox();
            picpath_txtbox = new TextBox();
            product_image_picturebox = new PictureBox();
            groupBox4 = new GroupBox();
            stocks_txtbox = new TextBox();
            price_txtbox = new TextBox();
            product_id_txtbox = new TextBox();
            product_name_txtbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)product_image_picturebox).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1534, 674);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1518, 631);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search_product_txtbox
            // 
            search_product_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_product_txtbox.Location = new Point(161, 161);
            search_product_txtbox.Name = "search_product_txtbox";
            search_product_txtbox.Size = new Size(470, 29);
            search_product_txtbox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1900, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(48, 82);
            label10.Name = "label10";
            label10.Size = new Size(202, 19);
            label10.TabIndex = 2;
            label10.Text = "Inventory Management System";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 0;
            label1.Text = "Villa Corp.";
            // 
            // search_product_button
            // 
            search_product_button.Location = new Point(12, 154);
            search_product_button.Name = "search_product_button";
            search_product_button.Size = new Size(143, 45);
            search_product_button.TabIndex = 3;
            search_product_button.Text = "Search product";
            search_product_button.UseVisualStyleBackColor = true;
            search_product_button.Click += search_product_button_Click;
            // 
            // update_button_box
            // 
            update_button_box.BackColor = Color.Coral;
            update_button_box.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_button_box.ForeColor = Color.White;
            update_button_box.Location = new Point(297, 885);
            update_button_box.Name = "update_button_box";
            update_button_box.Size = new Size(279, 58);
            update_button_box.TabIndex = 18;
            update_button_box.Text = "UPDATE";
            update_button_box.UseVisualStyleBackColor = false;
            update_button_box.Click += update_button_box_Click;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.IndianRed;
            delete_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.White;
            delete_button.Location = new Point(582, 885);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(279, 58);
            delete_button.TabIndex = 19;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // add_new_products_button
            // 
            add_new_products_button.BackColor = Color.YellowGreen;
            add_new_products_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_new_products_button.ForeColor = Color.White;
            add_new_products_button.Location = new Point(12, 885);
            add_new_products_button.Name = "add_new_products_button";
            add_new_products_button.Size = new Size(279, 58);
            add_new_products_button.TabIndex = 20;
            add_new_products_button.Text = "ADD NEW PRODUCTS";
            add_new_products_button.UseVisualStyleBackColor = false;
            add_new_products_button.Click += add_new_products_button_Click;
            // 
            // searchby_combobox
            // 
            searchby_combobox.FormattingEnabled = true;
            searchby_combobox.Location = new Point(637, 163);
            searchby_combobox.Name = "searchby_combobox";
            searchby_combobox.Size = new Size(121, 27);
            searchby_combobox.TabIndex = 21;
            searchby_combobox.Text = "search by";
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.Gray;
            exit_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_button.ForeColor = Color.White;
            exit_button.Location = new Point(867, 885);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(279, 58);
            exit_button.TabIndex = 22;
            exit_button.Text = "EXIT";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(picpath_txtbox);
            groupBox3.Controls.Add(product_image_picturebox);
            groupBox3.Location = new Point(1552, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 369);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Image";
            // 
            // picpath_txtbox
            // 
            picpath_txtbox.Enabled = false;
            picpath_txtbox.Location = new Point(96, 305);
            picpath_txtbox.Name = "picpath_txtbox";
            picpath_txtbox.Size = new Size(186, 26);
            picpath_txtbox.TabIndex = 1;
            picpath_txtbox.Visible = false;
            // 
            // product_image_picturebox
            // 
            product_image_picturebox.BackColor = Color.White;
            product_image_picturebox.BorderStyle = BorderStyle.FixedSingle;
            product_image_picturebox.Location = new Point(6, 25);
            product_image_picturebox.Name = "product_image_picturebox";
            product_image_picturebox.Size = new Size(348, 338);
            product_image_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            product_image_picturebox.TabIndex = 0;
            product_image_picturebox.TabStop = false;
            product_image_picturebox.Click += product_image_picturebox_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(stocks_txtbox);
            groupBox4.Controls.Add(price_txtbox);
            groupBox4.Controls.Add(product_id_txtbox);
            groupBox4.Controls.Add(product_name_txtbox);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(1552, 580);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(360, 299);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            // 
            // stocks_txtbox
            // 
            stocks_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocks_txtbox.Location = new Point(146, 189);
            stocks_txtbox.Name = "stocks_txtbox";
            stocks_txtbox.Size = new Size(192, 29);
            stocks_txtbox.TabIndex = 7;
            // 
            // price_txtbox
            // 
            price_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_txtbox.Location = new Point(146, 142);
            price_txtbox.Name = "price_txtbox";
            price_txtbox.Size = new Size(192, 29);
            price_txtbox.TabIndex = 6;
            // 
            // product_id_txtbox
            // 
            product_id_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product_id_txtbox.Location = new Point(146, 96);
            product_id_txtbox.Name = "product_id_txtbox";
            product_id_txtbox.Size = new Size(192, 29);
            product_id_txtbox.TabIndex = 5;
            // 
            // product_name_txtbox
            // 
            product_name_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product_name_txtbox.Location = new Point(146, 49);
            product_name_txtbox.Name = "product_name_txtbox";
            product_name_txtbox.Size = new Size(192, 29);
            product_name_txtbox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 192);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 3;
            label5.Text = "Stocks: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 2;
            label4.Text = "Price: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 99);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 1;
            label3.Text = "Product ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 52);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 0;
            label2.Text = "Product Name: ";
            // 
            // Inventory_management
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(exit_button);
            Controls.Add(searchby_combobox);
            Controls.Add(add_new_products_button);
            Controls.Add(delete_button);
            Controls.Add(update_button_box);
            Controls.Add(search_product_button);
            Controls.Add(groupBox2);
            Controls.Add(search_product_txtbox);
            Controls.Add(groupBox1);
            Name = "Inventory_management";
            Text = "Inventory_management";
            Load += Inventory_management_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)product_image_picturebox).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox search_product_txtbox;
        private GroupBox groupBox2;
        private Label label10;
        private Label label1;
        private Button search_product_button;
        private DataGridView dataGridView1;
        private Button update_button_box;
        private Button delete_button;
        private Button add_new_products_button;
        private ComboBox searchby_combobox;
        private Button exit_button;
        private GroupBox groupBox3;
        private PictureBox product_image_picturebox;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox stocks_txtbox;
        private TextBox price_txtbox;
        private TextBox product_id_txtbox;
        private TextBox product_name_txtbox;
        private TextBox picpath_txtbox;
    }
}