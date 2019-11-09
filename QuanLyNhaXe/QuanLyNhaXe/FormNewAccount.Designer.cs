namespace QuanLyNhaXe
{
    partial class FormNewAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbChucNang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnHuyAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 44);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 20);
            this.txtUser.TabIndex = 1;
            // 
            // cmbChucNang
            // 
            this.cmbChucNang.FormattingEnabled = true;
            this.cmbChucNang.Items.AddRange(new object[] {
            "admin",
            "Nhân Viên Vé",
            "Nhân Viên Kỹ Thuật",
            "Nhân Viên Lộ Trình",
            "Nhân Viên Nhân Sự"});
            this.cmbChucNang.Location = new System.Drawing.Point(124, 166);
            this.cmbChucNang.Name = "cmbChucNang";
            this.cmbChucNang.Size = new System.Drawing.Size(179, 21);
            this.cmbChucNang.TabIndex = 2;
            this.cmbChucNang.Text = "Chọn Loại Chức Năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chức Năng";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 87);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(179, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtRepass
            // 
            this.txtRepass.Location = new System.Drawing.Point(124, 130);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(179, 20);
            this.txtRepass.TabIndex = 7;
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(45, 217);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(101, 41);
            this.btnTaoTaiKhoan.TabIndex = 8;
            this.btnTaoTaiKhoan.Text = "Tạo Tài Khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.BtnTaoTaiKhoan_Click);
            // 
            // btnHuyAccount
            // 
            this.btnHuyAccount.Location = new System.Drawing.Point(202, 217);
            this.btnHuyAccount.Name = "btnHuyAccount";
            this.btnHuyAccount.Size = new System.Drawing.Size(101, 41);
            this.btnHuyAccount.TabIndex = 9;
            this.btnHuyAccount.Text = "Hủy";
            this.btnHuyAccount.UseVisualStyleBackColor = true;
            this.btnHuyAccount.Click += new System.EventHandler(this.BtnHuyAccount_Click);
            // 
            // FormNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 274);
            this.Controls.Add(this.btnHuyAccount);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbChucNang);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "FormNewAccount";
            this.Text = "FormNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnHuyAccount;
    }
}