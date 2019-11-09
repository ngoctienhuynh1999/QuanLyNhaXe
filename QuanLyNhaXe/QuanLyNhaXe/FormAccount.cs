using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaXe
{

    public partial class FormAccount : Form
    {
        public string user;
        
        public FormAccount()
        {
            InitializeComponent();
            
            
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            txtUser.Text = user;
            txtUser.Enabled = !Enabled;
            txtPass.Focus();
   
        }

        private void BtnThayMatKhau_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtRePass.Text && txtPass.Text !="")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
                SqlCommand cmd = new SqlCommand("Update tbl_Login set password = '" + txtPass.Text + "' where username = '" + txtUser.Text + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                conn.Close();
                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công", "Thông Báo", MessageBoxButtons.OK);
                FormApp formApp = new FormApp();
                formApp.user = user;
                this.Hide();
                formApp.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Mời Nhập Lại Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtPass.Text = "";
                txtRePass.Text = "";
                txtPass.Focus();
            }
            
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            FormApp formApp = new FormApp();
            formApp.user = user;
            this.Hide();
            formApp.ShowDialog();
            this.Close();
        }

        private void TrangChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApp formApp = new FormApp();
            formApp.user = user;
            this.Hide();
            formApp.ShowDialog();
            this.Close();
        }

        private void QuảnLýVéXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where (role='nhanvienve'and username ='" + user + "') or (role='admin'and username ='" + user + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                FormVeXe formVeXe = new FormVeXe();
                formVeXe.user = user;
                this.Hide();
                formVeXe.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Để Truy Cập", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void QuảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where (role='nhanvienkythuat'and username ='" + user + "') or (role='admin'and username ='" + user + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormXe formXe = new FormXe();
                formXe.user = user;
                this.Hide();
                formXe.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Để Truy Cập", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void QuảnLýLộTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where (role='nhanvienlotrinh'and username ='" + user + "') or (role='admin'and username ='" + user + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormLoTrinh formLoTrinh = new FormLoTrinh();
                formLoTrinh.user = user;
                this.Hide();
                formLoTrinh.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Để Truy Cập", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void QuảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where (role='nhanviennhansu'and username ='" + user + "') or (role='admin'and username ='" + user + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormNhanVien formNhanVien = new FormNhanVien();
                formNhanVien.user = user;
                this.Hide();
                formNhanVien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Để Truy Cập", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
