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
    internal class Distributor : Model.Connection
    {

        Connection connec = new Connection();
        public DataTable showDistributor()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = " SELECT * FROM distributor ";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void addDistributor(string idDistributor, string namaDistributor, string alamat)
        {
            string add = "insert into distributor values(" + "@id_distributor,@nama_distributor,@alamat)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@id_distributor", MySqlConnector.MySqlDbType.VarChar).Value = idDistributor;
                cmd.Parameters.Add("@nama_distributor", MySqlConnector.MySqlDbType.VarChar).Value = namaDistributor;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
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
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM distributor WHERE CONCAT(id_distributor, nama_distributor,alamat) LIKE @search";
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
        public void updateDistributor(string idDistributor, string namaDistributor, string alamat)
        {
            string update = "UPDATE distributor SET id_distributor=@id_distributor, nama_distributor=@nama_distributor,alamat=@alamat WHERE id_distributor = @id_distributor";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_distributor", MySqlDbType.VarChar).Value = idDistributor;
                    cmd.Parameters.Add("@nama_distributor", MySqlDbType.VarChar).Value = namaDistributor;
                    cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deleteDistributor(string id)
        {
            string delete = "DELETE FROM distributor WHERE id_distributor = @id_distributor";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_distributor", MySqlDbType.VarChar).Value = id;
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
