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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
            LoadData();
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtTenLoaiPhong.Enabled = t;
            nudDongia.Enabled = t;
            nudSoluong.Enabled = t;
            nudSonguoi.Enabled = t;
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
                dgvData.DataSource = context.TbLoaiPhongs.Select(x => new
                {
                    x.Tenloaiphong,
                    x.Dongia,
                    x.Songuoi,
                    x.Soluong,

                }).ToList();


            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    string tenloaiphong = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var loaiphong = context.TbLoaiPhongs.FirstOrDefault(lp=>lp.Tenloaiphong.Equals(tenloaiphong));

                    if (loaiphong != null)
                    {
                        context.TbLoaiPhongs.Remove(loaiphong);
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
                var loaiphong = new TbLoaiPhong
                {
                    Tenloaiphong = txtTenLoaiPhong.Text,
                    Dongia = (double)nudDongia.Value,
                    Songuoi = (int)nudSonguoi.Value,
                    Soluong = (int)nudSoluong.Value

                };
                context.TbLoaiPhongs.Add(loaiphong);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {

                    string tenloaiphong = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var loaiphong = context.TbLoaiPhongs.Find(tenloaiphong);
                    if (loaiphong != null)
                    {
                        loaiphong.Tenloaiphong = tenloaiphong;
                        loaiphong.Dongia = (double)nudDongia.Value;
                        loaiphong.Songuoi = (int)nudSonguoi.Value;
                        loaiphong.Soluong = (int)nudSoluong.Value;


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
        private void clearText()
        {

            txtTenLoaiPhong.Text = string.Empty;
            nudDongia.Text = string.Empty;
            nudSoluong.Text = string.Empty;
            nudSonguoi.Text = string.Empty;
            cbDisabled.Checked = false;
        }



        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();
            if (dgvData.SelectedRows.Count == 1)
            {

                int id = (int)dgvData.SelectedRows[0].Cells[0].Value;
                var loaiphong = context.TbLoaiPhongs.Find(id);
                if (loaiphong != null)
                {
                    txtTenLoaiPhong.Text = loaiphong.Tenloaiphong;
                    nudDongia.Value = (decimal)loaiphong.Dongia;
                    nudSonguoi.Value = (decimal)loaiphong.Songuoi;
                    nudSoluong.Value = loaiphong.Soluong;

                }
            }
        }
    }
}
