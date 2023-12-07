using MySqlConnector;
using DesktopDutaStoreApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DesktopDutaStoreApplication.Controller
{
    internal class LoginController : Model.Connection
    {
        Connection Connect = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = Connect.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
