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
    public partial class FormXe : Form
    {
        public string user = "";
        public FormXe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("select * from Xe", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();

            gridXe.DataSource = table;
        }

        private void GridXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridXe.Rows[e.RowIndex];

                cmbLoaiXe.SelectedItem = row.Cells["LoaiXe"].Value.ToString();
                txtBienSo.Text = row.Cells["BienSo"].Value.ToString();
                txtBenXe.Text = row.Cells["BenXe"].Value.ToString();
                txtSoLuongGhe.Text = row.Cells["SoLuongGhe"].Value.ToString();
                dtNgayDangKy.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
                txtTinhTrangXe.Text = row.Cells["TinhTrangXe"].Value.ToString();
            }
        }

        private void BtnThemXe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("insert into Xe values('" + cmbLoaiXe.SelectedItem.ToString() + "','" + txtBienSo.Text + "','" + txtBenXe.Text + "'," + txtSoLuongGhe.Text + ",'" + dtNgayDangKy.Value + "','" + txtTinhTrangXe.Text + "');", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnHuyXe_Click(object sender, EventArgs e)
        {
            txtBienSo.Text = "";
            txtBenXe.Text = "";
            txtSoLuongGhe.Text = "";
            txtTinhTrangXe.Text = "";
        }

        private void BtnXoaXe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridXe.Rows[gridXe.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Delete from Xe where MaXe =" + id + "", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnUpdateXe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridXe.Rows[gridXe.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Update Xe set LoaiXe='" + cmbLoaiXe.SelectedItem.ToString() + "',BienSo='" + txtBienSo.Text + "',BenXe='" + txtBenXe.Text + "',SoLuongGhe=" + txtSoLuongGhe.Text + ",NgayDangKy='" + dtNgayDangKy.Value + "',TinhTrangXe='" + txtTinhTrangXe.Text + "' where MaXe =" + id + "", conn);
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
    }
}
