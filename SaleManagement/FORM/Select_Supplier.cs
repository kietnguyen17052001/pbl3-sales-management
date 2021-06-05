﻿using SaleManagement.BLL;
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
    public partial class FrmSelect_Supplier : Form
    {
        public delegate void myDel(string idSupplier, string nameSupplier);
        public myDel d { get; set; }
        public FrmSelect_Supplier()
        {
            InitializeComponent();
            BLL_SUPPLIER.Instance.ShowData(dgvSUPPLIER);
            Disable(false);
            // Set style
            dgvSUPPLIER.EnableHeadersVisualStyles = false;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 8, FontStyle.Bold);
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HeaderText
            dgvSUPPLIER.Columns[0].HeaderText = "Mã NCC";
            dgvSUPPLIER.Columns[1].HeaderText = "Tên NCC";
            dgvSUPPLIER.Columns[2].HeaderText = "Địa chỉ";
            dgvSUPPLIER.Columns[3].HeaderText = "Email";
            dgvSUPPLIER.Columns[4].HeaderText = "Fax";
            dgvSUPPLIER.Columns[5].HeaderText = "SĐT";
            dgvSUPPLIER.Columns[6].HeaderText = "Mã số thuế";
        }
        public void Disable(bool E)
        {
            txtID_SUPPLIER.Enabled = txtNAME_SUPPLIER.Enabled = txtPHONE.Enabled = txtADDRESS.Enabled = txtID_TAX.Enabled = txtFAX.Enabled = txtEMAIL.Enabled = E;
            btnADD.Enabled = !E;
            btnSAVE.Enabled = E;
        }
        // DGV
        private void dgvSUPPLIER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_SUPPLIER.Text = dgvSUPPLIER.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
            txtNAME_SUPPLIER.Text = dgvSUPPLIER.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString();
            txtADDRESS.Text = dgvSUPPLIER.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtEMAIL.Text = dgvSUPPLIER.SelectedRows[0].Cells["Email"].Value.ToString();
            txtPHONE.Text = dgvSUPPLIER.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtFAX.Text = dgvSUPPLIER.SelectedRows[0].Cells["Fax"].Value.ToString();
            txtID_TAX.Text = dgvSUPPLIER.SelectedRows[0].Cells["MaSoThue"].Value.ToString();
        }
        private void dgvSUPPLIER_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSUPPLIER.DefaultCellStyle.BackColor = Color.OldLace;
            dgvSUPPLIER.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // Search Supplier
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_SUPPLIER.Instance.FuncSearchSupplier(dgvSUPPLIER ,txtSEARCH.Text.Trim());
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập tên hoặc mã nhà cung cấp")
            {
                txtSEARCH.ForeColor = Color.Black;
                txtSEARCH.Text = "";
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.ForeColor = Color.Silver;
                txtSEARCH.Text = "Nhập tên hoặc mã nhà cung cấp";
            }
        }
        // Add new supplier
        private void btnADD_Click(object sender, EventArgs e)
        {
            Disable(true);
            txtID_SUPPLIER.Text = BLL_SUPPLIER.Instance.GetNewIdSupplier();
            txtNAME_SUPPLIER.Clear();
            txtPHONE.Clear();
            txtEMAIL.Clear();
            txtFAX.Clear();
            txtADDRESS.Clear();
            txtID_TAX.Clear();
        }
        // Save change
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaCungCap supplier = new tblNhaCungCap();
            if (string.IsNullOrEmpty(txtNAME_SUPPLIER.Text) || string.IsNullOrEmpty(txtADDRESS.Text) || string.IsNullOrEmpty(txtPHONE.Text) ||
                string.IsNullOrEmpty(txtEMAIL.Text) || string.IsNullOrEmpty(txtFAX.Text) || string.IsNullOrEmpty(txtID_TAX.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable(true);
            }
            else
            {
                supplier.MaNhaCungCap = txtID_SUPPLIER.Text;
                supplier.TenNhaCungCap = txtNAME_SUPPLIER.Text;
                supplier.DiaChi = txtADDRESS.Text;
                supplier.SoDienThoai = txtPHONE.Text;
                supplier.Email = txtEMAIL.Text;
                supplier.Fax = txtFAX.Text;
                supplier.MaSoThue = Convert.ToInt32(txtID_TAX.Text);
                try
                {
                    BLL_SUPPLIER.Instance.FuncAddNewSupplier(supplier); // add new supplier
                    MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số nhà cung cấp bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Disable(true);
                }
            }
        }
        // Select supplier
        private void btnSELECT_Click(object sender, EventArgs e)
        {
            d(txtID_SUPPLIER.Text, txtNAME_SUPPLIER.Text);
            this.Close();
        }      
    }
}