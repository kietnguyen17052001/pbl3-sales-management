using SaleManagement.BLL;
using SaleManagement.Entity;
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
        bool isAdd; // Biến kiểm tra là thực hiện chức năng thêm hay sửa khách hàng.
        public FrmManage_Customers()
        {
            InitializeComponent();
            disable(false);
            ShowCustomer();
            rbID_CUSTOMER.Checked = true;
        }
        // Cho phép hoặc không cho phép các textbox hay button nào được và không được thực hiện
        void disable(bool E)
        {
            txtNAME_CUSTOMER.Enabled = E;
            txtID_CUSTOMER.Enabled = E;
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
        public void ShowCustomer()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var listCus = DB.tblKhachHangs.Select(p => new {
                p.MaKhachHang,
                p.TenKhachHang,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi
            });
            dgvLISTCUSTOMER.DataSource = listCus.ToList();
            txtID_CUSTOMER.Clear();
            txtNAME_CUSTOMER.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        // Btn liệt kê khách hàng
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        // Xuất danh sách khách hàng ra file excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListCustomer";
            for (int i = 1; i <= dgvLISTCUSTOMER.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLISTCUSTOMER.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLISTCUSTOMER.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLISTCUSTOMER.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLISTCUSTOMER.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Customer";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // Btn thêm mới khách hàng
        private void btnADD_Click(object sender, EventArgs e)
        {
            disable(true);
            isAdd = true; // thêm
            txtID_CUSTOMER.Text = BLL_CUSTOMER.Instance.GetNewIdCustomer().ToString(); // gọi hàm tự điền mã số khách hàng từ BLL_CUSTOMER
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
            isAdd = false; // sửa
        }
        // Btn lưu thông tin khách hàng
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblKhachHang customer = new tblKhachHang();
            customer.MaKhachHang = txtID_CUSTOMER.Text;
            customer.TenKhachHang = txtNAME_CUSTOMER.Text;
            if (rbMALE.Checked == true)
            {
                customer.GioiTinh = true;
            }
            else
            {
                customer.GioiTinh = false;
            }
            customer.SoDienThoai = txtPHONE.Text;
            customer.DiaChi = txtADDRESS.Text;
            if (string.IsNullOrEmpty(customer.MaKhachHang) || string.IsNullOrEmpty(customer.TenKhachHang) || string.IsNullOrEmpty(customer.SoDienThoai) ||
                string.IsNullOrEmpty(customer.DiaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        DB.tblKhachHangs.Add(customer);
                        DB.SaveChanges();
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        ShowCustomer();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số khách hàng bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    var getCustomer = DB.tblKhachHangs.Find(txtID_CUSTOMER.Text); // tìm kiếm khách hàng có mã txtID_CUSTOMER
                    getCustomer.TenKhachHang = customer.TenKhachHang;
                    getCustomer.GioiTinh = customer.GioiTinh;
                    getCustomer.SoDienThoai = customer.SoDienThoai;
                    getCustomer.DiaChi = customer.DiaChi;
                    DB.SaveChanges();
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowCustomer();
                    disable(false);
                }
            }
        }
        // Btn xóa khách hàng
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> listIdCustomer = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLISTCUSTOMER.SelectedRows;
            foreach (DataGridViewRow dataGvr in data)
            {
                listIdCustomer.Add(dataGvr.Cells["MaKhachHang"].Value.ToString());
            }
            foreach (string i in listIdCustomer)
            {
                foreach (tblKhachHang customer in DB.tblKhachHangs)
                {
                    if (customer.MaKhachHang == i)
                    {
                        DB.tblKhachHangs.Remove(customer);
                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                DB.SaveChanges();
            }
            ShowCustomer();
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
                FrmManage_Data frm = new FrmManage_Data();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
        // Đổ dữ liêu từ row vào các txt
        private void dgvLISTCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string idCustomer = dgvLISTCUSTOMER.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
            var getCustomer = DB.tblKhachHangs.Find(idCustomer);
            txtID_CUSTOMER.Text = getCustomer.MaKhachHang;
            txtNAME_CUSTOMER.Text = getCustomer.TenKhachHang;
            txtPHONE.Text = getCustomer.SoDienThoai;
            txtADDRESS.Text = getCustomer.DiaChi;
            if (getCustomer.GioiTinh == true)
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
                var getCustomer = DB.tblKhachHangs.Where(p => p.MaKhachHang.Contains(txtSEARCH.Text)).Select(p => new
                {
                    p.MaKhachHang,
                    p.TenKhachHang,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi
                });
                dgvLISTCUSTOMER.DataSource = getCustomer.ToList();
            }
            else // Tìm kiếm theo tên
            {
                var getCustomer = DB.tblKhachHangs.Where(p => p.TenKhachHang.Contains(txtSEARCH.Text)).Select(p => new
                {
                    p.MaKhachHang,
                    p.TenKhachHang,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi
                });
                dgvLISTCUSTOMER.DataSource = getCustomer.ToList();
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
