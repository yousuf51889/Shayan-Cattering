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
    public partial class Customer_Balance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public Customer_Balance()
        {
            InitializeComponent();
        }

        private void Customer_Balance_Load(object sender, EventArgs e)
        {
            if (Credit_Control.orderforcc == "")
            {
                Ordertxtbox.Text = Costing_Form.getorderid;
            }

            else if (Costing_Form.getorderid == "")
            {
                Ordertxtbox.Text = Credit_Control.orderforcc;
            }

            else
            {
                Ordertxtbox.Text = Costing_Form.getorderid;
            }
                       
            
            loadcompleteorderdata();
            findtotalbalance();
            updatebalancemehtod();
            loadbalanceinvoicesdata();
            voidminusentry();

        }



        private void loadbalanceinvoicesdata() 
        {
            
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select invoice_date,invoicenum,invoice_value,invoice_balance from invoice,customer where invoicenum = cus_id and cus_phonenum = '" + cusnum.Text + "' and invoice_balance > 0 ", con);
            adapt.Fill(dt);
            balanceinvgrid.DataSource = dt;


            con.Close();
        }

        private void voidminusentry() 
        {
            if (balance.Text == "0")
            {
                MessageBox.Show("This Invoice has no Balance");
                this.Close();

            }

            else if (Convert.ToInt32(balance.Text) < 0)
            {
                MessageBox.Show("This Invoice has no Balance");
                this.Close();
            }
        }

        string name = "0";
        string add = "0";
        string ph = "0";

        private void loadcompleteorderdata()
        {
            con.Open();
            String query1 = "select top 1 cus_name,cus_address,cus_phonenum from customer where cus_id = '" + Ordertxtbox.Text + "'  ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                name = read[0].ToString();
                add = read[1].ToString();
                ph = read[2].ToString();

            }
            read.Close();

            cusname.Text = name.ToString();
            cusadd.Text = add.ToString();
            cusnum.Text = ph.ToString();
            con.Close();
        }

        string totalbal = "0";
        private void findtotalbalance()
        {
            con.Open();
            String query1 = "select sum(invoice_balance) as balance from invoice,customer where invoicenum = cus_id and cus_phonenum = '" + cusnum.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                if (read[0].ToString() == "")
                {

                }
                else
                {
                    totalbal = (read[0].ToString());
                }

            }
            read.Close();

            totalbalance.Text = totalbal.ToString();
            con.Close();
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
            try
            {


                balupdfinaladvfigure = 0;
                balfigfrmdb11 = 0;

                con.Open();
                String query1 = "select invoice_value,invoice_adv,invoice_disc,invoice_balance from invoice where invoicenum = '" + Ordertxtbox.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader read = cmd1.ExecuteReader();

                while (read.Read())
                {
                    invvalfrmdb = Convert.ToDecimal((read[0].ToString()));
                    balupdadvamount = Convert.ToDecimal((read[1].ToString()));
                    invdiscdb = Convert.ToDecimal((read[2].ToString()));
                    balfigfrmdb = Convert.ToDecimal((read[3].ToString()));
                }
                read.Close();
                con.Close();

                invvalue.Text = invvalfrmdb.ToString();
                balance.Text = balfigfrmdb.ToString();

                txtpaymode.Text = "";
                txtpaystatus.Text = "";
            }
            catch
            {


            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        Decimal balfigfrmdb123;
        string customernumber = "0";
        int invoicebalancefinal = 0;

        private void updbalance_Click(object sender, EventArgs e)
        {
            string sqlFormattedDate = payrecdate.Value.ToString("yyyy-MMM-dd HH:mm:ss.fff");

            if (txtadvancebox.Text == "")
            {
                MessageBox.Show("Mention Amount for Update Balance");

            }
            else if (txtboxdiscount.Text == "")
            {
                MessageBox.Show("Mention Amount for Update Balance");
            }

            else if (txtadvancebox.Text == "0" && txtboxdiscount.Text == "0")
            {
                MessageBox.Show("You did not provide any value to update Balance");
            }
            else if (txtpaymode.Text == "")
            {
                MessageBox.Show("You did not provide Mode of Payment");
            }

            else if (txtpaystatus.Text == "")
            {
                MessageBox.Show("You did not provide Payment Submit Details");
            }

            else
            {
                balupdadvamountfrmtxtbox = Convert.ToDecimal(txtadvancebox.Text);
                balupdfinaladvfigure = balupdadvamount + balupdadvamountfrmtxtbox;

                discamountfinal = Convert.ToDecimal(txtboxdiscount.Text);
                discamountfinalupd = invdiscdb + discamountfinal;


                balfigfrmdb11 = invvalfrmdb - (balupdfinaladvfigure + discamountfinalupd);

                if (balfigfrmdb11 < 0)
                {
                    MessageBox.Show("Your Enter Amount is Over Ruled on Invoice Value");
                }
                else
                {
                    
                    con.Open();
                    string query2 = " update invoice set invoice_adv = " + balupdfinaladvfigure + " , invoice_disc = " + discamountfinalupd + " ,invoice_balance = " + balfigfrmdb11 + " where invoicenum = '" + Ordertxtbox.Text + "' ";
                    SqlCommand cmd3 = new SqlCommand(query2, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Balance of Subjected Invoice Updated Succesfuly in DataBase");
                    updatebalancemehtod();

                    ////////// for Get Customer Number and Invoice Balance Values

                    String query1 = "select invoice_balance,cus_phonenum from invoice inner join customer on invoicenum=cus_id where invoicenum =  '" + Ordertxtbox.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    SqlDataReader read = cmd1.ExecuteReader();

                    while (read.Read())
                    {

                        balfigfrmdb123 = Convert.ToDecimal((read["invoice_balance"].ToString()));
                        customernumber = (read["cus_phonenum"].ToString());

                    }
                    read.Close();

                    /////// For Get Customer Final Balance Values

                    String query11 = "select SUM(invoice.invoice_balance) as inv_balance from customer inner join invoice on customer.cus_id = invoice.invoicenum where customer.cus_phonenum = '" + cusnum.Text + "'  ";
                    SqlCommand cmd11 = new SqlCommand(query11, con);
                    SqlDataReader read1 = cmd11.ExecuteReader();

                    while (read1.Read())
                    {

                        invoicebalancefinal = Convert.ToInt32((read1["inv_balance"].ToString()));
                        
                    }
                    read1.Close();


                    String query3 = "insert into paymentlog ( loginvnum,loginvdate,loginvtotal,logcashrec,logdiscount,logbalance,cusnumber,cusfinalbalance,logmode,log_pay_status ) values ( '" + Ordertxtbox.Text + "' , '" + sqlFormattedDate + "' ," + invvalfrmdb + ", " + balupdadvamountfrmtxtbox + ", " + discamountfinal + " , " + balfigfrmdb123 + ",'" + customernumber.ToString() + "' , " + invoicebalancefinal + ", '" + txtpaymode.Text + "', '" + txtpaystatus.Text + "'   )";
                    SqlCommand cmd4 = new SqlCommand(query3, con);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                    txtadvancebox.Text = "0";
                    txtboxdiscount.Text = "0";
                    txtpaymode.Text = "";
                    txtpaystatus.Text = "";
                }
                
                
                
            }
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            updatebalancemehtod();
            findtotalbalance();
            loadbalanceinvoicesdata();
            voidminusentry();

            txtadvancebox.Text = "0";
            txtboxdiscount.Text = "0";
        }

                
        private void balanceamountupdateinrecbalform() 
        {
            try
            {

                int varpaid = Convert.ToInt32(txtadvancebox.Text); ;
                int vardisc = Convert.ToInt32(txtboxdiscount.Text); ;
                int varbal1 = Convert.ToInt32(balance.Text);
                                                

                    varbal1 = varbal1 - (vardisc + varpaid);

                    balance.Text = varbal1.ToString();
                
            }
            catch
            {

            }
        }


        private void txtadvancebox_TextChanged(object sender, EventArgs e)
        {
                       
                          
            if (txtadvancebox.Text == "" || txtadvancebox.Text == "0")
            {
                
                updatebalancemehtod();
                
            }
            else
            {
                updatebalancemehtod();
                balanceamountupdateinrecbalform();
            }
            
        }

        private void txtboxdiscount_TextChanged(object sender, EventArgs e)
        {
            
            if (txtboxdiscount.Text == "" || txtboxdiscount.Text == "0")
                {
                    updatebalancemehtod();
                }
                else
                {
                updatebalancemehtod();
                balanceamountupdateinrecbalform();
                }
                
        }

              

        private void txtpaymode_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtpaystatus.Items.Clear();

            string[] arr1 = new string[3];
            
            arr1[0] = "Submit to Waseem Hassan";
            arr1[1] = "Submit to Closing Sheet";
            arr1[2] = "Submit to Bank Account";


            string[] arr11 = new string[1];

            arr11[0] = "Reference Number of Online : ";
            
            string[] arr12 = new string[1];

            arr12[0] = "Cheque Details : ";
            

            if (txtpaymode.Text == "Cash")
            {
                
                txtpaystatus.Items.AddRange(arr1);
                
            }

            if (txtpaymode.Text == "Online in Bank")
            {

                txtpaystatus.Items.AddRange(arr11);

            }

            if (txtpaymode.Text == "Cheque")
            {

                txtpaystatus.Items.AddRange(arr12);

            }


        }
    }
}
