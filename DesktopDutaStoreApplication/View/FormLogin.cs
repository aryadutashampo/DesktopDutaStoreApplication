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
using System.Data.SqlClient;
using DesktopDutaStoreApplication.Model;
using MySqlConnector;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormLogin : Form
    {
        private bool isDarkMode = false;
        private Connection connection;
        LoginController lCtrl;
        Valid val;
        public FormLogin()
        {
            lCtrl = new LoginController();
            val = new Valid();
            connection = new Connection();
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
            FormDaftar rf = new FormDaftar();
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Need Login Data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtUsername.Text == "Admin123" && txtPassword.Text == "12345")
            {
                FormAdmin af = new FormAdmin();
                af.Show();
                this.Hide();
            }
            if(val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text))
            {
                // Menggunakan koneksi yang telah Anda buat di class Connection
                using (MySqlConnection connection = new Connection().GetConn())
                {
                    // Lakukan kueri ke database untuk mendapatkan account_id dari akun_pelanggan
                    string query = "SELECT account_id FROM akun_pelanggan WHERE username = @username AND pw = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null) // Jika login berhasil
                        {
                            int account_id = Convert.ToInt32(result);

                            // Sekarang, kita dapat menggunakan account_id untuk mendapatkan data lain dari info_pelanggan
                            string infoQuery = "SELECT user_id, nama, email FROM info_pelanggan WHERE user_id = @account_id";

                            using (MySqlCommand infoCommand = new MySqlCommand(infoQuery, connection))
                            {
                                infoCommand.Parameters.AddWithValue("@account_id", account_id);

                                using (MySqlDataReader reader = infoCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int user_id = reader.GetInt32(0);
                                        string nama = reader.GetString(1);
                                        string email = reader.GetString(2);

                                        // Membuka formUser dan meneruskan data
                                        FormUser formUser = new FormUser();
                                        formUser.SetUserData(account_id, user_id, username, nama, password, email);
                                        formUser.Show();

                                        // Menutup form login jika diperlukan
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gagal mendapatkan informasi pengguna.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Gagal. Periksa kembali username dan password Anda.");
                        }
                    }
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
