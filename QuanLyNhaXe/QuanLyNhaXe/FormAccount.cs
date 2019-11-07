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

        public string user = "";
        public FormAccount()
        {
            InitializeComponent();
            MessageBox.Show(user, "Thông Báo", MessageBoxButtons.OK);
            txtUser.Text = user;
            txtUser.Enabled = !Enabled;
        }


    }
}
