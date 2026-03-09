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
    public partial class enter_cash : Form
    {
        private cashier_interface _parent;
        public enter_cash(cashier_interface parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void enter_cash_Load(object sender, EventArgs e)
        {
            cash_enter_txtbox.Focus();
        }

        private void cash_enter_button_Click(object sender, EventArgs e)
        {
            cashier_interface cashier_Interface = new cashier_interface();
            _parent.cash_txtbox.Text = cash_enter_txtbox.Text;
            this.Close();
        }

    }
}
