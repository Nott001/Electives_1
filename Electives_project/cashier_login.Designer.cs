namespace Electives_project
{
    partial class cashier_login
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
            cancel_button = new Button();
            login_button = new Button();
            label1 = new Label();
            passwordbox = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            username_box = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // exit_button
            // 
            exit_button.BackColor = SystemColors.ActiveCaptionText;
            exit_button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit_button.ForeColor = SystemColors.ControlLightLight;
            exit_button.Location = new Point(418, 265);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(100, 42);
            exit_button.TabIndex = 5;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = SystemColors.ActiveCaptionText;
            cancel_button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_button.ForeColor = SystemColors.ControlLightLight;
            cancel_button.Location = new Point(312, 265);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(100, 42);
            cancel_button.TabIndex = 4;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // login_button
            // 
            login_button.BackColor = SystemColors.ActiveCaptionText;
            login_button.FlatAppearance.BorderColor = Color.Black;
            login_button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.ControlLightLight;
            login_button.Location = new Point(206, 265);
            login_button.Name = "login_button";
            login_button.Size = new Size(100, 42);
            login_button.TabIndex = 3;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 134);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbox.Location = new Point(254, 183);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(262, 26);
            passwordbox.TabIndex = 1;
            passwordbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 186);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(859, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(exit_button);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cancel_button);
            groupBox1.Controls.Add(login_button);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordbox);
            groupBox1.Controls.Add(username_box);
            groupBox1.Location = new Point(605, 383);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 377);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(-3, 0);
            label3.Name = "label3";
            label3.Size = new Size(717, 34);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // username_box
            // 
            username_box.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_box.Location = new Point(254, 131);
            username_box.Name = "username_box";
            username_box.Size = new Size(262, 26);
            username_box.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1900, 136);
            groupBox2.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(48, 35);
            label4.Name = "label4";
            label4.Size = new Size(125, 31);
            label4.TabIndex = 0;
            label4.Text = "Villa Corp.";
            // 
            // cashier_login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1041);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "cashier_login";
            Text = "cashier_login";
            Load += cashier_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button exit_button;
        private Button cancel_button;
        private Button login_button;
        private Label label1;
        private TextBox passwordbox;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox username_box;
        private GroupBox groupBox2;
        private Label label10;
        private Label label4;
    }
}