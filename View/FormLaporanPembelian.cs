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
    public partial class FormLaporanPembelian : Form
    {
        Laporan lp = new Laporan();
        Admin Admin = new Admin();
        public FormLaporanPembelian()
        {
            InitializeComponent();
            showLaporan();
            this.DoubleBuffered = true;
        }

        private void FormLaporanPembelian_Load(object sender, EventArgs e)
        {

        }
     
        public void showLaporan()
        {
            dtLaporanPembelian.DataSource = lp.showLaporanPembelian();
            dtLaporanPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTotal.DataSource = lp.showTotalPembelian();
            dtTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormLaporan lp = new FormLaporan();
            lp.Show();
            this.Hide();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printPreviewLaporanPb.Document = printDocumentLaporan;
            printPreviewLaporanPb.ShowDialog();
        }

        private void printDocumentLaporan_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(labelJudul.Text, new Font("Consolas", 36, FontStyle.Bold), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString(labelLaporan.Text, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, new Point(320, 160));
            int width = 100;
            int height = 100;
            Rectangle destinationRectangle = new Rectangle(150, 100, width, height);
            e.Graphics.DrawImage(pictureLogo.Image, destinationRectangle);

            Laporan lp = new Laporan();
            DataTable dtLaporanPenjualan = lp.showLaporanPembelian();
            DataTable dtTotal = lp.showTotalPembelian();
            DataTable admin = lp.showAdmin();

            // Inisialisasi variabel untuk pengaturan cetak
            int rowPosition = 250;
            int colPosition = 100;
            Font font = new Font("Arial", 10, FontStyle.Regular);

            // Judul kolom
            e.Graphics.DrawString("ID ", font, Brushes.Black, colPosition, rowPosition);
            e.Graphics.DrawString("Tgl Pembelian", font, Brushes.Black, colPosition + 60, rowPosition);
            e.Graphics.DrawString("Nama Distributor", font, Brushes.Black, colPosition + 170, rowPosition);
            e.Graphics.DrawString("Nama Pakaian", font, Brushes.Black, colPosition + 300, rowPosition);
            e.Graphics.DrawString("Ukuran", font, Brushes.Black, colPosition + 420, rowPosition);
            e.Graphics.DrawString("Harga", font, Brushes.Black, colPosition + 480, rowPosition);
            e.Graphics.DrawString("Jumlah", font, Brushes.Black, colPosition + 540, rowPosition);
            e.Graphics.DrawString("Total", font, Brushes.Black, colPosition + 620, rowPosition);


            // Garis pemisah judul kolom dan data
            rowPosition += 30;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), colPosition, rowPosition, colPosition + 660, rowPosition);

            // Data dari tabel
            foreach (DataRow row in dtLaporanPenjualan.Rows)
            {
                rowPosition += 30;
                e.Graphics.DrawString(row["id_pembelian"].ToString(), font, Brushes.Black, colPosition, rowPosition);
                e.Graphics.DrawString(Convert.ToDateTime(row["tanggal_pembelian"]).ToShortDateString(), font, Brushes.Black, colPosition + 70, rowPosition);
                e.Graphics.DrawString(row["nama_distributor"].ToString(), font, Brushes.Black, colPosition + 170, rowPosition);
                e.Graphics.DrawString(row["nama_pakaian"].ToString(), font, Brushes.Black, colPosition + 300, rowPosition);
                e.Graphics.DrawString(row["ukuran"].ToString(), font, Brushes.Black, colPosition + 430, rowPosition);
                e.Graphics.DrawString(row["harga"].ToString(), font, Brushes.Black, colPosition + 480, rowPosition);
                e.Graphics.DrawString(row["jumlah"].ToString(), font, Brushes.Black, colPosition + 560, rowPosition);
                e.Graphics.DrawString(row["total"].ToString(), font, Brushes.Black, colPosition + 630, rowPosition);
            }

            e.Graphics.DrawString("Total Pembelian   : ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            foreach (DataRow row in dtTotal.Rows)
            {
                e.Graphics.DrawString(row["total_pembelian"].ToString(), font, Brushes.Black, colPosition + 580, rowPosition + 100);
            }

            string currentDate = DateTime.Now.ToString("dd MMMM yyyy");
            e.Graphics.DrawString("Bandung, " + currentDate, font, Brushes.Black, colPosition + 480, rowPosition + 360);

            // Menambahkan spasi
            e.Graphics.DrawString(" ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            e.Graphics.DrawString("TTD Admin ", font, Brushes.Black, colPosition + 540, rowPosition + 400);
            e.Graphics.DrawString(txtAdmin.Text, font, Brushes.Black, colPosition + 520, rowPosition + 500);
        }
    }
}
