using Microsoft.Reporting.WinForms;
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
    public partial class Customer_Datewise_Statement : Form
    {
        public Customer_Datewise_Statement()
        {
            InitializeComponent();
        }

        private void Customer_Datewise_Statement_Load(object sender, EventArgs e)
        {
            
            this.DataTable2TableAdapter.Fill(this.DataSet6.DataTable2, MainSalesForm.oocusnum.ToString(), MainSalesForm.datestat1.ToString("yyyy-MM-dd 00:00"), MainSalesForm.datestat2.ToString("yyyy-MM-dd 23:59"));
            this.customerTableAdapter.Fill(this.DataSet6.customer, MainSalesForm.oocusnum.ToString());
            this.DataTable3TableAdapter.Fill(this.DataSet6.DataTable3, MainSalesForm.oocusnum.ToString(), MainSalesForm.datestat1.ToString("yyyy-MM-dd 00:00"));
                        
            ReportParameterCollection reportParameters1 = new ReportParameterCollection();
            reportParameters1.Add(new ReportParameter("ReportParameter2", MainSalesForm.datestat2.ToString("dd-MMM-yyyy")));
            reportParameters1.Add(new ReportParameter("ReportParameter1", MainSalesForm.datestat1.ToString("dd-MMM-yyyy")));
            reportViewer1.LocalReport.SetParameters(reportParameters1);

            this.reportViewer1.RefreshReport();
        }
    }
}
