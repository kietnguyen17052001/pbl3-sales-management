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
            txtID_SUPPLIER.Text = BLL_SUPPLIER.Instance.getNEWID_SUPPLIER();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblNhaCungCap SUPPLIER = new tblNhaCungCap();
            if(string.IsNullOrEmpty(txtID_SUPPLIER.Text) || string.IsNullOrEmpty(txtNAME_SUPPLIER.Text) || string.IsNullOrEmpty(txtADDRESS.Text) ||
                string.IsNullOrEmpty(txtPHONE.Text) || string.IsNullOrEmpty(txtEMAIL.Text) || string.IsNullOrEmpty(txtFAX.Text) ||
                string.IsNullOrEmpty(txtCODE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SUPPLIER.MaNhaCungCap = txtID_SUPPLIER.Text;
                SUPPLIER.TenNhaCungCap = txtNAME_SUPPLIER.Text;
                SUPPLIER.DiaChi = txtADDRESS.Text;
                SUPPLIER.Email = txtEMAIL.Text;
                SUPPLIER.Fax = txtFAX.Text;
                SUPPLIER.SoDienThoai = txtPHONE.Text;
                SUPPLIER.MaSoThue = Convert.ToInt32(txtCODE.Text);
                try
                {
                    DB.tblNhaCungCaps.Add(SUPPLIER);
                    DB.SaveChanges();
                    d(SUPPLIER.MaNhaCungCap, SUPPLIER.TenNhaCungCap);
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
