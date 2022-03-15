using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cattering
{


    public partial class MainSalesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static string ooiddp;
        public static string oocusnum;
        public static DateTime datestat1;
        public static DateTime datestat2;
        public static string statementoptions;
        
        public MainSalesForm()


        {

            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            griddishnamesload();
            loadcustomerrecordgriddata();
            orderitemlist.View = View.Details;
            
            cleardataform();
            resetedt();
                   
        }

        private void loadbuttonseditorderitems()
        {
            
        }

        string totalbal = "0";
        private void findbalanceonnumberfeeding() 
        {
            totalbal = "0";
            con.Open();
            String query1 = "select sum(invoice_balance) as balance from invoice,customer where invoicenum = cus_id and cus_phonenum = '" + txtcusnum.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                if (read[0].ToString() == "")
                {
                    totalbal = "0";
                }
                else
                {
                    totalbal = (read[0].ToString());
                }

            }
            read.Close();

            TBalance.Text = totalbal.ToString();
            con.Close();
        }
       

        private void griddishnamesload()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select dish_name,dish_ratespkg,digh_ratespp from dishdetails", con);
            adapt.Fill(dt);
            dishnamesgrid.DataSource = dt;


            con.Close();
        }

        private void ordergridreset() 
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from orders", con);
            adapt.Fill(dt);
            gridorderitemsdetails.DataSource = dt;
        }

        private void loadcustomerrecordgriddata() 
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select cus_id,cus_status,cus_name,cus_address,invoice_date,cus_phonenum,invoice_value,invoice_adv,invoice_disc,invoice_balance,Costing from customer, invoice where customer.cus_id = invoice.invoicenum order by cus_id desc", con);
            adapt.Fill(dt);
            customerrecordgrid.DataSource = dt;


            con.Close();
        }


        private void cleardataform()
        {
            griddishnamesload();

            cboxquotorder.SelectedIndex = 0;
            txtcusid.Text = "";
            txtcusname.Text = "";
            txtcusnum.Text = "";
            txtcusaddress.Text = "";
            txtcusbill.Text = "0";
            txtboxdiscount.ReadOnly = false;
            searchboxdishname.Text = "";
            orderitemname.Text = "";
            orderdatetime.Value = DateTime.UtcNow;
            orderunittype.SelectedIndex = 0;
            orderqty.Text = "0";
            Rates.Text = "0";
            orderitemamount.Text = "0";
            txtcusbill.ReadOnly = false;
            txtcusname.ReadOnly = false;
            txtcusnum.ReadOnly = false;
            txtadvancebox.Text = "0";
            txtboxdiscount.Text = "0";
            txtbalance.Text = "0";
            sales.Enabled = true;
            
            txtcusbill.ReadOnly = true;
            txtcusnum.Focus();
            TBalance.Text = "0";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void newentrybutton_Click(object sender, EventArgs e)
        {
            cleardataform();
            listclear();
            resetedt();
            loadcustomerrecordgriddata();
        }


        private void getspecificdata()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails where dish_name Like '%" + searchboxdishname.Text + "%'", con);
            adapt.Fill(dt);
            dishnamesgrid.DataSource = dt;
            con.Close();


        }

        private void searchboxdishname_TextChanged(object sender, EventArgs e)
        {

            if (searchboxdishname.Text == "")
            {
                griddishnamesload();
            }
            else
            {
                getspecificdata();
                orderitemname.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void orderitemname_TextChanged(object sender, EventArgs e)
        {
            try
            {

            
            searchboxdishname.Text = "";
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails where dish_name Like '%" + orderitemname.Text + "%'", con);
            adapt.Fill(dt);
            dishnamesgrid.DataSource = dt;
            con.Close();

            }
            catch 
            {

                
            }
        }

        private void dishnamesgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        decimal qty;
        decimal itrates;
        decimal itamount;
             
        private void calculateitemamountvalue()

        {
            try
            {
                qty = Convert.ToDecimal(orderqty.Text);
                itrates = Convert.ToDecimal(Rates.Text);
                itamount = qty * itrates;
                orderitemamount.Text = itamount.ToString();

            }
            catch
            {

            }

        }

        private void orderqty_TextChanged(object sender, EventArgs e)
        {
            if (orderqty.Text == "0")
            {

            }
            else
            {
                calculateitemamountvalue();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewDishName andw = new AddNewDishName();
            andw.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            griddishnamesload();
            txtcusbill.ReadOnly = true;
            
        }



        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderitemname.Text == "")
                {
                    MessageBox.Show("Add Item Please ...");
                }
                else if (cboxquotorder.Text == "")
                {
                    MessageBox.Show("Mention Quotation / Order pls ?");
                }
                else if (orderunittype.Text == "")
                {
                    MessageBox.Show("Select Unit");
                }

                else
                {

                    string[] arr = new string[5];
                    ListViewItem itm;


                    arr[0] = orderitemname.Text.ToString();
                    arr[1] = orderunittype.Text.ToString();
                    arr[2] = Rates.Text.ToString();
                    arr[3] = orderqty.Text.ToString();
                    arr[4] = orderitemamount.Text.ToString();

                    itm = new ListViewItem(arr);
                    orderitemlist.Items.Add(itm);

                    orderitemname.Text = "";
                    Rates.Text = "";
                    orderqty.Text = "";
                    orderitemamount.Text = "";
                    orderitemname.Focus();

                    decimal gtotal = 0;
                    foreach (ListViewItem lstItem in orderitemlist.Items)
                    {
                        gtotal += decimal.Parse(lstItem.SubItems[4].Text);
                    }

                    txtcusbill.Text = Convert.ToString(gtotal);
                }
            }
            catch 
            {
                

            }
        }

        private void dltlistbtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in orderitemlist.SelectedItems)
            {
                string grossvaluetotal = txtcusbill.Text;
                string delint = eachItem.SubItems[4].Text;
                orderitemlist.Items.Remove(eachItem);
                decimal deleteitemfrmlist = Convert.ToDecimal(grossvaluetotal) - Convert.ToDecimal(delint);
                txtcusbill.Text = deleteitemfrmlist.ToString();
            }
        }

        private void listclear() 
        {
            foreach (ListViewItem eachItem in orderitemlist.Items)
            {
                
                orderitemlist.Items.Remove(eachItem);
                
            }
        }

        private void dishnamesgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dishnamesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderitemname.Text = dishnamesgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        
        }

        private void rateschanged() 
        {
            if (orderunittype.Text == "Per Person")
            {
                Rates.Text = dishnamesgrid.SelectedRows[0].Cells[2].Value.ToString();
            }
            else if (orderunittype.Text == "Per KG")
            {
                Rates.Text = dishnamesgrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            else 
            {
                Rates.Text = "0";
            }
        }

        string ooid;
        decimal ooamounttotal;
        int invoicebalancefinal = 0;

        private void sales_Click(object sender, EventArgs e)
        {
            if (txtcusname.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if (txtcusbill.Text == "")
            {
                MessageBox.Show("You had not inserted any item for order");
            }
            
            else if (txtcusnum.Text == "")
            {
                MessageBox.Show("Please Enter Customer Contact Number ?");
            }

            else if (orderitemlist.Items.Count == 0)
            {
                MessageBox.Show("You had not inserted any item for order");
            }


            else
            {
                string prefix = "SCEO";
                con.Open();
                String query = "insert into customer ( cus_name,cus_phonenum,cus_address,cus_totalbill,cus_status,prefix ) values ( '" + txtcusname.Text + "','" + txtcusnum.Text + "','" + txtcusaddress.Text + "'," + txtcusbill.Text.ToString() + ",'" + cboxquotorder.Text + "','"+prefix+"' )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                

                String query1 = "select top 1 cus_id,cus_totalbill from customer order by cus_id desc";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader read = cmd1.ExecuteReader();

                while (read.Read())
                {
                    ooid = (read[0].ToString());
                    ooamounttotal = int.Parse((read[1].ToString()));
                }
                read.Close();

                txtcusid.Text = ooid.ToString();
                txtcusbill.ReadOnly = true;
                txtcusname.ReadOnly = true;
                txtcusnum.ReadOnly = true;
                string sqlFormattedDate = orderdatetime.Value.ToString("yyyy-MMM-dd HH:mm:ss.fff");
                string sqlTimeFormate = Time.Value.ToString("HH:mm");


                for (int i = 0; i < orderitemlist.Items.Count; i++)
                {
                    int val1 = 0;
                    int val2 = 1;
                    int val3 = 2;
                    int val4 = 3;
                    int val5 = 4;

                    String odname = orderitemlist.Items[i].SubItems[val1].Text;
                    String odunit = orderitemlist.Items[i].SubItems[val2].Text;
                    String odrates = orderitemlist.Items[i].SubItems[val3].Text;
                    String odqty = orderitemlist.Items[i].SubItems[val4].Text;
                    String odamount = orderitemlist.Items[i].SubItems[val5].Text;
                    
                    decimal ortblerates = Convert.ToDecimal(odrates);
                    decimal ortbleqty = Convert.ToDecimal(odqty);
                    decimal ortbleamount = Convert.ToDecimal(odamount);

                    String query6 = "insert into Orders ( order_no,order_date,order_itemname,order_itemunittype,order_qty,order_itemrates,order_itemperunitrate,Order_DelTime ) values ( '" + ooid.ToString() + "', '" + sqlFormattedDate + "' ,'" + odname.ToString() + "','" + odunit.ToString() + "'," + ortbleqty + "," + ortblerates + ","+ odamount + ", '"+ sqlTimeFormate + "' )";
                    SqlCommand cmd6 = new SqlCommand(query6, con);
                    cmd6.ExecuteNonQuery();
               
                }

                String query2 = "insert into invoice ( invoicenum,invoice_date,invoice_value,invoice_adv,invoice_disc,invoice_balance ) values ( '" + ooid.ToString() + "' , '" + sqlFormattedDate + "' ," + ooamounttotal + ", " + txtadvancebox.Text + ", " + txtboxdiscount.Text + " , " + txtbalance.Text + " )";
                SqlCommand cmd3 = new SqlCommand(query2, con);
                cmd3.ExecuteNonQuery();

                //////// for insert Customer final Balance Value against Customer Phone Number in Payment log table---- start (Ledger working)

                String query11 = "select SUM(invoice.invoice_balance) as inv_balance from customer inner join invoice on customer.cus_id = invoice.invoicenum where customer.cus_phonenum = '" + txtcusnum.Text + "'  ";
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlDataReader read1 = cmd11.ExecuteReader();

                while (read1.Read())
                {

                    invoicebalancefinal = Convert.ToInt32((read1["inv_balance"].ToString()));

                }
                read1.Close();

                String query12 = "insert into paymentlog ( loginvnum,loginvdate,loginvtotal,logcashrec,logdiscount,logbalance,cusnumber,cusfinalbalance ) values ( '" + ooid.ToString() + "' , '" + sqlFormattedDate + "' ," + ooamounttotal + ", " + txtadvancebox.Text + ", " + txtboxdiscount.Text + " ," + txtbalance.Text + ",'" + txtcusnum.Text + "'," + invoicebalancefinal + "   )";
                SqlCommand cmd13 = new SqlCommand(query12, con);
                cmd13.ExecuteNonQuery();

                MessageBox.Show("Order Had Been Placed Succesfully");

                loadcustomerrecordgriddata();
                listclear();
                con.Close();
                sales.Enabled = false;
                cleardataform();
            }
            
        }

        decimal payamounttxt;
        decimal balanceanswer;

        private void txtcusbill_TextChanged(object sender, EventArgs e)
        {
            getbalanceinvoicetotal();
        }
            

            private void getbalanceinvoicetotal() 
            {
                if (txtcusbill.Text == "0" || txtcusbill.Text == "")
                {

                }
            else if (txtadvancebox.Text == "")
            {

            }

            else if (txtboxdiscount.Text == "")
            {

            }
                else
                {
                    payamounttxt = Convert.ToDecimal(txtadvancebox.Text) + Convert.ToDecimal(txtboxdiscount.Text);
                    balanceanswer = Convert.ToDecimal(txtcusbill.Text) - payamounttxt;
                    txtbalance.Text = balanceanswer.ToString();
                }
            }

        private void txtadvancebox_TextChanged(object sender, EventArgs e)
        {
            getbalanceinvoicetotal();
        }

        private void txtboxdiscount_TextChanged(object sender, EventArgs e)
        {
            getbalanceinvoicetotal();
        }

        private void customerrecordgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                           
                txtcusid.Text = customerrecordgrid.SelectedRows[0].Cells["cus_id"].Value.ToString();
                txtcusnum.Text = customerrecordgrid.SelectedRows[0].Cells["cus_phonenum"].Value.ToString();
                Costing_Form.getorderid = customerrecordgrid.SelectedRows[0].Cells["cus_id"].Value.ToString();


                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
                con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from orders where order_no = '"+txtcusid.Text+"'", con);
            adapt.Fill(dt);
            gridorderitemsdetails.DataSource = dt;


            if (customerrecordgrid.Columns[e.ColumnIndex].HeaderText == "Rec_Balance")
            {
                                      
                
                    Customer_Balance csbl = new Customer_Balance();
                    csbl.Show();
                                  
            }

                else if (customerrecordgrid.Columns[e.ColumnIndex].HeaderText == "Print")
                {
                    ooiddp = txtcusid.Text;
                    P_Invoice invoiceprint = new P_Invoice();
                    invoiceprint.Show();
                    
                }


                else if (customerrecordgrid.Columns[e.ColumnIndex].HeaderText == "Kitchen")
                {
                    ooiddp = txtcusid.Text;
                    Kitchen_Schedule Kitsch = new Kitchen_Schedule();
                    Kitsch.Show();
                    
                }

                else if (customerrecordgrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    updateorderstatus();
                    loadcustomerrecordgriddata();
                    
                }
                else if (customerrecordgrid.Columns[e.ColumnIndex].HeaderText == "Costing")
                {
                    Costing_Form cf = new Costing_Form();
                    cf.Show();

                }

                else
                                
                {

                }

            con.Close();
            }
            catch
            {


            }

        }

        
        private void getspecificdatecuhistory() 
        {
            
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
                con.Open();
                findbalanceonnumberfeeding();

                DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select cus_id,cus_status,cus_name,cus_address,invoice_date,cus_phonenum,invoice_value,invoice_adv,invoice_disc,invoice_balance,Costing from customer, invoice where customer.cus_id = invoice.invoicenum and cus_phonenum = '"+txtcusnum.Text+ "' order by cus_id desc  ", con);
            adapt.Fill(dt);
            customerrecordgrid.DataSource = dt;

                txtcusname.Text = customerrecordgrid.Rows[0].Cells["cus_name"].Value.ToString();
                txtcusaddress.Text = customerrecordgrid.Rows[0].Cells["cus_address"].Value.ToString();
                
                con.Close();
            }
            catch
            {


            }
        }
        

        private void txtcusnum_TextChanged(object sender, EventArgs e)
        {
            if (txtcusnum.Text == "")
            {
                loadcustomerrecordgriddata();
            }
            else
            {
                getspecificdatecuhistory();

                
            }
        }
        private void resetedt() 
        {
            
        }
        decimal invvalfrmdb;
        decimal invdiscdb;
        decimal balupdadvamount;
        decimal balupdadvamountfrmtxtbox;
        decimal balupdfinaladvfigure;
        decimal balfigfrmdb;
        decimal balfigfrmdb11;
        decimal discamountfinal;
        decimal discamountfinalupd;


        private void updatebalancemehtod() 
        {
            

        }

        private void updateorderstatus() 
        {
            if (cboxquotorder.Text == "")
            {
                MessageBox.Show("First please select Update status of this Order");
                cleardataform();
            }
            else
            {
                con.Open();
                string query3 = " update customer set cus_status = '" + cboxquotorder.Text + "'  where cus_id = '" + txtcusid.Text + "' ";
                SqlCommand cmd4 = new SqlCommand(query3, con);
                cmd4.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order Status Succesfully Updated");
                cleardataform();

            }

        }

        private void customerrecordgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void edtbtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete Complete Order From Database", "Messege", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                con.Open();
                string query1 = " delete from Order_Costing where Order_id_ref = '" + txtcusid.Text + "' ";
                string query2 = " delete from Orders where order_no = '" + txtcusid.Text + "' ";
                string query3 = " delete from invoice where invoicenum = '" + txtcusid.Text + "' ";
                string query4 = " delete from customer where cus_id = '" + txtcusid.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd3 = new SqlCommand(query2, con);
                SqlCommand cmd4 = new SqlCommand(query3, con);
                SqlCommand cmd5 = new SqlCommand(query4, con);
                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("Complete Order had been deleted Succesfully ...");
                cleardataform();
                loadcustomerrecordgriddata();
                ordergridreset();
                resetedt();
            }
            else
            {

            }
            
            
        }

        private void orderunittype_SelectedIndexChanged(object sender, EventArgs e)
        {
            rateschanged();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadcustomerrecordgriddata();
        }

        private void Rates_TextChanged(object sender, EventArgs e)
        {
            if (Rates.Text == "0")
            {

            }
            else
            {
                calculateitemamountvalue();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcusnum.Text == "")
            {
                MessageBox.Show("Add Customer Number for Run Statement");
            }
            else
            {
                oocusnum = txtcusnum.Text;
                datestat1 = dateTimePicker1.Value;
                datestat2 = dateTimePicker2.Value;

                Cus_Statment cstmnt = new Cus_Statment();
                cstmnt.Show();
            }
            
            
        }

        private void creditlist_Click(object sender, EventArgs e)
        {
            Credit_list crdlist = new Credit_list();
            crdlist.Show();
        }

        private void compst_Click(object sender, EventArgs e)
        {
            if (txtcusnum.Text != "")
            {
                oocusnum = txtcusnum.Text;
                datestat1 = dateTimePicker1.Value;
                datestat2 = dateTimePicker2.Value;

                if (radioButton1.Checked == true)
                {
                    statementoptions = "complete";
                    Customer_Comp_Statement cmpstmnt = new Customer_Comp_Statement();
                    cmpstmnt.Show();
                }
                else if (radioButton1.Checked == false)
                {
                    datestat1 = dateTimePicker1.Value;
                    datestat2 = dateTimePicker2.Value;
                    
                    statementoptions = "datewise";
                    Customer_Datewise_Statement cstdtwise = new Customer_Datewise_Statement();
                    cstdtwise.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Provide any Customer number for required reort pls !!!");
            }
            
           

            
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monthly_Report mnrpt = new Monthly_Report();
            mnrpt.Show();
        }

        private void adminWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login_form.urole == "administrator")
            {
                admin_window adw = new admin_window();
                adw.Show();
            }
            else
            {
                MessageBox.Show("You Have No Access, Please Contact your administrator !!!");
            }

            
        }

        private void MainSalesForm_Load(object sender, EventArgs e)
        {

            label14.Text = " Login User : " + login_form.uname + " Login Date : " + DateTime.Now + "";
        }

        private void creditDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit_Control crcnt = new Credit_Control();
            crcnt.Show();
        }

        private void orderitemlist_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(orderitemlist.SelectedItems[0].SubItems[2].Text);
            orderitemname.Text = orderitemlist.SelectedItems[0].Text;
            orderunittype.Text = orderitemlist.SelectedItems[0].SubItems[1].Text;
            Rates.Text = orderitemlist.SelectedItems[0].SubItems[2].Text;
            orderqty.Text = orderitemlist.SelectedItems[0].SubItems[3].Text;
            orderitemamount.Text = orderitemlist.SelectedItems[0].SubItems[4].Text;
            orderitemlist.SelectedItems[0].Remove();
            
        }

        private void counterSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Counter_Sales ctrsale = new Counter_Sales();
            ctrsale.Show();
        }
    }





}
