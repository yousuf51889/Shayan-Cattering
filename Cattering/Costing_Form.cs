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
    public partial class Costing_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static string getorderid;
        public static string cstsheetpr;
        decimal costingvalue;
                       

        public Costing_Form()
        {
            
            InitializeComponent();




        }

        private void Costing_Form_Load(object sender, EventArgs e)
        {
            costingorderid.Text = Costing_Form.getorderid;
            

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from orders where order_no = '" + costingorderid.Text + "'", con);
            adapt.Fill(dt);
            ordercostinggrid.DataSource = dt;
            con.Close();
            costingitemsgriddetails();
            updatecostingfigureatload();

            cstsheetpr = costingorderid.Text;

        }

        private void cleardata() 
        {
            costorderitem.Text = "";
            costitemcost.Text = "";
            costitemrates.Text = "";
            costitemamount.Text = "";
            costorderitem.Focus();
        }

        private void costingitemsgriddetails() 
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from order_costing where Order_id_ref = '" + costingorderid.Text + "'", con);
            adapt.Fill(dt);
            ordercostgrid.DataSource = dt;
            con.Close();
        }

        private void ordercostinggrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ordercostingdorderitem.Text = ordercostinggrid.SelectedRows[0].Cells[2].Value.ToString();
            costingitemsgriddetails();
        }

        decimal val1;
        decimal val2;
        decimal val3;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void costitemrates_TextChanged(object sender, EventArgs e)
        {
            try
            {
                            
            if (costitemcost.Text == "")
            {
                
            }
            else if (costitemrates.Text == "")
            {

            }
            else
            {
                val1 = Convert.ToDecimal(costitemcost.Text);
                val2 = Convert.ToDecimal(costitemrates.Text);
                val3 = val1 * val2;
                costitemamount.Text = val3.ToString();
            }
            }
            catch 
            {
                               
            }

        }

        private void costitemcost_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (costitemcost.Text == "")
                {

                }
                else if (costitemrates.Text == "")
                {

                }
                else
                {
                    val1 = Convert.ToDecimal(costitemcost.Text);
                    val2 = Convert.ToDecimal(costitemrates.Text);
                    val3 = val1 * val2;
                    costitemamount.Text = val3.ToString();
                }
            }
            catch
            {

            }
        }
        

        private void insert_Click(object sender, EventArgs e)
        {
                        
            try
            {

                if (costitemcost.Text == "")
                {

                }
                else if (costitemrates.Text == "")
                {

                }
                else if (costorderitem.Text == "")
                {

                }
                else
                {
                    con.Open();
                    String query3 = "insert into order_costing ( Order_id_Ref,Order_costdishname,Order_Costitems,Order_costqty,Order_costrates,Order_costamount ) values ('" + costingorderid.Text + "' , '" + ordercostingdorderitem.Text + "','" + costorderitem.Text + "','" + costitemcost.Text + "','" + costitemrates.Text + "','" + costitemamount.Text + "')";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    cleardata();
                    costingitemsgriddetails();


                    con.Open();
                    String query4 = "select sum(Order_costamount) as Costing from Order_Costing where Order_id_ref = '" + costingorderid.Text + "' ";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    SqlDataReader read = cmd4.ExecuteReader();

                    while (read.Read())
                    {
                        if (read[0].ToString() == "")
                        {
                            costingvalue = 0;                       
                        }
                        else
                        {
                            costingvalue = Convert.ToDecimal(read["Costing"].ToString());
                        }
                    }
                    TCost.Text = costingvalue.ToString();
                    read.Close();
                    con.Close();
                    updatecostingrates();

                }

            }
            catch
            {

            }
        }
        private void updatecostingfigureatload() 
        {
            con.Open();
            String query4 = "select sum(Order_costamount) as Costing from Order_Costing where Order_id_ref = '" + costingorderid.Text + "' ";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            SqlDataReader read = cmd4.ExecuteReader();

            while (read.Read())
            {
                if (read[0].ToString() == "")
                {
                    costingvalue = 0;
                }
                else
                {
                    costingvalue = Convert.ToDecimal(read["Costing"].ToString());
                }
            }
            TCost.Text = costingvalue.ToString();
            read.Close();
            con.Close();
        }

        private void updatecostingrates() 
        {
            con.Open();
            String query5 = " Update invoice set Costing = " + costingvalue.ToString() + " where invoicenum = '" + costingorderid.Text + "' ";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            cmd5.ExecuteNonQuery();

            con.Close();
        }

        private void costprint_Click(object sender, EventArgs e)
        {
            Costing_Report csr = new Costing_Report();
            csr.Show();
        }
    }
}
