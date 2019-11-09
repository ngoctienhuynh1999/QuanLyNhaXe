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
    
    public partial class FormVeXe : Form
    {
        public string user = "";
        public FormVeXe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("select * from VeXe", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();

            gridVeXe.DataSource = table;
        }


        private void GridVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridVeXe.Rows[e.RowIndex];

                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDiemDi.Text = row.Cells["DiemDi"].Value.ToString();
                txtDiemDen.Text = row.Cells["DiemDen"].Value.ToString();
                dtNgayDi.Value = Convert.ToDateTime(row.Cells["NgayDi"].Value);
                txtGioKhoiHanh.Text = row.Cells["GioKhoiHanh"].Value.ToString();
                txtSoXe.Text = row.Cells["SoXe"].Value.ToString();
                txtSoGhe.Text = row.Cells["SoGhe"].Value.ToString();
            }
        }

        private void BtnThemVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("insert into VeXe values('"+txtTenKH.Text+"',"+txtSoGhe.Text+","+txtSoXe.Text+",'"+txtDiemDi.Text+"','"+txtDiemDen.Text+"','"+dtNgayDi.Value+"','"+txtGioKhoiHanh.Text+"',90000);", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();  
        }

        private void BtnHuyVe_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSoGhe.Text = "";
            txtSoXe.Text = "";
            txtDiemDi.Text = "";
            txtDiemDen.Text = "";
            txtGioKhoiHanh.Text = "";
            txtTenKH.Focus();
        }

        private void BtnUpdateVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridVeXe.Rows[gridVeXe.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Update VeXe set TenKH='"+txtTenKH.Text+"',SoGhe=" + txtSoGhe.Text + ",SoXe="+txtSoXe.Text+",DiemDi='" + txtDiemDi.Text + "',DiemDen='" + txtDiemDen.Text + "',NgayDi='" + dtNgayDi.Value + "',GioKhoiHanh='" + txtGioKhoiHanh.Text + "' where MaVe ="+id+"", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            LoadData();
            conn.Close();
        }

        private void BtnXoaVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
            DataGridViewRow row = gridVeXe.Rows[gridVeXe.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand("Delete from VeXe where MaVe =" + id + "", conn);
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
    }
}
