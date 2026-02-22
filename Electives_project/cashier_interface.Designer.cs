namespace Electives_project
{
    partial class cashier_interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label10 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            vat_txtbox = new TextBox();
            total_txtbox = new TextBox();
            discount_txtbox = new TextBox();
            subtotal_txtbox = new TextBox();
            items_txtbox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            cancel_transaction_button = new Button();
            exit_button = new Button();
            dataGridView1 = new DataGridView();
            process_payment_button = new Button();
            cashier_name_txtbox = new TextBox();
            date_today_picker = new DateTimePicker();
            circlePictureBox2 = new CirclePictureBox();
            groupBox4 = new GroupBox();
            barcode_txtbox = new TextBox();
            scanned_item_price_txtbox = new TextBox();
            scanned_item_name_txtbox = new TextBox();
            num7_button = new Button();
            num8_button = new Button();
            num9_button = new Button();
            num4_button = new Button();
            num1_button = new Button();
            clear_button = new Button();
            num5_button = new Button();
            num6_button = new Button();
            num2_button = new Button();
            num3_button = new Button();
            num0_button = new Button();
            delete_button = new Button();
            enter_button = new Button();
            groupBox5 = new GroupBox();
            coupons_discount_checkbox = new CheckBox();
            pwd_discount_checkbox = new CheckBox();
            senior_discount_checkbox = new CheckBox();
            cash_checkbox = new CheckBox();
            card_checkbox = new CheckBox();
            QR_checkbox = new CheckBox();
            label2 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tan;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1900, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(48, 82);
            label10.Name = "label10";
            label10.Size = new Size(113, 19);
            label10.TabIndex = 2;
            label10.Text = "Cashier Station 1";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(vat_txtbox);
            groupBox2.Controls.Add(total_txtbox);
            groupBox2.Controls.Add(discount_txtbox);
            groupBox2.Controls.Add(subtotal_txtbox);
            groupBox2.Controls.Add(items_txtbox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 521);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 381);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 267);
            label11.Name = "label11";
            label11.Size = new Size(106, 25);
            label11.TabIndex = 12;
            label11.Text = "VAT (12%): ";
            // 
            // vat_txtbox
            // 
            vat_txtbox.BackColor = Color.White;
            vat_txtbox.BorderStyle = BorderStyle.FixedSingle;
            vat_txtbox.Enabled = false;
            vat_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vat_txtbox.Location = new Point(463, 265);
            vat_txtbox.Name = "vat_txtbox";
            vat_txtbox.Size = new Size(197, 33);
            vat_txtbox.TabIndex = 11;
            // 
            // total_txtbox
            // 
            total_txtbox.BackColor = Color.White;
            total_txtbox.BorderStyle = BorderStyle.FixedSingle;
            total_txtbox.Enabled = false;
            total_txtbox.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_txtbox.Location = new Point(463, 325);
            total_txtbox.Name = "total_txtbox";
            total_txtbox.Size = new Size(197, 38);
            total_txtbox.TabIndex = 10;
            // 
            // discount_txtbox
            // 
            discount_txtbox.BackColor = Color.White;
            discount_txtbox.BorderStyle = BorderStyle.FixedSingle;
            discount_txtbox.Enabled = false;
            discount_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount_txtbox.Location = new Point(463, 220);
            discount_txtbox.Name = "discount_txtbox";
            discount_txtbox.Size = new Size(197, 33);
            discount_txtbox.TabIndex = 9;
            // 
            // subtotal_txtbox
            // 
            subtotal_txtbox.BackColor = Color.White;
            subtotal_txtbox.BorderStyle = BorderStyle.FixedSingle;
            subtotal_txtbox.Enabled = false;
            subtotal_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtotal_txtbox.Location = new Point(463, 170);
            subtotal_txtbox.Name = "subtotal_txtbox";
            subtotal_txtbox.Size = new Size(197, 33);
            subtotal_txtbox.TabIndex = 8;
            // 
            // items_txtbox
            // 
            items_txtbox.BackColor = Color.White;
            items_txtbox.BorderStyle = BorderStyle.FixedSingle;
            items_txtbox.Enabled = false;
            items_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            items_txtbox.Location = new Point(463, 97);
            items_txtbox.Name = "items_txtbox";
            items_txtbox.Size = new Size(197, 33);
            items_txtbox.TabIndex = 7;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(60, 310);
            label9.Name = "label9";
            label9.Size = new Size(600, 2);
            label9.TabIndex = 6;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 150);
            label8.Name = "label8";
            label8.Size = new Size(600, 2);
            label8.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 328);
            label7.Name = "label7";
            label7.Size = new Size(76, 30);
            label7.TabIndex = 4;
            label7.Text = "Total: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 220);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 3;
            label6.Text = "Discount: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 172);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 2;
            label5.Text = "Subtotal: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 105);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 1;
            label4.Text = "Items: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(246, 41);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 0;
            label3.Text = "Transaction Summary";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(cancel_transaction_button);
            groupBox3.Controls.Add(exit_button);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(process_payment_button);
            groupBox3.Location = new Point(1456, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(456, 813);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product scanned list";
            // 
            // cancel_transaction_button
            // 
            cancel_transaction_button.BackColor = Color.IndianRed;
            cancel_transaction_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_transaction_button.ForeColor = Color.White;
            cancel_transaction_button.Location = new Point(6, 748);
            cancel_transaction_button.Name = "cancel_transaction_button";
            cancel_transaction_button.Size = new Size(218, 58);
            cancel_transaction_button.TabIndex = 164;
            cancel_transaction_button.Text = "CANCEL";
            cancel_transaction_button.UseVisualStyleBackColor = false;
            cancel_transaction_button.Click += cancel_transaction_button_Click;
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.Gray;
            exit_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_button.ForeColor = Color.White;
            exit_button.Location = new Point(230, 748);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(220, 58);
            exit_button.TabIndex = 163;
            exit_button.Text = "EXIT";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 634);
            dataGridView1.TabIndex = 2;
            // 
            // process_payment_button
            // 
            process_payment_button.BackColor = Color.ForestGreen;
            process_payment_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            process_payment_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            process_payment_button.ForeColor = Color.White;
            process_payment_button.Location = new Point(6, 665);
            process_payment_button.Name = "process_payment_button";
            process_payment_button.Size = new Size(444, 77);
            process_payment_button.TabIndex = 1;
            process_payment_button.Text = "Process Payment";
            process_payment_button.UseVisualStyleBackColor = false;
            process_payment_button.Click += process_payment_button_Click;
            // 
            // cashier_name_txtbox
            // 
            cashier_name_txtbox.BackColor = Color.Gainsboro;
            cashier_name_txtbox.BorderStyle = BorderStyle.None;
            cashier_name_txtbox.Enabled = false;
            cashier_name_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_name_txtbox.ForeColor = Color.Black;
            cashier_name_txtbox.Location = new Point(169, 190);
            cashier_name_txtbox.Name = "cashier_name_txtbox";
            cashier_name_txtbox.Size = new Size(342, 26);
            cashier_name_txtbox.TabIndex = 0;
            // 
            // date_today_picker
            // 
            date_today_picker.CalendarMonthBackground = SystemColors.Control;
            date_today_picker.Location = new Point(169, 221);
            date_today_picker.Name = "date_today_picker";
            date_today_picker.Size = new Size(200, 26);
            date_today_picker.TabIndex = 5;
            // 
            // circlePictureBox2
            // 
            circlePictureBox2.Location = new Point(1007, 582);
            circlePictureBox2.Name = "circlePictureBox2";
            circlePictureBox2.Size = new Size(8, 8);
            circlePictureBox2.TabIndex = 6;
            circlePictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(barcode_txtbox);
            groupBox4.Controls.Add(scanned_item_price_txtbox);
            groupBox4.Controls.Add(scanned_item_name_txtbox);
            groupBox4.ForeColor = SystemColors.ControlText;
            groupBox4.Location = new Point(12, 281);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(745, 234);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Scanned Item";
            // 
            // barcode_txtbox
            // 
            barcode_txtbox.BackColor = Color.White;
            barcode_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcode_txtbox.Location = new Point(60, 109);
            barcode_txtbox.Name = "barcode_txtbox";
            barcode_txtbox.Size = new Size(437, 33);
            barcode_txtbox.TabIndex = 2;
            barcode_txtbox.KeyPress += barcode_txtbox_KeyPress;
            // 
            // scanned_item_price_txtbox
            // 
            scanned_item_price_txtbox.BackColor = Color.White;
            scanned_item_price_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanned_item_price_txtbox.Location = new Point(58, 161);
            scanned_item_price_txtbox.Name = "scanned_item_price_txtbox";
            scanned_item_price_txtbox.Size = new Size(197, 33);
            scanned_item_price_txtbox.TabIndex = 1;
            // 
            // scanned_item_name_txtbox
            // 
            scanned_item_name_txtbox.BackColor = Color.White;
            scanned_item_name_txtbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanned_item_name_txtbox.ForeColor = SystemColors.WindowText;
            scanned_item_name_txtbox.Location = new Point(58, 48);
            scanned_item_name_txtbox.Name = "scanned_item_name_txtbox";
            scanned_item_name_txtbox.Size = new Size(439, 43);
            scanned_item_name_txtbox.TabIndex = 0;
            // 
            // num7_button
            // 
            num7_button.BackColor = Color.DimGray;
            num7_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num7_button.ForeColor = Color.White;
            num7_button.Location = new Point(763, 463);
            num7_button.Name = "num7_button";
            num7_button.Size = new Size(225, 83);
            num7_button.TabIndex = 12;
            num7_button.Text = "7";
            num7_button.UseVisualStyleBackColor = false;
            // 
            // num8_button
            // 
            num8_button.BackColor = Color.DimGray;
            num8_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num8_button.ForeColor = Color.White;
            num8_button.Location = new Point(994, 463);
            num8_button.Name = "num8_button";
            num8_button.Size = new Size(225, 83);
            num8_button.TabIndex = 13;
            num8_button.Text = "8";
            num8_button.UseVisualStyleBackColor = false;
            // 
            // num9_button
            // 
            num9_button.BackColor = Color.DimGray;
            num9_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num9_button.ForeColor = Color.White;
            num9_button.Location = new Point(1225, 463);
            num9_button.Name = "num9_button";
            num9_button.Size = new Size(225, 83);
            num9_button.TabIndex = 14;
            num9_button.Text = "9";
            num9_button.UseVisualStyleBackColor = false;
            // 
            // num4_button
            // 
            num4_button.BackColor = Color.DimGray;
            num4_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num4_button.ForeColor = Color.White;
            num4_button.Location = new Point(763, 552);
            num4_button.Name = "num4_button";
            num4_button.Size = new Size(225, 83);
            num4_button.TabIndex = 15;
            num4_button.Text = "4";
            num4_button.UseVisualStyleBackColor = false;
            // 
            // num1_button
            // 
            num1_button.BackColor = Color.DimGray;
            num1_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num1_button.ForeColor = Color.White;
            num1_button.Location = new Point(763, 641);
            num1_button.Name = "num1_button";
            num1_button.Size = new Size(225, 83);
            num1_button.TabIndex = 16;
            num1_button.Text = "1";
            num1_button.UseVisualStyleBackColor = false;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.LightCoral;
            clear_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_button.ForeColor = Color.White;
            clear_button.Location = new Point(763, 730);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(225, 83);
            clear_button.TabIndex = 17;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // num5_button
            // 
            num5_button.BackColor = Color.DimGray;
            num5_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num5_button.ForeColor = Color.White;
            num5_button.Location = new Point(994, 552);
            num5_button.Name = "num5_button";
            num5_button.Size = new Size(225, 83);
            num5_button.TabIndex = 18;
            num5_button.Text = "5";
            num5_button.UseVisualStyleBackColor = false;
            // 
            // num6_button
            // 
            num6_button.BackColor = Color.DimGray;
            num6_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num6_button.ForeColor = Color.White;
            num6_button.Location = new Point(1225, 552);
            num6_button.Name = "num6_button";
            num6_button.Size = new Size(225, 83);
            num6_button.TabIndex = 19;
            num6_button.Text = "6";
            num6_button.UseVisualStyleBackColor = false;
            // 
            // num2_button
            // 
            num2_button.BackColor = Color.DimGray;
            num2_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num2_button.ForeColor = Color.White;
            num2_button.Location = new Point(994, 641);
            num2_button.Name = "num2_button";
            num2_button.Size = new Size(225, 83);
            num2_button.TabIndex = 20;
            num2_button.Text = "2";
            num2_button.UseVisualStyleBackColor = false;
            // 
            // num3_button
            // 
            num3_button.BackColor = Color.DimGray;
            num3_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num3_button.ForeColor = Color.White;
            num3_button.Location = new Point(1225, 641);
            num3_button.Name = "num3_button";
            num3_button.Size = new Size(225, 83);
            num3_button.TabIndex = 21;
            num3_button.Text = "3";
            num3_button.UseVisualStyleBackColor = false;
            // 
            // num0_button
            // 
            num0_button.BackColor = Color.DimGray;
            num0_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num0_button.ForeColor = Color.White;
            num0_button.Location = new Point(994, 730);
            num0_button.Name = "num0_button";
            num0_button.Size = new Size(225, 83);
            num0_button.TabIndex = 22;
            num0_button.Text = "0";
            num0_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.Coral;
            delete_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.White;
            delete_button.Location = new Point(1225, 730);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(225, 83);
            delete_button.TabIndex = 23;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // enter_button
            // 
            enter_button.BackColor = Color.CadetBlue;
            enter_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter_button.ForeColor = Color.White;
            enter_button.Location = new Point(763, 819);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(687, 83);
            enter_button.TabIndex = 24;
            enter_button.Text = "ENTER";
            enter_button.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(coupons_discount_checkbox);
            groupBox5.Controls.Add(pwd_discount_checkbox);
            groupBox5.Controls.Add(senior_discount_checkbox);
            groupBox5.Location = new Point(763, 281);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(687, 176);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Discount";
            // 
            // coupons_discount_checkbox
            // 
            coupons_discount_checkbox.Appearance = Appearance.Button;
            coupons_discount_checkbox.BackColor = Color.Gainsboro;
            coupons_discount_checkbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coupons_discount_checkbox.Location = new Point(432, 71);
            coupons_discount_checkbox.Name = "coupons_discount_checkbox";
            coupons_discount_checkbox.Size = new Size(163, 42);
            coupons_discount_checkbox.TabIndex = 31;
            coupons_discount_checkbox.Text = "Coupons";
            coupons_discount_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            coupons_discount_checkbox.UseVisualStyleBackColor = false;
            // 
            // pwd_discount_checkbox
            // 
            pwd_discount_checkbox.Appearance = Appearance.Button;
            pwd_discount_checkbox.BackColor = Color.Gainsboro;
            pwd_discount_checkbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwd_discount_checkbox.Location = new Point(263, 71);
            pwd_discount_checkbox.Name = "pwd_discount_checkbox";
            pwd_discount_checkbox.Size = new Size(163, 42);
            pwd_discount_checkbox.TabIndex = 30;
            pwd_discount_checkbox.Text = "PWD";
            pwd_discount_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            pwd_discount_checkbox.UseVisualStyleBackColor = false;
            // 
            // senior_discount_checkbox
            // 
            senior_discount_checkbox.Appearance = Appearance.Button;
            senior_discount_checkbox.BackColor = Color.Gainsboro;
            senior_discount_checkbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            senior_discount_checkbox.Location = new Point(94, 71);
            senior_discount_checkbox.Name = "senior_discount_checkbox";
            senior_discount_checkbox.Size = new Size(163, 42);
            senior_discount_checkbox.TabIndex = 29;
            senior_discount_checkbox.Text = "Senior";
            senior_discount_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            senior_discount_checkbox.UseVisualStyleBackColor = false;
            // 
            // cash_checkbox
            // 
            cash_checkbox.Appearance = Appearance.Button;
            cash_checkbox.BackColor = Color.FromArgb(192, 255, 192);
            cash_checkbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash_checkbox.Location = new Point(12, 908);
            cash_checkbox.Name = "cash_checkbox";
            cash_checkbox.Size = new Size(240, 59);
            cash_checkbox.TabIndex = 30;
            cash_checkbox.Text = "Cash";
            cash_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            cash_checkbox.UseVisualStyleBackColor = false;
            // 
            // card_checkbox
            // 
            card_checkbox.Appearance = Appearance.Button;
            card_checkbox.BackColor = Color.FromArgb(255, 255, 192);
            card_checkbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            card_checkbox.Location = new Point(258, 908);
            card_checkbox.Name = "card_checkbox";
            card_checkbox.Size = new Size(253, 59);
            card_checkbox.TabIndex = 31;
            card_checkbox.Text = "Card";
            card_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            card_checkbox.UseVisualStyleBackColor = false;
            // 
            // QR_checkbox
            // 
            QR_checkbox.Appearance = Appearance.Button;
            QR_checkbox.BackColor = Color.FromArgb(255, 224, 192);
            QR_checkbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QR_checkbox.Location = new Point(517, 908);
            QR_checkbox.Name = "QR_checkbox";
            QR_checkbox.Size = new Size(240, 59);
            QR_checkbox.TabIndex = 32;
            QR_checkbox.Text = "QR";
            QR_checkbox.TextAlign = ContentAlignment.MiddleCenter;
            QR_checkbox.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(36, 193);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 33;
            label2.Text = "Cashier Name: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.WindowText;
            label12.Location = new Point(36, 228);
            label12.Name = "label12";
            label12.Size = new Size(85, 19);
            label12.TabIndex = 34;
            label12.Text = "Date Today: ";
            // 
            // cashier_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(QR_checkbox);
            Controls.Add(card_checkbox);
            Controls.Add(cash_checkbox);
            Controls.Add(groupBox5);
            Controls.Add(enter_button);
            Controls.Add(delete_button);
            Controls.Add(num0_button);
            Controls.Add(num3_button);
            Controls.Add(num2_button);
            Controls.Add(num6_button);
            Controls.Add(num5_button);
            Controls.Add(clear_button);
            Controls.Add(num1_button);
            Controls.Add(num4_button);
            Controls.Add(num9_button);
            Controls.Add(num8_button);
            Controls.Add(num7_button);
            Controls.Add(groupBox4);
            Controls.Add(circlePictureBox2);
            Controls.Add(date_today_picker);
            Controls.Add(cashier_name_txtbox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "cashier_interface";
            Text = "Form1";
            Load += cashier_interface_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private DateTimePicker date_today_picker;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private CirclePictureBox circlePictureBox2;
        private Label label9;
        private GroupBox groupBox4;
        private TextBox items_txtbox;
        private TextBox scanned_item_price_txtbox;
        private TextBox scanned_item_name_txtbox;
        private TextBox total_txtbox;
        private TextBox discount_txtbox;
        private TextBox subtotal_txtbox;
        private Button num7_button;
        private Button num8_button;
        private Button num9_button;
        private Button num4_button;
        private Button num1_button;
        private Button clear_button;
        private Button num5_button;
        private Button num6_button;
        private Button num2_button;
        private Button num3_button;
        private Button num0_button;
        private Button delete_button;
        private Button enter_button;
        private GroupBox groupBox5;
        private Button process_payment_button;
        private Label label10;
        private CheckBox senior_discount_checkbox;
        private CheckBox coupons_discount_checkbox;
        private CheckBox pwd_discount_checkbox;
        private CheckBox cash_checkbox;
        private CheckBox card_checkbox;
        private CheckBox QR_checkbox;
        private TextBox barcode_txtbox;
        public TextBox cashier_name_txtbox;
        private Label label2;
        private Button cancel_transaction_button;
        private Button exit_button;
        private Label label11;
        private TextBox vat_txtbox;
        private Label label12;
        public DataGridView dataGridView1;
    }
}
