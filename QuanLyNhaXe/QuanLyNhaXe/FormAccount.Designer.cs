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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnThayMatKhau = new System.Windows.Forms.Button();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVéXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLộTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
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
            this.btnThayMatKhau.Click += new System.EventHandler(this.BtnThayMatKhau_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDiênToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDiênToolStripMenuItem
            // 
            this.giaoDiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChínhToolStripMenuItem,
            this.quảnLýVéXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýLộTrìnhToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.giaoDiênToolStripMenuItem.Name = "giaoDiênToolStripMenuItem";
            this.giaoDiênToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.giaoDiênToolStripMenuItem.Text = "Giao Diện";
            // 
            // trangChínhToolStripMenuItem
            // 
            this.trangChínhToolStripMenuItem.Name = "trangChínhToolStripMenuItem";
            this.trangChínhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trangChínhToolStripMenuItem.Text = "Trang Chính";
            this.trangChínhToolStripMenuItem.Click += new System.EventHandler(this.TrangChínhToolStripMenuItem_Click);
            // 
            // quảnLýVéXeToolStripMenuItem
            // 
            this.quảnLýVéXeToolStripMenuItem.Name = "quảnLýVéXeToolStripMenuItem";
            this.quảnLýVéXeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýVéXeToolStripMenuItem.Text = "Quản Lý Vé Xe";
            this.quảnLýVéXeToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýVéXeToolStripMenuItem_Click);
            // 
            // quảnLýXeToolStripMenuItem
            // 
            this.quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            this.quảnLýXeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýXeToolStripMenuItem.Text = "Quản Lý Xe";
            this.quảnLýXeToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýXeToolStripMenuItem_Click);
            // 
            // quảnLýLộTrìnhToolStripMenuItem
            // 
            this.quảnLýLộTrìnhToolStripMenuItem.Name = "quảnLýLộTrìnhToolStripMenuItem";
            this.quảnLýLộTrìnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýLộTrìnhToolStripMenuItem.Text = "Quản Lý Lộ Trình";
            this.quảnLýLộTrìnhToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýLộTrìnhToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 296);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThayMatKhau);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giaoDiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLộTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}