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
    public partial class FrmEditQuantityProduct_ListInvoice : Form
    {
        public delegate void myDEL(int quantity);
        public myDEL d { get; set; }
        private string idProduct;
        private int newQuantity;
        private bool isListSale;
        public FrmEditQuantityProduct_ListInvoice(string _idProduct, string nameProduct, int quantity, bool _isListSale)
        {
            InitializeComponent();
            isListSale = _isListSale;
            txtPRODUCT.Text = nameProduct;
            txtQUANTITY.Text = quantity.ToString();
            idProduct = _idProduct;
            lbQUANTITY.Text = BLL_PRODUCTS.Instance.getQuantityProductByIdProduct(idProduct).ToString();
            txtPRODUCT.Enabled = false;
            txtQUANTITY.Enabled = false;
            txtNEW_QUANTITY.Text = "1";
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNEW_QUANTITY.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newQuantity= Convert.ToInt32(txtNEW_QUANTITY.Text);
                if(isListSale == true)
                {
                    if (newQuantity > BLL_PRODUCTS.Instance.getQuantityProductByIdProduct(idProduct))
                    {
                        lbSTATUS.Text = "KHÔNG ĐỦ SL";
                    }
                    else
                    {
                        d(newQuantity);
                        this.Close();
                    }
                }
                else
                {
                    d(newQuantity);
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

        private void txtNEW_QUANTITY_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNEW_QUANTITY.Text))
            {
                txtNEW_QUANTITY.Text = "1";
            }
        }
    }
}
