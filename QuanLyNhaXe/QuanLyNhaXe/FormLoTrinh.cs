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
    public partial class FormLoTrinh : Form
    {
        public string user = "";
        public FormLoTrinh()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("select * from LoTrinh", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();

            gridLoTrinh.DataSource = table;
        }

        private void GridLoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridLoTrinh.Rows[e.RowIndex];
                txtDiemDi.Text = row.Cells["DiemDi"].Value.ToString();
                txtDiemDen.Text = row.Cells["DiemDen"].Value.ToString();
                dtNgayDi.Value = Convert.ToDateTime(row.Cells["NgayDi"].Value);
                txtGioKhoiHanh.Text = row.Cells["GioKhoiHanh"].Value.ToString();
            }
        }

        private void BtnThemLoTrinh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("insert into LoTrinh values('" + txtDiemDi.Text + "','" + txtDiemDen.Text + "','" + dtNgayDi.Value + "','" + txtGioKhoiHanh.Text + "');", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnHuyLoTrinh_Click(object sender, EventArgs e)
        {
            txtDiemDi.Text = "";
            txtDiemDen.Text = "";
            txtGioKhoiHanh.Text = "";
            txtDiemDi.Focus();
        }

        private void BtnXoaLoTrinh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridLoTrinh.Rows[gridLoTrinh.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Delete from LoTrinh where MaLoTrinh =" + id + "", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnUpdateLoTrinh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridLoTrinh.Rows[gridLoTrinh.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Update LoTrinh set DiemDi='" + txtDiemDi.Text + "',DiemDen='" + txtDiemDen.Text + "',NgayDi='" + dtNgayDi.Value + "',GioKhoiHanh='" + txtGioKhoiHanh.Text + "' where MaLoTrinh =" + id + "", conn);
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
    }
}
