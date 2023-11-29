using DesktopDutaStoreApplication.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopDutaStoreApplication.Model;

namespace DesktopDutaStoreApplication.Controller
{
    internal class RegistController : Model.Connection
    {
        Connection Connect = new Connection();

        public void AddUser(string username, string pw, string acc)
        {
            string add = "INSERT INTO user_access VALUES(" + "@username,@pw,@acc)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.Parameters.Add("@acc", MySqlConnector.MySqlDbType.VarChar).Value = acc;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ADD USER FAILED!" + ex.Message);
            }
        }
    }
}
