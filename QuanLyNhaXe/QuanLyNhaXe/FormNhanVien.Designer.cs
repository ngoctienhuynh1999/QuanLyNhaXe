namespace QuanLyNhaXe
{
    partial class FormNhanVien
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
            this.gridNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVéXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLộTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateNhanVien = new System.Windows.Forms.Button();
            this.btnHuyNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhanVien.Location = new System.Drawing.Point(13, 154);
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.Size = new System.Drawing.Size(775, 284);
            this.gridNhanVien.TabIndex = 0;
            this.gridNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(110, 32);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(387, 20);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(387, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(110, 59);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(387, 20);
            this.txtSoDienThoai.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDiênToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDiênToolStripMenuItem
            // 
            this.giaoDiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChínhToolStripMenuItem,
            this.quảnLýVéXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýLộTrìnhToolStripMenuItem});
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
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay Đổi Mật Khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ThayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // btnUpdateNhanVien
            // 
            this.btnUpdateNhanVien.Location = new System.Drawing.Point(659, 95);
            this.btnUpdateNhanVien.Name = "btnUpdateNhanVien";
            this.btnUpdateNhanVien.Size = new System.Drawing.Size(129, 40);
            this.btnUpdateNhanVien.TabIndex = 27;
            this.btnUpdateNhanVien.Text = "Update";
            this.btnUpdateNhanVien.UseVisualStyleBackColor = true;
            this.btnUpdateNhanVien.Click += new System.EventHandler(this.BtnUpdateNhanVien_Click);
            // 
            // btnHuyNhanVien
            // 
            this.btnHuyNhanVien.Location = new System.Drawing.Point(659, 39);
            this.btnHuyNhanVien.Name = "btnHuyNhanVien";
            this.btnHuyNhanVien.Size = new System.Drawing.Size(129, 40);
            this.btnHuyNhanVien.TabIndex = 26;
            this.btnHuyNhanVien.Text = "Hủy";
            this.btnHuyNhanVien.UseVisualStyleBackColor = true;
            this.btnHuyNhanVien.Click += new System.EventHandler(this.BtnHuyNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(527, 39);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(123, 40);
            this.btnThemNhanVien.TabIndex = 25;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.BtnThemNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(527, 95);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(123, 40);
            this.btnXoaNhanVien.TabIndex = 24;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.BtnXoaNhanVien_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateNhanVien);
            this.Controls.Add(this.btnHuyNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giaoDiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLộTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateNhanVien;
        private System.Windows.Forms.Button btnHuyNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
    }
}