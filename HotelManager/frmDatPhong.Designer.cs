namespace HotelManager
{
    partial class frmDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnCancle = new ToolStripButton();
            btnExit = new ToolStripButton();
            groupBox2 = new GroupBox();
            nudTongtien = new NumericUpDown();
            label1 = new Label();
            dgvSpDv = new DataGridView();
            dgvPhongtrong = new DataGridView();
            groupBox1 = new GroupBox();
            btnAddKh = new Button();
            dtpNgaytra = new DateTimePicker();
            dtpNgaydat = new DateTimePicker();
            lbNgaytra = new Label();
            lbNgaydat = new Label();
            cbKH = new ComboBox();
            lbKhachHang = new Label();
            dgvPhongdat = new DataGridView();
            tbPhongBindingSource = new BindingSource(components);
            dgcSP = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTongtien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpDv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhongtrong).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongdat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPhongBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgcSP).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnSave, btnCancle, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1245, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(23, 22);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources._6;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(23, 22);
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.remove;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(23, 22);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(23, 22);
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCancle.Image = Properties.Resources.cancel_48;
            btnCancle.ImageTransparentColor = Color.Magenta;
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(23, 22);
            btnCancle.Text = "Hủy";
            btnCancle.Click += btnCancle_Click;
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = Properties.Resources.Restore;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 22);
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudTongtien);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(398, 421);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 114);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng tiền";
            // 
            // nudTongtien
            // 
            nudTongtien.Location = new Point(157, 53);
            nudTongtien.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
            nudTongtien.Name = "nudTongtien";
            nudTongtien.Size = new Size(232, 23);
            nudTongtien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Tổng Tiền";
            // 
            // dgvSpDv
            // 
            dgvSpDv.AllowDrop = true;
            dgvSpDv.BackgroundColor = SystemColors.ButtonFace;
            dgvSpDv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpDv.Location = new Point(909, 79);
            dgvSpDv.Name = "dgvSpDv";
            dgvSpDv.RowTemplate.Height = 25;
            dgvSpDv.Size = new Size(320, 447);
            dgvSpDv.TabIndex = 5;
            dgvSpDv.CellClick += dgvSpDv_CellClick;
            // 
            // dgvPhongtrong
            // 
            dgvPhongtrong.AllowDrop = true;
            dgvPhongtrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongtrong.Location = new Point(23, 67);
            dgvPhongtrong.Name = "dgvPhongtrong";
            dgvPhongtrong.RowTemplate.Height = 25;
            dgvPhongtrong.Size = new Size(342, 459);
            dgvPhongtrong.TabIndex = 6;
            dgvPhongtrong.CellClick += dgvPhongtrong_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddKh);
            groupBox1.Controls.Add(dtpNgaytra);
            groupBox1.Controls.Add(dtpNgaydat);
            groupBox1.Controls.Add(lbNgaytra);
            groupBox1.Controls.Add(lbNgaydat);
            groupBox1.Controls.Add(cbKH);
            groupBox1.Controls.Add(lbKhachHang);
            groupBox1.Location = new Point(404, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 180);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // btnAddKh
            // 
            btnAddKh.BackColor = SystemColors.Control;
            btnAddKh.BackgroundImage = Properties.Resources.add;
            btnAddKh.BackgroundImageLayout = ImageLayout.None;
            btnAddKh.ForeColor = SystemColors.ButtonFace;
            btnAddKh.Location = new Point(379, 22);
            btnAddKh.Name = "btnAddKh";
            btnAddKh.Size = new Size(31, 30);
            btnAddKh.TabIndex = 4;
            btnAddKh.Text = " ";
            btnAddKh.UseVisualStyleBackColor = false;
            btnAddKh.Click += btnAddKh_Click;
            // 
            // dtpNgaytra
            // 
            dtpNgaytra.Location = new Point(341, 69);
            dtpNgaytra.Name = "dtpNgaytra";
            dtpNgaytra.Size = new Size(132, 23);
            dtpNgaytra.TabIndex = 3;
            // 
            // dtpNgaydat
            // 
            dtpNgaydat.CustomFormat = "";
            dtpNgaydat.Location = new Point(106, 68);
            dtpNgaydat.Name = "dtpNgaydat";
            dtpNgaydat.Size = new Size(144, 23);
            dtpNgaydat.TabIndex = 3;
            // 
            // lbNgaytra
            // 
            lbNgaytra.AutoSize = true;
            lbNgaytra.Location = new Point(282, 74);
            lbNgaytra.Name = "lbNgaytra";
            lbNgaytra.Size = new Size(53, 15);
            lbNgaytra.TabIndex = 2;
            lbNgaytra.Text = "Ngày Trả";
            // 
            // lbNgaydat
            // 
            lbNgaydat.AutoSize = true;
            lbNgaydat.Location = new Point(28, 74);
            lbNgaydat.Name = "lbNgaydat";
            lbNgaydat.Size = new Size(56, 15);
            lbNgaydat.TabIndex = 2;
            lbNgaydat.Text = "Ngày Đặt";
            // 
            // cbKH
            // 
            cbKH.FormattingEnabled = true;
            cbKH.Location = new Point(128, 26);
            cbKH.Name = "cbKH";
            cbKH.Size = new Size(228, 23);
            cbKH.TabIndex = 1;
            // 
            // lbKhachHang
            // 
            lbKhachHang.AutoSize = true;
            lbKhachHang.Location = new Point(27, 28);
            lbKhachHang.Name = "lbKhachHang";
            lbKhachHang.Size = new Size(72, 15);
            lbKhachHang.TabIndex = 0;
            lbKhachHang.Text = "Khách Hàng";
            // 
            // dgvPhongdat
            // 
            dgvPhongdat.AllowDrop = true;
            dgvPhongdat.AllowUserToResizeColumns = false;
            dgvPhongdat.AllowUserToResizeRows = false;
            dgvPhongdat.BackgroundColor = SystemColors.ButtonFace;
            dgvPhongdat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongdat.Location = new Point(398, 240);
            dgvPhongdat.Name = "dgvPhongdat";
            dgvPhongdat.ReadOnly = true;
            dgvPhongdat.RowTemplate.Height = 25;
            dgvPhongdat.Size = new Size(494, 94);
            dgvPhongdat.TabIndex = 8;
            dgvPhongdat.CellClick += dgvPhongdat_CellClick;
            dgvPhongdat.CellDoubleClick += dgvPhongdat_CellDoubleClick;
            // 
            // tbPhongBindingSource
            // 
            tbPhongBindingSource.DataSource = typeof(Models.TbPhong);
            // 
            // dgcSP
            // 
            dgcSP.BackgroundColor = SystemColors.ButtonFace;
            dgcSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcSP.Location = new Point(398, 343);
            dgcSP.Name = "dgcSP";
            dgcSP.RowTemplate.Height = 25;
            dgcSP.Size = new Size(498, 74);
            dgcSP.TabIndex = 9;
            dgcSP.CellClick += dgcSP_CellClick;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 584);
            Controls.Add(dgcSP);
            Controls.Add(dgvPhongdat);
            Controls.Add(groupBox1);
            Controls.Add(dgvPhongtrong);
            Controls.Add(dgvSpDv);
            Controls.Add(groupBox2);
            Controls.Add(toolStrip1);
            Name = "frmDatPhong";
            Text = "Quan Ly Dat Phong";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTongtien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpDv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhongtrong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongdat).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPhongBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgcSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripButton btnSave;
        private ToolStripButton btnCancle;
        private ToolStripButton btnExit;
        private GroupBox groupBox2;
        private DataGridView dgvSpDv;
        private DataGridView dgvPhongtrong;
        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown nudTongtien;
        private ComboBox cbKH;
        private Label lbKhachHang;
        private Label lbNgaytra;
        private Label lbNgaydat;
        private DateTimePicker dtpNgaytra;
        private DateTimePicker dtpNgaydat;
        private Button btnAddKh;
        private DataGridView dgvPhongdat;
        private BindingSource tbPhongBindingSource;
        private DataGridView dgcSP;
    }
}