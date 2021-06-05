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
    public partial class FrmEditQuantity_InvoiceSaleProduct : Form
    {
        public delegate void myDel(int quantity);
        public myDel d { get; set; }
        private string idProduct { get; set; }
        public FrmEditQuantity_InvoiceSaleProduct(string _idProduct)
        {
            InitializeComponent();
            idProduct = _idProduct;
            txtNEWQTY.Text = "1";
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNEWQTY.Text))
            {
                lbQTY.Text = "Bạn chưa nhập số lượng mới!"; 
            }
            else
            {
                if (Convert.ToInt32(txtNEWQTY.Text) > BLL_PRODUCTS.Instance.getQuantityProduct(idProduct))
                {
                    lbQTY.Text = "KHÔNG ĐỦ SL";
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
