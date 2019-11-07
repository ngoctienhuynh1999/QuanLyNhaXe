namespace QuanLyNhaXe
{
    partial class FormAccount
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnThayMatKhau = new System.Windows.Forms.Button();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(215, 225);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 37);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(78, 133);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 13);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(78, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Username: ";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(181, 88);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(119, 20);
            this.txtUser.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(181, 130);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(119, 20);
            this.txtPass.TabIndex = 11;
            // 
            // btnThayMatKhau
            // 
            this.btnThayMatKhau.Location = new System.Drawing.Point(81, 225);
            this.btnThayMatKhau.Name = "btnThayMatKhau";
            this.btnThayMatKhau.Size = new System.Drawing.Size(85, 35);
            this.btnThayMatKhau.TabIndex = 12;
            this.btnThayMatKhau.Text = "Đổi Mật Khẩu";
            this.btnThayMatKhau.UseVisualStyleBackColor = true;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(181, 168);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(119, 20);
            this.txtRePass.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Repeat Password: ";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 296);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThayMatKhau);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnThayMatKhau;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label1;
    }
}