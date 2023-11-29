using DesktopDutaStoreApplication.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.Model;
using MySqlConnector;

namespace DesktopDutaStoreApplication.View
{
    public partial class LoginForm : Form
    {
        LoginController LCtrl;
        Connection Connect;
        public LoginForm()
        {
            LCtrl = new LoginController();
            Connect = new Connection();
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm RF = new RegisterForm();
            this.Hide();
            RF.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtUsername.Text;
                string password = txtPassword.Text;
                DataTable table = LCtrl.getList(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM user_access WHERE username = '" + name + "' AND access_code ='" + password + "'"));
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

