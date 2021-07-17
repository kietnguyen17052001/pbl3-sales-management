using SaleManagement.BLL;
using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmCreate_NewProduct : Form
    {
        public delegate void myDel(string nameProduct);
        public myDel d { get; set; }
        public FrmCreate_NewProduct()
        {
            InitializeComponent();
            setCombobox();
        }
        public void setCombobox()
        {
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_PRODUCT.Instance.getCBBTypeProduct().ToArray());
            cbbPRODUCERs.Items.AddRange(BLL_PRODUCER.Instance.getCbbProducer().ToArray());
            cbbTYPE_OF_PRODUCT.SelectedIndex = cbbPRODUCERs.SelectedIndex = 0;
        }
        string imageLocation = "";
        byte[] images = null;
        // add pic for product
        private void btnADDPIC_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbIMAGE.ImageLocation = imageLocation;
                    FileStream fStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bReader = new BinaryReader(fStream);
                    images = bReader.ReadBytes((int)fStream.Length);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm ảnh thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblHangHoa product = new tblHangHoa();
            product.MaHangHoa = txtID_PRODUCT.Text.Trim();
            product.TenHangHoa = txtNAME_PRODUCT.Text.Trim();
            product.SoLuong = Convert.ToInt32(txtQUANTITY.Text);
            product.GiaBan = Convert.ToDouble(txtSALE.Text);
            product.GiaNhap = Convert.ToDouble(txtBUY.Text);
            product.MoTa = txtDESCRIBE.Text;
            product.MaLoaiHangHoa = ((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE;
            product.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
            if (String.IsNullOrEmpty(product.TenHangHoa))
            {
                MessageBox.Show("Tên hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                product.HinhAnh = images;
                BLL_PRODUCT.Instance.FuncAddNewProduct(product); // add new product
                MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTYPE_OF_PRODUCT_TextChanged(object sender, EventArgs e)
        {
            txtID_PRODUCT.Text = BLL_PRODUCT.Instance.getNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
        }
        public void NewTypeProduct(string id, string name)
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        public void NewProducer(string id, string name)
        {
            cbbPRODUCERs.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        // Call frmCreateNewTypeProduct
        private void btnADDTYPE_Click(object sender, EventArgs e)
        {
            FrmCreate_NewTypeItem frmCreateNewTypeOfProduct = new FrmCreate_NewTypeItem();
            frmCreateNewTypeOfProduct.d += new FrmCreate_NewTypeItem.myDEL(NewTypeProduct);
            frmCreateNewTypeOfProduct.Show();
        }
        //Call frmCreateNewSupplier
        private void btnADDPRODUCER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProducer frmCreateNewProducer = new FrmCreate_NewProducer();
            frmCreateNewProducer.d += new FrmCreate_NewProducer.myDEL(NewProducer);
            frmCreateNewProducer.Show();
        }

        private void txtSALE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQUANTITY_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBUY.Text))
            {
                txtBUY.Text = "0";
            }
            if (String.IsNullOrEmpty(txtSALE.Text))
            {
                txtSALE.Text = "0";
            }
        }
    }
}
