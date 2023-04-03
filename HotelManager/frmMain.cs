using HotelManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HotelManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        public frmMain(TbSysUser User)
        {
            InitializeComponent();
            LoadData();
            this.User = User;
            _enalbe(User);
        }
        TbSysUser User;

        public void _enalbe(TbSysUser User)
        {
            if (User.Isgroup == true)
            {
                danhMucCongTyToolStripMenuItem.Enabled = true;
                danhMucDonViToolStripMenuItem.Enabled = true;
                danhMucLoaiPhongToolStripMenuItem.Enabled = true;
                danhMucPhongToolStripMenuItem.Enabled = true;
                danhMucTangToolStripMenuItem.Enabled = true;
                quanLyDatPhongToolStripMenuItem.Enabled = true;
                quanLyKhacHangToolStripMenuItem.Enabled = true;
                quanLySanPhamToolStripMenuItem.Enabled = true;
                quanLyThietBiToolStripMenuItem.Enabled = true;
                quanLyThietBiTrongPhongToolStripMenuItem.Enabled = true;
                quanLyNguoiDungToolStripMenuItem.Enabled = true;

            }
            else
            {
                danhMucCongTyToolStripMenuItem.Enabled = true;
                danhMucDonViToolStripMenuItem.Enabled = true;
                danhMucLoaiPhongToolStripMenuItem.Enabled = true;
                danhMucPhongToolStripMenuItem.Enabled = true;
                danhMucTangToolStripMenuItem.Enabled = true;
                quanLyDatPhongToolStripMenuItem.Enabled = true;
                quanLyKhacHangToolStripMenuItem.Enabled = true;
                quanLySanPhamToolStripMenuItem.Enabled = true;
                quanLyThietBiToolStripMenuItem.Enabled = false;
                quanLyThietBiTrongPhongToolStripMenuItem.Enabled = false;
                quanLyKhacHangToolStripMenuItem.Enabled=false;
            }
        }
        private void LoadData()
        {
            using (var context = new HotelManageContext())
            {
                dgvData.DataSource = context.TbPhongs.Include(p => p.TbTang).Select(x => new
                {
                    x.TbTang.Tentang,
                    x.Tenphong,
                    x.Trangthai,
                }).ToList();


            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

        }

        private void DANHMUCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucCongTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongTy frm = new frmCongTy();
            frm.ShowDialog();
        }

        private void danhMucDonViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonVi frm = new frmDonVi();
            frm.ShowDialog();
        }

        private void danhMucLoaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frm = new frmLoaiPhong();
            frm.ShowDialog();
        }

        private void quanLyThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThietBi frm = new frmThietBi();
            frm.ShowDialog();
        }

        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.ShowDialog();
        }

        private void quanLyKhacHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void danhMucTangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTang frm = new frmTang();
            frm.ShowDialog();
        }

        private void quanLyDatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong(User);
            frm.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(User);
            frm.ShowDialog();
        }

        private void quanLyNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }
    }
}