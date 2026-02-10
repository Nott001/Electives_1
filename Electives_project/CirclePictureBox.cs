using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Electives_project
{
    // Adding ': PictureBox' makes this class a specialized version of the standard PictureBox
    internal class CirclePictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // This creates the circular boundary
            using (GraphicsPath grpath = new GraphicsPath())
            {
                grpath.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(grpath);
            }

            // This draws the image normally inside that circular boundary
            base.OnPaint(pe);
        }
    }
}
