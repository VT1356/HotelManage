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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = txtName.Text.Trim();
            string password = txtPass.Text.Trim();

            using (var context = new HotelManageContext())
            {
                var user = context.TbSysUsers.FirstOrDefault(u => u.Username == username && u.Passwd == password);
                if (user == null)
                {
                    MessageBox.Show("Tài Khoản khoản mật khẩu không đúng  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    frmMain frm = new frmMain(user);
                    frm.ShowDialog();
                    this.Hide();
                }
            }

         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
