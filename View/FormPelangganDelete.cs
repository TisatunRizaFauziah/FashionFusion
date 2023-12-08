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
    public partial class FormPelangganDelete : Form
    {
        Pelanggan pl = new Pelanggan();
        public FormPelangganDelete()
        {
            InitializeComponent();
            showPelanggan();
            this.DoubleBuffered = true;
        }

        private void FormPelangganDelete_Load(object sender, EventArgs e)
        {

        }

        public void showPelanggan()
        {
            dtPelanggan.DataSource = pl.showPelanggan();
            dtPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdPelanggan.Text) || string.IsNullOrEmpty(txtNamaPelanggan.Text) || string.IsNullOrEmpty(txtAlamat.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    pl = new Pelanggan();
                    pl.deletePelanggan(txtIdPelanggan.Text);
                    showPelanggan();
                    btnClear.PerformClick();
                    MessageBox.Show("pelanggan Deleted Suksess", "Delete palanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPelanggan.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ", "Delete Pelanggan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
