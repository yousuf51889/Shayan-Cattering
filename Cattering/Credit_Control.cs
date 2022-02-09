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
    public partial class Credit_Control : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static string orderforcc;

        public Credit_Control()
        {
            InitializeComponent();
        }

        private void Credit_Control_Load(object sender, EventArgs e)
        {
            
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select customer.cus_id,customer.cus_name,customer.cus_address,invoice.invoice_date,customer.cus_phonenum,invoice.invoice_value,invoice.invoice_adv,invoice.invoice_disc,invoice.invoice_balance from customer left join invoice on customer.cus_id = invoice.invoicenum where invoice.invoice_balance > 0 order by cus_id asc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Rec_Balance")
            {
                Costing_Form.getorderid = "";
                orderforcc = dataGridView1.SelectedRows[0].Cells["cus_id"].Value.ToString();

                Customer_Balance csbl = new Customer_Balance();
                csbl.Show();
                
            }
        }
    }
}
