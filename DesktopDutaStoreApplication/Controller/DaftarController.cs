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
    internal class DaftarController : Model.Connection
    {
        Connection Connect = new Connection();

        public void AddUserAccount(string accountId, string username, string pw)
        {
            string addAccount = "INSERT INTO akun_pelanggan VALUES(" + "@accountId,@username,@pw);";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addAccount, GetConn());
                cmd.Parameters.Add("@accountId", MySqlConnector.MySqlDbType.VarChar).Value = accountId;
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ADD USER ACCOUNT FAILED!" + ex.Message);
            }
        }
        public void AddUserInfo(string userid, string nama, string email)
        {
            string addInfo = "INSERT INTO info_pelanggan VALUES(" + "@userid,@nama,@email);";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addInfo, GetConn());
                cmd.Parameters.Add("@userid", MySqlConnector.MySqlDbType.VarChar).Value = userid;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ADD USER DATA FAILED!" + ex.Message);
            }
        }

    }
}
