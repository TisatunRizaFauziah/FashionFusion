using FashionFusion.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionFusion.Controller
{
    internal class Pakaian : Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showPakaian()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM pakaian ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void addPakaian(string idPakaian, string namaPakaian, string idKategori, string harga, string ukuran, string stok)
        {
            string tambah = "insert into pakaian values(" + "@id_pakaian,@nama_pakaian,@id_kategori,@harga,@ukuran,@stok)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pakaian", MySqlConnector.MySqlDbType.VarChar).Value = idPakaian;
                cmd.Parameters.Add("@nama_pakaian", MySqlConnector.MySqlDbType.VarChar).Value = namaPakaian;
                cmd.Parameters.Add("@id_kategori", MySqlConnector.MySqlDbType.VarChar).Value = idKategori;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@ukuran", MySqlConnector.MySqlDbType.VarChar).Value = ukuran;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlConnection connection = connec.GetConn(); // Pastikan Anda memiliki objek koneksi yang benar
                string query = "SELECT * FROM pakaian WHERE CONCAT(id_pakaian, nama_pakaian, id_kategori, harga, ukuran,stok) LIKE @search";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror search: " + ex.Message);
            }
            return table;
        }
        public void updatePakaian(string idPakaian, string namaPakaian, string idKategori, string harga, string ukuran, string stok)
        {
            string update = "UPDATE pakaian SET id_pakaian=@id_pakaian, nama_pakaian=@nama_pakaian, id_kategori=@id_kategori, harga=@harga, ukuran=@ukuran, stok=@stok WHERE id_pakaian = @id_pakaian";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_pakaian", MySqlDbType.VarChar).Value = idPakaian;
                    cmd.Parameters.Add("@nama_pakaian", MySqlDbType.VarChar).Value = namaPakaian;
                    cmd.Parameters.Add("@id_kategori", MySqlDbType.VarChar).Value = idKategori;
                    cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga;
                    cmd.Parameters.Add("@ukuran", MySqlDbType.VarChar).Value = ukuran;
                    cmd.Parameters.Add("@stok", MySqlDbType.VarChar).Value = stok;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }

        public void deletePakaian(string id)
        {

            string delete = "DELETE FROM pakaian WHERE id_pakaian = @id_pakaian";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_pakaian", MySqlDbType.VarChar).Value = id;
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
