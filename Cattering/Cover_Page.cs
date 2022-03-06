using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattering
{
    public partial class Cover_Page : Form
    {
        public Cover_Page()
        {
            InitializeComponent();
        }

        private void Cover_Page_Load(object sender, EventArgs e)
        {

        }

        private void kitchenSalesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainSalesForm msff = new MainSalesForm();
            msff.Show();
        }

        private void counterSalesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Counter_Sales csfrm = new Counter_Sales();
            csfrm.Show();
        }

        private void adminFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void creditReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit_Control cctrl = new Credit_Control();
            cctrl.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment_Vouchers pcv = new Payment_Vouchers();
            pcv.Show();
        }

        private void addVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnew_vendor adon = new addnew_vendor();
            adon.Show();
        }
    }
}
