using HotelManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            LoadData();
            showHideControl(true);
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtName.Enabled = t;
      
        }
        void showHideControl(bool t)
        {
            btnAdd.Visible = t;
            btnDelete.Visible = t;
            btnEdit.Visible = t;
            btnExit.Visible = t;
            btnSave.Visible = !t;
            btnCancle.Visible = !t;
        }
        private void clearText()
        {

            txtName.Text = string.Empty;
        
        }
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbSysUsers.Where(x=>x.Isgroup==false).Select(x => new
                {
                    x.Fullname,
                    x.Username,
                    x.Passwd,
                    x.Disabled
                }).ToList();
                Loadcty();
                Loaddv();
            }
        }
        private void Loadcty()
        {
            using (var context = new HotelManageContext())
            {
                cbMacty.DataSource = context.TbCongTies.Select(x => new
                {
                    x.Tencty,
                    x.Macty

                }).ToList();
                cbMacty.DisplayMember = "Tencty";
                cbMacty.ValueMember = "Macty";


            }
        }
        private void Loaddv()
        {
            using (var context = new HotelManageContext())
            {
                cbMadv.DataSource = context.TbDonVis.Select(x => new
                {
                    x.Madvi,
                    x.Tendvi

                }).ToList();
                cbMadv.DisplayMember = "Tendvi";
                cbMadv.ValueMember = "Madvi";


            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _them = true;
            _enable(true);

            showHideControl(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);

            showHideControl(false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var context = new HotelManageContext();

            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvData.SelectedRows.Count == 1)
                {
                    string Ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var user = context.TbSysUsers.FirstOrDefault(u=>u.Fullname.Equals(Ten));
                    if (user != null)
                    {
                        context.TbSysUsers.Remove(user);
                        context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = new HotelManageContext();
            if (_them)
            {
                var user = new TbSysUser
                {
                    Macty = cbMacty.SelectedValue.ToString(),
                    Madvi = cbMadv.SelectedValue.ToString(),
                    Fullname = txtName.Text,
                    Disabled = cbDisable.Checked
                };
                context.TbSysUsers.Add(user);
                context.SaveChanges();
                clearText();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {
                    string Ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var user = context.TbSysUsers.FirstOrDefault(u => u.Fullname.Equals(Ten));
                    if (user != null)
                    {
                        user.Madvi = cbMadv.SelectedValue.ToString();
                        user.Macty = cbMacty.SelectedValue.ToString();
                        user.Fullname = txtName.Text;
                        user.Disabled = cbDisable.Checked;
                        context.SaveChanges();
                    }
                }
            }
            _them = false;
            LoadData();
            showHideControl(true);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();

            if (dgvData.SelectedRows.Count == 1)
            {
                string Ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var user = context.TbSysUsers.FirstOrDefault(u => u.Fullname.Equals(Ten));
                if (user != null)
                {
                    cbMacty.SelectedItem = user.Madvi;
                    cbMacty.SelectedItem = user.Macty;
                    txtName.Text = user.Fullname;
                    cbDisable.Checked = user.Disabled.HasValue && user.Disabled.Value;
                }
            }
        }
    }
}
