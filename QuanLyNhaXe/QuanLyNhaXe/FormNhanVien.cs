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
    public partial class FormNhanVien : Form
    {
        public string user = "";
        public FormNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();

            gridNhanVien.DataSource = table;
        }

        private void GridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridNhanVien.Rows[e.RowIndex];

                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("insert into NhanVien values('" + txtTenNhanVien.Text + "','" + txtSoDienThoai.Text + "','" + txtDiaChi.Text + "','" + txtEmail.Text + "');", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnHuyNhanVien_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTenNhanVien.Focus();
        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridNhanVien.Rows[gridNhanVien.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Delete from NhanVien where MaNhanVien =" + id + "", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnUpdateNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridNhanVien.Rows[gridNhanVien.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Update NhanVien set TenNhanVien='" + txtTenNhanVien.Text + "',SoDienThoai='" + txtSoDienThoai.Text + "',DiaChi='" + txtDiaChi.Text + "',Email='" + txtEmail.Text + "' where MaNhanVien =" + id + "", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
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

       
    }
}
