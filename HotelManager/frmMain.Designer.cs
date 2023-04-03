namespace HotelManager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnHome = new ToolStripButton();
            btnBaocao = new ToolStripButton();
            btnExit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            splitContainer1 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            DANHMUCToolStripMenuItem = new ToolStripMenuItem();
            dANHMUCToolStripMenuItem1 = new ToolStripMenuItem();
            danhMucCongTyToolStripMenuItem = new ToolStripMenuItem();
            danhMucDonViToolStripMenuItem = new ToolStripMenuItem();
            danhMucTangToolStripMenuItem = new ToolStripMenuItem();
            danhMucLoaiPhongToolStripMenuItem = new ToolStripMenuItem();
            danhMucPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyDatPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLySanPhamToolStripMenuItem = new ToolStripMenuItem();
            quanLyThietBiToolStripMenuItem = new ToolStripMenuItem();
            quanLyThietBiTrongPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyKhacHangToolStripMenuItem = new ToolStripMenuItem();
            dANHMUCToolStripMenuItem2 = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            quanLyNguoiDungToolStripMenuItem = new ToolStripMenuItem();
            dgvData = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripMargin = new Padding(5);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnHome, btnBaocao, btnExit, toolStripSeparator1 });
            toolStrip1.Location = new Point(5, 5);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(877, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnHome
            // 
            btnHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHome.Image = Properties.Resources.Home;
            btnHome.ImageTransparentColor = Color.Magenta;
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(24, 24);
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // btnBaocao
            // 
            btnBaocao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBaocao.Image = Properties.Resources.ThongKe;
            btnBaocao.ImageTransparentColor = Color.Magenta;
            btnBaocao.Name = "btnBaocao";
            btnBaocao.Size = new Size(24, 24);
            btnBaocao.Text = "Bao Cao";
            btnBaocao.Click += btnBaocao_Click;
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = Properties.Resources.Thoat;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 24);
            btnExit.Text = "Thoat";
            btnExit.Click += btnExit_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvData);
            splitContainer1.Size = new Size(877, 428);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { DANHMUCToolStripMenuItem, dANHMUCToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(292, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DANHMUCToolStripMenuItem
            // 
            DANHMUCToolStripMenuItem.Name = "DANHMUCToolStripMenuItem";
            DANHMUCToolStripMenuItem.Size = new Size(12, 20);
            DANHMUCToolStripMenuItem.Click += DANHMUCToolStripMenuItem_Click;
            // 
            // dANHMUCToolStripMenuItem1
            // 
            dANHMUCToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { danhMucCongTyToolStripMenuItem, danhMucDonViToolStripMenuItem, danhMucTangToolStripMenuItem, danhMucLoaiPhongToolStripMenuItem, danhMucPhongToolStripMenuItem, quanLyDatPhongToolStripMenuItem, quanLySanPhamToolStripMenuItem, quanLyThietBiToolStripMenuItem, quanLyThietBiTrongPhongToolStripMenuItem, quanLyKhacHangToolStripMenuItem, dANHMUCToolStripMenuItem2, doiMatKhauToolStripMenuItem, quanLyNguoiDungToolStripMenuItem });
            dANHMUCToolStripMenuItem1.Name = "dANHMUCToolStripMenuItem1";
            dANHMUCToolStripMenuItem1.Size = new Size(83, 20);
            dANHMUCToolStripMenuItem1.Text = "DANH MUC";
            // 
            // danhMucCongTyToolStripMenuItem
            // 
            danhMucCongTyToolStripMenuItem.Name = "danhMucCongTyToolStripMenuItem";
            danhMucCongTyToolStripMenuItem.Size = new Size(225, 22);
            danhMucCongTyToolStripMenuItem.Text = "Danh muc cong ty";
            danhMucCongTyToolStripMenuItem.Click += danhMucCongTyToolStripMenuItem_Click;
            // 
            // danhMucDonViToolStripMenuItem
            // 
            danhMucDonViToolStripMenuItem.Name = "danhMucDonViToolStripMenuItem";
            danhMucDonViToolStripMenuItem.Size = new Size(225, 22);
            danhMucDonViToolStripMenuItem.Text = "Danh muc don vi";
            danhMucDonViToolStripMenuItem.Click += danhMucDonViToolStripMenuItem_Click;
            // 
            // danhMucTangToolStripMenuItem
            // 
            danhMucTangToolStripMenuItem.Name = "danhMucTangToolStripMenuItem";
            danhMucTangToolStripMenuItem.Size = new Size(225, 22);
            danhMucTangToolStripMenuItem.Text = "Quan ly tang";
            danhMucTangToolStripMenuItem.Click += danhMucTangToolStripMenuItem_Click;
            // 
            // danhMucLoaiPhongToolStripMenuItem
            // 
            danhMucLoaiPhongToolStripMenuItem.Name = "danhMucLoaiPhongToolStripMenuItem";
            danhMucLoaiPhongToolStripMenuItem.Size = new Size(225, 22);
            danhMucLoaiPhongToolStripMenuItem.Text = "Quan ly loai phong";
            danhMucLoaiPhongToolStripMenuItem.Click += danhMucLoaiPhongToolStripMenuItem_Click;
            // 
            // danhMucPhongToolStripMenuItem
            // 
            danhMucPhongToolStripMenuItem.Name = "danhMucPhongToolStripMenuItem";
            danhMucPhongToolStripMenuItem.Size = new Size(225, 22);
            danhMucPhongToolStripMenuItem.Text = "Quan ly phong";
            // 
            // quanLyDatPhongToolStripMenuItem
            // 
            quanLyDatPhongToolStripMenuItem.Name = "quanLyDatPhongToolStripMenuItem";
            quanLyDatPhongToolStripMenuItem.Size = new Size(225, 22);
            quanLyDatPhongToolStripMenuItem.Text = "Quan ly dat phong";
            quanLyDatPhongToolStripMenuItem.Click += quanLyDatPhongToolStripMenuItem_Click;
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            quanLySanPhamToolStripMenuItem.Size = new Size(225, 22);
            quanLySanPhamToolStripMenuItem.Text = "Quan ly san pham";
            quanLySanPhamToolStripMenuItem.Click += quanLySanPhamToolStripMenuItem_Click;
            // 
            // quanLyThietBiToolStripMenuItem
            // 
            quanLyThietBiToolStripMenuItem.Name = "quanLyThietBiToolStripMenuItem";
            quanLyThietBiToolStripMenuItem.Size = new Size(225, 22);
            quanLyThietBiToolStripMenuItem.Text = "Quan ly thiet bi";
            quanLyThietBiToolStripMenuItem.Click += quanLyThietBiToolStripMenuItem_Click;
            // 
            // quanLyThietBiTrongPhongToolStripMenuItem
            // 
            quanLyThietBiTrongPhongToolStripMenuItem.Name = "quanLyThietBiTrongPhongToolStripMenuItem";
            quanLyThietBiTrongPhongToolStripMenuItem.Size = new Size(225, 22);
            quanLyThietBiTrongPhongToolStripMenuItem.Text = "Quan ly thiet bi trong phong";
            // 
            // quanLyKhacHangToolStripMenuItem
            // 
            quanLyKhacHangToolStripMenuItem.Name = "quanLyKhacHangToolStripMenuItem";
            quanLyKhacHangToolStripMenuItem.Size = new Size(225, 22);
            quanLyKhacHangToolStripMenuItem.Text = "Quan ly khac hang";
            quanLyKhacHangToolStripMenuItem.Click += quanLyKhacHangToolStripMenuItem_Click;
            // 
            // dANHMUCToolStripMenuItem2
            // 
            dANHMUCToolStripMenuItem2.Name = "dANHMUCToolStripMenuItem2";
            dANHMUCToolStripMenuItem2.Size = new Size(225, 22);
            dANHMUCToolStripMenuItem2.Text = "HE THONG";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(225, 22);
            doiMatKhauToolStripMenuItem.Text = "Doi mat khau";
            doiMatKhauToolStripMenuItem.Click += doiMatKhauToolStripMenuItem_Click;
            // 
            // quanLyNguoiDungToolStripMenuItem
            // 
            quanLyNguoiDungToolStripMenuItem.Name = "quanLyNguoiDungToolStripMenuItem";
            quanLyNguoiDungToolStripMenuItem.Size = new Size(225, 22);
            quanLyNguoiDungToolStripMenuItem.Text = "Quan ly nguoi dung";
            quanLyNguoiDungToolStripMenuItem.Click += quanLyNguoiDungToolStripMenuItem_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ButtonFace;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.GridColor = SystemColors.ButtonHighlight;
            dgvData.Location = new Point(3, 38);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(575, 387);
            dgvData.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 465);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Padding = new Padding(5);
            Text = "Hotel Manage";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnBaocao;
        private ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripButton btnHome;
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DANHMUCToolStripMenuItem;
        private ToolStripMenuItem dANHMUCToolStripMenuItem1;
        private ToolStripMenuItem danhMucCongTyToolStripMenuItem;
        private ToolStripMenuItem danhMucDonViToolStripMenuItem;
        private ToolStripMenuItem danhMucTangToolStripMenuItem;
        private ToolStripMenuItem danhMucLoaiPhongToolStripMenuItem;
        private ToolStripMenuItem danhMucPhongToolStripMenuItem;
        private ToolStripMenuItem quanLyDatPhongToolStripMenuItem;
        private ToolStripMenuItem quanLySanPhamToolStripMenuItem;
        private ToolStripMenuItem quanLyThietBiToolStripMenuItem;
        private ToolStripMenuItem quanLyThietBiTrongPhongToolStripMenuItem;
        private ToolStripMenuItem quanLyKhacHangToolStripMenuItem;
        private DataGridView dgvData;
        private ToolStripMenuItem dANHMUCToolStripMenuItem2;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem quanLyNguoiDungToolStripMenuItem;
    }
}