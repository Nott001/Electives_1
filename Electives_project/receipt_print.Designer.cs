namespace Electives_project
{
    partial class receipt_print
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
            groupBox2 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label13 = new Label();
            lblChange = new Label();
            lblTotal = new Label();
            lblDiscount = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            total_items_txtbox = new TextBox();
            subtotal_txtbox = new TextBox();
            discount_txtbox = new TextBox();
            vat_txtbox = new TextBox();
            total_amount_txtbox = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(total_amount_txtbox);
            groupBox2.Controls.Add(vat_txtbox);
            groupBox2.Controls.Add(discount_txtbox);
            groupBox2.Controls.Add(subtotal_txtbox);
            groupBox2.Controls.Add(total_items_txtbox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lblChange);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblDiscount);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 559);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 423);
            label4.Name = "label4";
            label4.Size = new Size(43, 18);
            label4.TabIndex = 18;
            label4.Text = "VAT: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 353);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 17;
            label2.Text = "Subtotal: ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(563, 248);
            dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Microsoft Sans Serif", 500F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 463);
            label3.Name = "label3";
            label3.Size = new Size(600, 2);
            label3.TabIndex = 15;
            label3.Text = "VillaCorp";
            // 
            // label13
            // 
            label13.BackColor = SystemColors.WindowText;
            label13.Font = new Font("Microsoft Sans Serif", 500F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(30, 294);
            label13.Name = "label13";
            label13.Size = new Size(600, 2);
            label13.TabIndex = 13;
            label13.Text = "VillaCorp";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(67, 492);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(118, 18);
            lblChange.TabIndex = 12;
            lblChange.Text = "Total Amount: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(67, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 18);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Discount: ";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(67, 318);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(89, 18);
            lblDiscount.TabIndex = 9;
            lblDiscount.Text = "Total Items: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "VillaCorp";
            // 
            // total_items_txtbox
            // 
            total_items_txtbox.BackColor = SystemColors.Control;
            total_items_txtbox.BorderStyle = BorderStyle.None;
            total_items_txtbox.Location = new Point(446, 315);
            total_items_txtbox.Name = "total_items_txtbox";
            total_items_txtbox.Size = new Size(184, 19);
            total_items_txtbox.TabIndex = 19;
            // 
            // subtotal_txtbox
            // 
            subtotal_txtbox.BackColor = SystemColors.Control;
            subtotal_txtbox.BorderStyle = BorderStyle.None;
            subtotal_txtbox.Location = new Point(446, 350);
            subtotal_txtbox.Name = "subtotal_txtbox";
            subtotal_txtbox.Size = new Size(184, 19);
            subtotal_txtbox.TabIndex = 20;
            // 
            // discount_txtbox
            // 
            discount_txtbox.BackColor = SystemColors.Control;
            discount_txtbox.BorderStyle = BorderStyle.None;
            discount_txtbox.Location = new Point(446, 385);
            discount_txtbox.Name = "discount_txtbox";
            discount_txtbox.Size = new Size(184, 19);
            discount_txtbox.TabIndex = 21;
            // 
            // vat_txtbox
            // 
            vat_txtbox.BackColor = SystemColors.Control;
            vat_txtbox.BorderStyle = BorderStyle.None;
            vat_txtbox.Location = new Point(446, 420);
            vat_txtbox.Name = "vat_txtbox";
            vat_txtbox.Size = new Size(184, 19);
            vat_txtbox.TabIndex = 22;
            // 
            // total_amount_txtbox
            // 
            total_amount_txtbox.BackColor = SystemColors.Control;
            total_amount_txtbox.BorderStyle = BorderStyle.None;
            total_amount_txtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_amount_txtbox.Location = new Point(446, 489);
            total_amount_txtbox.Name = "total_amount_txtbox";
            total_amount_txtbox.Size = new Size(184, 20);
            total_amount_txtbox.TabIndex = 23;
            // 
            // receipt_print
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 700);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "receipt_print";
            Text = "Receipt";
            Load += Receipt_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label3;
        private Label label13;
        private Label lblChange;
        private Label lblCash;
        private Label lblTotal;
        private Label lblDiscount;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label2;
        public DataGridView dataGridView1;
        public TextBox total_amount_txtbox;
        public TextBox vat_txtbox;
        public TextBox discount_txtbox;
        public TextBox subtotal_txtbox;
        public TextBox total_items_txtbox;
        public TextBox textBox6;
        public TextBox textBox2;
    }
}