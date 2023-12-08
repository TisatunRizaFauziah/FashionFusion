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
    internal class Pembelian : Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showPembelian()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM pembelian ";
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
                    string query = "SELECT * FROM pembelian WHERE CONCAT(id_pembelian, tanggal_pembelian,id_distributor,id_pakaian,jumlah) LIKE @search";
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
        public void addPembelian(string idPembelian, DateTime tanggalPembelian, string idDistributor, string idPakaian, string jml)
        {
            string tambah = "insert into pembelian values(" + "@id_pembelian,@tanggal_pembelian,@id_distributor,@id_pakaian,@jumlah)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pembelian", MySqlConnector.MySqlDbType.VarChar).Value = idPembelian;
                cmd.Parameters.Add("@tanggal_pembelian", MySqlConnector.MySqlDbType.DateTime).Value = tanggalPembelian;
                cmd.Parameters.Add("@id_distributor", MySqlConnector.MySqlDbType.VarChar).Value = idDistributor;
                cmd.Parameters.Add("@id_pakaian", MySqlConnector.MySqlDbType.VarChar).Value = idPakaian;
                cmd.Parameters.Add("@jumlah", MySqlConnector.MySqlDbType.VarChar).Value = jml;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updatePembelian(string idPembelian, DateTime tanggalPembelian, string idDistributor, string idPakaian, string jml)
        { 
            string update = "UPDATE pembelian SET tanggal_pembelian=@tanggal_pembelian,id_distributor=@id_distributor,id_pakaian=@id_pakaian,jumlah=@jumlah WHERE id_pembelian=@id_pembelian";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_pembelian", MySqlConnector.MySqlDbType.VarChar).Value = idPembelian;
                    cmd.Parameters.Add("@tanggal_pembelian", MySqlConnector.MySqlDbType.DateTime).Value = tanggalPembelian;
                    cmd.Parameters.Add("@id_distributor", MySqlConnector.MySqlDbType.VarChar).Value = idDistributor;
                    cmd.Parameters.Add("@id_pakaian", MySqlConnector.MySqlDbType.VarChar).Value = idPakaian;
                    cmd.Parameters.Add("@jumlah", MySqlConnector.MySqlDbType.VarChar).Value = jml;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deletePembelian(string id)
        {

            string delete = "DELETE FROM pelanggan WHERE id_pelanggan = @id_pelanggan";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_pelanggan", MySqlDbType.VarChar).Value = id;
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
