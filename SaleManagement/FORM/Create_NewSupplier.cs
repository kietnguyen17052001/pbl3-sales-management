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
    public partial class FrmCreate_NewSupplier : Form
    {
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewSupplier()
        {
            InitializeComponent();
            txtID_SUPPLIER.Text = BLL_SUPPLIER.Instance.getNewIdSupplier();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaCungCap supplier = new tblNhaCungCap();
            supplier.MaNhaCungCap = txtID_SUPPLIER.Text.Trim();
            supplier.TenNhaCungCap = txtNAME_SUPPLIER.Text.Trim();
            supplier.DiaChi = txtADDRESS.Text.Trim();
            supplier.SoDienThoai = txtPHONE.Text.Trim();
            supplier.Email = txtEMAIL.Text.Trim();
            supplier.Fax = txtFAX.Text.Trim();
            supplier.MaSoThue = txtCODE.Text.Trim();
            if (String.IsNullOrEmpty(supplier.TenNhaCungCap))
            {
                MessageBox.Show("Tên nhà cung cấp trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL_SUPPLIER.Instance.FuncAddNewSupplier(supplier); // add new supplier
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
