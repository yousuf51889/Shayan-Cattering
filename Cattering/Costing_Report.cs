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
    public partial class Costing_Report : Form
    {
        public Costing_Report()
        {
            InitializeComponent();
        }

        private void Costing_Report_Load(object sender, EventArgs e)
        {
                    

            this.Order_CostingTableAdapter.Fillk1(this.DataSet3.Order_Costing, Costing_Form.cstsheetpr.ToString());

            this.invoiceTableAdapter.Fillk2(this.DataSet3.invoice, Costing_Form.cstsheetpr.ToString());

            
            this.reportViewer1.RefreshReport();
        }
    }
}
