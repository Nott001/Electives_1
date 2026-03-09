namespace Electives_project
{
    partial class enter_cash
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
            cash_enter_button = new Button();
            label1 = new Label();
            cash_enter_txtbox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(cash_enter_button);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cash_enter_txtbox);
            groupBox1.Location = new Point(82, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cash_enter_button
            // 
            cash_enter_button.FlatAppearance.BorderColor = Color.Black;
            cash_enter_button.FlatAppearance.BorderSize = 2;
            cash_enter_button.FlatStyle = FlatStyle.Flat;
            cash_enter_button.Location = new Point(185, 142);
            cash_enter_button.Name = "cash_enter_button";
            cash_enter_button.Size = new Size(101, 36);
            cash_enter_button.TabIndex = 2;
            cash_enter_button.Text = "ENTER";
            cash_enter_button.UseVisualStyleBackColor = true;
            cash_enter_button.Click += cash_enter_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 43);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter cash:";
            // 
            // cash_enter_txtbox
            // 
            cash_enter_txtbox.BorderStyle = BorderStyle.FixedSingle;
            cash_enter_txtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cash_enter_txtbox.Location = new Point(80, 92);
            cash_enter_txtbox.Name = "cash_enter_txtbox";
            cash_enter_txtbox.Size = new Size(292, 33);
            cash_enter_txtbox.TabIndex = 0;
            // 
            // enter_cash
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(688, 287);
            Controls.Add(groupBox1);
            Name = "enter_cash";
            Text = "enter_cash";
            Load += enter_cash_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        public Button cash_enter_button;
        public TextBox cash_enter_txtbox;
    }
}