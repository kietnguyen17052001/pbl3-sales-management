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
    public partial class FrmEditQty_CreateInvoice : Form
    {
        public delegate void myDEL(int quantity);
        public myDEL d { get; set; }
        public string idProduct { get; set; }
        public FrmEditQty_CreateInvoice(string _idProduct)
        {
            InitializeComponent();
            idProduct = _idProduct;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var product = DB.tblHangHoas.Find(idProduct);
            if (Convert.ToInt32(txtNEWQTY.Text) > product.SoLuong)
            {
                lbQTY.Text = "KHÔNG ĐỦ SL";
            }
            else
            {
                d(Convert.ToInt32(txtNEWQTY.Text));
                this.Close();
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
