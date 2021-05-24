﻿using SaleManagement.BLL;
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
    public partial class FrmManage_Staffs : Form
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        bool isAdd; // Kiểm tra xem thực hiện chức năng ADD hay EDIT
        public FrmManage_Staffs()
        {
            InitializeComponent();
            SetCbb();    
            disable(false);
            ShowStaff();
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
        public void SetCbb()
        {
            cbbPOSITION_DETAIL.Items.Add("Tất cả");
            cbbPOSITION_DETAIL.Items.AddRange(BLL_STAFF.Instance.GetListPosition().Distinct().ToArray());
            cbbPOSITION.Items.Add("None");
            cbbPOSITION.Items.AddRange(BLL_STAFF.Instance.GetListPosition().Distinct().ToArray());
            cbbPOSITION_DETAIL.SelectedIndex = cbbPOSITION.SelectedIndex = 0;
        }
        public void ShowStaff()
        {
            if (cbbPOSITION_DETAIL.SelectedIndex == 0)
            {
                var getStaff = DB.tblNhanViens.Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = getStaff.ToList();
            }
            else
            {
                var getStaff = DB.tblNhanViens.Where(p => p.ViTri == cbbPOSITION_DETAIL.SelectedItem.ToString()).Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong
                });
                dgvLIST_STAFF.DataSource = getStaff.ToList();
            }
            txtID_STAFF.Clear();
            txtNAME_STAFF.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
            txtSALARY.Clear();
            cbbPOSITION.SelectedIndex = 0;
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListStaff";
            for (int i = 1; i <= dgvLIST_STAFF.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_STAFF.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLIST_STAFF.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLIST_STAFF.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLIST_STAFF.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Staff";
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
            disable(true);
            isAdd = true;
            txtID_STAFF.Text = BLL_STAFF.Instance.GetNewIdStaff().ToString();
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
            isAdd = false;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhanVien staff = new tblNhanVien();
            staff.MaNhanVien = txtID_STAFF.Text;
            staff.TenNhanVien = txtNAME_STAFF.Text;
            staff.ViTri = cbbPOSITION.SelectedItem.ToString();
            staff.NgaySinh = Convert.ToDateTime(dpDAY.Value.ToShortDateString());
            if(rbMALE.Checked == true)
            {
                staff.GioiTinh = true;
            }
            else
            {
                staff.GioiTinh = false;
            }
            staff.SoDienThoai = txtPHONE.Text;
            staff.DiaChi = txtADDRESS.Text;
            staff.Luong = txtSALARY.Text;
            if(string.IsNullOrEmpty(staff.MaNhanVien) || string.IsNullOrEmpty(staff.TenNhanVien) || string.IsNullOrEmpty(staff.SoDienThoai) || 
                string.IsNullOrEmpty(staff.DiaChi) || string.IsNullOrEmpty(staff.Luong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        BLL_STAFF.Instance.FuncAddNewStaff(staff); // add new staff
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(false);
                        ShowStaff();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số nhân viên bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable(true);
                    }
                }
                else
                {
                    BLL_STAFF.Instance.FuncEditStaff(staff); // edit staff
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable(false);
                    ShowStaff();
                }
                
            } 
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdStaff = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_STAFF.SelectedRows;
            foreach(DataGridViewRow dataGvr in data)
            {
                listIdStaff.Add(dataGvr.Cells["MaNhanVien"].Value.ToString());
            }
            DialogResult question = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                BLL_STAFF.Instance.FuncDeleteStaff(listIdStaff); // delete staff
                ShowStaff();
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

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (rbID_STAFF.Checked == true)
            {
                BLL_STAFF.Instance.FuncSearchID(dgvLIST_STAFF, txtSEARCH.Text.Trim()); // search id 
            }
            else
            {
                BLL_STAFF.Instance.FuncSearchName(dgvLIST_STAFF, txtSEARCH.Text.Trim()); // search name
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
                FrmManage_Data frm = new FrmManage_Data();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
        private void dgvLIST_STAFF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_STAFF.Text = dgvLIST_STAFF.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
            txtNAME_STAFF.Text = dgvLIST_STAFF.SelectedRows[0].Cells["TenNhanVien"].Value.ToString();
            cbbPOSITION.Text = dgvLIST_STAFF.SelectedRows[0].Cells["ViTri"].Value.ToString();
            dpDAY.Value = (DateTime)dgvLIST_STAFF.SelectedRows[0].Cells["NgaySinh"].Value;
            txtPHONE.Text = dgvLIST_STAFF.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtADDRESS.Text = dgvLIST_STAFF.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtSALARY.Text = String.Format("{0:n0}", dgvLIST_STAFF.SelectedRows[0].Cells["Luong"].Value);
            if (Convert.ToBoolean(dgvLIST_STAFF.SelectedRows[0].Cells["GioiTinh"].Value.ToString()) == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
    }
}
