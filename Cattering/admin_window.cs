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
    public partial class admin_window : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True");
        public static int vargstvalue;
        public static int vardiscountvalue;

        
        public admin_window()
        {
            InitializeComponent();
            txtgst.Text = vargstvalue.ToString();
            txtdisc.Text = vardiscountvalue.ToString();
        }

        private void admin_window_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from logins", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "insert into logins ( username,upassword,userrole ) values ( '" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "' )";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Had been Created Succesfully");
        }
    }
}
