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
    public partial class Cus_Statment : Form
    {
        public Cus_Statment()
        {
            InitializeComponent();
        }

        private void Cus_Statment_Load(object sender, EventArgs e)
        {
                    

            stcusnum.Text = MainSalesForm.oocusnum.ToString();

            this.customerTableAdapter.Fill1(this.DataSet4.customer, stcusnum.Text);

            this.DataTable1TableAdapter.Fill2(this.DataSet4.DataTable1, stcusnum.Text);

            this.DataTable2TableAdapter.Fill3(this.DataSet4.DataTable2, stcusnum.Text);


            this.reportViewer1.RefreshReport();


        }

        private void loadreport() 
        {
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
