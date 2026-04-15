namespace Biometrics
{
    partial class employee_attendance_report
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
            searchby_combobox = new ComboBox();
            search_employee_button = new Button();
            search_employee_txtbox = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            exit_button = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1900, 71);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            // 
            // searchby_combobox
            // 
            searchby_combobox.FormattingEnabled = true;
            searchby_combobox.Location = new Point(637, 98);
            searchby_combobox.Name = "searchby_combobox";
            searchby_combobox.Size = new Size(121, 27);
            searchby_combobox.TabIndex = 47;
            searchby_combobox.Text = "search by";
            // 
            // search_employee_button
            // 
            search_employee_button.Location = new Point(12, 89);
            search_employee_button.Name = "search_employee_button";
            search_employee_button.Size = new Size(143, 45);
            search_employee_button.TabIndex = 46;
            search_employee_button.Text = "Search Employee";
            search_employee_button.UseVisualStyleBackColor = true;
            // 
            // search_employee_txtbox
            // 
            search_employee_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_employee_txtbox.Location = new Point(161, 96);
            search_employee_txtbox.Name = "search_employee_txtbox";
            search_employee_txtbox.Size = new Size(470, 29);
            search_employee_txtbox.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1900, 848);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attendance Table";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1888, 817);
            dataGridView1.TabIndex = 0;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(802, 89);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(143, 45);
            exit_button.TabIndex = 49;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            // 
            // employee_attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(exit_button);
            Controls.Add(groupBox1);
            Controls.Add(searchby_combobox);
            Controls.Add(search_employee_button);
            Controls.Add(search_employee_txtbox);
            Controls.Add(groupBox3);
            Name = "employee_attendance";
            Text = "employee_attendance";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private ComboBox searchby_combobox;
        private Button search_employee_button;
        private TextBox search_employee_txtbox;
        private GroupBox groupBox1;
        private Button exit_button;
        private DataGridView dataGridView1;
    }
}