namespace HotelManager
{
    partial class frmChangePass
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
            groupBox1 = new GroupBox();
            lbMKmoi1 = new Label();
            lbMKmoi = new Label();
            lbMKcu = new Label();
            txtMKcu = new TextBox();
            txtMKmoi = new TextBox();
            txtMKmoi1 = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtMKmoi1);
            groupBox1.Controls.Add(txtMKmoi);
            groupBox1.Controls.Add(txtMKcu);
            groupBox1.Controls.Add(lbMKmoi1);
            groupBox1.Controls.Add(lbMKmoi);
            groupBox1.Controls.Add(lbMKcu);
            groupBox1.Location = new Point(124, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thay Doi Mat Khau";
            // 
            // lbMKmoi1
            // 
            lbMKmoi1.AutoSize = true;
            lbMKmoi1.Location = new Point(128, 226);
            lbMKmoi1.Name = "lbMKmoi1";
            lbMKmoi1.Size = new Size(132, 15);
            lbMKmoi1.TabIndex = 0;
            lbMKmoi1.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // lbMKmoi
            // 
            lbMKmoi.AutoSize = true;
            lbMKmoi.Location = new Point(128, 157);
            lbMKmoi.Name = "lbMKmoi";
            lbMKmoi.Size = new Size(114, 15);
            lbMKmoi.TabIndex = 0;
            lbMKmoi.Text = "Nhập Mật Khẩu Mới";
            // 
            // lbMKcu
            // 
            lbMKcu.AutoSize = true;
            lbMKcu.Location = new Point(128, 87);
            lbMKcu.Name = "lbMKcu";
            lbMKcu.Size = new Size(108, 15);
            lbMKcu.TabIndex = 0;
            lbMKcu.Text = "Nhập Mật Khẩu Cũ";
            // 
            // txtMKcu
            // 
            txtMKcu.Location = new Point(282, 84);
            txtMKcu.Name = "txtMKcu";
            txtMKcu.Size = new Size(197, 23);
            txtMKcu.TabIndex = 1;
            // 
            // txtMKmoi
            // 
            txtMKmoi.Location = new Point(282, 154);
            txtMKmoi.Name = "txtMKmoi";
            txtMKmoi.Size = new Size(197, 23);
            txtMKmoi.TabIndex = 1;
            // 
            // txtMKmoi1
            // 
            txtMKmoi1.Location = new Point(282, 223);
            txtMKmoi1.Name = "txtMKmoi1";
            txtMKmoi1.Size = new Size(197, 23);
            txtMKmoi1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(397, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(492, 292);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmChangePass";
            Text = "Thay đổi mật khẩu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbMKmoi1;
        private Label lbMKmoi;
        private Label lbMKcu;
        private Button btnExit;
        private Button btnSave;
        private TextBox txtMKmoi1;
        private TextBox txtMKmoi;
        private TextBox txtMKcu;
    }
}