using DesktopDutaStoreApplication.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.Model;

namespace DesktopDutaStoreApplication.View
{
    public partial class RegisterForm : Form
    {
        RegistController RCtrl;
        public RegisterForm()
        {
            RCtrl = new RegistController();
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            try
            {
                RCtrl.AddUser(txtUsernameREG.Text, txtPasswordREG.Text, txtAccess.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                txtUsernameREG.Focus();
                MessageBox.Show("User Data Added");

                LoginForm fl = new LoginForm();
                this.Hide();
                fl.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

    

