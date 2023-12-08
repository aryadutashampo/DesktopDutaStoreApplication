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
using DesktopDutaStoreApplication.Model;
using DesktopDutaStoreApplication.Validation;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormDaftar : Form
    {
        DaftarController RCtrl;
        Valid val;
        private bool isDarkMode = false;
        public int accountId = 0;
        public int idUser = 0;
        public string namaUser = string.Empty;
        public string namaLengkap = string.Empty;
        public string passwordUser = string.Empty;
        public string emailUser = string.Empty;

        public FormDaftar()
        {
            RCtrl = new DaftarController();
            val = new Valid();
            InitializeComponent();
            InitializeMode();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //Mengatur batas inputan
            txtUserId.MaxLength = 2;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 8;
            txtNama.MaxLength = 20;
            txtAlamatEmail.MaxLength = 30;
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



        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == "" || txtUserId.Text == ""  || txtNama.Text == "" || txtAlamatEmail.Text == ""))
            {
                MessageBox.Show("Need Register Data", "Wrong Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val.valId(txtUserId.Text) && val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text) && val.valNama(txtNama.Text) && val.valEmail(txtAlamatEmail.Text))
            {
                try
                {
                    namaUser = txtUsername.Text;
                    idUser = Convert.ToInt32(txtUserId.Text);
                    accountId = Convert.ToInt32(txtUserId.Text);
                    passwordUser = txtPassword.Text;
                    namaLengkap = txtNama.Text;
                    emailUser = txtAlamatEmail.Text;
                    RCtrl.AddUserAccount(txtUserId.Text, txtUsername.Text, txtPassword.Text);
                    RCtrl.AddUserInfo(txtUserId.Text, txtNama.Text, txtAlamatEmail.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtUsername.Focus();
                    MessageBox.Show($"User Data Added\nID : {idUser}\nUsername : {namaUser}\nPassword :{passwordUser}\nNama : {namaLengkap}\nEmail: {emailUser}");
                    // Membuka formUser dan meneruskan data
                    FormUser formUser = new FormUser();
                    formUser.SetUserData(accountId, idUser, namaUser, namaLengkap, passwordUser, emailUser);
                    formUser.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormLogin lf = new FormLogin();
            this.Hide();
            lf.Show();
        }

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelRegister.Text = "DAFTAR";
                txtUsername.PlaceholderText = "Masukkan Nama Pengguna";
                txtPassword.PlaceholderText = "Masukkan Kata Sandi";
                txtNama.PlaceholderText = "Masukkan Nama Lengkap";
                txtAlamatEmail.PlaceholderText = "Masukkan Alamat";
                btnKembali.Text = "Kembali";
                btnKonfirmasi.Text = "Konfirmasi";
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelRegister.Text = "SIGN UP";
                txtUsername.PlaceholderText = "Input username";
                txtPassword.PlaceholderText = "Input password";
                txtNama.PlaceholderText = "Input fullname";
                txtAlamatEmail.PlaceholderText = "Input Adress";
                btnKembali.Text = "Back";
                btnKonfirmasi.Text = "Confirm";
            }

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
                labelRegister.ForeColor = Color.White;
                btnKonfirmasi.ForeColor = Color.Brown;
                btnKembali.ForeColor = Color.Brown;
                //Fill Color
                btnKonfirmasi.FillColor = Color.White;
                btnKembali.FillColor = Color.White;
            }
            else
            {
                pictureBoxOrnamentBottomRed.Visible = false;
                pictureBoxOrnamentTopRed.Visible = false;
                // Mode terang
                //Pattern
                this.BackColor = Color.White;
                labelRegister.ForeColor = Color.Brown;
                btnKonfirmasi.ForeColor = Color.White;
                btnKembali.ForeColor = Color.White;
                //Fill Color
                btnKonfirmasi.FillColor = Color.Brown;
                btnKembali.FillColor = Color.Brown;
            }
        }

        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}

    

