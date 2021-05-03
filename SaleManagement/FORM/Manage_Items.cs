using SaleManagement.BLL;
using SaleManagement.FORM;
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
    public partial class FrmManage_Items : Form
    {
        bool isADD;
        public FrmManage_Items()
        {
            InitializeComponent();
            setCBB();
            disable(false);
            rbID_ITEM.Checked = true;
        }
        public void setCBB()
        {
            cbbTYPE_OF_ITEMS_DETAIL.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả" });
            cbbTYPE_OF_ITEMS_DETAIL.Items.AddRange(BLL_ITEMS.Instance.getCBB_TYPEOFITEMS().ToArray());
            cbbTYPE_OF_ITEMs.Items.AddRange(BLL_ITEMS.Instance.getCBB_TYPEOFITEMS().ToArray());
            cbbSUPPLIERs.Items.AddRange(BLL_ITEMS.Instance.getCBB_SUPPLIERS().ToArray());
            cbbPRODUCERs.Items.AddRange(BLL_ITEMS.Instance.getCBB_PRODUCERS().ToArray());
            cbbTYPE_OF_ITEMS_DETAIL.SelectedIndex = 0;
        }
        void disable(bool E)
        {
            txtID_ITEM.Enabled = E;
            txtNAME_ITEM.Enabled = E;
            txtAMOUNT.Enabled = E;
            txtBUY.Enabled = E;
            txtSALE.Enabled = E;
            txtDESCRIBE.Enabled = E;
            cbbTYPE_OF_ITEMs.Enabled = E;
            cbbPRODUCERs.Enabled = E;
            cbbSUPPLIERs.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void showITEMS(int NUMBER)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string ID_TYPEOFITEMS = ((CBBItem)cbbTYPE_OF_ITEMS_DETAIL.SelectedItem).VALUE;
            if (NUMBER == 0)
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
                var ITEMS = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == ID_TYPEOFITEMS).Select(p => new
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
        }
        public void addTYPEITEM(string ID, string NAME)
        {
            cbbTYPE_OF_ITEMs.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
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
            showITEMS(cbbTYPE_OF_ITEMS_DETAIL.SelectedIndex);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            isADD = true;
            disable(true);
            cbbPRODUCERs.SelectedIndex = cbbSUPPLIERs.SelectedIndex = cbbTYPE_OF_ITEMs.SelectedIndex = 0;
            txtNAME_ITEM.Clear();
            txtAMOUNT.Clear();
            txtBUY.Clear();
            txtSALE.Clear();
            txtDESCRIBE.Clear();
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
            FrmCreate_NewSupplier FRM = new FrmCreate_NewSupplier();
            FRM.d += new FrmCreate_NewSupplier.myDEL(addSUPPLIER);
            FRM.Show();
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            isADD = false;
            disable(true);
            txtID_ITEM.Enabled = false;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblHangHoa HANGHOA = new tblHangHoa();
            HANGHOA.MaHangHoa = txtID_ITEM.Text;
            HANGHOA.TenHangHoa = txtNAME_ITEM.Text;
            HANGHOA.SoLuong = Convert.ToInt32(txtAMOUNT.Text);
            HANGHOA.GiaBan = Convert.ToDouble(txtSALE.Text);
            HANGHOA.GiaNhap = Convert.ToDouble(txtBUY.Text);
            HANGHOA.MoTa = txtDESCRIBE.Text;
            HANGHOA.MaLoaiHangHoa = ((CBBItem)cbbTYPE_OF_ITEMs.SelectedItem).VALUE;
            HANGHOA.MaNhaCungCap = ((CBBItem)cbbSUPPLIERs.SelectedItem).VALUE;
            HANGHOA.MaNhaSanXuat = ((CBBItem)cbbPRODUCERs.SelectedItem).VALUE;
            if (txtID_ITEM.Text == "" || txtNAME_ITEM.Text == "" || txtAMOUNT.Text == "" || txtBUY.Text == "" || txtSALE.Text == "" || txtDESCRIBE.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isADD)
                {
                    try
                    {
                        DB.tblHangHoas.Add(HANGHOA);
                        DB.SaveChanges();
                        MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        showITEMS(0);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số hàng hóa bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    var GETITEM = DB.tblHangHoas.Find(txtID_ITEM.Text);
                    GETITEM.TenHangHoa = HANGHOA.TenHangHoa;
                    GETITEM.SoLuong = HANGHOA.SoLuong;
                    GETITEM.GiaBan = HANGHOA.GiaBan;
                    GETITEM.GiaNhap = HANGHOA.GiaNhap;
                    GETITEM.MaLoaiHangHoa = HANGHOA.MaLoaiHangHoa;
                    GETITEM.MaNhaCungCap = HANGHOA.MaNhaCungCap;
                    GETITEM.MaNhaSanXuat = HANGHOA.MaNhaSanXuat;
                    DB.SaveChanges();
                    MessageBox.Show("Sửa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable(false);
                    showITEMS(0);
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
            showITEMS(0);
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
                var GETITEMs = DB.tblHangHoas.Where(p => p.MaHangHoa.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
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
                var GETITEMs = DB.tblHangHoas.Where(p => p.TenHangHoa.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
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
        private void dgvLISTITEMS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string ID_ITEM = dgvLISTITEMS.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            var HANGHOA = DB.tblHangHoas.Find(ID_ITEM);
            txtID_ITEM.Text = HANGHOA.MaHangHoa;
            txtNAME_ITEM.Text = HANGHOA.TenHangHoa;
            txtAMOUNT.Text = HANGHOA.SoLuong.ToString();
            txtDESCRIBE.Text = HANGHOA.MoTa;
            string TYPEOFITEM = dgvLISTITEMS.SelectedRows[0].Cells["TenLoaiHangHoa"].Value.ToString();
            string SUPPLIER = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString();
            string PRODUCER = dgvLISTITEMS.SelectedRows[0].Cells["TenNhaSanXuat"].Value.ToString();
            cbbTYPE_OF_ITEMs.Text = BLL_ITEMS.Instance.getTEXT(TYPEOFITEM, BLL_ITEMS.Instance.getCBB_TYPEOFITEMS());
            cbbSUPPLIERs.Text = BLL_ITEMS.Instance.getTEXT(SUPPLIER, BLL_ITEMS.Instance.getCBB_SUPPLIERS());
            cbbPRODUCERs.Text = BLL_ITEMS.Instance.getTEXT(PRODUCER, BLL_ITEMS.Instance.getCBB_PRODUCERS());
            txtBUY.Text = String.Format("{0:n0}", Convert.ToDouble(HANGHOA.GiaNhap));
            txtSALE.Text = String.Format("{0:n0}", Convert.ToDouble(HANGHOA.GiaBan));
        }
        // Thay đổi txtID_ITEM khi cbbTYPE_OF_ITEMS thay đổi
        private void cbbTYPE_OF_ITEMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID_ITEM.Text = BLL_ITEMS.Instance.getNEWID_ITEM(((CBBItem)cbbTYPE_OF_ITEMs.SelectedItem).VALUE);
        }

        private void txtNAME_ITEM_Enter(object sender, EventArgs e)
        {
            if(txtNAME_ITEM.Text == "Nhập tên hàng hóa")
            {
                txtNAME_ITEM.Text = "";
                txtNAME_ITEM.ForeColor = Color.Black;
            }
        }

        private void txtNAME_ITEM_Leave(object sender, EventArgs e)
        {
            if (txtNAME_ITEM.Text == "")
            {
                txtNAME_ITEM.Text = "Nhập tên hàng hóa";
                txtNAME_ITEM.ForeColor = Color.Silver;
            }
        }

        private void txtAMOUNT_Enter(object sender, EventArgs e)
        {
            if (txtAMOUNT.Text == "Nhập số lượng hàng hóa")
            {
                txtAMOUNT.Text = "";
                txtAMOUNT.ForeColor = Color.Black;
            }
        }

        private void txtAMOUNT_Leave(object sender, EventArgs e)
        {
            if (txtAMOUNT.Text == "")
            {
                txtAMOUNT.Text = "Nhập số lượng hàng hóa";
                txtAMOUNT.ForeColor = Color.Silver;
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
