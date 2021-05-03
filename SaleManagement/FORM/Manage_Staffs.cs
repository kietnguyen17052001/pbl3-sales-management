using SaleManagement.BLL;
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
    public partial class FrmManage_Staffs : Form
    {
        bool isADD; // Kiểm tra xem thực hiện chức năng ADD hay EDIT
        public FrmManage_Staffs()
        {
            InitializeComponent();
            setCBB();    
            disable(false);
            rbID_STAFF.Checked = true;        
        }
        void disable(bool E)
        {
            txtNAME_STAFF.Enabled = E;
            txtID_STAFF.Enabled = E;
            cbbPOSITION.Enabled = E;
            dpDAY.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            txtSALARY.Enabled = E;
            gbGENDER.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void setCBB()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            cbbPOSITION_DETAIL.Items.Add("Tất cả");
            cbbPOSITION_DETAIL.Items.AddRange(BLL_STAFF.Instance.getList_Position().Distinct().ToArray());
            cbbPOSITION.Items.AddRange(BLL_STAFF.Instance.getList_Position().Distinct().ToArray());
            cbbPOSITION_DETAIL.SelectedIndex = 0;
        }
        public void showSTAFF(int NUMBER)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (NUMBER == 0)
            {
                var GETSTAFF = DB.tblNhanViens.Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = GETSTAFF.ToList();
            }
            else
            {
                var GETSTAFF = DB.tblNhanViens.Where(p => p.ViTri == cbbPOSITION_DETAIL.SelectedItem.ToString()).Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = GETSTAFF.ToList();
            }
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            showSTAFF(cbbPOSITION_DETAIL.SelectedIndex);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            disable(true);
            isADD = true;
            txtID_STAFF.Text = BLL_STAFF.Instance.getNEWID_STAFF().ToString();
            txtNAME_STAFF.Clear();
            txtPHONE.Clear();
            rbMALE.Checked = true;
            txtADDRESS.Clear();
            txtSALARY.Clear();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            disable(true);
            txtID_STAFF.Enabled = false;
            isADD = false;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblNhanVien NHANVIEN = new tblNhanVien();
            NHANVIEN.MaNhanVien = txtID_STAFF.Text;
            NHANVIEN.TenNhanVien = txtNAME_STAFF.Text;
            NHANVIEN.ViTri = cbbPOSITION.SelectedItem.ToString();
            NHANVIEN.NgaySinh = Convert.ToDateTime(dpDAY.Value.ToShortDateString());
            if(rbMALE.Checked == true)
            {
                NHANVIEN.GioiTinh = true;
            }
            else
            {
                NHANVIEN.GioiTinh = false;
            }
            NHANVIEN.SoDienThoai = txtPHONE.Text;
            NHANVIEN.DiaChi = txtADDRESS.Text;
            NHANVIEN.Luong = txtSALARY.Text;
            if(txtID_STAFF.Text == "" || txtNAME_STAFF.Text == "" || txtPHONE.Text == "" || txtADDRESS.Text == "" || txtSALARY.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isADD)
                {
                    try
                    {
                        DB.tblNhanViens.Add(NHANVIEN);
                        DB.SaveChanges();
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        showSTAFF(0);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số nhân viên bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    var GETSTAFF = DB.tblNhanViens.Find(txtID_STAFF.Text);
                    GETSTAFF.TenNhanVien = NHANVIEN.TenNhanVien;
                    GETSTAFF.ViTri = NHANVIEN.ViTri;
                    GETSTAFF.NgaySinh = NHANVIEN.NgaySinh;
                    GETSTAFF.GioiTinh = NHANVIEN.GioiTinh;
                    GETSTAFF.SoDienThoai = NHANVIEN.SoDienThoai;
                    GETSTAFF.DiaChi = NHANVIEN.DiaChi;
                    GETSTAFF.Luong = NHANVIEN.Luong;
                    DB.SaveChanges();
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable(false);
                    showSTAFF(0);
                }
                
            } 
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> LIST_ID_STAFF = new List<string>();
            DataGridViewSelectedRowCollection DATA = dgvLIST_STAFF.SelectedRows;
            foreach(DataGridViewRow data in DATA)
            {
                LIST_ID_STAFF.Add(data.Cells["MaNhanVien"].Value.ToString());
            }
            foreach(string i in LIST_ID_STAFF)
            {
                foreach(tblNhanVien NHANVIEN in DB.tblNhanViens)
                {
                    if(NHANVIEN.MaNhanVien == i)
                    {
                        DB.tblNhanViens.Remove(NHANVIEN);
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                DB.SaveChanges();
            }
            dgvLIST_STAFF.DataSource = DB.tblNhanViens.ToList();
        }
        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (rbID_STAFF.Checked == true)
            {
                var GETSTAFFs = DB.tblNhanViens.Where(p => p.MaNhanVien.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = GETSTAFFs.ToList();
            }
            else
            {
                var GETSTAFFs = DB.tblNhanViens.Where(p => p.TenNhanVien.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = GETSTAFFs.ToList();
            }
        }
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            disable(false);
        }
        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
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
        private void dgvLIST_STAFF_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string ID_STAFF = dgvLIST_STAFF.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
            var NHANVIEN = DB.tblNhanViens.Find(ID_STAFF);
            txtID_STAFF.Text = NHANVIEN.MaNhanVien;
            txtNAME_STAFF.Text = NHANVIEN.TenNhanVien;
            cbbPOSITION.Text = NHANVIEN.ViTri;
            dpDAY.Value = (DateTime)NHANVIEN.NgaySinh;
            txtPHONE.Text = NHANVIEN.SoDienThoai;
            txtADDRESS.Text = NHANVIEN.DiaChi;
            //txtSALARY.Text = NHANVIEN.Luong;
            txtSALARY.Text = String.Format("{0:n0}", Convert.ToDouble(NHANVIEN.Luong));
            if(NHANVIEN.GioiTinh == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        private void txtNAME_STAFF_Enter(object sender, EventArgs e)
        {
            if(txtNAME_STAFF.Text == "Nhập tên nhân viên")
            {
                txtNAME_STAFF.Text = "";
                txtNAME_STAFF.ForeColor = Color.Black;
            }
        }

        private void txtNAME_STAFF_Leave(object sender, EventArgs e)
        {
            if (txtNAME_STAFF.Text == "")
            {
                txtNAME_STAFF.Text = "Nhập tên nhân viên";
                txtNAME_STAFF.ForeColor = Color.Silver;
            }
        }

        private void txtPHONE_Enter(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "Nhập SĐT")
            {
                txtPHONE.Text = "";
                txtPHONE.ForeColor = Color.Black;
            }
        }

        private void txtPHONE_Leave(object sender, EventArgs e)
        {
            if (txtPHONE.Text == "")
            {
                txtPHONE.Text = "Nhập SĐT";
                txtPHONE.ForeColor = Color.Silver;
            }
        }

        private void txtADDRESS_Enter(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "Nhập địa chỉ")
            {
                txtADDRESS.Text = "";
                txtADDRESS.ForeColor = Color.Black;
            }
        }

        private void txtADDRESS_Leave(object sender, EventArgs e)
        {
            if (txtADDRESS.Text == "")
            {
                txtADDRESS.Text = "Nhập địa chỉ";
                txtADDRESS.ForeColor = Color.Silver;
            }
        }

        private void txtSALARY_Enter(object sender, EventArgs e)
        {
            if (txtSALARY.Text == "Nhập tiền lương")
            {
                txtSALARY.Text = "";
                txtSALARY.ForeColor = Color.Black;
            }
        }

        private void txtSALARY_Leave(object sender, EventArgs e)
        {
            if (txtSALARY.Text == "")
            {
                txtSALARY.Text = "Nhập tiền lương";
                txtSALARY.ForeColor = Color.Silver;
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
