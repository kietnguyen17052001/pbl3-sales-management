using SaleManagement.BLL;
using SaleManagement.Entity;
using SaleManagement.VIEW;
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
    public partial class FrmCreate_NewTypeItem : Form
    {
        public delegate void myDEL(string VALUE, string TEXT);
        public myDEL d { get; set; }
        public FrmCreate_NewTypeItem()
        {
            InitializeComponent();
        }
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblLoaiHangHoa typeOfProduct = new tblLoaiHangHoa();
            if(string.IsNullOrEmpty(txtIdTypeOfProduct.Text) || string.IsNullOrEmpty(txtNameTypeOfProduct.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                typeOfProduct.MaLoaiHangHoa = txtIdTypeOfProduct.Text;
                typeOfProduct.TenLoaiHangHoa = txtNameTypeOfProduct.Text;
                try
                {
                    BLL_TYPEOFPRODUCT.Instance.FuncAddNewProduct(typeOfProduct);
                    d(typeOfProduct.MaLoaiHangHoa, typeOfProduct.TenLoaiHangHoa);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số bị trùng. Vui lòng nhập mã khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
