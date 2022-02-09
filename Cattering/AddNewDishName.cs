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
    public partial class AddNewDishName : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public AddNewDishName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dishname.Focus();
            if (dishname.Text == "")
            {
                MessageBox.Show("Please Enter Dish / Item Name");
            }
            else if (perkgrates.Text == "")
            {
                MessageBox.Show("Please Enter Rates per KG");
            }
            else if (perpersonrates.Text == "")
            {
                MessageBox.Show("Please Enter Rates Per Person");
            }
            else
            {
                con.Open();
                String query3 = "insert into dishdetails (dish_name, dish_ratespkg , digh_ratespp, foodcatagory) values ('" + dishname.Text + "' , " + perkgrates.Text + ",'" + perpersonrates.Text + "', '" + txtfoodcat.Text + "')";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Dish / Item Saved Succesfully");


                dishname.Focus();
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails", con);
                adapt.Fill(dt);
                dishnamesgrid.DataSource = dt;
                con.Close();
                cleardata();
            }
            
        }

        private void AddNewDishName_Load(object sender, EventArgs e)
        {
            
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails", con);
            adapt.Fill(dt);
            dishnamesgrid.DataSource = dt;
            con.Close();

            dishname.Focus();
        }

        private void AddNewDishName_Activated(object sender, EventArgs e)
        {
            dishname.Focus();
        }

        private void dishname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails where dish_name Like '%" + dishname.Text + "%'", con);
                adapt.Fill(dt);
                dishnamesgrid.DataSource = dt;
                con.Close();
            }
            catch 
            {

                
            }
            
        }

        private void cleardata() 
        {
            dishname.Text = "";
            perkgrates.Text = "";
            perpersonrates.Text = "";
            txtfoodcat.Text = "";
            dishname.ReadOnly = false;
        }

        private void editdishnamebtn_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (dishname.Text == "")
            {
                MessageBox.Show("Please Enter Dish / Item Name");
            }
            else if (perkgrates.Text == "")
            {
                MessageBox.Show("Please Enter Rates per KG");
            }
            else if (perpersonrates.Text == "")
            {
                MessageBox.Show("Please Enter Rates Per Person");
            }
            else
            {
                con.Open();
                String query3 = "update dishdetails set dish_name = '"+dishname.Text+"', dish_ratespkg = '"+perkgrates.Text+"', digh_ratespp = '"+perpersonrates.Text+ "', foodcatagory = '" + txtfoodcat.Text + "'  where dish_name = '" + dishname.Text + "' ";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Rates Updated Succesfully");


                dishname.Focus();
                
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails", con);
                adapt.Fill(dt);
                dishnamesgrid.DataSource = dt;
                con.Close();
                cleardata();
            }
            }
            catch
            {


            }
        }

        private void dishnamesgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            cleardata();
            button1.Enabled = true;
            dishname.Focus();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from dishdetails", con);
            adapt.Fill(dt);
            dishnamesgrid.DataSource = dt;
            con.Close();
            cleardata();
        }

        private void dishnamesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;
            dishname.Text = dishnamesgrid.SelectedRows[0].Cells[0].Value.ToString();
            perkgrates.Text = dishnamesgrid.SelectedRows[0].Cells[1].Value.ToString();
            perpersonrates.Text = dishnamesgrid.SelectedRows[0].Cells[2].Value.ToString();
            txtfoodcat.Text = dishnamesgrid.SelectedRows[0].Cells[4].Value.ToString();
            dishname.ReadOnly = true;
        }
    }
}
