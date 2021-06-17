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
    public partial class FrmCreate_NewSupplier : Form
    {
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewSupplier()
        {
            InitializeComponent();
            txtID_SUPPLIER.Text = BLL_SUPPLIER.Instance.getNewIdSupplier();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaCungCap supplier = new tblNhaCungCap();
            if(string.IsNullOrEmpty(txtID_SUPPLIER.Text) || string.IsNullOrEmpty(txtNAME_SUPPLIER.Text) || string.IsNullOrEmpty(txtADDRESS.Text) ||
                string.IsNullOrEmpty(txtPHONE.Text) || string.IsNullOrEmpty(txtEMAIL.Text) || string.IsNullOrEmpty(txtFAX.Text) ||
                string.IsNullOrEmpty(txtCODE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                supplier.MaNhaCungCap = txtID_SUPPLIER.Text;
                supplier.TenNhaCungCap = txtNAME_SUPPLIER.Text;
                supplier.DiaChi = txtADDRESS.Text;
                supplier.Email = txtEMAIL.Text;
                supplier.Fax = txtFAX.Text;
                supplier.SoDienThoai = txtPHONE.Text;
                supplier.MaSoThue = Convert.ToInt32(txtCODE.Text);
                try
                {
                    BLL_SUPPLIER.Instance.FuncAddNewSupplier(supplier);
                    d(supplier.MaNhaCungCap, supplier.TenNhaCungCap);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số bị trùng. Vui lòng nhập mã khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
