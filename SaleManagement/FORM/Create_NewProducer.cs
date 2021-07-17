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
    public partial class FrmCreate_NewProducer : Form
    {
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewProducer()
        {
            InitializeComponent();
            txtID_PRODUCER.Text = BLL_PRODUCER.Instance.getNewIDProducer();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaSanXuat producer = new tblNhaSanXuat();
            producer.MaNhaSanXuat = txtID_PRODUCER.Text.Trim();
            producer.TenNhaSanXuat = txtNAME_PRODUCER.Text.Trim();
            producer.DiaChi = txtADDRESS.Text.Trim();
            if (String.IsNullOrEmpty(producer.TenNhaSanXuat))
            {
                MessageBox.Show("Tên nhà sản xuất trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL_PRODUCER.Instance.FuncAddProducer(producer);
                d(producer.MaNhaSanXuat, producer.TenNhaSanXuat);
                MessageBox.Show("Thêm nhà sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
