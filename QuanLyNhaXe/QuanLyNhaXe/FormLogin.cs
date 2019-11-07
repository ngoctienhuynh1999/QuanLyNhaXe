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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
                sqlcon.Open();
                string query = "Select * from tbl_Login where username = @username and password = @password";
                var cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add(new SqlParameter("@username", txtUser.Text));
                cmd.Parameters.Add(new SqlParameter("@password", txtPass.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x >= 1)
                {
                    FormApp formApp = new FormApp();
                    formApp.user = txtUser.Text.Trim();
                    this.Hide();
                    formApp.ShowDialog();
                    this.Close();
                }
               
            }
            catch(Exception)
            {
                if (txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "")
                {
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();

                    MessageBox.Show("Hãy Nhập Username Và Password", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                    MessageBox.Show("Username Hoặc Password Không Đúng", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
