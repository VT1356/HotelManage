namespace HotelManager
{
    partial class frmLoaiPhong
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
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnCancle = new ToolStripButton();
            btnExit = new ToolStripButton();
            dgvData = new DataGridView();
            groupBox1 = new GroupBox();
            nudSoluong = new NumericUpDown();
            nudSonguoi = new NumericUpDown();
            nudDongia = new NumericUpDown();
            cbDisabled = new CheckBox();
            txtTenLoaiPhong = new TextBox();
            lbSoLuong = new Label();
            lbSonguoi = new Label();
            lbDonGia = new Label();
            lbTenloaiphong = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSonguoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDongia).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnSave, btnCancle, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
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
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(9, 44);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(369, 396);
            dgvData.TabIndex = 1;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudSoluong);
            groupBox1.Controls.Add(nudSonguoi);
            groupBox1.Controls.Add(nudDongia);
            groupBox1.Controls.Add(cbDisabled);
            groupBox1.Controls.Add(txtTenLoaiPhong);
            groupBox1.Controls.Add(lbSoLuong);
            groupBox1.Controls.Add(lbSonguoi);
            groupBox1.Controls.Add(lbDonGia);
            groupBox1.Controls.Add(lbTenloaiphong);
            groupBox1.Location = new Point(408, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 397);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // nudSoluong
            // 
            nudSoluong.Location = new Point(98, 234);
            nudSoluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoluong.Name = "nudSoluong";
            nudSoluong.Size = new Size(171, 23);
            nudSoluong.TabIndex = 3;
            nudSoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudSonguoi
            // 
            nudSonguoi.Location = new Point(98, 167);
            nudSonguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSonguoi.Name = "nudSonguoi";
            nudSonguoi.Size = new Size(171, 23);
            nudSonguoi.TabIndex = 3;
            nudSonguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDongia
            // 
            nudDongia.Location = new Point(97, 105);
            nudDongia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDongia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDongia.Name = "nudDongia";
            nudDongia.Size = new Size(171, 23);
            nudDongia.TabIndex = 3;
            nudDongia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // cbDisabled
            // 
            cbDisabled.AutoSize = true;
            cbDisabled.Location = new Point(317, 58);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(64, 19);
            cbDisabled.TabIndex = 2;
            cbDisabled.Text = "Disable";
            cbDisabled.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiPhong
            // 
            txtTenLoaiPhong.Location = new Point(127, 55);
            txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            txtTenLoaiPhong.Size = new Size(175, 23);
            txtTenLoaiPhong.TabIndex = 1;
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Location = new Point(33, 234);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(57, 15);
            lbSoLuong.TabIndex = 0;
            lbSoLuong.Text = "Số Lượng";
            // 
            // lbSonguoi
            // 
            lbSonguoi.AutoSize = true;
            lbSonguoi.Location = new Point(33, 169);
            lbSonguoi.Name = "lbSonguoi";
            lbSonguoi.Size = new Size(56, 15);
            lbSonguoi.TabIndex = 0;
            lbSonguoi.Text = "Số Người";
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(33, 110);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(49, 15);
            lbDonGia.TabIndex = 0;
            lbDonGia.Text = "Đơn Giá";
            // 
            // lbTenloaiphong
            // 
            lbTenloaiphong.AutoSize = true;
            lbTenloaiphong.Location = new Point(33, 55);
            lbTenloaiphong.Name = "lbTenloaiphong";
            lbTenloaiphong.Size = new Size(88, 15);
            lbTenloaiphong.TabIndex = 0;
            lbTenloaiphong.Text = "Tên Loại Phòng";
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmLoaiPhong";
            Text = "Quan ly Loai Phong";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSonguoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDongia).EndInit();
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
        private DataGridView dgvData;
        private GroupBox groupBox1;
        private NumericUpDown nudSoluong;
        private NumericUpDown nudSonguoi;
        private NumericUpDown nudDongia;
        private CheckBox cbDisabled;
        private TextBox txtTenLoaiPhong;
        private Label lbSoLuong;
        private Label lbSonguoi;
        private Label lbDonGia;
        private Label lbTenloaiphong;
    }
}