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
using System.Xml.Linq;

namespace HotelManager
{
    public partial class frmThietBi : Form
    {
        public frmThietBi()
        {
            InitializeComponent();
            LoadData();
            showHideControl(true);
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtTenTB.Enabled = t;
            nudDongia.Enabled = t;

        }
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbThietBis.Select(x => new
                {
                    x.Tentb,
                    x.Dongia,
                }).ToList();


            }
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
                    string tentb = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var thietBi = context.TbThietBis.Find(tentb);

                    if (thietBi != null)
                    {
                        context.TbThietBis.Remove(thietBi);
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
                var tb = new TbThietBi
                {
                    Tentb = txtTenTB.Text,
                    Dongia = (double)nudDongia.Value,


                };
                context.TbThietBis.Add(tb);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {
                    string ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var tb = context.TbThietBis.Find(ten);
                    if (tb != null)
                    {
                        tb.Tentb = txtTenTB.Text;
                        tb.Dongia = (double)nudDongia.Value;

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
                string ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var tb = context.TbThietBis.FirstOrDefault(tb => tb.Tentb == ten);
                if (tb != null)
                {
                    txtTenTB.Text = tb.Tentb;
                    nudDongia.Value = (decimal)tb.Dongia;
                }
            }
        }
        private void clearText()
        {
            txtTenTB.Text = string.Empty;
            nudDongia.Text = string.Empty;
        }
    }
}
