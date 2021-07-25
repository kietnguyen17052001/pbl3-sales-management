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
    public partial class FrmEditQuantityProduct_InvoiceSaleProduct : Form
    {
        public delegate void myDel(int quantity);
        public myDel d { get; set; }
        private string idProduct { get; set; }
        public FrmEditQuantityProduct_InvoiceSaleProduct(string _idProduct)
        {
            InitializeComponent();
            idProduct = _idProduct;
            txtNEWQTY.Text = "1";
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNEWQTY.Text))
            {
                lbQTY.Text = "Bạn chưa nhập số lượng mới!"; 
            }
            else
            {
                if (Convert.ToInt32(txtNEWQTY.Text) > BLL_PRODUCT.Instance.getQuantityProductByIdProduct(idProduct) || Convert.ToInt32(txtNEWQTY.Text) == 0)
                {
                    if (Convert.ToInt32(txtNEWQTY.Text) > BLL_PRODUCT.Instance.getQuantityProductByIdProduct(idProduct))
                    {
                        lbQTY.Text = "Không đủ hàng hóa trong kho";
                    }
                    else
                    {
                        lbQTY.Text = "Số lượng nhập phải lớn hơn 0";
                    }
                }
                else
                {
                    d(Convert.ToInt32(txtNEWQTY.Text));
                    this.Close();
                }
            } 
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNEWQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
