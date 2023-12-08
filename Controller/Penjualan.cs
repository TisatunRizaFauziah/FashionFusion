using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionFusion.Model;
using System.Windows.Forms;
using MySqlConnector;

namespace FashionFusion.Controller
{
    internal class Penjualan : Model.Connection
    {

        Connection connec = new Connection();
        public DataTable showPemjualan()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM penjualan ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM penjualan WHERE CONCAT(id_penjualan, tanggal_penjualan,id_pelanggan,id_pakaian,jumlah) LIKE @search";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + search + "%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            return table;
        }
        public void addPenjualan(string idPenjualan, DateTime tanggalPenjualan, string idPelanggan, string idPakaian, string jml)
        {
            string tambah = "insert into penjualan values(" + "@id_penjualan,@tanggal_penjualan,@id_pelanggan,@id_pakaian,@jumlah)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_penjualan", MySqlConnector.MySqlDbType.VarChar).Value = idPenjualan;
                cmd.Parameters.Add("@tanggal_penjualan", MySqlConnector.MySqlDbType.DateTime).Value = tanggalPenjualan;
                cmd.Parameters.Add("@id_pelanggan", MySqlConnector.MySqlDbType.VarChar).Value = idPelanggan;
                cmd.Parameters.Add("@id_pakaian", MySqlConnector.MySqlDbType.VarChar).Value = idPakaian;
                cmd.Parameters.Add("@jumlah", MySqlConnector.MySqlDbType.VarChar).Value = jml;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updatePenjualan(string idPenjualan, DateTime tanggalPenjualan, string idPelanggan, string idPakaian, string jml)
        {
            string update = "UPDATE penjualan SET tanggal_penjualan=@tanggal_penjualan, id_pelanggan=@id_pelanggan, id_pakaian=@id_pakaian, jumlah=@jumlah WHERE id_penjualan=@id_penjualan";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_penjualan", MySqlDbType.VarChar).Value = idPenjualan;
                    cmd.Parameters.Add("@tanggal_penjualan", MySqlDbType.DateTime).Value = tanggalPenjualan;
                    cmd.Parameters.Add("@id_pelanggan", MySqlDbType.VarChar).Value = idPelanggan;
                    cmd.Parameters.Add("@id_pakaian", MySqlDbType.VarChar).Value = idPakaian;
                    cmd.Parameters.Add("@jumlah", MySqlDbType.VarChar).Value = jml;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }
        }

        public void deletePenjualan(string id)
        {

            string delete = "DELETE FROM penjualan WHERE id_penjualan = @id_penjualan";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_penjualan", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete: " + ex.Message);
            }


        }
    }
}
