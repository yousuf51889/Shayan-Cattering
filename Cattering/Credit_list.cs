using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattering
{
    public partial class Credit_list : Form
    {
        public Credit_list()
        {
            InitializeComponent();
        }

        private void Credit_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet5.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.DataSet5.customer);
            // TODO: This line of code loads data into the 'DataSet5.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet5.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
