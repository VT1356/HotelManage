using HotelManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelManager
{
    public partial class frmCongTy : Form
    {
        public frmCongTy()
        {
            InitializeComponent();
            LoadData();
            showHideControl(true);
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtMaCty.Enabled = t;
            txtName.Enabled = t;
            txtPhone.Enabled = t;
            txtDiachi.Enabled = t;
            txtEmail.Enabled = t;
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
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbCongTies.Select(x => new
                {
                    x.Macty,
                    x.Tencty,
                    x.Dienthoai,
                    x.Email,
                    x.Diachi
                }).ToList();


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

            txtMaCty.Enabled = false;
            showHideControl(false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var context = new HotelManageContext();

            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvData.SelectedRows.Count == 1)
                {
                    string macty = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var cty = context.TbCongTies.Find(macty);

                    if (cty != null)
                    {
                        context.TbCongTies.Remove(cty);
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
                var congTy = new TbCongTy
                {
                    Macty = txtMaCty.Text,
                    Tencty = txtName.Text,
                    Diachi = txtDiachi.Text,
                    Email = txtEmail.Text,
                    Dienthoai = txtPhone.Text,
                    Disabled = cbDisabled.Checked

                };
                context.TbCongTies.Add(congTy);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {
                    string macty = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var cty = context.TbCongTies.Find(macty);
                    if (cty != null)
                    {
                        cty.Macty = macty;
                        cty.Tencty = txtName.Text;
                        cty.Diachi = txtDiachi.Text;
                        cty.Email = txtEmail.Text;
                        cty.Dienthoai = txtPhone.Text;
                        cty.Disabled = cbDisabled.Checked;
                        context.SaveChanges();
                    }
                }
            }
            clearText();
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
                string macty = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var cty = context.TbCongTies.Find(macty);
                if (cty != null)
                {
                    txtMaCty.Text = cty.Macty;
                    txtName.Text = cty.Tencty;
                    txtDiachi.Text = cty.Diachi;
                    txtEmail.Text = cty.Email;
                    txtPhone.Text = cty.Dienthoai;
                    cbDisabled.Checked = cty.Disabled.Value;
                }
            }
        }
        private void clearText()
        {

            txtMaCty.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbDisabled.Checked = false;
        }
    }
}
