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
    public partial class FrmManage_Customers : Form
    {
        bool isADD; // Biến kiểm tra là thực hiện chức năng thêm hay sửa khách hàng.
        public FrmManage_Customers()
        {
            InitializeComponent();
            disable(false);
            rbID_CUSTOMER.Checked = true;
        }
        // Cho phép hoặc không cho phép các textbox hay button nào được và không được thực hiện
        void disable(bool E)
        {
            txtNAME_CUSTOMER.Enabled = E;
            txtID_CUSTOMER.Enabled = E;
            dpDAY.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            gbGENDER.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        // Liệt kê danh sách khách hàng từ DB
        public void showCUSTOMER()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var GETALLCUSTOMER = DB.tblKhachHangs.Select(p => new {
                p.MaKhachHang,
                p.TenKhachHang,
                p.SoDienThoai,
                p.GioiTinh,
                p.DiaChi,
            });
            dgvLISTCUSTOMER.DataSource = GETALLCUSTOMER.ToList();
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        // Btn liệt kê khách hàng
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            showCUSTOMER();
        }
        // Btn thêm mới khách hàng
        private void btnADD_Click(object sender, EventArgs e)
        {
            disable(true);
            isADD = true; // thêm
            txtID_CUSTOMER.Text = BLL_CUSTOMER.Instance.getNEWID_CUSTOMER().ToString(); // gọi hàm tự điền mã số khách hàng từ BLL_CUSTOMER
            txtNAME_CUSTOMER.Clear();
            txtPHONE.Clear();
            rbMALE.Checked = true;
            txtADDRESS.Clear();
        }
        // Btn sửa khách hàng
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            disable(true);
            txtID_CUSTOMER.Enabled = false;
            isADD = false; // sửa
        }
        // Btn lưu thông tin khách hàng
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblKhachHang KHACHHANG = new tblKhachHang();
            KHACHHANG.MaKhachHang = txtID_CUSTOMER.Text;
            KHACHHANG.TenKhachHang = txtNAME_CUSTOMER.Text;
            if (rbMALE.Checked == true)
            {
                KHACHHANG.GioiTinh = true;
            }
            else
            {
                KHACHHANG.GioiTinh = false;
            }
            KHACHHANG.SoDienThoai = txtPHONE.Text;
            KHACHHANG.DiaChi = txtADDRESS.Text;
            if (txtID_CUSTOMER.Text == "" || txtNAME_CUSTOMER.Text == "" || txtPHONE.Text == "" || txtADDRESS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isADD)
                {
                    try
                    {
                        DB.tblKhachHangs.Add(KHACHHANG);
                        DB.SaveChanges();
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        showCUSTOMER();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số khách hàng bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    var GETCUSTOMER = DB.tblKhachHangs.Find(txtID_CUSTOMER.Text); // tìm kiếm khách hàng có mã txtID_CUSTOMER
                    GETCUSTOMER.TenKhachHang = KHACHHANG.TenKhachHang;
                    GETCUSTOMER.GioiTinh = KHACHHANG.GioiTinh;
                    GETCUSTOMER.SoDienThoai = KHACHHANG.SoDienThoai;
                    GETCUSTOMER.DiaChi = KHACHHANG.DiaChi;
                    DB.SaveChanges();
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showCUSTOMER();
                    disable(false);
                }
            }
        }
        // Btn xóa khách hàng
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> LIST_ID_CUSTOMER = new List<string>();
            DataGridViewSelectedRowCollection DATA = dgvLISTCUSTOMER.SelectedRows;
            foreach (DataGridViewRow data in DATA)
            {
                LIST_ID_CUSTOMER.Add(data.Cells["MaKhachHang"].Value.ToString());
            }
            foreach (string i in LIST_ID_CUSTOMER)
            {
                foreach (tblKhachHang KHACHHANG in DB.tblKhachHangs)
                {
                    if (KHACHHANG.MaKhachHang == i)
                    {
                        DB.tblKhachHangs.Remove(KHACHHANG);
                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                DB.SaveChanges();
            }
            showCUSTOMER();
        }
        // Btn hủy bỏ
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            disable(false);
        }
        // Btn quay lại
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
        // Đổ dữ liêu từ row vào các txt
        private void dgvLISTCUSTOMER_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string ID_CUSTOMER = dgvLISTCUSTOMER.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            var KHACHHANG = DB.tblKhachHangs.Find(ID_CUSTOMER);
            txtID_CUSTOMER.Text = KHACHHANG.MaKhachHang;
            txtNAME_CUSTOMER.Text = KHACHHANG.TenKhachHang;
            txtPHONE.Text = KHACHHANG.SoDienThoai;
            txtADDRESS.Text = KHACHHANG.DiaChi;
            if (KHACHHANG.GioiTinh == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        // Btn tìm kiếm
        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (rbID_CUSTOMER.Checked == true) // Tìm kiếm theo mã số
            {
                var GETCUSTOMERs = DB.tblKhachHangs.Where(p => p.MaKhachHang.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaKhachHang,
                    p.TenKhachHang,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                });
                dgvLISTCUSTOMER.DataSource = GETCUSTOMERs.ToList();
            }
            else // Tìm kiếm theo tên
            {
                var GETCUSTOMERs = DB.tblKhachHangs.Where(p => p.TenKhachHang.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaKhachHang,
                    p.TenKhachHang,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                });
                dgvLISTCUSTOMER.DataSource = GETCUSTOMERs.ToList();
            }
        }

        private void txtNAME_CUSTOMER_Enter(object sender, EventArgs e)
        {
            if(txtNAME_CUSTOMER.Text == "Nhập tên khách hàng")
            {
                txtNAME_CUSTOMER.Text = "";
                txtNAME_CUSTOMER.ForeColor = Color.Black;
            }
        }

        private void txtNAME_CUSTOMER_Leave(object sender, EventArgs e)
        {
            if (txtNAME_CUSTOMER.Text == "")
            {
                txtNAME_CUSTOMER.Text = "Nhập tên khách hàng";
                txtNAME_CUSTOMER.ForeColor = Color.Silver;
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
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Silver;
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
