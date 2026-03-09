using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electives_project
{
    public partial class swipe_card : Form
    {
        public swipe_card()
        {
            InitializeComponent();
        }

        private void swipe_done_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
