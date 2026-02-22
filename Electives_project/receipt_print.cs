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
    public partial class receipt_print : Form
    {
        public receipt_print()
        {
            InitializeComponent();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("product", "Product");
                dataGridView1.Columns.Add("qty", "Qty");
                dataGridView1.Columns.Add("price", "Price");
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        public void LoadItems(DataGridView source)
        {
            dataGridView1.Rows.Clear();

            foreach (DataGridViewRow row in source.Rows)
            {
                if (!row.IsNewRow)
                {
                    object[] cellValues = new object[row.Cells.Count];

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }

                    dataGridView1.Rows.Add(cellValues);
                }
            }
        }

    }
}
