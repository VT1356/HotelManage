namespace HotelManager
{
    partial class frmKhachHang
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
            gbInfo = new GroupBox();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lbDiaChi = new Label();
            label3 = new Label();
            lbPhone = new Label();
            lbMaCty = new Label();
            lbCCCD = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnSave, btnCancle, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(908, 25);
            toolStrip1.TabIndex = 1;
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
            btnDelete.Image = Properties.Resources.remove3;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(23, 22);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.floppy_disk_483;
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
            dgvData.Location = new Point(45, 63);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(800, 227);
            dgvData.TabIndex = 2;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(txtHoTen);
            gbInfo.Controls.Add(txtCCCD);
            gbInfo.Controls.Add(txtDiaChi);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Controls.Add(txtPhone);
            gbInfo.Controls.Add(lbDiaChi);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(lbPhone);
            gbInfo.Controls.Add(lbMaCty);
            gbInfo.Controls.Add(lbCCCD);
            gbInfo.Location = new Point(45, 311);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(809, 243);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông Tin";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(130, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(210, 23);
            txtHoTen.TabIndex = 1;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(130, 75);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(210, 23);
            txtCCCD.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(494, 78);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 23);
            txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(494, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(130, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 1;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(419, 78);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(45, 15);
            lbDiaChi.TabIndex = 0;
            lbDiaChi.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 35);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(28, 125);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(61, 15);
            lbPhone.TabIndex = 0;
            lbPhone.Text = "Điện thoại";
            // 
            // lbMaCty
            // 
            lbMaCty.AutoSize = true;
            lbMaCty.Location = new Point(37, 33);
            lbMaCty.Name = "lbMaCty";
            lbMaCty.Size = new Size(44, 15);
            lbMaCty.TabIndex = 0;
            lbMaCty.Text = "Họ Tên";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Location = new Point(39, 78);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(39, 15);
            lbCCCD.TabIndex = 0;
            lbCCCD.Text = "CCCD";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 566);
            Controls.Add(gbInfo);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmKhachHang";
            Text = "Danh muc khach hang";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
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
        private GroupBox gbInfo;
        private CheckBox cbDisabled;
        private TextBox txtMaCty;
        private TextBox txtCCCD;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label3;
        private Label lbPhone;
        private Label lbMaCty;
        private Label lbCCCD;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private Label lbDiaChi;
    }
}