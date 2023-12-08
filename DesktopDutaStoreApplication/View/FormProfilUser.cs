using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormProfilUser : Form
    {
        private bool isDarkMode = false;
        Valid val = new Valid();
        private Pelanggancontroller pCtrl;
        // Properti untuk menetapkan dan mengakses data pengguna
        public int uAccountId { get; set; }
        public int uIdUser { get; set; }
        public string uNamaUser { get; set; }
        public string uNamaLengkap { get; set; }
        public string uPasswordUser { get; set; }
        public string uEmailUser { get; set; }

        // Metode untuk menetapkan data pengguna
        public void SetUserData(int accountId, int idUser, string namaUser, string namaLengkap, string passwordUser, string emailUser)
        {
            uAccountId = accountId;
            uIdUser = idUser;
            uNamaUser = namaUser;
            uNamaLengkap = namaLengkap;
            uPasswordUser = passwordUser;
            uEmailUser = emailUser;
        }

        public FormProfilUser()
        {
            pCtrl = new Pelanggancontroller();
            InitializeComponent();
            InitializeMode();
        }
        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }

        private void FormProfilUser_Load(object sender, EventArgs e)
        {
            txtIdUser.Text = Convert.ToString(uIdUser);
            txtUsername.Text = uNamaUser;
            txtPassword.Text = uPasswordUser;
            txtNama.Text = uNamaLengkap;
            txtemail.Text = uEmailUser;
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            //Mengatur Batas Input
            txtIdUser.MaxLength = 2;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 8;
            txtNama.MaxLength = 20;
            txtemail.MaxLength = 30;
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
                // Mode gelap
                this.BackColor = Color.Black;
                panelTop.BackColor = Color.OrangeRed;
                panelBottom.BackColor = Color.OrangeRed;
                btnKembali.FillColor = Color.DarkOrange;
                btnUpdate.FillColor = Color.DarkOrange;
                btnHapus.FillColor = Color.DarkOrange;
                //Fore Color
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
                btnHapus.ForeColor = Color.Black;
                btnUpdate.ForeColor = Color.Black;
                labelEdit.ForeColor = Color.White;
            }
            else
            {
                // Mode terang
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                panelTop.BackColor = Color.IndianRed;
                panelBottom.BackColor = Color.IndianRed;
                //Fill Color
                btnKembali.FillColor = Color.DarkRed;
                btnUpdate.FillColor = Color.DarkRed;
                btnHapus.FillColor= Color.DarkRed;
                //Fore Color
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
                btnHapus.ForeColor = Color.White;
                btnUpdate.ForeColor= Color.White;
                labelEdit.ForeColor= Color.DarkRed;
            }
        }


        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelSwitch.Text = "Ganti Mode";
                btnKembali.Text = "Kembali";
                txtemail.PlaceholderText = "Email";
                txtIdUser.PlaceholderText = "ID Pelanggan";
                txtNama.PlaceholderText = "Nama Lengkap";
                txtUsername.PlaceholderText = "Nama Pengguna";
                txtPassword.PlaceholderText = "Kata Kunci";
                btnUpdate.Text = "Perbarui";
                btnHapus.Text = "Hapus";
                labelEdit.Text = "Ubah Akun";
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelSwitch.Text = "Switch Mode";
                btnKembali.Text = "Back";
                txtemail.PlaceholderText = "Email";
                txtIdUser.PlaceholderText = "ID User";
                txtNama.PlaceholderText = "Fullname";
                txtUsername.PlaceholderText = "Username";
                txtPassword.PlaceholderText = "Password";
                btnUpdate.Text = "Update";
                btnHapus.Text = "Delete";
                labelEdit.Text = "Edit Account";
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser();
            user.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtIdUser.Text == "")
            {
                MessageBox.Show("Need Data", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val.valId(txtIdUser.Text) && val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text) && val.valNama(txtNama.Text) && val.valEmail(txtemail.Text))
            {
                try
                {
                    pCtrl = new Pelanggancontroller();
                    pCtrl.updateAkunPelanggan(txtIdUser.Text, txtUsername.Text, txtPassword.Text);
                    pCtrl.updateDataPelanggan(txtIdUser.Text, txtNama.Text, txtemail.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtIdUser.Focus();
                    MessageBox.Show("Data Pelanggan diupdate");
                    FormLogin fl = new FormLogin();
                    fl.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text == "")
            {
                MessageBox.Show("Need Data", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtIdUser.Text != "")
            {
                try
                {
                    pCtrl.hapusAkunPelanggan(txtIdUser.Text);
                    pCtrl.hapusDataPelanggan(txtIdUser.Text);
                    MessageBox.Show("Data Pelanggan Berhasil Dihapus", "Hapus Data Peserta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdUser.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Data Pelanggan gagal dihapus", "Hapus Data Pelanggan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();

        }
    }
}
