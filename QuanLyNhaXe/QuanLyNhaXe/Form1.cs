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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TIEN-PC;Initial Catalog=QuanLyNhaXe;Integrated Security=True");
            string query = "Select * from tbl_Login where username ='" + txtUser.Text.Trim() + "' and password ='" + txtPass.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form2 objForm2 = new Form2();
                this.Hide();
                objForm2.Show();
            }
            else
            {
                if(txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Username Và Password","Thông Báo",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Username Hoặc Password Không Đúng", "Thông Báo",MessageBoxButtons.OK);
                }
                
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
