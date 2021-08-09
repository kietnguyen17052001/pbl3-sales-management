using SaleManagement.BLL;
using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmLogin : Form
    {
        //private string idAccount;
        public FrmLogin(string usernameLogin)
        {
            InitializeComponent();
            txtUSER.ForeColor = Color.Black;
            txtUSER.Text = usernameLogin;
        }
        // Login application
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLL_ACCOUNT.Instance.isLoginSuccessful(txtUSER.Text.Trim(), txtPASSWORD.Text.Trim()))
            {
                if (BLL_ACCOUNT.Instance.isAdmin(txtUSER.Text.Trim()))
                {
                    FrmMain_Admin frmMainAdmin = new FrmMain_Admin(txtUSER.Text.Trim());
                    frmMainAdmin.Show();
                }
                else
                {
                    FrmMain_Member frmMainMember = new FrmMain_Member(txtUSER.Text.Trim());
                    frmMainMember.Show();
                }
                this.Hide();
            }
            else
            {
                lbINFO.Text = "Kiểm tra lại tài khoản và mật khẩu";
                txtPASSWORD.Clear();
            }
        }
        private void txtUSER_Enter(object sender, EventArgs e)
        {
            if (txtUSER.Text == "Nhập tài khoản")
            {
                txtUSER.Text = "";
                txtUSER.ForeColor = Color.Black;
            }
        }

        private void txtUSER_Leave(object sender, EventArgs e)
        {
            if (txtUSER.Text == "")
            {
                txtUSER.Text = "Nhập tài khoản";
                txtUSER.ForeColor = Color.Silver;
            }
        }

        private void txtPASSWORD_Enter(object sender, EventArgs e)
        {
            if (txtPASSWORD.Text == "Nhập mật khẩu")
            {
                txtPASSWORD.Text = "";
                txtPASSWORD.PasswordChar = '•';
                txtPASSWORD.ForeColor = Color.Black;
            }
        }

        private void txtPASSWORD_Leave(object sender, EventArgs e)
        {
            if (txtPASSWORD.Text == "")
            {
                txtPASSWORD.PasswordChar = '\0';
                txtPASSWORD.Text = "Nhập mật khẩu";
                txtPASSWORD.ForeColor = Color.Silver;
            }
        }
        private void lbForgot_Click(object sender, EventArgs e)
        {
            if (BLL_ACCOUNT.Instance.checkUsername(txtUSER.Text.Trim()))
            {
                FrmForgotPassword frmForgotPassword = new FrmForgotPassword(txtUSER.Text.Trim());
                frmForgotPassword.Show();
            }
            else
            {
                lbINFO.Text = "Tên đăng nhập không tồn tại!";
            }
        }
        // Exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
