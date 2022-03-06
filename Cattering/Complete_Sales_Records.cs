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
    public partial class Complete_Sales_Records : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");

        public Complete_Sales_Records()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datestat11 = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00");
            string datestat12 = dateTimePicker2.Value.ToString("yyyy-MM-dd 00:00");


            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Orders.order_no,customer.cus_name,Orders.order_date,Orders.order_itemname,order_qty from Orders inner join customer on Orders.order_no=customer.cus_id where order_no like 'SCCS%' and order_date between '" + datestat11 + "' and '" + datestat12 + "' order by Orders.order_no desc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }
    }
}
