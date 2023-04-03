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
    public partial class frmDonVi : Form
    {
        public frmDonVi()
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
            txtMa.Enabled = t;
            txtDiachi.Enabled = t;
            txtEmail.Enabled = t;
            txtPhone.Enabled = t;
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
                dgvData.DataSource = context.TbDonVis.Select(x => new
                {
                    x.Madvi,
                    x.Macty,   
                    x.Tendvi,
                    x.Dienthoai,
                    x.Email,
                    x.Diachi
                }).ToList();
                Loadcty();

            }
        }
        private void Loadcty()
        {
            using (var context = new HotelManageContext())
            {
                cbCty.DataSource = context.TbCongTies.Select(x => new
                {
                    x.Tencty,
                    x.Macty

                }).ToList();
                cbCty.DisplayMember = "Tencty";
                cbCty.ValueMember = "Macty";


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
                    string madvi = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var dvi = context.TbDonVis.Find(madvi);
                                            if (dvi != null)
                    {
                        context.TbDonVis.Remove(dvi);
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
                var donVi = new TbDonVi
                {
                    Macty = cbCty.SelectedValue.ToString(),
                    Madvi = txtMa.Text,
                    Tendvi = txtName.Text,
                    Diachi = txtDiachi.Text,
                    Email = txtEmail.Text,
                    Dienthoai = txtPhone.Text,

                };
                context.TbDonVis.Add(donVi);
                context.SaveChanges();
                clearText();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {
                    string madvi = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var donVi = context.TbDonVis.Find(madvi);
                    if (donVi != null)
                    {
                        donVi.Madvi = madvi;
                        donVi.Macty = cbCty.SelectedValue.ToString();
                        donVi.Tendvi = txtName.Text;
                        donVi.Diachi = txtDiachi.Text;
                        donVi.Email = txtEmail.Text;
                        donVi.Dienthoai = txtPhone.Text;
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
                string madvi = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var donVi = context.TbDonVis.Find(madvi);
                if (donVi != null)
                {
                    txtMa.Text = donVi.Madvi;
                    cbCty.SelectedItem = donVi.Macty;
                    txtName.Text = donVi.Tendvi;
                    txtDiachi.Text = donVi.Diachi;
                    txtEmail.Text = donVi.Email;
                    txtPhone.Text = donVi.Dienthoai;
                }
            }
        }
        private void clearText()
        {

            txtMa.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbDisabled.Checked = false;
        }

      
    }
}
