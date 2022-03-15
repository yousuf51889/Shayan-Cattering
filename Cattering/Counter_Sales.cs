using Microsoft.Reporting.WinForms;
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

        public static string orderidcounter;
        public static string orderno;


        public static int x = 1;
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


            else if (ch4.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Bar B.Q / Rolls'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch5.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Drinks / Juices'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch6.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Roti / Bread'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch7.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Bakery Items'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch8.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Fried Items'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch9.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Curry Items'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch10.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Desert Items / Sweet Dishes'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            else if (ch11.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,digh_ratespp,dish_ratespkg from dishdetails where foodcatagory = 'Chineese Items'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }



        }


        private void Counter_Sales_Load(object sender, EventArgs e)
        {
            ch1.Checked = true;
            foodcatagories();
            loadsalesrecordcounter();

        }


        private void loadsalesrecordcounter() 
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select DISTINCT customer.cus_id,customer.cus_name,Orders.order_date,customer.cus_address,customer.cus_totalbill,customer.userid,customer.branch_name from customer left join Orders on Orders.order_no = customer.cus_id where cus_id like 'SCCS%' order by customer.cus_id desc ", con);
            adapt.Fill(dt);
            salesrecordgrid.DataSource = dt;
            con.Close();
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
            x = 1;
            qty.Text = "1";
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

        // Value of GST TAX

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

                ttgst = 0;

                // GST Calculation as below
                // ttgst = tt1 / 100 * 13;

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
                loadsalesrecordcounter();

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
            
        }

        private void ch2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ch3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            
        }

        private void ch3_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch2_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch1_Click(object sender, EventArgs e)
        {
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        

        private void loadorderidnumberforcounterslipprint() 
        {

            con.Open();
            String query1 = "select top 1 cus_id from customer where cus_id like 'SCCS%' order by cus_no desc";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                orderidcounter = (read[0].ToString());
            }
            read.Close();
            con.Close();
        }
                

        private void print_Click(object sender, EventArgs e)
        {
                                   
            loadorderidnumberforcounterslipprint();
            orderno = orderidcounter;
            printDocument1.Print();
            printDocument2.Print();

        }

        private void salesrecordgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salesrecordgrid.Columns[e.ColumnIndex].HeaderText == "Slip_Print")
            {
                //orderidcounter = "orderidcounter";

                orderno = salesrecordgrid.SelectedRows[0].Cells[1].Value.ToString();
                printDocument1.Print();
                printDocument2.Print();


            }
        }

        private void ch4_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();

        }

        private void ch5_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch6_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch7_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch8_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch9_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch10.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch10_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch11.Checked = false;

            foodcatagories();
        }

        private void ch11_Click(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
            ch4.Checked = false;
            ch5.Checked = false;
            ch6.Checked = false;
            ch7.Checked = false;
            ch8.Checked = false;
            ch9.Checked = false;
            ch10.Checked = false;

            foodcatagories();
        }

        private void GST_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales_Report_Item_Wise slit = new Sales_Report_Item_Wise();
            slit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complete_Sales_Records csrc = new Complete_Sales_Records();
            csrc.Show();
        }

        
        string customername;
        string orderdate;
        string itemname;
        int itemqty;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            con.Open();
            String query4 = "select Orders.order_no,customer.cus_name,Orders.order_date,Orders.order_itemname,order_qty from Orders inner join customer on Orders.order_no=customer.cus_id where Orders.order_no = '" + orderno + "' ";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            SqlDataReader read = cmd4.ExecuteReader();

            while (read.Read())
            {
                customername = (read[1].ToString());
                orderdate = (read[2].ToString());
                itemname = (read[3].ToString());
                itemqty = Convert.ToInt32(read[4].ToString());

            }

            int oldmargin = 0;
            e.Graphics.DrawString("SHAYAN CATTERERS", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 55));
            e.Graphics.DrawString(" Kitchen Slip ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 75));
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 85));

            e.Graphics.DrawString(customername.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, 95));
            e.Graphics.DrawString(orderdate, new Font("Arial", 10), Brushes.Black, new Point(25, 115));
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 125));
            e.Graphics.DrawString("Item Name", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 135));
            e.Graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(250, oldmargin + 135));
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 145));

            read.Close();
            con.Close();

            int margline = 160;

            con.Open();
            String query41 = "select Orders.order_no,customer.cus_name,Orders.order_date,Orders.order_itemname,order_qty from Orders inner join customer on Orders.order_no=customer.cus_id where Orders.order_no = '" + orderno + "' ";
            SqlCommand cmd41 = new SqlCommand(query4, con);
            SqlDataReader read1 = cmd41.ExecuteReader();

            while (read1.Read())
            {

                itemname = (read1[3].ToString());
                itemqty = Convert.ToInt32(read1[4].ToString());

                e.Graphics.DrawString(itemname.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, margline));
                e.Graphics.DrawString(itemqty.ToString(), new Font("Arial", 10), Brushes.Black, new Point(250, margline));
                margline = margline + 20;

            }
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10), Brushes.Black, new Point(25, margline));
            e.Graphics.DrawString("Please Show this Slip to Counter / Kitchen", new Font("Arial", 10), Brushes.Black, new Point(25, margline + 20));


            read1.Close();
            con.Close();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.shayan_catt_logoo;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 85, 1, 100, 100);

            e.Graphics.DrawString("SHAYAN CATTERERS", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(25, 105));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 125));
            e.Graphics.DrawString(" Shop No 02 Mustafa Garden", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(45, 145));
            e.Graphics.DrawString("Soldier Bazar No 02 Karachi", new Font("Arial", 10), Brushes.Black, new Point(55, 160));
            e.Graphics.DrawString("PTCL No : 021 - 32229806", new Font("Arial", 10), Brushes.Black, new Point(60, 175));
            e.Graphics.DrawString("STRN # S3202855-5 ", new Font("Arial", 10), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("NTN # 3202855-5 ", new Font("Arial", 10), Brushes.Black, new Point(90, 205));

            e.Graphics.DrawString("SOLDIER BAZAR", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 225));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 240));

            con.Open();
            String query4 = "select customer.cus_name,Orders.order_date,customer.userid from Orders inner join customer on Orders.order_no=customer.cus_id where Orders.order_no = '" + orderno + "' ";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            SqlDataReader read = cmd4.ExecuteReader();

            String name1 = "";
            String orderdate1 = "";
            string user = "";
            while (read.Read())
            {
                name1 = (read[0].ToString());
                orderdate1 = (read[1].ToString());
                user = (read[2].ToString());
            }
            read.Close();
            con.Close();

            e.Graphics.DrawString("Customer : " + name1.ToString(), new Font("Arial", 09), Brushes.Black, new Point(20, 250));

            e.Graphics.DrawString("Date : " + orderdate1.ToString(), new Font("Arial", 09), Brushes.Black, new Point(20, 270));

            e.Graphics.DrawString("USER : " + user.ToString(), new Font("Arial", 09), Brushes.Black, new Point(20, 290));


            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 305));
            e.Graphics.DrawString("Item", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 315));
            e.Graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(130, 315));
            e.Graphics.DrawString("Rates", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(165, 315));
            e.Graphics.DrawString("Amount", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(210, 315));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 320));

            int margline = 340;
            int submargline = 360;
            con.Open();
            String query5 = "select order_itemname,order_qty,order_itemrates,order_itemperunitrate from Orders where Orders.order_no = '" + orderno + "' ";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            SqlDataReader read1 = cmd5.ExecuteReader();

            String itemname1 = "";
            String qty1 = "";
            string rates1 = "";
            string amount1 = "";
            while (read1.Read())
            {
                itemname1 = (read1[0].ToString());
                qty1 = (read1[1].ToString());
                rates1 = (read1[2].ToString());
                amount1 = (read1[3].ToString());

                e.Graphics.DrawString(itemname1.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, margline));
                e.Graphics.DrawString(qty1.ToString(), new Font("Arial", 10), Brushes.Black, new Point(130, submargline));
                e.Graphics.DrawString(rates1.ToString(), new Font("Arial", 10), Brushes.Black, new Point(165, submargline));
                e.Graphics.DrawString(amount1.ToString(), new Font("Arial", 10), Brushes.Black, new Point(210, submargline));
                margline = margline + 40;
                submargline = submargline + 40;
            }
            read1.Close();
            con.Close();
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, submargline));

            con.Open();
            String query55 = "select SUM(Orders.order_itemperunitrate) as Sub_Total,invoice.invoice_disc,invoice.invoice_value,invoice.invoice_adv from invoice inner join orders on invoice.invoicenum = Orders.order_no where Orders.order_no = '" + orderno + "' group by invoice.invoice_disc,invoice.invoice_value,invoice.invoice_adv  ";
            SqlCommand cmd55 = new SqlCommand(query55, con);
            SqlDataReader read15 = cmd55.ExecuteReader();

            String subtotal = "";
            String invdisc = "";
            string invvalue = "";
            string invcashrec = "";
            int cashpaid = 0;
            int invamount = 0;
            int invchange = 0;
            while (read15.Read())
            {
                subtotal = (read15[0].ToString());
                invdisc = (read15[1].ToString());
                invvalue = (read15[2].ToString());
                invcashrec = (read15[3].ToString());
                invamount = Convert.ToInt16(read15[2].ToString());
                cashpaid = Convert.ToInt16(read15[3].ToString());
                invchange = cashpaid - invamount;
            }

            e.Graphics.DrawString("SUB TOTAL : ", new Font("Arial", 10), Brushes.Black, new Point(20, submargline + 20));
            e.Graphics.DrawString(subtotal.ToString(), new Font("Arial", 10), Brushes.Black, new Point(210, submargline + 20));
            e.Graphics.DrawString("DISCOUNT : ", new Font("Arial", 10), Brushes.Black, new Point(20, submargline + 40));
            e.Graphics.DrawString(invdisc.ToString(), new Font("Arial", 10), Brushes.Black, new Point(210, submargline + 40));
            e.Graphics.DrawString("INVOICE VALUE : ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, submargline + 60));
            e.Graphics.DrawString(invvalue.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(210, submargline + 60));
            e.Graphics.DrawString("CASH PAID : ", new Font("Arial", 10), Brushes.Black, new Point(20, submargline + 80));
            e.Graphics.DrawString(invcashrec.ToString(), new Font("Arial", 10), Brushes.Black, new Point(210, submargline + 80));
            e.Graphics.DrawString("CHANGE : ", new Font("Arial", 10), Brushes.Black, new Point(20, submargline + 100));
            e.Graphics.DrawString(invchange.ToString(), new Font("Arial", 10), Brushes.Black, new Point(210, submargline + 100));

            read15.Close();
            con.Close();
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, submargline + 110));
            e.Graphics.DrawString("Terms and Conditions : ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, submargline + 120));
            e.Graphics.DrawString("1.Please Check Your Remaining Amount : ", new Font("Arial", 08), Brushes.Black, new Point(20, submargline + 140));
            e.Graphics.DrawString("2.Please Check Items Before Leaving Counter : ", new Font("Arial", 08), Brushes.Black, new Point(20, submargline + 155));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, submargline + 160));
            e.Graphics.DrawString(" Thanks For Choosing Us ", new Font("Arial", 08), Brushes.Black, new Point(70, submargline + 175));
            e.Graphics.DrawString(" For Complaint and Suggestions ", new Font("Arial", 08), Brushes.Black, new Point(60, submargline + 190));
            e.Graphics.DrawString(" 021 - 32229806 ", new Font("Arial", 08), Brushes.Black, new Point(100, submargline + 205));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, submargline + 210));
            e.Graphics.DrawString(" Developed by DEVRAJ-TECH 0308-2787745 ", new Font("Arial", 08), Brushes.Black, new Point(20, submargline + 220));
        }
    }
}
