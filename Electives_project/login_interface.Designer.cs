namespace Electives_project
{
    partial class login_interface
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
            circlePictureBox1 = new CirclePictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label3 = new Label();
            username_txtbox = new TextBox();
            password_txtbox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(password_txtbox);
            groupBox1.Controls.Add(username_txtbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(circlePictureBox1);
            groupBox1.Location = new Point(632, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // circlePictureBox1
            // 
            circlePictureBox1.BackColor = Color.Gray;
            circlePictureBox1.Location = new Point(279, 44);
            circlePictureBox1.Name = "circlePictureBox1";
            circlePictureBox1.Size = new Size(199, 189);
            circlePictureBox1.TabIndex = 0;
            circlePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 331);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 384);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Password: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1900, 136);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(48, 79);
            label10.Name = "label10";
            label10.Size = new Size(104, 19);
            label10.TabIndex = 2;
            label10.Text = "Log in Interface";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(48, 35);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 0;
            label3.Text = "Villa Corp.";
            // 
            // username_txtbox
            // 
            username_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txtbox.Location = new Point(220, 328);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(420, 33);
            username_txtbox.TabIndex = 3;
            // 
            // password_txtbox
            // 
            password_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txtbox.Location = new Point(220, 381);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.Size = new Size(420, 33);
            password_txtbox.TabIndex = 4;
            // 
            // login_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "login_interface";
            Text = "login_interface";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private CirclePictureBox circlePictureBox1;
        private Label label2;
        private TextBox password_txtbox;
        private TextBox username_txtbox;
        private GroupBox groupBox2;
        private Label label10;
        private Label label3;
    }
}