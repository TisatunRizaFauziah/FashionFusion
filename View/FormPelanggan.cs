using FashionFusion.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionFusion.View
{
    public partial class FormPelanggan : Form
    {
        Pelanggan pl = new Pelanggan();
        public FormPelanggan()
        {
            InitializeComponent();
            showPelanggan();
            this.DoubleBuffered = true;
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {

        }

             
        public void showPelanggan()
        {
            dtPelanggan.DataSource = pl.showPelanggan();
            dtPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormPelangganAdd pl = new FormPelangganAdd();
            pl.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormPelangganUpdate pl = new FormPelangganUpdate();
            pl.Show();
            this.Hide();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormPelangganDelete pl = new FormPelangganDelete();
            pl.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtPelanggan.DataSource = pl.Search(txtSearch.Text);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtPelanggan.DataSource = pl.Search(txtSearch.Text);
        }
    }
}
