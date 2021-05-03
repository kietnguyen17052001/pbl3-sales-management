using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.VIEW
{
    public partial class FrmManage_Suppliers : Form
    {
        public FrmManage_Suppliers()
        {
            InitializeComponent();
        }

        private void txtNAME_SUPPLIER_Enter(object sender, EventArgs e)
        {
            if(txtNAME_SUPPLIER.Text == "Nhập tên nhà cung cấp")
            {
                txtNAME_SUPPLIER.Text = "";
                txtNAME_SUPPLIER.ForeColor = Color.Black;
            }
        }

        private void txtNAME_SUPPLIER_Leave(object sender, EventArgs e)
        {
            if (txtNAME_SUPPLIER.Text == "")
            {
                txtNAME_SUPPLIER.Text = "Nhập tên nhà cung cấp";
                txtNAME_SUPPLIER.ForeColor = Color.Silver;
            }
        }

        private void txtPHONE_Enter(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "Nhập SĐT")
            {
                txtPHONE.Text = "";
                txtPHONE.ForeColor = Color.Black;
            }
        }

        private void txtPHONE_Leave(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "")
            {
                txtPHONE.Text = "Nhập SĐT";
                txtPHONE.ForeColor = Color.Silver;
            }
        }

        private void txtADDRESS_Enter(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "Nhập địa chỉ nhà cung cấp")
            {
                txtADDRESS.Text = "";
                txtADDRESS.ForeColor = Color.Black;
            }
        }

        private void txtADDRESS_Leave(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "")
            {
                txtADDRESS.Text = "Nhập địa chỉ nhà cung cấp";
                txtADDRESS.ForeColor = Color.Silver;
            }
        }

        private void txtEMAIL_Enter(object sender, EventArgs e)
        {
            if (txtEMAIL.Text == "Nhập email")
            {
                txtEMAIL.Text = "";
                txtEMAIL.ForeColor = Color.Black;
            }
        }

        private void txtEMAIL_Leave(object sender, EventArgs e)
        {
            if (txtEMAIL.Text == "")
            {
                txtEMAIL.Text = "Nhập email";
                txtEMAIL.ForeColor = Color.Silver;
            }
        }

        private void txtFAX_Enter(object sender, EventArgs e)
        {
            if (txtFAX.Text == "Nhập fax")
            {
                txtFAX.Text = "";
                txtFAX.ForeColor = Color.Black;
            }
        }

        private void txtFAX_Leave(object sender, EventArgs e)
        {
            if (txtFAX.Text == "")
            {
                txtFAX.Text = "Nhập fax";
                txtFAX.ForeColor = Color.Silver;
            }
        }

        private void txtID_TAX_Enter(object sender, EventArgs e)
        {
            if (txtID_TAX.Text == "Nhập mã số thuế")
            {
                txtID_TAX.Text = "";
                txtID_TAX.ForeColor = Color.Black;
            }
        }

        private void txtID_TAX_Leave(object sender, EventArgs e)
        {
            if (txtID_TAX.Text == "")
            {
                txtID_TAX.Text = "Nhập mã số thuế";
                txtID_TAX.ForeColor = Color.Silver;
            }
        }
    }
}
