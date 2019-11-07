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
            txtPass.Text = "";
            txtRePass.Text = "";
            txtPass.Focus();
        }
    }
}
