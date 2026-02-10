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
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            cashier_name_txtbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            circlePictureBox2 = new CirclePictureBox();
            circlePictureBox1 = new CirclePictureBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            scanned_item_txtbox = new TextBox();
            scanned_item_price_txtbox = new TextBox();
            items_txtbox = new TextBox();
            subtotal_txtbox = new TextBox();
            discount_txtbox = new TextBox();
            total_txtbox = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            groupBox5 = new GroupBox();
            button1 = new Button();
            label10 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).BeginInit();
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
            groupBox2.Location = new Point(12, 463);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 439);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 173);
            label8.Name = "label8";
            label8.Size = new Size(600, 2);
            label8.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 319);
            label7.Name = "label7";
            label7.Size = new Size(76, 30);
            label7.TabIndex = 4;
            label7.Text = "Total: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 250);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 3;
            label6.Text = "Discount: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 197);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 2;
            label5.Text = "Subtotal: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 126);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 1;
            label4.Text = "Items: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 67);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 0;
            label3.Text = "Transaction Summary";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new Point(1456, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(456, 748);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product scanned list";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(444, 631);
            listBox1.TabIndex = 0;
            // 
            // cashier_name_txtbox
            // 
            cashier_name_txtbox.BackColor = Color.Gainsboro;
            cashier_name_txtbox.BorderStyle = BorderStyle.None;
            cashier_name_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_name_txtbox.Location = new Point(169, 190);
            cashier_name_txtbox.Name = "cashier_name_txtbox";
            cashier_name_txtbox.Size = new Size(285, 26);
            cashier_name_txtbox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.Location = new Point(169, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // circlePictureBox2
            // 
            circlePictureBox2.Location = new Point(1007, 582);
            circlePictureBox2.Name = "circlePictureBox2";
            circlePictureBox2.Size = new Size(8, 8);
            circlePictureBox2.TabIndex = 6;
            circlePictureBox2.TabStop = false;
            // 
            // circlePictureBox1
            // 
            circlePictureBox1.BackColor = SystemColors.ControlDark;
            circlePictureBox1.Location = new Point(32, 165);
            circlePictureBox1.Name = "circlePictureBox1";
            circlePictureBox1.Size = new Size(114, 94);
            circlePictureBox1.TabIndex = 2;
            circlePictureBox1.TabStop = false;
            circlePictureBox1.Click += circlePictureBox1_Click;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(58, 293);
            label9.Name = "label9";
            label9.Size = new Size(600, 2);
            label9.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(scanned_item_price_txtbox);
            groupBox4.Controls.Add(scanned_item_txtbox);
            groupBox4.ForeColor = SystemColors.ControlText;
            groupBox4.Location = new Point(12, 281);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(745, 176);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Scanned Item";
            // 
            // scanned_item_txtbox
            // 
            scanned_item_txtbox.BackColor = Color.White;
            scanned_item_txtbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanned_item_txtbox.ForeColor = SystemColors.WindowText;
            scanned_item_txtbox.Location = new Point(58, 48);
            scanned_item_txtbox.Name = "scanned_item_txtbox";
            scanned_item_txtbox.Size = new Size(439, 39);
            scanned_item_txtbox.TabIndex = 0;
            // 
            // scanned_item_price_txtbox
            // 
            scanned_item_price_txtbox.BackColor = Color.White;
            scanned_item_price_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanned_item_price_txtbox.Location = new Point(58, 109);
            scanned_item_price_txtbox.Name = "scanned_item_price_txtbox";
            scanned_item_price_txtbox.Size = new Size(197, 33);
            scanned_item_price_txtbox.TabIndex = 1;
            // 
            // items_txtbox
            // 
            items_txtbox.BackColor = Color.White;
            items_txtbox.BorderStyle = BorderStyle.None;
            items_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            items_txtbox.Location = new Point(461, 128);
            items_txtbox.Name = "items_txtbox";
            items_txtbox.Size = new Size(197, 26);
            items_txtbox.TabIndex = 7;
            // 
            // subtotal_txtbox
            // 
            subtotal_txtbox.BackColor = Color.White;
            subtotal_txtbox.BorderStyle = BorderStyle.None;
            subtotal_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtotal_txtbox.Location = new Point(461, 199);
            subtotal_txtbox.Name = "subtotal_txtbox";
            subtotal_txtbox.Size = new Size(197, 26);
            subtotal_txtbox.TabIndex = 8;
            // 
            // discount_txtbox
            // 
            discount_txtbox.BackColor = Color.White;
            discount_txtbox.BorderStyle = BorderStyle.None;
            discount_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount_txtbox.Location = new Point(461, 252);
            discount_txtbox.Name = "discount_txtbox";
            discount_txtbox.Size = new Size(197, 26);
            discount_txtbox.TabIndex = 9;
            // 
            // total_txtbox
            // 
            total_txtbox.BackColor = Color.White;
            total_txtbox.BorderStyle = BorderStyle.None;
            total_txtbox.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_txtbox.Location = new Point(461, 319);
            total_txtbox.Name = "total_txtbox";
            total_txtbox.Size = new Size(197, 31);
            total_txtbox.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(763, 463);
            button5.Name = "button5";
            button5.Size = new Size(225, 83);
            button5.TabIndex = 12;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(994, 463);
            button6.Name = "button6";
            button6.Size = new Size(225, 83);
            button6.TabIndex = 13;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(1225, 463);
            button7.Name = "button7";
            button7.Size = new Size(225, 83);
            button7.TabIndex = 14;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(763, 552);
            button8.Name = "button8";
            button8.Size = new Size(225, 83);
            button8.TabIndex = 15;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(763, 641);
            button9.Name = "button9";
            button9.Size = new Size(225, 83);
            button9.TabIndex = 16;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.LightCoral;
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(763, 730);
            button10.Name = "button10";
            button10.Size = new Size(225, 83);
            button10.TabIndex = 17;
            button10.Text = "CLEAR";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.DimGray;
            button11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(994, 552);
            button11.Name = "button11";
            button11.Size = new Size(225, 83);
            button11.TabIndex = 18;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.DimGray;
            button12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(1225, 552);
            button12.Name = "button12";
            button12.Size = new Size(225, 83);
            button12.TabIndex = 19;
            button12.Text = "6";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.DimGray;
            button13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.Location = new Point(994, 641);
            button13.Name = "button13";
            button13.Size = new Size(225, 83);
            button13.TabIndex = 20;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.DimGray;
            button14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button14.ForeColor = Color.White;
            button14.Location = new Point(1225, 641);
            button14.Name = "button14";
            button14.Size = new Size(225, 83);
            button14.TabIndex = 21;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.DimGray;
            button15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button15.ForeColor = Color.White;
            button15.Location = new Point(994, 730);
            button15.Name = "button15";
            button15.Size = new Size(225, 83);
            button15.TabIndex = 22;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.Coral;
            button16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.White;
            button16.Location = new Point(1225, 730);
            button16.Name = "button16";
            button16.Size = new Size(225, 83);
            button16.TabIndex = 23;
            button16.Text = "DELETE";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.CadetBlue;
            button17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.White;
            button17.Location = new Point(763, 819);
            button17.Name = "button17";
            button17.Size = new Size(687, 83);
            button17.TabIndex = 24;
            button17.Text = "ENTER";
            button17.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(checkBox3);
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Location = new Point(763, 281);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(687, 176);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Discount";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 665);
            button1.Name = "button1";
            button1.Size = new Size(444, 77);
            button1.TabIndex = 1;
            button1.Text = "Process Payment";
            button1.UseVisualStyleBackColor = false;
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
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.BackColor = Color.Gainsboro;
            checkBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(94, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 42);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "Senior";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.Appearance = Appearance.Button;
            checkBox2.BackColor = Color.Gainsboro;
            checkBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(263, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(163, 42);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "PWD";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.BackColor = Color.Gainsboro;
            checkBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(432, 71);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(163, 42);
            checkBox3.TabIndex = 31;
            checkBox3.Text = "Coupons";
            checkBox3.TextAlign = ContentAlignment.MiddleCenter;
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.BackColor = Color.FromArgb(192, 255, 192);
            checkBox4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(12, 908);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(240, 59);
            checkBox4.TabIndex = 30;
            checkBox4.Text = "Cash";
            checkBox4.TextAlign = ContentAlignment.MiddleCenter;
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.BackColor = Color.FromArgb(255, 255, 192);
            checkBox5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(258, 908);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(253, 59);
            checkBox5.TabIndex = 31;
            checkBox5.Text = "Card";
            checkBox5.TextAlign = ContentAlignment.MiddleCenter;
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.BackColor = Color.FromArgb(255, 224, 192);
            checkBox6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(517, 908);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(240, 59);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "QR";
            checkBox6.TextAlign = ContentAlignment.MiddleCenter;
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // cashier_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(groupBox5);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(circlePictureBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(cashier_name_txtbox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(circlePictureBox1);
            Controls.Add(groupBox1);
            Name = "cashier_interface";
            Text = "Form1";
            Load += cashier_interface_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).EndInit();
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
        private ListBox listBox1;
        private TextBox cashier_name_txtbox;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private CirclePictureBox circlePictureBox2;
        private Label label9;
        private CirclePictureBox circlePictureBox1;
        private GroupBox groupBox4;
        private TextBox items_txtbox;
        private TextBox scanned_item_price_txtbox;
        private TextBox scanned_item_txtbox;
        private TextBox total_txtbox;
        private TextBox discount_txtbox;
        private TextBox subtotal_txtbox;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private GroupBox groupBox5;
        private Button button1;
        private Label label10;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}
