using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
using System.IO;

namespace Electives_project
{
    internal static class add_products_helper
    {
        public static void SelectProductImage(PictureBox pb, TextBox pathTxt)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(ofd.FileName);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pathTxt.Text = ofd.FileName; // Store path for database
                }
            }
        }
    }
}
