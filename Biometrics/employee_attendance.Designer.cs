namespace Biometrics
{
    partial class employee_attendance
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
            groupBox3 = new GroupBox();
            current_time_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            employee_pictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            department_box = new TextBox();
            label60 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            time_in_txtbox = new TextBox();
            timeout_txtbox = new TextBox();
            fingerprint_pictureBox = new PictureBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employee_pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fingerprint_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(current_time_label);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(840, 86);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            // 
            // current_time_label
            // 
            current_time_label.AutoSize = true;
            current_time_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            current_time_label.Location = new Point(678, 54);
            current_time_label.Name = "current_time_label";
            current_time_label.Size = new Size(71, 20);
            current_time_label.TabIndex = 48;
            current_time_label.Text = "00:00:00";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(616, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 47;
            // 
            // employee_pictureBox
            // 
            employee_pictureBox.BorderStyle = BorderStyle.FixedSingle;
            employee_pictureBox.Location = new Point(47, 104);
            employee_pictureBox.Name = "employee_pictureBox";
            employee_pictureBox.Size = new Size(323, 261);
            employee_pictureBox.TabIndex = 44;
            employee_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(department_box);
            groupBox1.Controls.Add(label60);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(401, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 342);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            // 
            // department_box
            // 
            department_box.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department_box.Location = new Point(161, 258);
            department_box.Name = "department_box";
            department_box.Size = new Size(224, 21);
            department_box.TabIndex = 65;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Microsoft Sans Serif", 9F);
            label60.Location = new Point(27, 261);
            label60.Name = "label60";
            label60.Size = new Size(75, 15);
            label60.TabIndex = 64;
            label60.Text = "Department:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(160, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 21);
            textBox1.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(160, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 21);
            textBox2.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(160, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 21);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(160, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 21);
            textBox4.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(27, 79);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 50;
            label5.Text = "Employee Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(27, 214);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 49;
            label6.Text = "Surname:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(27, 167);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 48;
            label7.Text = "Middle Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(27, 122);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 47;
            label8.Text = "First Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 531);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(840, 198);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Attendance Sheet";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(828, 272);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 487);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 47;
            label1.Text = "Time In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(468, 487);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 48;
            label2.Text = "Time Out:";
            // 
            // time_in_txtbox
            // 
            time_in_txtbox.Location = new Point(168, 489);
            time_in_txtbox.Name = "time_in_txtbox";
            time_in_txtbox.Size = new Size(218, 26);
            time_in_txtbox.TabIndex = 49;
            // 
            // timeout_txtbox
            // 
            timeout_txtbox.Location = new Point(572, 489);
            timeout_txtbox.Name = "timeout_txtbox";
            timeout_txtbox.Size = new Size(218, 26);
            timeout_txtbox.TabIndex = 50;
            // 
            // fingerprint_pictureBox
            // 
            fingerprint_pictureBox.BorderStyle = BorderStyle.FixedSingle;
            fingerprint_pictureBox.Location = new Point(155, 375);
            fingerprint_pictureBox.Name = "fingerprint_pictureBox";
            fingerprint_pictureBox.Size = new Size(102, 71);
            fingerprint_pictureBox.TabIndex = 51;
            fingerprint_pictureBox.TabStop = false;
            // 
            // employee_attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 741);
            Controls.Add(fingerprint_pictureBox);
            Controls.Add(timeout_txtbox);
            Controls.Add(time_in_txtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(employee_pictureBox);
            Controls.Add(groupBox3);
            Name = "employee_attendance";
            Text = "employee_attendance";
            Load += employee_attendance_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employee_pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fingerprint_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private PictureBox employee_pictureBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private TextBox department_box;
        private Label label60;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox time_in_txtbox;
        private TextBox timeout_txtbox;
        private Label current_time_label;
        private PictureBox fingerprint_pictureBox;
    }
}
