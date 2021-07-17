﻿using SaleManagement.BLL;
using SaleManagement.Entity;
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

namespace SaleManagement.FORM
{
    public partial class FrmSelect_Customer : Form
    {
        public delegate void myDEL(string idCus, string nameCus);
        public myDEL d { get; set; }
        public FrmSelect_Customer()
        {
            InitializeComponent();
            LoadData();
            rbMALE.Checked = true;
            FormatColumnHeaders();
        }
        // Format Column header
        public void FormatColumnHeaders()
        {
            // Set style
            dgvLISTCUSTOMER.EnableHeadersVisualStyles = false;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 8, FontStyle.Bold);
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HeaderText
            dgvLISTCUSTOMER.Columns[0].HeaderText = "Mã k.hàng";
            dgvLISTCUSTOMER.Columns[1].HeaderText = "Tên k.hàng";
            dgvLISTCUSTOMER.Columns[2].HeaderText = "Giới tính";
            dgvLISTCUSTOMER.Columns[3].HeaderText = "SĐT";
            dgvLISTCUSTOMER.Columns[4].HeaderText = "Địa chỉ";
        }
        public void Disable(bool E)
        {
            txtNAME_CUSTOMER.Enabled = txtPHONE.Enabled = txtADDRESS.Enabled = E;
            btnADD.Enabled = !E;
            btnSAVE.Enabled = E;
            dgvLISTCUSTOMER.Enabled = !E;
        }
        // Hiển thị thông tin các khách hàng
        public void LoadData()
        {
            Disable(false);
            BLL_CUSTOMER.Instance.LoadData(dgvLISTCUSTOMER);
        }
        // Set backColor for row in dgvListCustomer
        private void dgvLISTCUSTOMER_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLISTCUSTOMER.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLISTCUSTOMER.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // load lại dgv
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Thêm khách hàng mới
        private void btnADD_Click(object sender, EventArgs e)
        {
            Disable(true);
            txtNAME_CUSTOMER.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
            txtID_CUSTOMER.Text = BLL_CUSTOMER.Instance.getNewIdCustomer();
        }
        // Lưu khách hàng vừa thêm 
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblKhachHang customer = new tblKhachHang();
            customer.MaKhachHang = txtID_CUSTOMER.Text.Trim();
            customer.TenKhachHang = txtNAME_CUSTOMER.Text.Trim();
            customer.DiaChi = txtADDRESS.Text.Trim();
            customer.SoDienThoai = txtPHONE.Text.Trim();
            customer.GioiTinh = rbMALE.Checked;
            if (String.IsNullOrEmpty(customer.TenKhachHang))
            {
                MessageBox.Show("Tên khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else
            {
                BLL_CUSTOMER.Instance.FuncAddNewCustomer(customer);
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        // Chọn khách hàng cần thêm vào hóa đơn
        private void btnSELECT_Click(object sender, EventArgs e)
        {
            d(txtID_CUSTOMER.Text, txtNAME_CUSTOMER.Text);
            this.Close();
        }
        private void dgvLISTCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_CUSTOMER.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            txtNAME_CUSTOMER.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["TenKhachHang"].Value.ToString();
            txtPHONE.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtADDRESS.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            if (Convert.ToBoolean(dgvLISTCUSTOMER.SelectedRows[0].Cells["GioiTinh"].Value) == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        // search customer
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_CUSTOMER.Instance.FuncSearchCustomer(dgvLISTCUSTOMER, txtSEARCH.Text.Trim());
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên khách hàng")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }

        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên khách hàng";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
    }
}
