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

namespace SaleManagement
{
    public partial class FrmSale_Management : Form
    {
        public FrmSale_Management()
        {
            InitializeComponent();
        }

        private void btnQuanLyDuLieu_Click(object sender, EventArgs e)
        {
            FrmManage_Data Frm = new FrmManage_Data();
            Frm.Show();
            this.Hide();
        }
    }
}
