namespace Electives_project
{
    partial class sales_reports
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
            exit_button = new Button();
            groupBox1 = new GroupBox();
            search_button = new Button();
            optionInputTxtbox = new TextBox();
            optionCombo = new ComboBox();
            label1 = new Label();
            dataGridView_sale = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView_sale_item = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridView_payment = new DataGridView();
            groupBox4 = new GroupBox();
            delete_button = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sale).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sale_item).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // exit_button
            // 
            exit_button.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit_button.Location = new Point(1116, 55);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(129, 36);
            exit_button.TabIndex = 5;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete_button);
            groupBox1.Controls.Add(exit_button);
            groupBox1.Controls.Add(search_button);
            groupBox1.Controls.Add(optionInputTxtbox);
            groupBox1.Controls.Add(optionCombo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1900, 141);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // search_button
            // 
            search_button.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_button.Location = new Point(846, 55);
            search_button.Name = "search_button";
            search_button.Size = new Size(129, 36);
            search_button.TabIndex = 3;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // optionInputTxtbox
            // 
            optionInputTxtbox.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optionInputTxtbox.Location = new Point(464, 59);
            optionInputTxtbox.Name = "optionInputTxtbox";
            optionInputTxtbox.Size = new Size(365, 27);
            optionInputTxtbox.TabIndex = 2;
            // 
            // optionCombo
            // 
            optionCombo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optionCombo.FormattingEnabled = true;
            optionCombo.Location = new Point(289, 59);
            optionCombo.Name = "optionCombo";
            optionCombo.Size = new Size(169, 28);
            optionCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 59);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Select an option:";
            // 
            // dataGridView_sale
            // 
            dataGridView_sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sale.Location = new Point(6, 26);
            dataGridView_sale.Name = "dataGridView_sale";
            dataGridView_sale.Size = new Size(963, 766);
            dataGridView_sale.TabIndex = 7;
            dataGridView_sale.CellContentClick += dataGridView_sale_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_sale_item);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(993, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 805);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items";
            // 
            // dataGridView_sale_item
            // 
            dataGridView_sale_item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sale_item.Location = new Point(6, 26);
            dataGridView_sale_item.Name = "dataGridView_sale_item";
            dataGridView_sale_item.Size = new Size(459, 766);
            dataGridView_sale_item.TabIndex = 0;
            dataGridView_sale_item.CellContentClick += dataGridView_sale_item_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView_payment);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1470, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(442, 805);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Payment";
            // 
            // dataGridView_payment
            // 
            dataGridView_payment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_payment.Location = new Point(6, 26);
            dataGridView_payment.Name = "dataGridView_payment";
            dataGridView_payment.Size = new Size(430, 766);
            dataGridView_payment.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView_sale);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 159);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(975, 805);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sales";
            // 
            // delete_button
            // 
            delete_button.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_button.Location = new Point(981, 54);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(129, 36);
            delete_button.TabIndex = 6;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // sales_reports
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "sales_reports";
            Text = "sales_reports";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sale).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_sale_item).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button exit_button;
        private GroupBox groupBox1;
        private Button search_button;
        private TextBox optionInputTxtbox;
        private ComboBox optionCombo;
        private Label label1;
        private DataGridView dataGridView_sale;
        private GroupBox groupBox2;
        private DataGridView dataGridView_sale_item;
        private GroupBox groupBox3;
        private DataGridView dataGridView_payment;
        private GroupBox groupBox4;
        private Button delete_button;
    }
}