namespace QuanLyNhaXe
{
    partial class FormApp
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
            this.btnQLVeXe = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLXe = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLVeXe
            // 
            this.btnQLVeXe.Location = new System.Drawing.Point(12, 220);
            this.btnQLVeXe.Name = "btnQLVeXe";
            this.btnQLVeXe.Size = new System.Drawing.Size(119, 47);
            this.btnQLVeXe.TabIndex = 0;
            this.btnQLVeXe.Text = "Quản Lý Vé Xe";
            this.btnQLVeXe.UseVisualStyleBackColor = true;
            this.btnQLVeXe.Click += new System.EventHandler(this.BtnQLVeXe_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(420, 220);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(119, 47);
            this.btnQLNhanVien.TabIndex = 1;
            this.btnQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnQLXe
            // 
            this.btnQLXe.Location = new System.Drawing.Point(148, 220);
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.Size = new System.Drawing.Size(119, 47);
            this.btnQLXe.TabIndex = 1;
            this.btnQLXe.Text = "Quản Lý Xe";
            this.btnQLXe.UseVisualStyleBackColor = true;
            this.btnQLXe.Click += new System.EventHandler(this.BtnQLXe_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Quản Lý Lộ Trình";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 285);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnQLXe);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.btnQLVeXe);
            this.Name = "FormApp";
            this.Text = "Quản Lý Nhà Xe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLVeXe;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLXe;
        private System.Windows.Forms.Button button4;
    }
}