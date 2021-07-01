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
        private bool isAdd;
        private string usernamelogin;
        public FrmManage_Items(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            setCombobox();
            LoadData();
            FormatColumnHeader();
            Disable(false);
        }
        // format columns header
        public void FormatColumnHeader()
        {
            // set style for ColumnHeader
            dgvLISTPRODUCT.EnableHeadersVisualStyles = false;
            dgvLISTPRODUCT.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLISTPRODUCT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLISTPRODUCT.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLISTPRODUCT.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // set hearderText
            dgvLISTPRODUCT.Columns[0].HeaderText = "Mã h.hóa";
            dgvLISTPRODUCT.Columns[1].HeaderText = "Tên h.hóa";
            dgvLISTPRODUCT.Columns[2].HeaderText = "Số lượng";
            dgvLISTPRODUCT.Columns[3].HeaderText = "Loại h.hóa";
            dgvLISTPRODUCT.Columns[4].HeaderText = "Nhà s.xuất";
            dgvLISTPRODUCT.Columns[5].HeaderText = "Giá mua";
            dgvLISTPRODUCT.Columns[6].HeaderText = "Giá bán";
            dgvLISTPRODUCT.Columns[7].HeaderText = "Mô tả";
        }
        public void setCombobox()
        {
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_PRODUCT.Instance.getCBBTypeProduct().ToArray());
            cbbPRODUCERs.Items.AddRange(BLL_PRODUCER.Instance.getCbbProducer().ToArray());
        }
        void Disable(bool E)
        {
            txtID_PRODUCT.Enabled = E;
            txtNAME_PRODUCT.Enabled = E;
            txtBUY.Enabled = E;
            txtSALE.Enabled = E;
            txtDESCRIBE.Enabled = E;
            cbbTYPE_OF_PRODUCT.Enabled = E;
            cbbPRODUCERs.Enabled = E;
            btnADDPIC.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void ClearCode()
        {
            txtID_PRODUCT.Clear();
            txtNAME_PRODUCT.Clear();
            txtBUY.Clear();
            txtSALE.Clear();
            txtQUANTITY.Clear();
            txtDESCRIBE.Clear();
            pbIMAGE.Image = null;
        }
        public void LoadData()
        {
            BLL_PRODUCT.Instance.LoadDataProduct(dgvLISTPRODUCT);
            ClearCode();
            lbQuantity.Text = BLL_PRODUCT.Instance.getQuantityProduct(dgvLISTPRODUCT).ToString();
        }
        public void addTypeOfProduct(string id, string name)
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        public void addProducer(string id, string name)
        {
            cbbPRODUCERs.Items.Add(new CBBItem { VALUE = id, TEXT = name });
        }
        // Set backColor for dgv
        private void dgvLISTITEMS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLISTPRODUCT.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLISTPRODUCT.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        public Image ByteArrayToImage(byte[] byArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        // click event
        private void dgvLISTITEMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_PRODUCT.Text = dgvLISTPRODUCT.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            txtNAME_PRODUCT.Text = dgvLISTPRODUCT.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
            txtQUANTITY.Text = dgvLISTPRODUCT.SelectedRows[0].Cells["SoLuong"].Value.ToString();
            txtDESCRIBE.Text = dgvLISTPRODUCT.SelectedRows[0].Cells["MoTa"].Value.ToString();
            cbbTYPE_OF_PRODUCT.Text = BLL_PRODUCT.Instance.getText(dgvLISTPRODUCT.SelectedRows[0].Cells["TenLoaiHangHoa"].Value.ToString(), BLL_PRODUCT.Instance.getCBBTypeProduct());
            cbbPRODUCERs.Text = BLL_PRODUCT.Instance.getText(dgvLISTPRODUCT.SelectedRows[0].Cells["TenNhaSanXuat"].Value.ToString(), BLL_PRODUCER.Instance.getCbbProducer());
            txtBUY.Text = String.Format("{0:n0}", dgvLISTPRODUCT.SelectedRows[0].Cells["GiaNhap"].Value);
            txtSALE.Text = String.Format("{0:n0}", dgvLISTPRODUCT.SelectedRows[0].Cells["GiaBan"].Value);
            pbIMAGE.Image = BLL_PRODUCT.Instance.image(dgvLISTPRODUCT.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernamelogin);
            frmMainAdmin.Show();
            this.Close();
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            LoadData();
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
            for (int i = 1; i <= dgvLISTPRODUCT.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLISTPRODUCT.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLISTPRODUCT.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLISTPRODUCT.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLISTPRODUCT.Rows[i].Cells[j].Value.ToString();
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
            Disable(true);
            cbbPRODUCERs.SelectedIndex = cbbPRODUCERs.SelectedIndex = cbbTYPE_OF_PRODUCT.SelectedIndex = 0;
            txtID_PRODUCT.Text = BLL_PRODUCT.Instance.getNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
            txtNAME_PRODUCT.Clear();
            txtQUANTITY.Text = txtBUY.Text = txtSALE.Text = "0";
            txtQUANTITY.Enabled = false;
            txtDESCRIBE.Clear();
            pbIMAGE.Image = null;
        }
        // show frmCreate_NewTypeProduct
        private void btnADDTYPE_Click(object sender, EventArgs e)
        {
            FrmCreate_NewTypeItem frmCreateNewTypeOfProduct = new FrmCreate_NewTypeItem();
            frmCreateNewTypeOfProduct.d += new FrmCreate_NewTypeItem.myDEL(addTypeOfProduct);
            frmCreateNewTypeOfProduct.Show();
        }
        // show ...
        private void btnADDPRODUCER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProducer frmCreateNewProducer = new FrmCreate_NewProducer();
            frmCreateNewProducer.d += new FrmCreate_NewProducer.myDEL(addProducer);
            frmCreateNewProducer.Show();
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
            Disable(true);
            txtID_PRODUCT.Enabled = false;
        }
        // save 
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblHangHoa product = new tblHangHoa();
            product.MaHangHoa = txtID_PRODUCT.Text.Trim();
            product.TenHangHoa = txtNAME_PRODUCT.Text.Trim();
            product.SoLuong = Convert.ToInt32(txtQUANTITY.Text.Trim());
            product.GiaBan = Convert.ToDouble(txtSALE.Text.Trim());
            product.GiaNhap = Convert.ToDouble(txtBUY.Text.Trim());
            product.MoTa = txtDESCRIBE.Text;
            product.MaLoaiHangHoa = ((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE;
            product.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
            if (product.MaHangHoa == null && product.TenHangHoa != null)
            {
                MessageBox.Show("Mã khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (product.MaHangHoa != null && product.TenHangHoa == null)
            {
                MessageBox.Show("Tên khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (product.MaHangHoa == null && product.TenHangHoa == null)
            {
                MessageBox.Show("Mã và tên khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        product.HinhAnh = images;
                        BLL_PRODUCT.Instance.FuncAddNewProduct(product); // add new product
                        MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disable(false);
                        LoadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã hàng hóa đã tồn tại", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Disable(true);
                    }
                }
                else
                {
                    BLL_PRODUCT.Instance.FuncEditProduct(product); // edit product
                    MessageBox.Show("Sửa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable(false);
                    LoadData();
                }
            }
        }
        // delete product
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLISTPRODUCT.SelectedRows;
            foreach (DataGridViewRow dgvRow in data)
            {
                listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
            }
            DialogResult answer = MessageBox.Show("Bạn chắc chắn xóa hàng hóa này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                BLL_PRODUCT.Instance.FuncDeleteProduct(listIdProduct); // delete product 
                LoadData(); // load form sau khi delete
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Disable(false);
            ClearCode();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManagaData = new FrmManage_Data(usernamelogin);
            frmManagaData.Show();
            this.Close();
        }
        // search product
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên hàng hóa, loại hàng hóa")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên hàng hóa, loại hàng hóa";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_PRODUCT.Instance.FuncSearchProduct(dgvLISTPRODUCT, txtSEARCH.Text.Trim());
            lbQuantity.Text = BLL_PRODUCT.Instance.getQuantityProduct(dgvLISTPRODUCT).ToString();
        }
        // change idProduct
        private void cbbTYPE_OF_ITEMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btnADD.Enabled == false)
            {
                txtID_PRODUCT.Text = BLL_PRODUCT.Instance.getNewIdProduct(((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE);
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
        // KeyPress Event
        private void txtSALE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
