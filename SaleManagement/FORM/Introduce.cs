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
        public FrmIntroduce(bool _isAdmin)
        {
            isAdmin = _isAdmin;
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
                FrmMain_Member frm = new FrmMain_Member();
                frm.Show();
            }
            this.Close();
        }
    }
}
