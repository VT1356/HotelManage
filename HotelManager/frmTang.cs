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
    public partial class frmTang : Form
    {
        public frmTang()
        {
            InitializeComponent();
            LoadData();
            showHideControl(true);
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtTentang.Enabled = t;
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
            txtTentang.Text = string.Empty;

        }
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbTangs.Select(x => new
                {
                    x.Tentang,

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
            showHideControl(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var context = new HotelManageContext();

            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvData.SelectedRows.Count == 1)
                {
                    string ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var tang = context.TbTangs.FirstOrDefault(kh => kh.Tentang.Equals(ten));

                    if (tang != null)
                    {
                        context.TbTangs.Remove(tang);
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
                var tang = new TbTang
                {
                    Tentang = txtTentang.Text,
        

                };
                context.TbTangs.Add(tang);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {

                    string ten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var tang = context.TbTangs.FirstOrDefault(kh => kh.Tentang.Equals(ten));
                    if (tang != null)
                    {
                        tang.Tentang = txtTentang.Text;
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
                string tentang = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var t = context.TbTangs.FirstOrDefault(t => t.Tentang.Equals(tentang));
                if (t!= null)
                {
                    txtTentang.Text=t.Tentang;
                }
            }
        }
    }
}
