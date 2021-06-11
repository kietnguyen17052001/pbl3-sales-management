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
    public partial class FrmIntroduce : Form
    {
        private bool isAdmin;
        private string idStaff;
        public FrmIntroduce(bool _isAdmin, string _idStaff)
        {
            isAdmin = _isAdmin;
            idStaff = _idStaff;
            InitializeComponent();
        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frm = new FrmMain_Admin();
                frm.Show();
            }
            else
            {
                FrmMain_Member frm = new FrmMain_Member(idStaff);
                frm.Show();
            }
            this.Close();
        }
    }
}
