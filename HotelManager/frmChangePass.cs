using HotelManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        public frmChangePass(TbSysUser user)
        {
            InitializeComponent();
            this.user = user;
        }
        TbSysUser user;
        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = new HotelManageContext();
            if (user.Passwd.Equals(txtMKcu)!=true)
            {
                MessageBox.Show("Mật Khẩu Không Chính Xác  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                if (txtMKmoi.Text.Equals(txtMKmoi1.Text))
            {
                user.Passwd= txtMKmoi.Text;
                context.SaveChanges();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
