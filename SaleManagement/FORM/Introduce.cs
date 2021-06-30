using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmIntroduce : Form
    {
        private string usernameLogin;
        public FrmIntroduce(string _usernameLogin)
        {
            usernameLogin = _usernameLogin;
            InitializeComponent();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernameLogin);
            frmMainAdmin.Show();
            this.Close();
        }
    }
}
