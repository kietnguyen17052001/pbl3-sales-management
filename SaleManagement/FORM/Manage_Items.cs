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
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        bool isAdd;
        public FrmManage_Items()
        {
            InitializeComponent();
            setCBB();
            ShowProduct();
            disable(false);
            rbID_ITEM.Checked = true;
            // set style for ColumnHeader
            dgvLISTITEMS.EnableHeadersVisualStyles = false;
            dgvLISTITEMS.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLISTITEMS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLISTITEMS.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLISTITEMS.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // set hearderText
            dgvLISTITEMS.Columns[0].HeaderText = "Mã h.hóa";
            dgvLISTITEMS.Columns[1].HeaderText = "Tên h.hóa";
            dgvLISTITEMS.Columns[2].HeaderText = "Số lượng";
            dgvLISTITEMS.Columns[3].HeaderText = "Loại h.hóa";
            dgvLISTITEMS.Columns[4].HeaderText = "Nhà c.cấp";
            dgvLISTITEMS.Columns[5].HeaderText = "Nhà s.xuất";
            dgvLISTITEMS.Columns[6].HeaderText = "Giá mua";
            dgvLISTITEMS.Columns[7].HeaderText = "Giá bán";
            dgvLISTITEMS.Columns[8].HeaderText = "Mô tả";
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
        // load form
        public void LoadForm()
        {
            txtID_PRODUCT.Text = txtNAME_PRODUCT.Text = txtBUY.Text = txtSALE.Text = "";
            ShowProduct();
        }
        public void ShowProduct()
        {
            string idTypeOfProduct = ((CBBItem)cbbTYPE_OF__PRODUCT_DETAIL.SelectedItem).VALUE;
            if (cbbTYPE_OF__PRODUCT_DETAIL.SelectedIndex == 0)
            {
                var product = DB.tblHangHoas.Select(p => new
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
                dgvLISTITEMS.DataSource = product.ToList();
            }
            else
            {
                var product = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == idTypeOfProduct).Select(p => new
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
                dgvLISTITEMS.DataSource = product.ToList();
            }
            txtID_PRODUCT.Clear();
            txtNAME_PRODUCT.Clear();
            txtBUY.Clear();
            txtSALE.Clear();
            txtQUANTITY.Clear();
            txtDESCRIBE.Clear();
            pbIMAGE.Image = null;
        }
        public void addTYPEITEM(string id, string name)
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        public void addSUPPLIER(string id, string name)
        {
            cbbSUPPLIERs.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        public void addPRODUCER(string id, string name)
        {
            cbbPRODUCERs.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        // Set backColor for dgv
        private void dgvLISTITEMS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLISTITEMS.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLISTITEMS.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // click event
        private void dgvLISTITEMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProduct = dgvLISTITEMS.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            txtID_PRODUCT.Text = idProduct;
            txtNAME_PRODUCT.Text = dgvLISTITEMS.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
            txtQUANTITY.Text = dgvLISTITEMS.SelectedRows[0].Cells["SoLuong"].Value.ToString();
            txtDESCRIBE.Text = dgvLISTITEMS.SelectedRows[0].Cells["MoTa"].Value.ToString();
            string typeProduct = dgvLISTITEMS.SelectedRows[0].Cells["TenLoaiHangHoa"].Value.ToString();
            string supplier = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString();
            string producer = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaSanXuat"].Value.ToString();
            cbbTYPE_OF_PRODUCT.Text = BLL_ITEMS.Instance.GetText(typeProduct, BLL_ITEMS.Instance.GetCBBTypeProduct());
            cbbSUPPLIERs.Text = BLL_ITEMS.Instance.GetText(supplier, BLL_ITEMS.Instance.GetCBBSupplier());
            cbbPRODUCERs.Text = BLL_ITEMS.Instance.GetText(producer, BLL_ITEMS.Instance.GetCBBProducer());
            txtBUY.Text = String.Format("{0:n0}", dgvLISTITEMS.SelectedRows[0].Cells["GiaNhap"].Value);
            txtSALE.Text = String.Format("{0:n0}", dgvLISTITEMS.SelectedRows[0].Cells["GiaBan"].Value);
            var product = DB.tblHangHoas.Find(idProduct);
            pbIMAGE.Image = ByteArrayToImage(product.HinhAnh.ToArray());
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }
        // export
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
        // show frmCreate_NewTypeProduct
        private void btnADDTYPE_Click(object sender, EventArgs e)
        {
            FrmCreate_NewTypeItem frm = new FrmCreate_NewTypeItem();
            frm.d += new FrmCreate_NewTypeItem.myDEL(addTYPEITEM);
            frm.Show();
        }
        // show ...
        private void btnADDSUPPLIER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewSupplier frm = new FrmCreate_NewSupplier();
            frm.d += new FrmCreate_NewSupplier.myDEL(addSUPPLIER);
            frm.Show();
        }
        // show ...
        private void btnADDPRODUCER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProducer frm = new FrmCreate_NewProducer();
            frm.d += new FrmCreate_NewProducer.myDEL(addPRODUCER);
            frm.Show();
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
        // edit product
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            isAdd = false;
            disable(true);
            txtID_PRODUCT.Enabled = false;
        }
        // save 
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
            product.MaNhaCungCap = ((CBBItem)cbbSUPPLIERs.SelectedItem).VALUE;
            product.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
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
                        product.HinhAnh = images;
                        BLL_ITEMS.Instance.FuncAddNewProduct(product); // add new product
                        MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        LoadForm(); // load form after add new product
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số hàng hóa bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    BLL_ITEMS.Instance.FuncEditProduct(product); // edit product
                    MessageBox.Show("Sửa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable(false);
                    ShowProduct();
                }
            }
        }
        // delete product
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLISTITEMS.SelectedRows;
            foreach (DataGridViewRow dataGvr in data)
            {
                listIdProduct.Add(dataGvr.Cells["MaHangHoa"].Value.ToString());
            }
            DialogResult question = MessageBox.Show("Bạn chắc chắn xóa hàng hóa này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                BLL_ITEMS.Instance.FuncDeleteProduct(listIdProduct); // delete product 
                LoadForm(); // load form sau khi delete
            }
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
                this.Close();
            }
            else
            {
                return;
            }
        }
        // search product
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

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (rbID_ITEM.Checked == true)
            {
                BLL_ITEMS.Instance.FuncSearchId(dgvLISTITEMS, txtSEARCH.Text.Trim());
            }
            else
            {
                BLL_ITEMS.Instance.FuncSearchName(dgvLISTITEMS, txtSEARCH.Text.Trim());
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
        // change idProduct
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
    }
}
