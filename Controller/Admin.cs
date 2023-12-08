using FashionFusion.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FashionFusion.Controller
{
    internal class Admin : Model.Connection
    {
        Connection koneksi = new Connection();
        public DataTable getlist(MySqlCommand cmd)
        {
            cmd.Connection = koneksi.GetConn();
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void tambahAdmin(string id, string admin, string pass)
        {
            string tambah = " INSERT INTO admin VALUES (" + "@id,@admin,@passwoard)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@admin", MySqlConnector.MySqlDbType.VarChar).Value = admin;
                cmd.Parameters.Add("@passwoard", MySqlConnector.MySqlDbType.VarChar).Value = pass;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);

            }
        }
    }
}
