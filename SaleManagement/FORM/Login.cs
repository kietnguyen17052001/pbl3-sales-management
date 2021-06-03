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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var admin = DB.tblTaiKhoans.Find(txtUSER.Text);
            if(string.IsNullOrEmpty(txtUSER.Text) || admin == null)
            {
                lbINFO.ForeColor = Color.IndianRed;
                lbINFO.Text = "Tên tài khoản không hợp lệ";
            }
            else
            {
                if (admin.MatKhau == txtPASSWORD.Text)
                {
                    lbINFO.ForeColor = Color.SteelBlue;
                    lbINFO.Text = "Đăng nhập thành công";
                    FrmSale_Management frm = new FrmSale_Management(txtUSER.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lbINFO.ForeColor = Color.IndianRed;
                    lbINFO.Text = "Sai mật khẩu. Đăng nhập thất bại";
                }
            }
        }

        private void btnSTAFF_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var staff = DB.tblTaiKhoans.Find(txtUSER.Text);
            if (staff.MatKhau == txtPASSWORD.Text)
            {
                lbINFO.ForeColor = Color.SteelBlue;
                lbINFO.Text = "Đăng nhập thành công";
                FrmSale_Management frm = new FrmSale_Management();
                frm.SetStaff();
                frm.Show();
                this.Hide();
            }
            else
            {
                lbINFO.ForeColor = Color.IndianRed;
                lbINFO.Text = "Sai mật khẩu. Đăng nhập thất bại";
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
                txtPASSWORD.PasswordChar = '*';
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
    }
}
