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
    public partial class FormApp : Form
    {
        public string user="";
        public FormApp()
        {
            InitializeComponent();

        }

        public void BtnQLVeXe_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where (role='nhanvienve'and username ='" + user + "') or (role='admin'and username ='" + user + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
      
                FormVeXe formVeXe= new FormVeXe();
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

        private void BtnQLXe_Click(object sender, EventArgs e)
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

        private void BtnQLLoTrinh_Click(object sender, EventArgs e)
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

        private void BtnQLNhanVien_Click(object sender, EventArgs e)
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
        private void ThayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccount formAccount = new FormAccount();
            formAccount.user = user;
            this.Hide();
            formAccount.ShowDialog();
            this.Close();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");

            string query = "Select * from tbl_Login where role='admin'and username ='" + user + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 1)
            {
                thêmTàiKhoảnToolStripMenuItem.Dispose();
            }
            
        }

        private void ThêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewAccount formNewAccount = new FormNewAccount();
            formNewAccount.user = user;
            this.Hide();
            formNewAccount.ShowDialog();
            this.Close();
        }
    }
}
