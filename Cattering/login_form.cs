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
    public partial class login_form : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static string uname;
        public static string upass;
        public static string urole;



        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query1 = "select * from logins where username = '" + textBox1.Text + "' and upassword = '" + textBox2.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader read = cmd1.ExecuteReader();

                while (read.Read())
                {
                    if (read.HasRows)
                    {
                        uname = (read["username"].ToString());
                        urole = (read["userrole"].ToString());
                    }

                }
                read.Close();
                
                
                MainSalesForm msf = new MainSalesForm();
                msf.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please Check Username OR Password");
            }
                        
            con.Close();
                
            
            
        }
    }
}
