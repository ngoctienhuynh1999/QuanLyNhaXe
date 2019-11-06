﻿using System;
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

        private void GridVeXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                btnThemVe.Enabled = !Enabled;
            }
        }

        private void TrangChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApp formApp = new FormApp();
            formApp.user = user;
            this.Hide();
            formApp.ShowDialog();
            this.Close();
        }
    }
}
