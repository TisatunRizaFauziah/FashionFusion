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
    public partial class FormPelangganAdd : Form
    {
        Pelanggan pl = new Pelanggan();
        Validasi val = new Validasi();
        public FormPelangganAdd()
        {
            InitializeComponent();
            showPelanggan();
            this.DoubleBuffered = true;
        }

        private void FormPelangganAdd_Load(object sender, EventArgs e)
        {
            txtIdPelanggan.MaxLength = 6;
            txtNamaPelanggan.MaxLength = 225;
            txtAlamat.MaxLength = 225;
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (val.ValId(txtIdPelanggan.Text) && val.valNama(txtNamaPelanggan.Text) && val.ValAlamat(txtAlamat.Text))
            {
                try
                {
                    pl.addPelanggan(txtIdPelanggan.Text, txtNamaPelanggan.Text, txtAlamat.Text);
                    MessageBox.Show("New Pelanggan Added ", "Add Pelanggan ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                    txtIdPelanggan.Focus();
                    showPelanggan();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field ", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
