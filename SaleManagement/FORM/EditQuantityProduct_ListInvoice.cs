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
        private string idInvoice, idProduct;
        private int newQuantity;
        private bool isListSale;
        public delegate void myDel(string _idInvoice);
        public myDel d { get; set; }
        public FrmEditQuantityProduct_ListInvoice(string _idInvoice, string _idProduct, string nameProduct, int oldQuantity, bool _isListSale)
        {
            InitializeComponent();
            isListSale = _isListSale;
            idInvoice = _idInvoice;
            txtNameProduct.Text = nameProduct;
            txtOldQuantity.Text = oldQuantity.ToString();
            idProduct = _idProduct;
            txtQuantity.Text = BLL_PRODUCT.Instance.getQuantityProductByIdProduct(idProduct).ToString();
            txtNewQuantity.Text = "1";
        }
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            newQuantity = Convert.ToInt32(txtNewQuantity.Text);
            if (isListSale)
            {
                if (newQuantity > BLL_PRODUCT.Instance.getQuantityProductByIdProduct(idProduct) && newQuantity != Convert.ToInt32(txtOldQuantity.Text))
                {
                    lbSTATUS.Text = "Không đủ số lượng hàng hóa";
                }
                else
                {
                    BLL_LISTSALEINVOICE.Instance.ChangeQuantityProduct(idInvoice, idProduct, Convert.ToInt32(txtOldQuantity.Text), newQuantity);
                    d(idInvoice);
                    this.Close();
                }
            }
            else
            {
                BLL_LISTIMPORTINVOICE.Instance.ChangeQuantityProduct(idInvoice, idProduct, Convert.ToInt32(txtOldQuantity.Text), newQuantity);
                d(idInvoice);
                this.Close();
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
            if (String.IsNullOrEmpty(txtNewQuantity.Text))
            {
                txtNewQuantity.Text = "1";
            }
        }
    }
}
