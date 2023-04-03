namespace HotelManager
{
    partial class frmCongTy
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
            cbDisabled = new CheckBox();
            txtMaCty = new TextBox();
            txtName = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lbAddress = new Label();
            label3 = new Label();
            lbPhone = new Label();
            lbMaCty = new Label();
            lbName = new Label();
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
            toolStrip1.Size = new Size(892, 25);
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
            dgvData.Location = new Point(22, 56);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(402, 416);
            dgvData.TabIndex = 1;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(cbDisabled);
            gbInfo.Controls.Add(txtMaCty);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(txtDiachi);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Controls.Add(txtPhone);
            gbInfo.Controls.Add(lbAddress);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(lbPhone);
            gbInfo.Controls.Add(lbMaCty);
            gbInfo.Controls.Add(lbName);
            gbInfo.Location = new Point(447, 64);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(433, 408);
            gbInfo.TabIndex = 2;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông Tin";
            // 
            // cbDisabled
            // 
            cbDisabled.AutoSize = true;
            cbDisabled.Location = new Point(351, 36);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(71, 19);
            cbDisabled.TabIndex = 2;
            cbDisabled.Text = "Disabled";
            cbDisabled.UseVisualStyleBackColor = true;
            // 
            // txtMaCty
            // 
            txtMaCty.Location = new Point(130, 28);
            txtMaCty.Name = "txtMaCty";
            txtMaCty.Size = new Size(210, 23);
            txtMaCty.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 1;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(130, 239);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(210, 23);
            txtDiachi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 186);
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
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(28, 239);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(45, 15);
            lbAddress.TabIndex = 0;
            lbAddress.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 189);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(28, 136);
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
            lbMaCty.Size = new Size(70, 15);
            lbMaCty.TabIndex = 0;
            lbMaCty.Text = "Mã Công Ty";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(37, 75);
            lbName.Name = "lbName";
            lbName.Size = new Size(25, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Tên";
            // 
            // frmCongTy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 484);
            Controls.Add(gbInfo);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmCongTy";
            Text = "Danh Mục Công Ty";
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
        private ToolStripButton btnExit;
        private DataGridView dgvData;
        private GroupBox gbInfo;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label lbAddress;
        private Label label3;
        private Label lbPhone;
        private Label lbName;
        private CheckBox cbDisabled;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private ToolStripButton btnCancle;
        private TextBox txtMaCty;
        private Label lbMaCty;
    }
}