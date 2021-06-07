using SaleManagement.FORM;
using SaleManagement.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class FrmMain_Admin : Form
    {
        private string usernameLogin;
        public FrmMain_Admin(string name = null)
        {
            InitializeComponent();
            usernameLogin = name;
            lbWelcome.Text += " " + name;
            lbDate.Text += " " + DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void btnManage_Data_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data();
            frm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            frm.Show();
            this.Close();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic();
            frm.Show();
            this.Close();
        }

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            FrmIntroduce frm = new FrmIntroduce(true);
            frm.Show();
            this.Close();
        }
        private void btnChange_Password_Click(object sender, EventArgs e)
        {
            FrmChange_Password frm = new FrmChange_Password(usernameLogin);
            frm.Show();
        }
    }
}
