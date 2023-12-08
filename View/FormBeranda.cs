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
    public partial class FormBeranda : Form
    {
        private string loggedInUser;
        public FormBeranda()
        {
            InitializeComponent();
            // biar nggak kedip kedip backgraoundnya
            this.DoubleBuffered = true;

            lblWelcome.Text = "admin : @" + AppSession.LoggedInUser + "!";

        }

        private void pictureBoxPakaian_Click(object sender, EventArgs e)
        {
            FormPakaian pk = new FormPakaian();
            pk.Show();
            this.Hide();
        }

        private void pictureBoxPelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan pl = new FormPelanggan();
            pl.Show();
            this.Hide();
        }

        private void pictureDistributor_Click(object sender, EventArgs e)
        {
            FormDistributor ds = new FormDistributor();
            ds.Show();
            this.Hide();
        }

        private void pictureBoxKategori_Click(object sender, EventArgs e)
        {
            FormKategori kt = new FormKategori();
            kt.Show();
            this.Hide();
        }

        private void pictureBoxPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan pj = new FormPenjualan();
            pj.Show();
            this.Hide();
        }

        private void pictureBoxPembelian_Click(object sender, EventArgs e)
        {
            FormPembelian pb = new FormPembelian();
            pb.Show();
            this.Hide();
        }

        private void pictureBoxLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan pl = new FormLaporan();
            pl.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormSignIn sign = new FormSignIn();
            sign.Show();
            this.Hide();

        }

        private void pictureBoxAbout_Click(object sender, EventArgs e)
        {
            FormAbout ab = new FormAbout();
            ab.Show(); 
            this.Hide();

        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {

        }
    }
}
