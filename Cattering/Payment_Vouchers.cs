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
    public partial class Payment_Vouchers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");


        public Payment_Vouchers()
        {
            InitializeComponent();
        }

        private void Payment_Vouchers_Load(object sender, EventArgs e)
        {
            loadgriddataexp();
            loadvendorsnamesexpense();
            todayexpensesfigure();
            loadheadofaccountexpense();

            if (ename.Text == "" && eamount.Text == "" && paidtovendor.Text == "")
            {

                loadgriddataexp();
            }

            else
            {
                button1.Enabled = true;

            }

            button3.Enabled = false;

        }


        int creditvalue = 0;
        int paymentvalue = 0;
        int Balance = 0;

        string exp_id = "1";
        string expenseamountpcv = "1";
        string expdetailspcv = "1";
        string preparedby = "1";
        string exppaidto = "1";
        string exptransnature = "1";
        string exphof = "1";
        string expdate;


        int showtotalamount = 0;
        private void todayexpensesfigure()
        {

            con.Open();

            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd 00:00");

            string sqlFormattedDate1 = DateTime.Now.ToString("yyyy-MM-dd 23:59");

            String query4 = "select SUM(amount) as exp_amount from expense where date_of_entry between '" + sqlFormattedDate + "' and + '" + sqlFormattedDate1 + "' ";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            SqlDataReader read = cmd4.ExecuteReader();

            while (read.Read())
            {
                if ((read["exp_amount"]).ToString() == "")
                {
                    showtotalamount = 0;
                }
                else
                {
                    showtotalamount = int.Parse(read["exp_amount"].ToString());
                }

            }

            read.Close();
            con.Close();
            todayexpenses.Text = showtotalamount.ToString();

        }


        private void addvenbtn_Click(object sender, EventArgs e)
        {
            addnew_vendor adnnew = new addnew_vendor();
            adnnew.Show();
        }

        private void loadheadofaccountexpense()
        {
            try
            {

                hof.Items.Clear();

                con.Open();

                String query4 = "select hof_name from HOF  ";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlDataReader read = cmd4.ExecuteReader();

                while (read.Read())
                {

                    hof.Items.Add(read["hof_name"]);

                }

                read.Close();
                con.Close();

            }
            catch
            {


            }
        }


        private void getspecificdata()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt1 = new SqlDataAdapter("select * from expense where paid_to = '" + paidtovendor.Text + "'", con);
                adapt1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (ename.Text == "" && eamount.Text == "")
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }

            e_id.Text = "";
            ename.Text = "";
            eamount.Text = "";
            trnature.Text = "";
            vensearchbox.Text = "";
            hof.Text = "";
            paidtovendor.Text = "";
            trnature.Focus();
            button1.Enabled = true;
            vbalance.Text = "0";
            textBox1.Text = "0";
            specifichofforexpense();
            loadgriddataexp();
            dateTimePicker2.Value = DateTime.Now;
            loadheadofaccountexpense();
            loadvendorsnamesexpense();



            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select vendor_name, phone from Vendor", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }


        private void specifichofforexpense()
        {
            con.Open();

            if (hof.Text != "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapt1 = new SqlDataAdapter(" select hof_name from HOF where hof_name like '%" + hof.Text + "%' ", con);
                adapt1.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapt1 = new SqlDataAdapter(" select hof_name from HOF ", con);
                adapt1.Fill(dt);
                dataGridView3.DataSource = dt;
            }



            con.Close();


        }

        private void loadvendorsnamesexpense()
        {
            try
            {

                paidtovendor.Items.Clear();
                con.Open();
                String query4 = "select vendor_name from Vendor  ";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlDataReader read = cmd4.ExecuteReader();

                while (read.Read())
                {

                    paidtovendor.Items.Add(read["vendor_name"]);

                }

                read.Close();
                con.Close();
            }
            catch
            {


            }


        }

        private void loadgriddataexp()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter("select * from expense order by id desc", con);
            adapt1.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void hof_TextChanged(object sender, EventArgs e)
        {
            specifichofforexpense();
        }

        private void vensearchbox_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select vendor_name, phone from Vendor where vendor_name like '%" + vensearchbox.Text + "%'", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void paidtovendor_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (paidtovendor.Text == "")
                {
                    loadgriddataexp();
                }
                else
                {
                    getspecificdata();

                    con.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("select vendor_name, phone from Vendor where vendor_name like '%" + paidtovendor.Text + "%'", con);
                    adapt.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();

                }
            }
            catch
            {
            }
        }

        private void creditvaluegetmthod()
        {
            string query = "select sum(amount) from expense where paid_to = '" + paidtovendor.Text + "' and trans_nature = 'Credit'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                if ((read[0]).ToString() == "")
                {
                    creditvalue = 0;
                }
                else
                {
                    creditvalue = int.Parse((read[0]).ToString());
                }

            }
            read.Close();
            con.Close();
        }

        private void paymentvaluegetmethod()
        {
            string query1 = "select sum(amount) from expense where paid_to = '" + paidtovendor.Text + "' and trans_nature in ('Payment','Bank','Discount')";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                if ((read1[0]).ToString() == "")
                {
                    paymentvalue = 0;
                }
                else
                {
                    paymentvalue = int.Parse((read1[0]).ToString());
                }

            }
            read1.Close();
            con.Close();

        }





        private void showbalancemethod()
        {
            try
            {

                vbalance.Text = "0";

                Balance = 0;
                creditvaluegetmthod();
                paymentvaluegetmethod();

                Balance = creditvalue - paymentvalue;

                vbalance.Text = Balance.ToString();
                
                Balance = 0;
                creditvalue = 0;
                paymentvalue = 0;

            }
            catch
            {


            }
        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                paidtovendor.Text = dataGridView2.SelectedRows[0].Cells["vendor_name"].Value.ToString();
                textBox1.Text = dataGridView2.SelectedRows[0].Cells["phone"].Value.ToString();

            }
            catch
            {


            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hof.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            paidtovendor.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ename.Text == "")
            {

            }

            else if (eamount.Text == "")
            {

            }

            else
            {
                string branch = "POS";
                button1.Enabled = true;

                con.Open();

                string sqlFormattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string prefix = "SCEV";
                String query3 = "insert into expense (expense, amount , username ,date_of_entry,paid_to,trans_nature,account_head,branch_name,prefix) values ('" + ename.Text + "' , " + eamount.Text + ",'" + login_form.uname.ToString() + "','" + sqlFormattedDate + "','" + paidtovendor.Text + "','" + trnature.Text + "','" + hof.Text + "','" + branch + "','" + prefix.ToString() + "')";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Expense Save");


                String query4 = "select top 1 id,expense,amount,username,paid_to,trans_nature,account_head,PCV_No,date_of_entry from expense order by id desc";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlDataReader read = cmd4.ExecuteReader();

                while (read.Read())
                {
                    expdetailspcv = (read[1].ToString());
                    expenseamountpcv = (read[2].ToString());
                    preparedby = (read[3].ToString());
                    exppaidto = (read[4].ToString());
                    exptransnature = (read[5].ToString());
                    exphof = (read[6].ToString());
                    exp_id = (read[7].ToString());
                    expdate = (read[8].ToString());
                    
                }
                e_id.Text = exp_id.ToString();
                eamount.Text = expenseamountpcv.ToString();
                ename.Text = expdetailspcv.ToString();

                read.Close();
                con.Close();
                button1.Enabled = false;
                button3.Enabled = true;
                showbalancemethod();

                con.Open();
                String query1 = "update expense set Balance = '" + vbalance.Text + "' where PCV_No = '" + e_id.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
                loadgriddataexp();
                todayexpensesfigure();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.shayan_catt_logoo;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 15, 15, 150, 150);


            e.Graphics.DrawString("SHAYAN CATTERERS", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(150, 55));
            e.Graphics.DrawString(" Payment Voucher ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 92));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------ ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 107));

            e.Graphics.DrawString("PCV NUMBER = " + exp_id.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("Date = " + expdate, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(495, 160));
            e.Graphics.DrawString(exphof.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 180));
            e.Graphics.DrawString(exptransnature.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(635, 180));
            e.Graphics.DrawString("Paid TO = " + exppaidto.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 200));
            e.Graphics.DrawString("Balance = " + vbalance.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 220));
            e.Graphics.DrawString("Expense Details", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 260));
            e.Graphics.DrawString(expdetailspcv.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 280));
            e.Graphics.DrawString("PCV Amount = " + expenseamountpcv.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 355));
            e.Graphics.DrawString(preparedby.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, 425));
            e.Graphics.DrawString("_________________        ______________________         ___________________ ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 435));
            e.Graphics.DrawString("      Prepared By                                    Approved By                                           Received by  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(100, 455));
        }



        private void showbalance_Click(object sender, EventArgs e)
        {
            showbalancemethod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            //    if (printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            //    {
            //        printDocument1.Print();
            //    }
                
                printDocument1.Print();

                button1.Enabled = true;
                e_id.Text = "";
                ename.Text = "";
                vensearchbox.Text = "";
                eamount.Text = "";
                trnature.Text = "";
                hof.Text = "";
                paidtovendor.Text = "";

                ename.Focus();
                button3.Enabled = false;
            }
            catch
            {


            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
