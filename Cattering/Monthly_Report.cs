using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattering
{
    public partial class Monthly_Report : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");

        public static DateTime datestat11;
        public static DateTime datestat12;


        public Monthly_Report()
        {
            InitializeComponent();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select customer.cus_id,customer.cus_name,customer.cus_address,invoice.invoice_date,invoice.invoice_value,invoice.invoice_adv,invoice.invoice_disc,invoice.invoice_balance from customer left join invoice on customer.cus_id = invoice.invoicenum order by cus_id desc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();


        }

        

        private void loadrpt_Click(object sender, EventArgs e)
        {

            Monthly_Report.datestat11 = dateTimePicker1.Value;
            Monthly_Report.datestat12 = dateTimePicker2.Value;

            Monthly_Report_Print mnpr = new Monthly_Report_Print();
            mnpr.Show();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Print")
            {
                MainSalesForm.ooiddp = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                P_Invoice invoiceprint = new P_Invoice();
                invoiceprint.Show();

            }


        }
    }
}
