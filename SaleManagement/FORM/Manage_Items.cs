using SaleManagement.BLL;
using SaleManagement.Entity;
using SaleManagement.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SaleManagement.VIEW
{
    public partial class FrmManage_Items : Form
    {
        bool isAdd;
        public FrmManage_Items()
        {
            InitializeComponent();
            setCBB();
            ShowProduct();
            disable(false);
            rbID_ITEM.Checked = true;
        }
        public void setCBB()
        {
            cbbTYPE_OF__PRODUCT_DETAIL.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả" });
            cbbTYPE_OF__PRODUCT_DETAIL.Items.AddRange(BLL_ITEMS.Instance.GetCBBTypeProduct().ToArray());
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_ITEMS.Instance.GetCBBTypeProduct().ToArray());
            cbbSUPPLIERs.Items.AddRange(BLL_ITEMS.Instance.GetCBBSupplier().ToArray());
            cbbPRODUCERs.Items.AddRange(BLL_ITEMS.Instance.GetCBBProducer().ToArray());
            cbbTYPE_OF__PRODUCT_DETAIL.SelectedIndex = 0;
        }
        void disable(bool E)
        {
            txtID_PRODUCT.Enabled = E;
            txtNAME_PRODUCT.Enabled = E;
            txtQUANTITY.Enabled = E;
            txtBUY.Enabled = E;
            txtSALE.Enabled = E;
            txtDESCRIBE.Enabled = E;
            cbbTYPE_OF_PRODUCT.Enabled = E;
            cbbPRODUCERs.Enabled = E;
            cbbSUPPLIERs.Enabled = E;
            btnADDPIC.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void ShowProduct()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string id_TypeOfProduct = ((CBBItem)cbbTYPE_OF__PRODUCT_DETAIL.SelectedItem).VALUE;
            if (cbbTYPE_OF__PRODUCT_DETAIL.SelectedIndex == 0)
            {
                var ITEMS = DB.tblHangHoas.Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.tblLoaiHangHoa.TenLoaiHangHoa,
                    p.tblNhaCungCap.TenNhaCungCap,
                    p.tblNhaSanXuat.TenNhaSanXuat,
                    p.GiaNhap,
                    p.GiaBan,
                    p.MoTa
                });
                dgvLISTITEMS.DataSource = ITEMS.ToList();
            }
            else
            {
                var ITEMS = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == id_TypeOfProduct).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.tblLoaiHangHoa.TenLoaiHangHoa,
                    p.tblNhaCungCap.TenNhaCungCap,
                    p.tblNhaSanXuat.TenNhaSanXuat,
                    p.GiaNhap,
                    p.GiaBan,
                    p.MoTa
                });
                dgvLISTITEMS.DataSource = ITEMS.ToList();
            }
            txtID_PRODUCT.Clear();
            txtNAME_PRODUCT.Clear();
            txtBUY.Clear();
            txtSALE.Clear();
            txtQUANTITY.Clear();
            txtDESCRIBE.Clear();
            pbIMAGE.Image = null;
        }
        public void addTYPEITEM(string ID, string NAME)
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        public void addSUPPLIER(string ID, string NAME)
        {
            cbbSUPPLIERs.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        public void addPRODUCER(string ID, string NAME)
        {
            cbbPRODUCERs.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListProduct";
            for (int i = 1; i <= dgvLISTITEMS.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLISTITEMS.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLISTITEMS.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLISTITEMS.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLISTITEMS.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Product";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            isAdd = true;
            disable(true);
            cbbPRODUCERs.SelectedIndex = cbbSUPPLIERs.SelectedIndex = cbbTYPE_OF_PRODUCT.SelectedIndex = 0;
            txtID_PRODUCT.Text = BLL_ITEMS.Instance.GetNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
            txtNAME_PRODUCT.Clear();
            txtQUANTITY.Clear();
            txtBUY.Clear();
            txtSALE.Clear();
            txtDESCRIBE.Clear();
            pbIMAGE.Image = null;
        }
        private void btnADDTYPE_Click(object sender, EventArgs e)
        {
            FrmCreate_NewTypeItem FRM = new FrmCreate_NewTypeItem();
            FRM.d += new FrmCreate_NewTypeItem.myDEL(addTYPEITEM);
            FRM.Show();
        }

        private void btnADDSUPPLIER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewSupplier FRM = new FrmCreate_NewSupplier();
            FRM.d += new FrmCreate_NewSupplier.myDEL(addSUPPLIER);
            FRM.Show();
        }

        private void btnADDPRODUCER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProducer FRM = new FrmCreate_NewProducer();
            FRM.d += new FrmCreate_NewProducer.myDEL(addPRODUCER);
            FRM.Show();
        }
        // thêm hình ảnh cho hàng hóa
        string imageLocation = "";
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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm ảnh thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            isAdd = false;
            disable(true);
            txtID_PRODUCT.Enabled = false;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream fStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(fStream);
            images = bReader.ReadBytes((int)fStream.Length);
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblHangHoa HANGHOA = new tblHangHoa();
            HANGHOA.MaHangHoa = txtID_PRODUCT.Text;
            HANGHOA.TenHangHoa = txtNAME_PRODUCT.Text;
            HANGHOA.SoLuong = Convert.ToInt32(txtQUANTITY.Text);
            HANGHOA.GiaBan = Convert.ToDouble(txtSALE.Text);
            HANGHOA.GiaNhap = Convert.ToDouble(txtBUY.Text);
            HANGHOA.MoTa = txtDESCRIBE.Text;
            HANGHOA.MaLoaiHangHoa = ((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE;
            HANGHOA.MaNhaCungCap = ((CBBItem)cbbSUPPLIERs.SelectedItem).VALUE;
            HANGHOA.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
            HANGHOA.HinhAnh = images;
            if (string.IsNullOrEmpty(txtID_PRODUCT.Text)|| string.IsNullOrEmpty(txtNAME_PRODUCT.Text) || string.IsNullOrEmpty(txtQUANTITY.Text) ||
                string.IsNullOrEmpty(txtBUY.Text) || string.IsNullOrEmpty(txtSALE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        DB.tblHangHoas.Add(HANGHOA);
                        DB.SaveChanges();
                        MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        ShowProduct();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số hàng hóa bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    var GETITEM = DB.tblHangHoas.Find(HANGHOA.MaHangHoa);
                    GETITEM.TenHangHoa = HANGHOA.TenHangHoa;
                    GETITEM.SoLuong = HANGHOA.SoLuong;
                    GETITEM.GiaBan = HANGHOA.GiaBan;
                    GETITEM.GiaNhap = HANGHOA.GiaNhap;
                    GETITEM.MaLoaiHangHoa = HANGHOA.MaLoaiHangHoa;
                    GETITEM.MaNhaCungCap = HANGHOA.MaNhaCungCap;
                    GETITEM.MaNhaSanXuat = HANGHOA.MaNhaSanXuat;
                    GETITEM.HinhAnh = HANGHOA.HinhAnh;
                    DB.SaveChanges();
                    MessageBox.Show("Sửa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable(false);
                    ShowProduct();
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> LIST_ID_ITEMS = new List<string>();
            DataGridViewSelectedRowCollection DATA = dgvLISTITEMS.SelectedRows;
            foreach (DataGridViewRow data in DATA)
            {
                LIST_ID_ITEMS.Add(data.Cells["MaHangHoa"].Value.ToString());
            }
            foreach (string i in LIST_ID_ITEMS)
            {
                foreach (tblHangHoa HANGHOA in DB.tblHangHoas)
                {
                    if (HANGHOA.MaHangHoa == i)
                    {
                        DB.tblHangHoas.Remove(HANGHOA);
                        MessageBox.Show("Xóa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                DB.SaveChanges();
            }
            ShowProduct();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            disable(false);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                FrmManage_Data FRM = new FrmManage_Data();
                FRM.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if(rbID_ITEM.Checked == true)
            {
                var GETITEMs = DB.tblHangHoas.Where(p => p.MaHangHoa.Contains(txtSEARCH.Text)).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.tblLoaiHangHoa.TenLoaiHangHoa,
                    p.tblNhaCungCap.TenNhaCungCap,
                    p.tblNhaSanXuat.TenNhaSanXuat,
                    p.GiaNhap,
                    p.GiaBan,
                });
                dgvLISTITEMS.DataSource = GETITEMs.ToList();
            }
            else
            {
                var GETITEMs = DB.tblHangHoas.Where(p => p.TenHangHoa.Contains(txtSEARCH.Text)).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.tblLoaiHangHoa.TenLoaiHangHoa,
                    p.tblNhaCungCap.TenNhaCungCap,
                    p.tblNhaSanXuat.TenNhaSanXuat,
                    p.GiaNhap,
                    p.GiaBan,
                });
                dgvLISTITEMS.DataSource = GETITEMs.ToList();
            }
        }
        public Image ByteArrayToImage(byte[] byArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void dgvLISTITEMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string ID_ITEM = dgvLISTITEMS.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            txtID_PRODUCT.Text = ID_ITEM;
            var HANGHOA = DB.tblHangHoas.Find(ID_ITEM);
            txtNAME_PRODUCT.Text = HANGHOA.TenHangHoa;
            txtQUANTITY.Text = HANGHOA.SoLuong.ToString();
            txtDESCRIBE.Text = HANGHOA.MoTa;
            string TYPEOFITEM = dgvLISTITEMS.SelectedRows[0].Cells["TenLoaiHangHoa"].Value.ToString();
            string SUPPLIER = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString();
            string PRODUCER = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaSanXuat"].Value.ToString();
            cbbTYPE_OF_PRODUCT.Text = BLL_ITEMS.Instance.GetText(TYPEOFITEM, BLL_ITEMS.Instance.GetCBBTypeProduct());
            cbbSUPPLIERs.Text = BLL_ITEMS.Instance.GetText(SUPPLIER, BLL_ITEMS.Instance.GetCBBSupplier());
            cbbPRODUCERs.Text = BLL_ITEMS.Instance.GetText(PRODUCER, BLL_ITEMS.Instance.GetCBBProducer());
            txtBUY.Text = String.Format("{0:n0}", Convert.ToDouble(HANGHOA.GiaNhap));
            txtSALE.Text = String.Format("{0:n0}", Convert.ToDouble(HANGHOA.GiaBan));
            pbIMAGE.Image = ByteArrayToImage(HANGHOA.HinhAnh.ToArray());
        }
        // Thay đổi txtID_ITEM khi cbbTYPE_OF_ITEMS thay đổi
        private void cbbTYPE_OF_ITEMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID_PRODUCT.Text = BLL_ITEMS.Instance.GetNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
        }

        private void txtNAME_ITEM_Enter(object sender, EventArgs e)
        {
            if(txtNAME_PRODUCT.Text == "Nhập tên hàng hóa")
            {
                txtNAME_PRODUCT.Text = "";
                txtNAME_PRODUCT.ForeColor = Color.Black;
            }
        }

        private void txtNAME_ITEM_Leave(object sender, EventArgs e)
        {
            if (txtNAME_PRODUCT.Text == "")
            {
                txtNAME_PRODUCT.Text = "Nhập tên hàng hóa";
                txtNAME_PRODUCT.ForeColor = Color.Silver;
            }
        }

        private void txtAMOUNT_Enter(object sender, EventArgs e)
        {
            if (txtQUANTITY.Text == "Nhập số lượng hàng hóa")
            {
                txtQUANTITY.Text = "";
                txtQUANTITY.ForeColor = Color.Black;
            }
        }

        private void txtAMOUNT_Leave(object sender, EventArgs e)
        {
            if (txtQUANTITY.Text == "")
            {
                txtQUANTITY.Text = "Nhập số lượng hàng hóa";
                txtQUANTITY.ForeColor = Color.Silver;
            }
        }

        private void txtBUY_Enter(object sender, EventArgs e)
        {
            if (txtBUY.Text == "Nhập giá mua")
            {
                txtBUY.Text = "";
                txtBUY.ForeColor = Color.Black;
            }
        }

        private void txtBUY_Leave(object sender, EventArgs e)
        {
            if (txtBUY.Text == "")
            {
                txtBUY.Text = "Nhập giá mua";
                txtBUY.ForeColor = Color.Silver;
            }
        }

        private void txtSALE_Enter(object sender, EventArgs e)
        {
            if (txtSALE.Text == "Nhập giá bán")
            {
                txtSALE.Text = "";
                txtSALE.ForeColor = Color.Black;
            }
        }

        private void txtSALE_Leave(object sender, EventArgs e)
        {
            if (txtSALE.Text == "")
            {
                txtSALE.Text = "Nhập giá bán";
                txtSALE.ForeColor = Color.Silver;
            }
        }

        private void txtDESCRIBE_Enter(object sender, EventArgs e)
        {
            if (txtDESCRIBE.Text == "Nhập mô tả ...")
            {
                txtDESCRIBE.Text = "";
                txtDESCRIBE.ForeColor = Color.Black;
            }
        }

        private void txtDESCRIBE_Leave(object sender, EventArgs e)
        {
            if (txtDESCRIBE.Text == "")
            {
                txtDESCRIBE.Text = "Nhập mô tả ...";
                txtDESCRIBE.ForeColor = Color.Silver;
            }
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
    }
}
