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
            typeOfProduct.MaLoaiHangHoa = txtIdTypeOfProduct.Text.Trim();
            typeOfProduct.TenLoaiHangHoa = txtNameTypeOfProduct.Text.Trim();
            if (String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) || !String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Mã loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) || String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Tên loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) || String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Mã và tên loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    BLL_TYPEOFPRODUCT.Instance.FuncAddNewProduct(typeOfProduct);
                    MessageBox.Show("Thêm loại hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số loại hàng hóa đã tồn tại", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
