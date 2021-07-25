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
    public partial class FrmDiscount_Percent : Form
    {
        public delegate void myDEL(string DISCOUNT);
        public myDEL d { get; set; }
        public FrmDiscount_Percent()
        {
            InitializeComponent();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            d(txtDISCOUNT.Text);
            this.Close();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtDISCOUNT_Enter(object sender, EventArgs e)
        {
            if (txtDISCOUNT.Text == "Nhập %")
            {
                txtDISCOUNT.Text = "";
                txtDISCOUNT.ForeColor = Color.Black;
            }
        }

        private void txtDISCOUNT_Leave(object sender, EventArgs e)
        {
            if (txtDISCOUNT.Text == "")
            {
                txtDISCOUNT.Text = "Nhập %";
                txtDISCOUNT.ForeColor = Color.Silver;
            }
        }

        private void txtDISCOUNT_TextChanged(object sender, EventArgs e)
        {
            if(txtDISCOUNT.Text == "")
            {
                txtDISCOUNT.Text = "0";
            }
            if(Convert.ToInt32(txtDISCOUNT.Text) > 100)
            {
                txtDISCOUNT.Text = (Convert.ToInt32(txtDISCOUNT.Text) / 10).ToString();
            }
        }

        private void txtDISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
