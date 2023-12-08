using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionFusion.Controller
{
    internal class Laporan : Model.Connection
    {
        public DataTable showLaporanPenjualan()
        {
            DataTable dt = new DataTable();


            try
            {
                string show = @"SELECT
                penjualan.id_penjualan,
                penjualan.tanggal_penjualan,
                pelanggan.nama_pelanggan,
                pakaian.nama_pakaian,
                pakaian.ukuran,
                penjualan.jumlah,
                pakaian.harga,
                penjualan.jumlah * pakaian.harga AS total
                FROM penjualan
                INNER JOIN pelanggan ON penjualan.id_pelanggan = pelanggan.id_pelanggan
                INNER JOIN pakaian ON penjualan.id_pakaian = pakaian.id_pakaian
                GROUP BY
                penjualan.id_penjualan,
                penjualan.tanggal_penjualan,
                pelanggan.nama_pelanggan,
                pakaian.nama_pakaian,
                pakaian.ukuran,
                penjualan.jumlah,
                pakaian.harga";

                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable showTotal()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"SELECT
                SUM(penjualan.jumlah * pakaian.harga) AS total_penjualan
                FROM penjualan
                INNER JOIN pelanggan ON penjualan.id_pelanggan = pelanggan.id_pelanggan
                INNER JOIN pakaian ON penjualan.id_pakaian = pakaian.id_pakaian";


                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
        public DataTable showAdmin()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM admin ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable showLaporanPembelian()
        {
            DataTable dt = new DataTable();


            try
            {
                string show = @"
                SELECT 
                p.id_pembelian,
                p.tanggal_pembelian,
                d.nama_distributor,
                pa.nama_pakaian,
                pa.ukuran,
                pa.harga,
                p.jumlah,
                p.jumlah * pa.harga AS total
                FROM 
                pembelian p
                JOIN 
                distributor d ON p.id_distributor = d.id_distributor
                JOIN 
                pakaian pa ON p.id_pakaian = pa.id_pakaian";


                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable showTotalPembelian()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"SELECT
                SUM(pembelian.jumlah * pakaian.harga) AS total_pembelian
                FROM pembelian
                INNER JOIN distributor ON pembelian.id_distributor = distributor.id_distributor
                INNER JOIN pakaian ON pembelian.id_pakaian = pakaian.id_pakaian";


                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
    }
}
