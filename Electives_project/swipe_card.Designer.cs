namespace Electives_project
{
    partial class swipe_card
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
            swipe_done_button = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(swipe_done_button);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // swipe_done_button
            // 
            swipe_done_button.FlatAppearance.BorderColor = Color.Black;
            swipe_done_button.FlatAppearance.BorderSize = 2;
            swipe_done_button.FlatStyle = FlatStyle.Flat;
            swipe_done_button.Location = new Point(212, 160);
            swipe_done_button.Name = "swipe_done_button";
            swipe_done_button.Size = new Size(101, 36);
            swipe_done_button.TabIndex = 3;
            swipe_done_button.Text = "Done";
            swipe_done_button.UseVisualStyleBackColor = true;
            swipe_done_button.Click += swipe_done_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 104);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 4;
            label1.Text = "Swipe Credit Card";
            // 
            // swipe_card
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(566, 304);
            Controls.Add(groupBox1);
            Name = "swipe_card";
            Text = "swipe_card";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        public Button swipe_done_button;
    }
}