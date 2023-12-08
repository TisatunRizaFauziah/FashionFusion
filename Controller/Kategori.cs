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
    internal class Kategori : Model.Connection
    {

        Connection connec = new Connection();
        public DataTable showKategori()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM kategori ";
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
                    string query = "SELECT * FROM kategori WHERE CONCAT(id_kategori, nama_kategori) LIKE @search";
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
        public void addKategori(string idKategori, string namaKategori)
        {
            string tambah = "insert into kategori values(" + "@id_kategori,@nama_Kategori)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_kategori", MySqlConnector.MySqlDbType.VarChar).Value = idKategori;
                cmd.Parameters.Add("@nama_kategori", MySqlConnector.MySqlDbType.VarChar).Value = namaKategori;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updateKategori(string idKategori, string namaKategori)
        {
            string update = "UPDATE kategori SET id_kategori=@id_kategori, nama_kategori=@nama_kategori WHERE id_kategori = @id_kategori";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_kategori", MySqlDbType.VarChar).Value = idKategori;
                    cmd.Parameters.Add("@nama_kategori", MySqlDbType.VarChar).Value = namaKategori;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deleteKategori(string id)
        {

            string delete = "DELETE FROM kategori WHERE id_kategori = @id_kategori";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_kategori", MySqlDbType.VarChar).Value = id;
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
