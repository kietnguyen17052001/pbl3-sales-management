using SaleManagement.BLL;
using SaleManagement.Entity;
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
    public partial class FrmLogin : Form
    {
        //private string idAccount;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tblTaiKhoan user = BLL_ACCOUNT.Instance.getUser(txtUSER.Text.Trim());
            if (user == null)
            {
                lbINFO.Text = "Kiểm tra lại tài khoản và mật khẩu";
                txtPASSWORD.Clear();
            }
            else
            {
                if (user.ChucVu == "Admin")
                {
                    if (user.MatKhau == txtPASSWORD.Text.Trim())
                    {
                        FrmMain_Admin frmMainAdmin = new FrmMain_Admin(txtUSER.Text.Trim());
                        frmMainAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbINFO.Text = "Kiểm tra lại tài khoản và mật khẩu";
                        txtPASSWORD.Clear();
                    }
                }
                else if (user.ChucVu == "Member")
                {
                    if (user.MatKhau == txtPASSWORD.Text.Trim())
                    {
                        FrmMain_Member frmMainMember = new FrmMain_Member(txtUSER.Text.Trim());
                        frmMainMember.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbINFO.Text = "Kiểm tra lại tài khoản và mật khẩu";
                        txtPASSWORD.Clear();
                    }
                }
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
                txtPASSWORD.Text = "Nhập mật khẩu";
                txtPASSWORD.PasswordChar = '\0';
                txtPASSWORD.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
