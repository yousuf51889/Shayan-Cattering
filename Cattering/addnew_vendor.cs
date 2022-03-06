using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cattering
{
    public partial class addnew_vendor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");


        public addnew_vendor()
        {
            InitializeComponent();
        }

        private void addnewvendor_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                loadvndordata();
            }

            else
            {

            }

        }


        private void loadvndordata()
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select vendor_id , vendor_name , phone from Vendor", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


              

        private void loadspecificdata()
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select vendor_id , vendor_name , phone from Vendor where vendor_name like '%" + textBox1.Text + "%'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
                

        private void resetformaddvendor()
        {
            textBox1.Text = "";
            textBox2.Text = "0";
        }

        

        int venid;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadspecificdata();
        }

        private void addnewvendorbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");


            if (textBox1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select vendor_id , vendor_name , phone from Vendor where vendor_name = '" + textBox1.Text + "'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count <= 0)
                {
                    String query3 = "insert into Vendor (vendor_name ,  phone) values ('" + textBox1.Text + "' , ' " + textBox2.Text + "')";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("New Vendor Inserted");

                    con.Close();

                    resetformaddvendor();
                    loadvndordata();
                }
                else
                {
                    MessageBox.Show("Vendor Name Already Exist");
                }
            }
            else
            {
                MessageBox.Show("Please add New Venor Name");

            }
        }

        private void addmobnum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please Select Vendor Name for Update his Number");
            }
            else
            {
                con.Open();
                string query1 = "update vendor set vendor_name = '" + textBox1.Text + "', phone = '" + textBox2.Text + "' where vendor_id = " + venid + " ";

                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("DETAILS UPDATED");
                con.Close();
                loadvndordata();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            venid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["vendor_id"].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["vendor_name"].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
        }
    }
}
