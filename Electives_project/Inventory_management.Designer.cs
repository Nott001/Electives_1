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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button10 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button4 = new Button();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(161, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 29);
            textBox1.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(12, 154);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 3;
            button1.Text = "Search product";
            button1.UseVisualStyleBackColor = true;
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
            // button10
            // 
            button10.BackColor = Color.Coral;
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(297, 885);
            button10.Name = "button10";
            button10.Size = new Size(279, 58);
            button10.TabIndex = 18;
            button10.Text = "UPDATE";
            button10.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(582, 885);
            button2.Name = "button2";
            button2.Size = new Size(279, 58);
            button2.TabIndex = 19;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 885);
            button3.Name = "button3";
            button3.Size = new Size(279, 58);
            button3.TabIndex = 20;
            button3.Text = "ADD NEW ITEMS";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "search by";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(867, 885);
            button4.Name = "button4";
            button4.Size = new Size(279, 58);
            button4.TabIndex = 22;
            button4.Text = "EXIT";
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(1552, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 369);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Image";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(6, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 338);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(textBox2);
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(146, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(146, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(146, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 29);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(146, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 29);
            textBox5.TabIndex = 7;
            // 
            // Inventory_management
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button10);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Inventory_management";
            Text = "Inventory_management";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button10;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Button button4;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}