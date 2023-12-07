using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.View;
using DesktopDutaStoreApplication.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.View
{
    public partial class LoginForm : Form
    {
        private bool isDarkMode = false;
        LoginController lCtrl;
        Valid val;
        public LoginForm()
        {
            lCtrl = new LoginController();
            val = new Valid();
            InitializeComponent();
            InitializeMode();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Mengatur Batas Input
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 8;
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            //Mengatur Mode
            pictureBoxOrnamentTopWhite.Visible = true;
            pictureBoxOrnamentBottomWhite.Visible = true;
            pictureBoxOrnamentTopRed.Visible = false;
            pictureBoxOrnamentBottomRed.Visible = false;
        }

        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelLogin.Text = "MASUK";
                labelAsk.Text = "Belum punya akun?";
                labelSignUp.Text = "Daftar";
                btnConfirm.Text = "Konfirmasi";
                btnKeluar.Text = "Keluar";
                txtUsername.PlaceholderText = "Masukkan Nama Pengguna";
                txtPassword.PlaceholderText = "Masukkan Kata Sandi";
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelLogin.Text = "LOGIN";
                labelAsk.Text = "Didn't have account?";
                labelSignUp.Text = "Register";
                btnConfirm.Text = "Confirm";
                btnKeluar.Text = "Exit";
                txtUsername.PlaceholderText = "Input Username";
                txtPassword.PlaceholderText = "input Password";
            }
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }

        private void toggleSwithMode_CheckedChanged(object sender, EventArgs e)
        {
            // Ganti mode saat CheckBox diubah
            isDarkMode = toggleSwithMode.Checked;
            SetMode(isDarkMode);
        }

        private void SetMode(bool darkMode)
        {
            // Atur latar belakang form dan gambar di PictureBox berdasarkan mode
            if (darkMode)
            {
                // Mode Merah
                pictureBoxOrnamentBottomRed.Visible = true;
                pictureBoxOrnamentTopRed.Visible = true;
                this.BackColor = Color.FromArgb(241, 30, 38);
                //Fore Color
                labelLogin.ForeColor = Color.White;
                labelAsk.ForeColor = Color.White;
                btnConfirm.ForeColor = Color.Brown;
                btnKeluar.ForeColor = Color.Brown;
                //Fill Color
                btnConfirm.FillColor = Color.White;
                btnKeluar.FillColor = Color.White;
            }
            else
            {
                pictureBoxOrnamentBottomRed.Visible = false;
                pictureBoxOrnamentTopRed.Visible = false;
                // Mode terang
                //Pattern
                this.BackColor = Color.White;
                labelLogin.ForeColor = Color.Brown;
                labelAsk.ForeColor = Color.Black;
                btnConfirm.ForeColor = Color.White;
                btnKeluar.ForeColor = Color.White;
                //Fill Color
                btnConfirm.FillColor = Color.Brown;
                btnKeluar.FillColor = Color.Brown;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Need Login Data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtUsername.Text == "Admin123" && txtPassword.Text == "12345")
            {
                AdminForm af = new AdminForm();
                af.Show();
                this.Hide();
            }
            if(val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text))
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    DataTable table = lCtrl.getList(new MySqlConnector.MySqlCommand
                        ("SELECT * FROM pengguna WHERE username = '" + username + "' AND pw ='" + password + "'"));

                    if (table.Rows.Count > 0)
                    {
                        UserForm uf = new UserForm();
                        uf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Menampilkan pesan konfirmasi sebelum keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Memeriksa apakah pengguna mengklik tombol Yes
            if (result == DialogResult.Yes)
            {
                // Keluar dari aplikasi jika dikonfirmasi
                Application.Exit();
            }
        }
    }
}
