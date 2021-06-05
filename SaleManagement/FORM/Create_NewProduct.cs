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
        public delegate void myDel(String nameProduct);
        public myDel d { get; set; }
        public FrmCreate_NewProduct()
        {
            InitializeComponent();
            setCbbTypeProduct();
        }
        public void setCbbTypeProduct()
        {
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_PRODUCTS.Instance.getCBBTypeProduct().ToArray());
            cbbPRODUCERs.Items.AddRange(BLL_PRODUCER.Instance.getCbbProducer().ToArray());
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
            product.MaHangHoa = txtID_PRODUCT.Text;
            product.TenHangHoa = txtNAME_PRODUCT.Text;
            product.SoLuong = Convert.ToInt32(txtQUANTITY.Text);
            product.GiaBan = Convert.ToDouble(txtSALE.Text);
            product.GiaNhap = Convert.ToDouble(txtBUY.Text);
            product.MoTa = txtDESCRIBE.Text;
            product.MaLoaiHangHoa = ((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE;
            product.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
            if (string.IsNullOrEmpty(txtID_PRODUCT.Text) || string.IsNullOrEmpty(txtNAME_PRODUCT.Text) || string.IsNullOrEmpty(txtQUANTITY.Text) ||
                string.IsNullOrEmpty(txtBUY.Text) || string.IsNullOrEmpty(txtSALE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    product.HinhAnh = images;
                    BLL_PRODUCTS.Instance.FuncAddNewProduct(product); // add new product
                    MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    d(product.TenHangHoa);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số hàng hóa bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTYPE_OF_PRODUCT_TextChanged(object sender, EventArgs e)
        {
            txtID_PRODUCT.Text = BLL_PRODUCTS.Instance.getNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
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
            FrmCreate_NewTypeItem frm = new FrmCreate_NewTypeItem();
            frm.d += new FrmCreate_NewTypeItem.myDEL(NewTypeProduct);
            frm.Show();
        }
        //Call frmCreateNewSupplier
        private void btnADDPRODUCER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProducer frm = new FrmCreate_NewProducer();
            frm.d += new FrmCreate_NewProducer.myDEL(NewProducer);
            frm.Show();
        }
    }
}
