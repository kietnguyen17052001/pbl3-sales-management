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
    public partial class FrmEdit_Quantity : Form
    {
        public delegate void myDEL(int quantity);
        public myDEL d { get; set; }
        public string idProduct { get; set; }
        public FrmEdit_Quantity(string _idProduct, string nameProduct, int quantity)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            InitializeComponent();
            txtPRODUCT.Text = nameProduct;
            txtQUANTITY.Text = quantity.ToString();
            idProduct = _idProduct;
            var product = DB.tblHangHoas.Find(idProduct);
            lbQUANTITY.Text = product.SoLuong.ToString();
            txtPRODUCT.Enabled = false;
            txtQUANTITY.Enabled = false;
            txtNEW_QUANTITY.Text = "1";
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (string.IsNullOrEmpty(txtNEW_QUANTITY.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int oldQty = Convert.ToInt32(txtQUANTITY.Text);
                int newQty = Convert.ToInt32(txtNEW_QUANTITY.Text);
                var product = DB.tblHangHoas.Find(idProduct);
                if (newQty > product.SoLuong)
                {
                    lbSTATUS.Text = "KHÔNG ĐỦ SL";
                }
                else
                {
                    product.SoLuong = product.SoLuong + oldQty - newQty;
                    DB.SaveChanges();
                    d(newQty);
                    this.Close();
                }
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNEW_QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
