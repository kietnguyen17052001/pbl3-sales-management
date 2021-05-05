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
        public FrmEdit_Quantity(string nameProduct, int quantity)
        {
            InitializeComponent();
            txtPRODUCT.Text = nameProduct;
            txtQUANTITY.Text = quantity.ToString();
            txtPRODUCT.Enabled = false;
            txtQUANTITY.Enabled = false;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            d(Convert.ToInt32(txtNEW_QUANTITY.Text));
            this.Close();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNEW_QUANTITY_Enter(object sender, EventArgs e)
        {
            if (txtNEW_QUANTITY.Text == "Nhập số lượng mới")
            {
                txtNEW_QUANTITY.Text = "";
                txtNEW_QUANTITY.ForeColor = Color.Black;
            }
        }

        private void txtNEW_QUANTITY_Leave(object sender, EventArgs e)
        {
            if (txtNEW_QUANTITY.Text == "")
            {
                txtNEW_QUANTITY.Text = "Nhập số lượng mới";
                txtNEW_QUANTITY.ForeColor = Color.Silver;
            }
        }
    }
}
