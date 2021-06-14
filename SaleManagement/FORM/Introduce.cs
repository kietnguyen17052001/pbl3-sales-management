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
        private bool isAdmin;
        private string usernameLogin;
        public FrmIntroduce(bool _isAdmin, string _usernameLogin)
        {
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            InitializeComponent();
        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frm = new FrmMain_Admin(usernameLogin);
                frm.Show();
            }
            else
            {
                FrmMain_Member frm = new FrmMain_Member(usernameLogin);
                frm.Show();
            }
            this.Close();
        }
    }
}
