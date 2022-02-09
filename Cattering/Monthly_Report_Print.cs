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
    public partial class Monthly_Report_Print : Form
    {
        public Monthly_Report_Print()
        {
            InitializeComponent();
        }

        private void Monthly_Report_Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet7.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet7.DataTable2, Monthly_Report.datestat11.ToString(), Monthly_Report.datestat12.ToString());
            // TODO: This line of code loads data into the 'DataSet7.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSet7.DataTable3, Monthly_Report.datestat11.ToString(), Monthly_Report.datestat12.ToString());
            // TODO: This line of code loads data into the 'DataSet7.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet7.DataTable1, Monthly_Report.datestat11.ToString() , Monthly_Report.datestat12.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
