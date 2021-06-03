using SaleManagement.BLL;
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
    public partial class FrmManage_Warehouse : Form
    {
        DataTable data = BLL_WAREHOUSE.Instance.createListItem();
        public FrmManage_Warehouse()
        {
            InitializeComponent();
            SetCBB();
        }
        public void load()
        {
            txtTenHangHoa.Text = "";
            txtALL_AMOUNT_ITEMs.Text = "0";
            txtGiaNhap.Text = "0";
            txtMaHoaDon.Text = "";
            txtSoLuong.Text = "1";
            txtTotalItem.Text = "0";
            txtGiamGia.Text = "0";
            data.Clear();
            cbbMaHangHoa.SelectedIndex = cbbNhaCungCap.SelectedIndex = cbbSTAFF.SelectedIndex = 0;
        }
        public void setGUI()
        {
            txtALL_AMOUNT_ITEMs.Text = BLL_WAREHOUSE.Instance.GetAllAMOUNT(data).ToString();
            txtTotalItem.Text = BLL_WAREHOUSE.Instance.countItem(data).ToString();
        }
        public void addSUPPLIER(string ID, string NAME)
        {
            cbbNhaCungCap.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        public void addTYPEITEM(string ID, string NAME)
        {
            cbbMaHangHoa.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        public void SetCBB()
        {
            cbbSTAFF.Items.Add("None");
            cbbSTAFF.SelectedIndex = 0;
            cbbSTAFF.Items.AddRange(BLL_WAREHOUSE.Instance.getCBB_Staff().ToArray());
            cbbNhaCungCap.Items.Add("None");
            cbbNhaCungCap.SelectedIndex = 0;
            cbbNhaCungCap.Items.AddRange(BLL_WAREHOUSE.Instance.getCBB_NhaCungCap().ToArray());
            cbbMaHangHoa.Items.Add("None");
            cbbMaHangHoa.SelectedIndex = 0;
            cbbMaHangHoa.Items.AddRange(BLL_WAREHOUSE.Instance.getCBB_Item().ToArray());
        }
        public bool check()
        {
            if (cbbSTAFF.SelectedIndex == 0 || cbbNhaCungCap.SelectedIndex == 0 || cbbMaHangHoa.SelectedIndex == 0 ||
                String.IsNullOrEmpty(txtGiaNhap.Text) || String.IsNullOrEmpty(txtMaHoaDon.Text) ||
                String.IsNullOrEmpty(txtSoLuong.Text) || String.IsNullOrEmpty(txtTenHangHoa.Text) ||
                Convert.ToDouble(txtGiamGia.Text) < 0 && Convert.ToDouble(txtGiamGia.Text) > 100)
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToDouble(txtGiamGia.Text) > 100)
            {
                MessageBox.Show("Vui lòng nhập đúng khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnADD_NCC_Click(object sender, EventArgs e)
        {
            FrmCreate_NewSupplier frm = new FrmCreate_NewSupplier();
            frm.d += new FrmCreate_NewSupplier.myDEL(addSUPPLIER);
            frm.Show();
        }
        private void btnADD_ITEM_Click(object sender, EventArgs e)
        {
            FrmCreate_NewTypeItem frm = new FrmCreate_NewTypeItem();
            frm.d += new FrmCreate_NewTypeItem.myDEL(addTYPEITEM);
            frm.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(check())
           {
                string LoaiHangHoa = ((CBBItem)cbbMaHangHoa.SelectedItem).VALUE.ToString();
                string TenHangHoa = txtTenHangHoa.Text;
                double TienNhap = Convert.ToDouble(txtGiaNhap.Text);
                int SoLuong = Convert.ToInt32(txtSoLuong.Text);
                double TienGiam = (SoLuong * TienNhap) * (Convert.ToDouble(txtGiamGia.Text)/100);
                double ThanhTien = SoLuong * TienNhap - TienGiam;
                BLL_WAREHOUSE.Instance.addItemToList(data, LoaiHangHoa, TenHangHoa, TienNhap, SoLuong,TienGiam, ThanhTien);
                dgvLIST.DataSource = data;
                setGUI();
           }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DataGridViewSelectedRowCollection rows = dgvLIST.SelectedRows;
                List<String> listID_Item = new List<string>();
                foreach (DataGridViewRow i in rows)
                {
                    listID_Item.Add(rows[0].Cells["MaHangHoa"].Value.ToString());
                }
                BLL_CREATEBILL.Instance.delITEMS(listID_Item, data);
                setGUI();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (dgvLIST.SelectedRows.Count == 1)
                {
                    string MaHangHoa = ((CBBItem)cbbMaHangHoa.SelectedItem).VALUE.ToString();
                    string TenHangHoa = txtTenHangHoa.Text;
                    string GiaNhap = txtGiaNhap.Text;
                    string SoLuong = txtSoLuong.Text;
                    string GiamGia = txtGiamGia.Text;
                    string ThanhTien = dgvLIST.SelectedRows[0].Cells["ThanhTien(VND)"].Value.ToString();
                    BLL_WAREHOUSE.Instance.EditItem(data, MaHangHoa, TenHangHoa, GiaNhap, SoLuong, GiamGia, ThanhTien);
                    setGUI();
                }
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            string MaHoaDon = txtMaHoaDon.Text;
            tblHoaDonNhapHang delHoaDon = db.tblHoaDonNhapHangs.Find(MaHoaDon);
            if (delHoaDon == null)
            {
                MessageBox.Show("Mã hóa đơn không tồn tại để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.tblHoaDonNhapHangs.Remove(delHoaDon);
                db.SaveChanges();
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
        }
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            if (check())
            {
                tblHoaDonNhapHang nhap = new tblHoaDonNhapHang()
                {
                    MaHoaDonNhap = txtMaHoaDon.Text,
                    MaNhaCungCap = ((CBBItem)cbbNhaCungCap.SelectedItem).VALUE.ToString(),
                    MaNhanVien = ((CBBItem)cbbSTAFF.SelectedItem).VALUE.ToString(),
                    NgayNhap = dpDAY.Value,
                    SoTien = Convert.ToDouble(txtALL_AMOUNT_ITEMs.Text),
                };
                List<tblChiTietHoaDonNhapHang> list = new List<tblChiTietHoaDonNhapHang>();
                foreach(DataRow i in data.Rows)
                {
                    list.Add(new tblChiTietHoaDonNhapHang
                    {
                        MaHoaDonNhap = txtMaHoaDon.Text,
                        MaHangHoa = ((CBBItem)cbbMaHangHoa.SelectedItem).VALUE.ToString(),
                        SoLuong = Convert.ToInt32(dgvLIST.SelectedRows[0].Cells["SoLuong"].Value.ToString()),
                        DonGia = Convert.ToDouble(dgvLIST.SelectedRows[0].Cells["GiaNhap"].Value.ToString()),
                        GiamGia = Convert.ToDouble(dgvLIST.SelectedRows[0].Cells["TienGiam"].Value.ToString()),
                        TongTien = Convert.ToDouble(dgvLIST.SelectedRows[0].Cells["ThanhTien(VND)"].Value.ToString())
                    });
                }
                tblHoaDonNhapHang hoadon = db.tblHoaDonNhapHangs.Find(txtMaHoaDon.Text);
                if (hoadon != null)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.tblHoaDonNhapHangs.Add(nhap);
                    //db.tblChiTietHoaDonNhapHangs.AddRange(list.ToArray());
                    db.SaveChanges();
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
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
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        private void dgvLIST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLIST.CurrentRow.Index;
            txtTenHangHoa.Text = dgvLIST.Rows[i].Cells["TenHangHoa"].Value.ToString();
            txtSoLuong.Text = dgvLIST.Rows[i].Cells["SoLuong"].Value.ToString();
            txtGiaNhap.Text = dgvLIST.Rows[i].Cells["GiaNhap"].Value.ToString();
            double TienGiam = 100 * Convert.ToDouble(dgvLIST.Rows[i].Cells["TienGiam"].Value.ToString()) /
            (Convert.ToDouble(dgvLIST.Rows[i].Cells["SoLuong"].Value.ToString()) * Convert.ToDouble(dgvLIST.Rows[i].Cells["GiaNhap"].Value.ToString()));
            txtGiamGia.Text = TienGiam.ToString();
        }


    }
}
