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
    public partial class FormPelangganUpdate : Form
    {
        Pelanggan pl = new Pelanggan();
        public FormPelangganUpdate()
        {
            InitializeComponent();
            showPelanggan();
            this.DoubleBuffered = true;
        }

        private void FormPelangganUpdate_Load(object sender, EventArgs e)
        {

        }      
        public void showPelanggan()
        {
            dtPelanggan.DataSource = pl.showPelanggan();
            dtPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
           

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormPelanggan pl = new FormPelanggan();
            pl.Show();
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdPelanggan.Clear();
            txtNamaPelanggan.Clear();
            txtAlamat.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                pl = new Pelanggan();
                pl.updatePelanggan(txtIdPelanggan.Text, txtNamaPelanggan.Text, txtAlamat.Text);
                MessageBox.Show("Update Success");
                showPelanggan();
                btnClear.PerformClick();
                txtIdPelanggan.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }
        }

        private void dtPelanggan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPelanggan.Text = dtPelanggan.CurrentRow.Cells[0].Value.ToString();
            txtNamaPelanggan.Text = dtPelanggan.CurrentRow.Cells[1].Value.ToString();
            txtAlamat.Text = dtPelanggan.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
