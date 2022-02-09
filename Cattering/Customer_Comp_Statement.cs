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
    public partial class Customer_Comp_Statement : Form
    {
        public Customer_Comp_Statement()
        {
            InitializeComponent();
        }

        private void Customer_Comp_Statement_Load(object sender, EventArgs e)
        {
            stcusnum1.Text = MainSalesForm.oocusnum.ToString();

            // TODO: This line of code loads data into the 'DataSet6.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet6.DataTable1, stcusnum1.Text);

            
            // TODO: This line of code loads data into the 'DataSet6.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.DataSet6.customer, stcusnum1.Text);


            

            //MessageBox.Show(MainSalesForm.datestat1.ToString("yyyy-MM-dd 00:00"));
            //MessageBox.Show(MainSalesForm.datestat2.ToString("yyyy-MM-dd 23:59"));
            //MessageBox.Show(MainSalesForm.statementoptions);

                                    
            //this.DataTable1TableAdapter.Fill(this.DataSet6.DataTable1, stcusnum1.Text);
            
            




            this.reportViewer1.RefreshReport();
        }
    }
}
