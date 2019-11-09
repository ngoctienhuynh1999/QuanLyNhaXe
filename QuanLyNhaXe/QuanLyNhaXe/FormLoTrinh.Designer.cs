namespace QuanLyNhaXe
{
    partial class FormLoTrinh
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
            this.gridLoTrinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemDi = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.txtGioKhoiHanh = new System.Windows.Forms.TextBox();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVéXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateLoTrinh = new System.Windows.Forms.Button();
            this.btnHuyLoTrinh = new System.Windows.Forms.Button();
            this.btnThemLoTrinh = new System.Windows.Forms.Button();
            this.btnXoaLoTrinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoTrinh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLoTrinh
            // 
            this.gridLoTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoTrinh.Location = new System.Drawing.Point(12, 162);
            this.gridLoTrinh.Name = "gridLoTrinh";
            this.gridLoTrinh.Size = new System.Drawing.Size(699, 212);
            this.gridLoTrinh.TabIndex = 0;
            this.gridLoTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLoTrinh_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm Đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ Khởi Hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Đi";
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.Location = new System.Drawing.Point(151, 42);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.Size = new System.Drawing.Size(325, 20);
            this.txtDiemDi.TabIndex = 5;
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Location = new System.Drawing.Point(151, 69);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(325, 20);
            this.txtDiemDen.TabIndex = 6;
            // 
            // txtGioKhoiHanh
            // 
            this.txtGioKhoiHanh.Location = new System.Drawing.Point(151, 99);
            this.txtGioKhoiHanh.Name = "txtGioKhoiHanh";
            this.txtGioKhoiHanh.Size = new System.Drawing.Size(325, 20);
            this.txtGioKhoiHanh.TabIndex = 7;
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDi.Location = new System.Drawing.Point(151, 131);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(325, 20);
            this.dtNgayDi.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDiênToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDiênToolStripMenuItem
            // 
            this.giaoDiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChínhToolStripMenuItem,
            this.quảnLýVéXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
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
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay Đổi Mật Khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ThayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // btnUpdateLoTrinh
            // 
            this.btnUpdateLoTrinh.Location = new System.Drawing.Point(616, 105);
            this.btnUpdateLoTrinh.Name = "btnUpdateLoTrinh";
            this.btnUpdateLoTrinh.Size = new System.Drawing.Size(95, 40);
            this.btnUpdateLoTrinh.TabIndex = 27;
            this.btnUpdateLoTrinh.Text = "Update";
            this.btnUpdateLoTrinh.UseVisualStyleBackColor = true;
            this.btnUpdateLoTrinh.Click += new System.EventHandler(this.BtnUpdateLoTrinh_Click);
            // 
            // btnHuyLoTrinh
            // 
            this.btnHuyLoTrinh.Location = new System.Drawing.Point(616, 49);
            this.btnHuyLoTrinh.Name = "btnHuyLoTrinh";
            this.btnHuyLoTrinh.Size = new System.Drawing.Size(95, 40);
            this.btnHuyLoTrinh.TabIndex = 26;
            this.btnHuyLoTrinh.Text = "Hủy";
            this.btnHuyLoTrinh.UseVisualStyleBackColor = true;
            this.btnHuyLoTrinh.Click += new System.EventHandler(this.BtnHuyLoTrinh_Click);
            // 
            // btnThemLoTrinh
            // 
            this.btnThemLoTrinh.Location = new System.Drawing.Point(497, 49);
            this.btnThemLoTrinh.Name = "btnThemLoTrinh";
            this.btnThemLoTrinh.Size = new System.Drawing.Size(92, 40);
            this.btnThemLoTrinh.TabIndex = 25;
            this.btnThemLoTrinh.Text = "Thêm";
            this.btnThemLoTrinh.UseVisualStyleBackColor = true;
            this.btnThemLoTrinh.Click += new System.EventHandler(this.BtnThemLoTrinh_Click);
            // 
            // btnXoaLoTrinh
            // 
            this.btnXoaLoTrinh.Location = new System.Drawing.Point(497, 105);
            this.btnXoaLoTrinh.Name = "btnXoaLoTrinh";
            this.btnXoaLoTrinh.Size = new System.Drawing.Size(92, 40);
            this.btnXoaLoTrinh.TabIndex = 24;
            this.btnXoaLoTrinh.Text = "Xóa";
            this.btnXoaLoTrinh.UseVisualStyleBackColor = true;
            this.btnXoaLoTrinh.Click += new System.EventHandler(this.BtnXoaLoTrinh_Click);
            // 
            // FormLoTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 386);
            this.Controls.Add(this.btnUpdateLoTrinh);
            this.Controls.Add(this.btnHuyLoTrinh);
            this.Controls.Add(this.btnThemLoTrinh);
            this.Controls.Add(this.btnXoaLoTrinh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtNgayDi);
            this.Controls.Add(this.txtGioKhoiHanh);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemDi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridLoTrinh);
            this.Name = "FormLoTrinh";
            this.Text = "FormLoTrinh";
            ((System.ComponentModel.ISupportInitialize)(this.gridLoTrinh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLoTrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemDi;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtGioKhoiHanh;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giaoDiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateLoTrinh;
        private System.Windows.Forms.Button btnHuyLoTrinh;
        private System.Windows.Forms.Button btnThemLoTrinh;
        private System.Windows.Forms.Button btnXoaLoTrinh;
    }
}