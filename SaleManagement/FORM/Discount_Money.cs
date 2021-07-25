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
    public partial class FrmDiscount_Money : Form
    {
        public delegate void myDEL(double discount);
        public myDEL d { get; set; }
        private double totalMoney;
        public FrmDiscount_Money(double _totalMoney)
        {
            InitializeComponent();
            totalMoney = _totalMoney;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            d(Convert.ToDouble(txtDISCOUNT.Text));
            this.Close();
        }
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDISCOUNT_Enter(object sender, EventArgs e)
        {
            if(txtDISCOUNT.Text == "Nhập số tiền")
            {
                txtDISCOUNT.Text = "";
                txtDISCOUNT.ForeColor = Color.Black;
            }
        }

        private void txtDISCOUNT_Leave(object sender, EventArgs e)
        {
            if (txtDISCOUNT.Text == "")
            {
                txtDISCOUNT.Text = "Nhập số tiền";
                txtDISCOUNT.ForeColor = Color.Silver;
            }
        }

        private void txtDISCOUNT_TextChanged(object sender, EventArgs e)
        {
            if (txtDISCOUNT.Text == "")
            {
                txtDISCOUNT.Text = "0";
            }
            if (Convert.ToDouble(txtDISCOUNT.Text) > totalMoney)
            {
                txtDISCOUNT.Text = totalMoney.ToString();
            }
        }
        // keypress event
        private void txtDISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
