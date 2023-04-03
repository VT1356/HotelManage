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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
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
            nudDongia.Enabled = t;

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
                dgvData.DataSource = context.TbSanPhams.Select(x => new
                {
                    x.Tensp,
                    x.Dongia

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
                    string tensp = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var sp = context.TbSanPhams.FirstOrDefault(sp=>sp.Tensp.Equals(tensp));

                    if (sp != null)
                    {
                        context.TbSanPhams.Remove(sp);
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
                var sanPham = new TbSanPham
                {
                    Tensp = txtName.Text,
                    Dongia =(double) nudDongia.Value,
              

                };
                context.TbSanPhams.Add(sanPham);
                context.SaveChanges();
            }
            else
            {

                if (dgvData.SelectedRows.Count == 1)
                {
                    string tensp = (string)dgvData.SelectedRows[0].Cells[0].Value;
                    var sanPham = context.TbSanPhams.FirstOrDefault(sp=>sp.Tensp.Equals(tensp));
                    if (sanPham != null)
                    {
                        sanPham.Tensp = txtName.Text;
                        sanPham.Dongia =(double) nudDongia.Value;
                        
               
                        context.SaveChanges();
                    }
                }
            }
            clearText();
            _them = false;
            LoadData();
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
                string tensp = (string)dgvData.SelectedRows[0].Cells[0].Value;
                var sanPham = context.TbSanPhams.FirstOrDefault(sp => sp.Tensp.Equals(tensp));
                if (sanPham != null)
                {
                    txtName.Text = sanPham.Tensp;
                    nudDongia.Value =(decimal) sanPham.Dongia;
                }
            }
        }
        private void clearText()
        {

            txtName.Text = string.Empty;
            nudDongia.Value = 0;          
        }
    }
}
