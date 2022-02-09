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
    public partial class Kitchen_Schedule : Form
    {
        public Kitchen_Schedule()
        {
            InitializeComponent();
        }

        private void Kitchen_Schedule_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSet1.Orders' table. You can move, or remove it, as needed.
            this.OrdersTableAdapter.Fillk1(this.DataSet2.Orders, MainSalesForm.ooiddp.ToString());
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fillk2(this.DataSet2.DataTable1, MainSalesForm.ooiddp.ToString());

            this.reportViewer1.RefreshReport();
            
        }
    }
}
