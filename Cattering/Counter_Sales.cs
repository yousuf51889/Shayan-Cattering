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
    public partial class Counter_Sales : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static int x = 0;
        public static int y;

        public Counter_Sales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            x = x + 1;

            qty.Text = x.ToString();

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (x <= 0)
            {

            }
            else
            {
                x = x - 1;
            }

            qty.Text = x.ToString();
        }

        private void foodcatagories()
        {
            dataGridView1.Columns["dish_name"].DefaultCellStyle.Font = new Font("calibri", 28);
            dataGridView1.Columns["digh_ratespp"].DefaultCellStyle.Font = new Font("calibri", 13);
            dataGridView1.Columns["dish_ratespkg"].DefaultCellStyle.Font = new Font("calibri", 13);
            unittype.Text = "Per Person";

            if (ch1.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (ch2.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Fast Food / Burgers - Sandwitches'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (ch3.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Biryani / Palao'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                              

            }



        }


        private void Counter_Sales_Load(object sender, EventArgs e)
        {
            ch1.Checked = true;
            foodcatagories();

        }

        decimal qtyvar;
        decimal itrates;
        decimal itamount;

        private void gettotalitemwise()
        {
            try
            {
                qtyvar = Convert.ToDecimal(qty.Text);

                itrates = Convert.ToDecimal(rates.Text);
                itamount = qtyvar * itrates;
                total.Text = itamount.ToString();

            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x = 0;
            qty.Text = "0";
            rates.Text = "";

            item.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (unittype.Text == "Per Person")
            {
                rates.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                rates.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void rates_TextChanged(object sender, EventArgs e)
        {
            if (rates.Text == "0")
            {
                qty.Text = "0";
            }
            else
            {
                gettotalitemwise();
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            if (qty.Text == "0")
            {

            }
            else
            {
                gettotalitemwise();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Add Item Please ...");
                }
                else if (rates.Text == "")
                {
                    MessageBox.Show("Add Rates Please ...");
                }
                else if (qty.Text == "")
                {
                    MessageBox.Show("Add Quantity Please ...");
                }

                else if (unittype.Text == "")
                {
                    MessageBox.Show("Select Unit");
                }

                else
                {

                    string[] arr = new string[4];
                    ListViewItem itm;


                    arr[0] = item.Text.ToString();
                    arr[1] = rates.Text.ToString();
                    arr[2] = qty.Text.ToString();
                    arr[3] = total.Text.ToString();


                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);


                    item.Text = "";
                    rates.Text = "";
                    qty.Text = "";
                    total.Text = "";
                    item.Focus();

                    decimal gtotal = 0;
                    foreach (ListViewItem lstItem in listView1.Items)
                    {
                        gtotal += decimal.Parse(lstItem.SubItems[3].Text);
                    }

                    gtotal1.Text = Convert.ToString(gtotal);
                }
            }
            catch
            {


            }

            x = 0;
            qty.Text = "0";
            rates.Text = "";
            total.Text = "0";


        }

        decimal tt1 = 0;
        decimal ttgst = 0;
        decimal ttdisc = 0;
        decimal ttgrttl = 0;

        private void getinvcalc()
        {
            if (Discount.Text == "")
            {
                Discount.Text = "0";
            }

            else
            {

                tt1 = Convert.ToDecimal(gtotal1.Text);
                ttgst = Convert.ToDecimal(GST.Text);
                ttdisc = Convert.ToDecimal(Discount.Text);
                ttgrttl = Convert.ToDecimal(Grand_Total.Text);

                ttgst = tt1 / 100 * 13;
                ttgrttl = (tt1 + ttgst) - ttdisc;

                GST.Text = ttgst.ToString();
                Grand_Total.Text = ttgrttl.ToString();
            }


        }


        private void gtotal1_TextChanged(object sender, EventArgs e)
        {
            getinvcalc();
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            getinvcalc();
        }

        decimal varcashrec = 0;
        decimal varchange = 0;

        private void cashrec_TextChanged(object sender, EventArgs e)
        {

            if (cashrec.Text == "")
            {
                cashrec.Text = "0";
            }

            else
            {

                varcashrec = Convert.ToDecimal(cashrec.Text);
                varchange = Convert.ToDecimal(chnageam.Text);
                ttgrttl = Convert.ToDecimal(Grand_Total.Text);

                varchange = varcashrec - ttgrttl;
                chnageam.Text = varchange.ToString();

            }

        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cashrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }




        private void listView1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text);

            item.Text = listView1.SelectedItems[0].Text;
            rates.Text = listView1.SelectedItems[0].SubItems[1].Text;
            qty.Text = listView1.SelectedItems[0].SubItems[2].Text;
            total.Text = listView1.SelectedItems[0].SubItems[3].Text;

            listView1.SelectedItems[0].Remove();
            decimal vargtotal = 0;
            foreach (ListViewItem eachItem in listView1.Items)
            {
                vargtotal += Convert.ToDecimal(eachItem.SubItems[3].Text);

            }
            gtotal1.Text = vargtotal.ToString();
        }


        private void delitem_Click(object sender, EventArgs e)
        {
            item.Text = "";
            rates.Text = "0";
            qty.Text = "0";
            total.Text = "0";

        }

        private void listclear()
        {
            foreach (ListViewItem eachItem in listView1.Items)
            {

                listView1.Items.Remove(eachItem);

            }
        }

        string ooid = "0";
        Decimal ooamounttotal = 0;
        
        private void insertorder_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Please Enter some values in item list");
            }

            else
            {
                string prefix = "SCCS";
                string cusadd = "Counter_(Sale_POS)";

                y = y + 1;
                Token_no.Text = "Token No : " + prefix.ToString() + "0000" + y;

                con.Open();
                String query = "insert into customer ( cus_name,cus_address,cus_totalbill,prefix,userid ) values ( '" + Token_no.Text + "','" + cusadd + "'," + Grand_Total.Text.ToString() + ",'" + prefix + "','" + login_form.uname + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                String query1 = "select top 1 cus_id,cus_totalbill from customer order by cus_no desc";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader read = cmd1.ExecuteReader();

                while (read.Read())
                {
                    ooid = (read[0].ToString());
                    ooamounttotal = Decimal.Parse((read[1].ToString()));
                }
                read.Close();
                con.Close();

                string sqlFormattedDate = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss.fff");

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    int val1 = 0;
                    int val2 = 1;
                    int val3 = 2;
                    int val4 = 3;

                    String itnames = listView1.Items[i].SubItems[val1].Text;
                    String itrates = listView1.Items[i].SubItems[val2].Text;
                    String itqtyy = listView1.Items[i].SubItems[val3].Text;
                    String ittotals = listView1.Items[i].SubItems[val4].Text;

                    decimal ditrates = Convert.ToDecimal(itrates);
                    decimal ditqtyy = Convert.ToDecimal(itqtyy);
                    decimal dittotals = Convert.ToDecimal(ittotals);


                    con.Open();
                    String query6 = "insert into Orders ( order_no,order_date,order_itemname,order_itemunittype,order_qty,order_itemrates,order_itemperunitrate ) values ( '" + ooid.ToString() + "', '" + sqlFormattedDate + "' ,'" + itnames.ToString() + "','" + unittype.Text.ToString() + "'," + ditqtyy + "," + ditrates + "," + dittotals + " )";
                    SqlCommand cmd6 = new SqlCommand(query6, con);
                    cmd6.ExecuteNonQuery();
                    con.Close();
                    
                }
                con.Open();
                String query2 = "insert into invoice ( invoicenum,invoice_date,invoice_value,invoice_adv,invoice_disc,userid,GST ) values ( '" + ooid.ToString() + "' , '" + sqlFormattedDate + "' ," + Grand_Total.Text.ToString() + ", " + cashrec.Text.ToString() + ", " + Discount.Text.ToString() + " , '" + login_form.uname + "', " + GST.Text.ToString() + " )";
                SqlCommand cmd3 = new SqlCommand(query2, con);
                cmd3.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Order Place Succesfully");

                listclear();
                item.Text = "";
                rates.Text = "0";
                qty.Text = "0";
                total.Text = "0";
                
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            x = 0;
            listclear();
            item.Text = "";
            rates.Text = "0";
            qty.Text = "0";
            total.Text = "0";
            gtotal1.Text = "0";
            GST.Text = "0";
            Discount.Text = "0";
            Grand_Total.Text = "0";
            cashrec.Text = "0";
            chnageam.Text = "0";

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewDishName adnd = new AddNewDishName();
            adnd.Show();
        }

        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            ch2.Checked = false;
            ch3.Checked = false;

            foodcatagories();
        }

        private void ch2_CheckedChanged(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch3.Checked = false;

            foodcatagories();
        }

        private void ch3_CheckedChanged(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;

            foodcatagories();
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            
        }
    }
}
