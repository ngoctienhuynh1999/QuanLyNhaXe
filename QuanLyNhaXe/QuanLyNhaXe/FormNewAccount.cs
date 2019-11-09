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
    public partial class FormNewAccount : Form
    {
        public string user = "";
        public FormNewAccount()
        {
            InitializeComponent();
        }

        private void BtnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtRepass.Text == "" || cmbChucNang.SelectedItem == null)
            {
                MessageBox.Show("Mời Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
                txtPass.Text = "";
                txtRepass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
            else
            {
                if(txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("Mời Nhập lại Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                    txtPass.Text = "";
                    txtRepass.Text = "";
                    txtPass.Focus();
                }
                else
                {
                    string role = cmbChucNang.SelectedItem.ToString();
                    switch (role)
                    {
                        case "Nhân Viên Vé":
                            role = "nhanvienve";
                            break;
                        case "Nhân Viên Kỹ Thuật":
                            role = "nhanvienkythuat";
                            break;
                        case "Nhân Viên Lộ Trình":
                            role = "nhanvienlotrinh";
                            break;
                        case "Nhân Viên Nhân Sự":
                            role = "nhanviennhansu";
                            break;
                    }

                    SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;User ID=sa;Password=123");
                    SqlCommand cmd = new SqlCommand("insert into tbl_Login values('" + txtUser.Text + "'," + txtPass.Text + ",'" + role + "');", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    MessageBox.Show("Tạo Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    conn.Close();
                    FormApp formApp = new FormApp();
                    formApp.user = user;
                    this.Hide();
                    formApp.ShowDialog();
                    this.Close();
                }
                
            }
            
        }

        private void BtnHuyAccount_Click(object sender, EventArgs e)
        {
            FormApp formApp = new FormApp();
            formApp.user = user;
            this.Hide();
            formApp.ShowDialog();
            this.Close();
        }
    }
}
