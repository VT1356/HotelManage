using HotelManager.Models;

namespace HotelManager
{
    partial class frmLogin
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
            btnLogin = new Button();
            btnExit = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new Point(109, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 277);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Đăng Nhập";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(107, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 31);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(271, 195);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 31);
            btnExit.TabIndex = 1;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 53);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 101);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(203, 93);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(175, 23);
            txtPass.TabIndex = 2;
            // 
            // frmLogin
            // 
            ClientSize = new Size(689, 429);
            Controls.Add(groupBox1);
            Name = "frmLogin";
            Text = "Đăng Nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtName;
        private Button btnExit;
        private Button btnLogin;
    }
}