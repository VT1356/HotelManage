namespace HotelManager
{
    partial class frmTang
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
            lbTentang = new Label();
            txtTentang = new TextBox();
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
            toolStrip1.Size = new Size(842, 25);
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
            dgvData.Location = new Point(54, 82);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(645, 241);
            dgvData.TabIndex = 1;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTentang);
            groupBox1.Controls.Add(lbTentang);
            groupBox1.Location = new Point(103, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 101);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // lbTentang
            // 
            lbTentang.AutoSize = true;
            lbTentang.Location = new Point(54, 48);
            lbTentang.Name = "lbTentang";
            lbTentang.Size = new Size(54, 15);
            lbTentang.TabIndex = 0;
            lbTentang.Text = "Tên Tầng";
            // 
            // txtTentang
            // 
            txtTentang.Location = new Point(133, 47);
            txtTentang.Name = "txtTentang";
            txtTentang.Size = new Size(100, 23);
            txtTentang.TabIndex = 1;
            // 
            // frmTang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 549);
            Controls.Add(groupBox1);
            Controls.Add(dgvData);
            Controls.Add(toolStrip1);
            Name = "frmTang";
            Text = "Quan Ly Tang ";
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
        private TextBox txtTentang;
        private Label lbTentang;
    }
}