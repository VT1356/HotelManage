namespace HotelManager
{
    partial class frmDonVi
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
            cbCty = new ComboBox();
            cbDisabled = new CheckBox();
            txtMa = new TextBox();
            txtName = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lbAddress = new Label();
            label3 = new Label();
            lbPhone = new Label();
            lbCty = new Label();
            lbMa = new Label();
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
            dgvData.Location = new Point(23, 28);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(402, 416);
            dgvData.TabIndex = 2;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(cbCty);
            gbInfo.Controls.Add(cbDisabled);
            gbInfo.Controls.Add(txtMa);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(txtDiachi);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Controls.Add(txtPhone);
            gbInfo.Controls.Add(lbAddress);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(lbPhone);
            gbInfo.Controls.Add(lbCty);
            gbInfo.Controls.Add(lbMa);
            gbInfo.Controls.Add(lbName);
            gbInfo.Location = new Point(446, 36);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(433, 408);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông Tin";
            // 
            // cbCty
            // 
            cbCty.FormattingEnabled = true;
            cbCty.Location = new Point(132, 33);
            cbCty.Name = "cbCty";
            cbCty.Size = new Size(210, 23);
            cbCty.TabIndex = 3;
            // 
            // cbDisabled
            // 
            cbDisabled.AutoSize = true;
            cbDisabled.Location = new Point(351, 67);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(71, 19);
            cbDisabled.TabIndex = 2;
            cbDisabled.Text = "Disabled";
            cbDisabled.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(130, 67);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(210, 23);
            txtMa.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 1;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(130, 270);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(210, 23);
            txtDiachi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(130, 166);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 1;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(28, 273);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(45, 15);
            lbAddress.TabIndex = 0;
            lbAddress.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 227);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(28, 169);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(61, 15);
            lbPhone.TabIndex = 0;
            lbPhone.Text = "Điện thoại";
            // 
            // lbCty
            // 
            lbCty.AutoSize = true;
            lbCty.Location = new Point(37, 37);
            lbCty.Name = "lbCty";
            lbCty.Size = new Size(50, 15);
            lbCty.TabIndex = 0;
            lbCty.Text = "Công Ty";
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.Location = new Point(37, 68);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(27, 15);
            lbMa.TabIndex = 0;
            lbMa.Text = "Mã ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(39, 122);
            lbName.Name = "lbName";
            lbName.Size = new Size(25, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Tên";
            // 
            // frmDonVi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 465);
            Controls.Add(gbInfo);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmDonVi";
            Text = "Danh Muc Don Vi";
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
        private TextBox txtMa;
        private TextBox txtName;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lbAddress;
        private Label label3;
        private Label lbPhone;
        private Label lbMa;
        private Label lbName;
        private Label lbCty;
        private ComboBox cbCty;
    }
}