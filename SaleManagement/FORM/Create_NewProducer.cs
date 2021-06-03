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
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewProducer()
        {
            InitializeComponent();
            txtID_PRODUCER.Text = BLL_PRODUCER.Instance.getNewIDProduct();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaSanXuat PRODUCER = new tblNhaSanXuat();
            if(string.IsNullOrEmpty(txtID_PRODUCER.Text) || string.IsNullOrEmpty(txtNAME_PRODUCER.Text) || string.IsNullOrEmpty(txtADDRESS.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PRODUCER.MaNhaSanXuat = txtID_PRODUCER.Text;
                PRODUCER.TenNhaSanXuat = txtNAME_PRODUCER.Text;
                PRODUCER.DiaChi = txtADDRESS.Text;
                try {
                    DB.tblNhaSanXuats.Add(PRODUCER);
                    DB.SaveChanges();
                    d(PRODUCER.MaNhaSanXuat, PRODUCER.TenNhaSanXuat);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số bị trùng. Vui lòng nhập mã khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
