using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalReport = Microsoft.Reporting.WebForms.LocalReport;
using Report = Microsoft.Reporting.WebForms.Report;
using Warning = Microsoft.Reporting.WebForms.Warning;

namespace Cattering
{
    public partial class printslip : Form
    {
        public printslip()
        {
            InitializeComponent();
        }

        private void printslip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet8.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet8.DataTable2, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.DataSet8.invoice, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.Orders' table. You can move, or remove it, as needed.
            this.OrdersTableAdapter.Fill(this.DataSet8.Orders, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet8.DataTable1, Counter_Sales.orderidcounter.ToString());

            this.reportViewer1.RefreshReport();
                        

        }


            























    
    }
}
