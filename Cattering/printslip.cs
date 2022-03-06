using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalReport = Microsoft.Reporting.WebForms.LocalReport;
using Report = Microsoft.Reporting.WebForms.Report;
using Warning = Microsoft.Reporting.WebForms.Warning;

namespace Cattering
{
    public partial class printslip : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-661JC43\SQLEXPRESS;Initial Catalog=cattering;Integrated Security=True;");

        public printslip()
        {
            InitializeComponent();
        }

        private void printslip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet8.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet8.DataTable2, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.DataSet8.invoice, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.Orders' table. You can move, or remove it, as needed.
            this.OrdersTableAdapter.Fill(this.DataSet8.Orders, Counter_Sales.orderidcounter.ToString());
            // TODO: This line of code loads data into the 'DataSet8.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet8.DataTable1, Counter_Sales.orderidcounter.ToString());

            this.reportViewer1.RefreshReport();
            dataforkitchenslipprint();
            printDocument1.Print();

        }

               


        private void dataforkitchenslipprint()
        {
            //con.Open();
            //String query4 = "select Orders.order_no,customer.cus_name,Orders.order_date,Orders.order_itemname,order_qty from Orders inner join customer on Orders.order_no=customer.cus_id where Orders.order_no = '" + Counter_Sales.orderidcounter.ToString() + "' ";
            //SqlCommand cmd4 = new SqlCommand(query4, con);
            //SqlDataReader read = cmd4.ExecuteReader();

            //while (read.Read())
            //{
            //    expdetailspcv = (read[1].ToString());
            //    expenseamountpcv = (read[2].ToString());
            //    preparedby = (read[3].ToString());
            //    exppaidto = (read[4].ToString());
            //    exptransnature = (read[5].ToString());
            //    exphof = (read[6].ToString());
            //    exp_id = (read[7].ToString());
            //    expdate = (read[8].ToString());
            //    pcvnoforbenform = (read[7].ToString());
            //    pcvamountbenform = (read[2].ToString());

            //}

            //read.Close();
            //con.Close();
        }


        string orderno = Counter_Sales.orderidcounter.ToString();
        string customername;
        string orderdate;
        string itemname;
        int itemqty;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
                        
            con.Open();
            String query4 = "select Orders.order_no,customer.cus_name,Orders.order_date,Orders.order_itemname,order_qty from Orders inner join customer on Orders.order_no=customer.cus_id where Orders.order_no = '" + Counter_Sales.orderidcounter.ToString() + "' ";
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
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 85));

            e.Graphics.DrawString(customername.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, 95));
            e.Graphics.DrawString(orderdate, new Font("Arial", 10), Brushes.Black, new Point(25, 115));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 125));
            e.Graphics.DrawString("Item Name", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 135));
            e.Graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(250, oldmargin + 135));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, oldmargin + 145));
            //e.Graphics.DrawString(itemname.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, 155));
            //e.Graphics.DrawString(itemqty.ToString(), new Font("Arial", 10), Brushes.Black, new Point(250, 155));

            int margin = read.VisibleFieldCount;
            int margline = 155;
            
            for (int i = 0; i < margin; i++)
            {
                                    
                e.Graphics.DrawString(itemname.ToString(), new Font("Arial", 10), Brushes.Black, new Point(25, margline));
                e.Graphics.DrawString(itemqty.ToString(), new Font("Arial", 10), Brushes.Black, new Point(250, margline));
                margline = margline + 20;
                             
                                
            }





            read.Close();
            con.Close();

        }
            









        }

    }

