using DesktopDutaStoreApplication.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.Controller
{
    internal class RegistController : Model.Connection
    {
        Connection Connect = new Connection();

        public void AddUser(string userid, string username, string pw, string nama, string email)
        {
            string add = "INSERT INTO pengguna VALUES(" + "@userid,@username,@pw,@nama,@email);";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@userid", MySqlConnector.MySqlDbType.VarChar).Value = userid;
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ADD USER FAILED!" + ex.Message);
            }
        }
    }
}
