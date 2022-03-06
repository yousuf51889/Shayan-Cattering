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
    public partial class Sales_Report_Item_Wise : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
       
        public Sales_Report_Item_Wise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string datestat11 = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00");
            string datestat10 = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00");
            string datestat12 = dateTimePicker2.Value.ToString("yyyy-MM-dd 00:00");
            string datestat13 = dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59");

            Loadgriddata(datestat11, datestat12);
            LoadValueamountsales(datestat11, datestat12);
            Loadexpensefigure(datestat11, datestat12);

        }

        private void Loadexpensefigure(string datestat10, string datestat13)
        {
            con.Open();
            int totalcashexp;
            String query1 = "select sum(amount) as Cash_Exp from expense where trans_nature in ('Payment','Cash') and date_of_entry between '" + datestat10 + "' and '" + datestat13 + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                if (read[0].ToString() == "")
                {
                    totalcashexp = 0;
                }
                else
                {
                    totalcashexp = Convert.ToInt32(read[0].ToString());
                }

                exp.Text = totalcashexp.ToString();

            }

            read.Close();

            con.Close();
        }


        private void LoadValueamountsales(string datestat11, string datestat12)
        {
            con.Open();
            int totalbal;
            String query1 = "select sum(order_itemperunitrate) as Amount  from Orders where order_no like 'SCCS%' and order_date between '" + datestat11 + "' and '" + datestat12 + "'  ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                if (read[0].ToString() == "")
                {
                    totalbal = 0;
                }
                else
                {
                    totalbal = Convert.ToInt32(read[0].ToString());
                }

                sales.Text = totalbal.ToString();

            }

            read.Close();

            con.Close();
        }

        private void Loadgriddata(string datestat11, string datestat12)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select order_date,order_itemname,sum(order_qty) as Qty,sum(order_itemperunitrate) as Amount from Orders where order_no like 'SCCS%' and order_date between '" + datestat11 + "' and '" + datestat12 + "'  group by order_date,order_itemname order by order_date desc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
