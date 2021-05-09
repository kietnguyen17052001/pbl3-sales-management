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
    public partial class FrmCreate_NewCustomer : Form
    {
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewCustomer()
        {
            InitializeComponent();
            txtID_CUSTOMER.Text = BLL_CUSTOMER.Instance.GetNewIdCustomer();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblKhachHang KHACHHANG = new tblKhachHang();
            if (string.IsNullOrEmpty(txtID_CUSTOMER.Text) || string.IsNullOrEmpty(txtNAME_CUSTOMER.Text) || string.IsNullOrEmpty(txtPHONE.Text) ||
                string.IsNullOrEmpty(txtADDRESS.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                KHACHHANG.MaKhachHang = txtID_CUSTOMER.Text;
                KHACHHANG.TenKhachHang = txtNAME_CUSTOMER.Text;
                KHACHHANG.SoDienThoai = txtPHONE.Text;
                if (rbMALE.Checked == true)
                {
                    KHACHHANG.GioiTinh = true;
                }
                else
                {
                    KHACHHANG.GioiTinh = false;
                }
                KHACHHANG.DiaChi = txtADDRESS.Text;
                try
                {
                    DB.tblKhachHangs.Add(KHACHHANG);
                    DB.SaveChanges();
                    d(KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã khách hàng bị trùng. Vui lòng nhập mã khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNAME_CUSTOMER_Enter(object sender, EventArgs e)
        {
            if(txtNAME_CUSTOMER.Text == "Nhập tên khách hàng")
            {
                txtNAME_CUSTOMER.Text = "";
                txtNAME_CUSTOMER.ForeColor = Color.Black;
            }
        }
        private void txtNAME_CUSTOMER_Leave(object sender, EventArgs e)
        {
            if (txtNAME_CUSTOMER.Text == "")
            {
                txtNAME_CUSTOMER.Text = "Nhập tên khách hàng";
                txtNAME_CUSTOMER.ForeColor = Color.Silver;
            }
        }

        private void txtPHONE_Enter(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "Nhập SĐT")
            {
                txtPHONE.Text = "";
                txtPHONE.ForeColor = Color.Black;
            }
        }

        private void txtPHONE_Leave(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "")
            {
                txtPHONE.Text = "Nhập SĐT";
                txtPHONE.ForeColor = Color.Silver;
            }
        }

        private void txtADDRESS_Enter(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "Nhập địa chỉ")
            {
                txtADDRESS.Text = "";
                txtADDRESS.ForeColor = Color.Black;
            }
        }

        private void txtADDRESS_Leave(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "")
            {
                txtADDRESS.Text = "Nhập địa chỉ";
                txtADDRESS.ForeColor = Color.Silver;
            }
        }
    }
}
