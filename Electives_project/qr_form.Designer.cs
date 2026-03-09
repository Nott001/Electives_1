namespace Electives_project
{
    partial class qr_form
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
            qr_picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)qr_picturebox).BeginInit();
            SuspendLayout();
            // 
            // qr_picturebox
            // 
            qr_picturebox.BackColor = SystemColors.Control;
            qr_picturebox.BorderStyle = BorderStyle.FixedSingle;
            qr_picturebox.Location = new Point(63, 12);
            qr_picturebox.Name = "qr_picturebox";
            qr_picturebox.Size = new Size(500, 522);
            qr_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            qr_picturebox.TabIndex = 0;
            qr_picturebox.TabStop = false;
            // 
            // qr_form
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(634, 546);
            Controls.Add(qr_picturebox);
            Name = "qr_form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)qr_picturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox qr_picturebox;
    }
}