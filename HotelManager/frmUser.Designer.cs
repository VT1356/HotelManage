namespace HotelManager
{
    partial class frmUser
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
            lbName = new Label();
            lbMadv = new Label();
            lbMacty = new Label();
            txtName = new TextBox();
            cbMacty = new ComboBox();
            cbMadv = new ComboBox();
            cbDisable = new CheckBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
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
            btnSave.Image = Properties.Resources.floppy_disk_48;
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
            btnExit.Image = Properties.Resources.Thoat;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 22);
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(47, 56);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(690, 170);
            dgvData.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDisable);
            groupBox1.Controls.Add(cbMadv);
            groupBox1.Controls.Add(cbMacty);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lbMacty);
            groupBox1.Controls.Add(lbMadv);
            groupBox1.Controls.Add(lbName);
            groupBox1.Location = new Point(47, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 185);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(36, 31);
            lbName.Name = "lbName";
            lbName.Size = new Size(28, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Tên ";
            // 
            // lbMadv
            // 
            lbMadv.AutoSize = true;
            lbMadv.Location = new Point(36, 90);
            lbMadv.Name = "lbMadv";
            lbMadv.Size = new Size(44, 15);
            lbMadv.TabIndex = 0;
            lbMadv.Text = "Mã Dvi";
            // 
            // lbMacty
            // 
            lbMacty.AutoSize = true;
            lbMacty.Location = new Point(305, 31);
            lbMacty.Name = "lbMacty";
            lbMacty.Size = new Size(45, 15);
            lbMacty.TabIndex = 0;
            lbMacty.Text = "Mã Cty";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(119, 23);
            txtName.TabIndex = 1;
            // 
            // cbMacty
            // 
            cbMacty.FormattingEnabled = true;
            cbMacty.Location = new Point(377, 31);
            cbMacty.Name = "cbMacty";
            cbMacty.Size = new Size(148, 23);
            cbMacty.TabIndex = 2;
            // 
            // cbMadv
            // 
            cbMadv.FormattingEnabled = true;
            cbMadv.Location = new Point(115, 90);
            cbMadv.Name = "cbMadv";
            cbMadv.Size = new Size(148, 23);
            cbMadv.TabIndex = 2;
            // 
            // cbDisable
            // 
            cbDisable.AutoSize = true;
            cbDisable.Location = new Point(407, 92);
            cbDisable.Name = "cbDisable";
            cbDisable.Size = new Size(64, 19);
            cbDisable.TabIndex = 3;
            cbDisable.Text = "Disable";
            cbDisable.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmUser";
            Text = "Quan Ly Nguoi Dung";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label lbMadv;
        private Label lbName;
        private Label lbMacty;
        private ComboBox cbMadv;
        private ComboBox cbMacty;
        private TextBox txtName;
        private CheckBox cbDisable;
    }
}