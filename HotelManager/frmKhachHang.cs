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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadData();
            showHideControl(true);
            _enable(false);
        }
        bool _them;
        void _enable(bool t)
        {
            txtHoTen.Enabled = t;
            txtCCCD.Enabled = t;
            txtPhone.Enabled = t;
            txtDiaChi.Enabled = t;
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
        private void clearText()
        {

            txtHoTen.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbKhachHangs.Select(x => new
                {
                    x.Hoten,
                    x.Cccd,
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
            showHideControl(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var context = new HotelManageContext();

            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvData.SelectedRows.Count == 1)
                {
                    string hoten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var khachHang = context.TbKhachHangs.FirstOrDefault(kh=>kh.Hoten.Equals(hoten));
                    var phongdat = context.TbDatPhongs.FirstOrDefault(p => p.Idkh == khachHang.Idkh);
                    if (khachHang != null)
                    {
                        context.TbDatPhongs.Remove(phongdat);
                        context.TbKhachHangs.Remove(khachHang);
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
                var khachHang = new TbKhachHang
                {
                    Hoten = txtHoTen.Text,
                    Cccd = txtCCCD.Text,
                    Diachi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    Dienthoai = txtPhone.Text,

                };
                context.TbKhachHangs.Add(khachHang);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {

                    string hoten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var khachHang = context.TbKhachHangs.FirstOrDefault(kh => kh.Hoten.Equals(hoten));
                    if (khachHang != null)
                    {
                        khachHang.Hoten = hoten;
                        khachHang.Cccd = txtCCCD.Text;
                        khachHang.Cccd = txtCCCD.Text;
                        khachHang.Email = txtEmail.Text;
                        khachHang.Dienthoai = txtPhone.Text;
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
                string hoten = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var khachHang = context.TbKhachHangs.FirstOrDefault(kh => kh.Hoten.Equals(hoten));
                if (khachHang != null)
                {
                    txtHoTen.Text = khachHang.Hoten;
                    txtCCCD.Text = khachHang.Cccd;
                    txtDiaChi.Text = khachHang.Diachi;
                    txtEmail.Text = khachHang.Email;
                    txtPhone.Text = khachHang.Dienthoai;
                }
            }
        }
    }
}
