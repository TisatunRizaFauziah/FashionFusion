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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }
        private void pictureBoxLpPenjualan_Click_1(object sender, EventArgs e)
        {
            FormLaporanPenjualan pl = new FormLaporanPenjualan();
            pl.Show();
            this.Hide();
        }

        private void PictureBoxLpPembelian_Click_1(object sender, EventArgs e)
        {
            FormLaporanPembelian pb = new FormLaporanPembelian();
            pb.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }
    }
}
