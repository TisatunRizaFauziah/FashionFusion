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
    internal class Pelanggan : Model.Connection
    {

        Connection connec = new Connection();
        public DataTable showPelanggan()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = " SELECT * FROM pelanggan ";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void addPelanggan(string idPelanggan, string namaPelanggan, string alamat)
        {
            string add = "insert into pelanggan values(" + "@id_pelanggan,@nama_pelanggan,@alamat)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@id_pelanggan", MySqlConnector.MySqlDbType.VarChar).Value = idPelanggan;
                cmd.Parameters.Add("@nama_pelanggan", MySqlConnector.MySqlDbType.VarChar).Value = namaPelanggan;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updatePelanggan(string idPelanggan, string namaPelanggan, string alamat)
        {
            string update = "UPDATE pelanggan SET id_pelanggan=@id_pelanggan, nama_pelanggan=@nama_pelanggan,alamat=@alamat WHERE id_pelanggan = @id_pelanggan";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_pelanggan", MySqlDbType.VarChar).Value = idPelanggan;
                    cmd.Parameters.Add("@nama_pelanggan", MySqlDbType.VarChar).Value = namaPelanggan;
                    cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deletePelanggan(string id)
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
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM pelanggan WHERE CONCAT(id_pelanggan, nama_pelanggan,alamat) LIKE @search";
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
    }
}
