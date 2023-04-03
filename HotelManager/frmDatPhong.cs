using HotelManager.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();



        }
        public frmDatPhong(TbSysUser User)
        {
            InitializeComponent();
   
            LoadDatafrm();
            groupBox2.Visible = true;
            showHideControl(true);
            this.User = User;


        }
        TbSysUser User;

        bool _them;
        //private DataGridViewRow rowToMove;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        void _enable(bool t)
        {


        }
        void LoadDatafrm()
        {
            dtpNgaytra.Value = DateTime.Now;
            LoadKH();
            LoadSP();
            LoadData();
            TotalMoney();
            LoadDataSp_Phong();


        }
        void LoadKH()
        {
            using (var context = new HotelManageContext())
            {
                cbKH.DataSource = context.TbKhachHangs.Select(x => new
                {
                    x.Idkh,
                    x.Hoten

                }).ToList();
                cbKH.DisplayMember = "Hoten";
                cbKH.ValueMember = "Idkh";


            }
        }
        void LoadSP()
        {
            using (var context = new HotelManageContext())
            {
                dgvSpDv.DataSource = context.TbSanPhams.Select(x => new
                {
                    x.Tensp,
                    x.Dongia

                }).ToList();
            }
        }
     
        private void LoadData()
        {
            using (var db = new HotelManageContext())
            {
                var phongTrongs = db.TbPhongs.Include(p => p.TbTang).Include(p => p.TbLoaiPhong).Where(p => p.Trangthai == true).Select(p => new { p.Tenphong, p.TbTang.Tentang, p.TbLoaiPhong.Dongia }).ToList();
                dgvPhongtrong.DataSource = phongTrongs;

                var phongDats = db.TbPhongs.Include(p => p.TbTang).Include(p => p.TbLoaiPhong).Where(p => p.Trangthai == false).Select(p => new { p.Tenphong, p.TbLoaiPhong.Dongia }).ToList();
                dgvPhongdat.DataSource = phongDats;
                var spsd = db.TbSanPhams.Select(p => new { p.Tensp, p.Dongia });
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

        private void LoadDataSp_Phong()
        {
            using (var context = new HotelManageContext())
            {
                var sanPhamDatPhong = context.TbSanPhams
       .Join(context.TbDatPhongs, x => x.Idsp, y => y.Idsp, (x, y) => new { x, y })
       .Join(context.TbPhongs, xy => xy.y.Idphong, z => z.Idphong, (xy, z) => new { xy.x, xy.y, z })
       .GroupBy(xyz => new { xyz.x.Idsp, xyz.x.Tensp, xyz.x.Dongia, xyz.z.Tenphong })
       .Select(g => new
       {
           g.Key.Tenphong,
           g.Key.Tensp,
           g.Key.Dongia,
           SoLuong = g.Count()
       })
       .ToList();


                dgcSP.DataSource = sanPhamDatPhong;

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
            //var context = new HotelManageContext();

            //if (MessageBox.Show("Bạn có hủy đặt phòng này không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    if (dgvPhongdat.SelectedRows.Count == 1)
            //    {
            //        string ten = (string)dgvPhongdat.SelectedRows[0].Cells[0].Value;
            //        var phong = context.TbPhongs.FirstOrDefault(p => p.Tenphong.Equals(ten));
            //        if (phong != null)
            //        {
            //            phong.Trangthai = true;

            //            context.SaveChanges();
            //            LoadDatafrm();
            //        }
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var context = new HotelManageContext();
            if (_them)
            {
                var selectedKH = cbKH.SelectedItem as dynamic;
                int idKH = (int)selectedKH.Idkh;
                var khachHang = context.TbDatPhongs.FirstOrDefault(kh => kh.Idkh == idKH);
                var phongdat = new TbDatPhong();

                if (khachHang != null)
                {


                    khachHang.Ngaydat = dtpNgaydat.Value;
                    khachHang.Ngaytra = dtpNgaytra.Value;
                    khachHang.Uid = User.Uid;
                    //khachHang.Macty = User.Macty;
                    //khachHang.Madvi= User.Madvi;
                    khachHang.Songayo = (int)(dtpNgaytra.Value - dtpNgaydat.Value).TotalDays;
                    context.SaveChanges();
                }
                else
                {

                    phongdat.Idkh = idKH;
                    phongdat.Ngaydat = dtpNgaydat.Value;
                    phongdat.Ngaytra = dtpNgaytra.Value;
                    phongdat.Uid = User.Uid;
                    phongdat.Songayo = (int)(dtpNgaytra.Value - dtpNgaydat.Value).TotalDays;
                    context.TbDatPhongs.Add(phongdat);

                    context.SaveChanges();
                }

            }

            _them = false;
            LoadDatafrm();
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

        private void btnAddKh_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }



        private void dgvPhongtrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();


            if (dgvPhongtrong.SelectedRows.Count == 1)
            {
                string ten = (string)dgvPhongtrong.SelectedRows[0].Cells[0].Value;
                var phong = context.TbPhongs.FirstOrDefault(p => p.Tenphong.Equals(ten));
                if (phong != null)
                {
                    phong.Trangthai = false;

                    context.SaveChanges();
                    LoadDatafrm();
                }
            }

        }

        private void dgvPhongdat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();
            if (dgvPhongdat.SelectedRows.Count == 1)
            {
                string ten = (string)dgvPhongdat.SelectedRows[0].Cells[0].Value;
                var phong = context.TbPhongs.FirstOrDefault(p => p.Tenphong.Equals(ten));
                if (phong != null)
                {

                    context.SaveChanges();
                    LoadDatafrm();
                }
            }
        }
        private void TotalMoney()
        {
            using (var context = new HotelManageContext())
            {
                var selectedKH = cbKH.SelectedItem as dynamic;
                int idKH = (int)selectedKH.Idkh;
                var datPhong = context.TbDatPhongs.FirstOrDefault(kh => kh.Idkh == idKH);
                DateTime ngayDat = dtpNgaydat.Value;
                DateTime ngayTra = dtpNgaytra.Value;
                TimeSpan? soNgay = ngayTra - ngayDat;
                double tongTien = 0;

           
                if (dgvPhongdat.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPhongdat.Rows)
                    {
                        double giaphong = Convert.ToDouble(row.Cells["DonGia"].Value);
                        tongTien +=  giaphong;
                    }
                }

                if (dgcSP.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgcSP.Rows)
                    {
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        double giaSp = Convert.ToDouble(row.Cells["DonGia"].Value);
                        tongTien += soLuong * giaSp;
                    }
                }
                nudTongtien.Value = (decimal)tongTien;
            }
        }
        private void dgcSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgcSP.SelectedRows.Count == 1)
            {
                var selectedRow = dgcSP.SelectedRows[0];
                string tenPhong = selectedRow.Cells["Tenphong"].Value.ToString();
                string tenSanPham = selectedRow.Cells["Tensp"].Value.ToString();

                using (var context = new HotelManageContext())
                {
                    var sanPham = context.TbSanPhams
                        .SingleOrDefault(sp => sp.Tensp == tenSanPham);

                    if (sanPham != null)
                    {
                        var phong = context.TbDatPhongs.FirstOrDefault(p => p.Idsp == sanPham.Idsp);
                        if (phong != null)
                        {
                            context.TbDatPhongs.Remove(phong);
                            context.SaveChanges();
                            LoadDataSp_Phong();
                        }
                    }
                }
            }
        }

        private void dgvSpDv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();

            if (dgvSpDv.SelectedRows.Count == 1 && dgvPhongdat.SelectedRows.Count == 1)
            {
                string tenSp = (string)dgvSpDv.SelectedRows[0].Cells["Tensp"].Value;
                var sp = context.TbSanPhams.FirstOrDefault(p => p.Tensp.Equals(tenSp));

                string tenPhong = (string)dgvPhongdat.SelectedRows[0].Cells["Tenphong"].Value;
                var phong = context.TbPhongs.FirstOrDefault(p => p.Tenphong.Equals(tenPhong));

                if (sp != null && phong != null)
                {
                    var datPhong = new TbDatPhong
                    {
                        Idsp = sp.Idsp,
                        Idphong = phong.Idphong
                    };

                    context.TbDatPhongs.Add(datPhong);
                    context.SaveChanges();

                    LoadDataSp_Phong();
                }
            }
        }

        private void dgvPhongdat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelManageContext();
            if (dgvPhongdat.SelectedRows.Count == 1)
            {
                string ten = (string)dgvPhongdat.SelectedRows[0].Cells[0].Value;
                var phong = context.TbPhongs.FirstOrDefault(p => p.Tenphong.Equals(ten));
                if (phong != null)
                {
                    phong.Trangthai = true;
                    context.SaveChanges();
                    LoadDatafrm();
                }
            }
        }
    }
}