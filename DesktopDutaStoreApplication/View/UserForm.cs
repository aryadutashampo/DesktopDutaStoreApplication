using DesktopDutaStoreApplication.View;
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

namespace DesktopDutaStoreApplication
{
    public partial class UserForm : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        //Variabel Untuk Mengatur Lingkaran
        private int x;
        private int y;
        private int radius = 120;
        private Color circleColor = Color.IndianRed;

        public UserForm()
        {
            InitializeComponent();
            InitializeMode();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //Mengatur Bahasa
            pictureBoxIndonesiaUser.Visible = false;
            pictureBoxEnglishUser.Visible = true;
            //Mengatur Mode
            pictureBoxLightUser.Visible = true;
            pictureBoxDarkUser.Visible = false;
            //Mengatur Logo
            pictureBoxLogoUser.Visible = true;
            pictureBoxLogoDarkUser.Visible = false;


            // Menambahkan event handler Paint dan Resize saat form dimuat
            this.Paint += new PaintEventHandler(pictureBox_Paint);
            this.Resize += new EventHandler(UserForm_Resize);

            // Mengatur posisi awal lingkaran saat form pertama kali dimuat
            x = this.Width / 2;
            y = this.Height / 2;

            // Radius tetap sama agar lingkaran tidak berubah ukuran
            radius = 120;
        }

        //// MODE ////
        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
            InitializeCircle();
        }

        private void toggleSwithModeUser_CheckedChanged(object sender, EventArgs e)
        {
            // Ganti mode saat CheckBox diubah
            isDarkMode = toggleSwithModeUser.Checked;
            SetMode(isDarkMode);
            SetCircleColor();
        }

        private void SetMode(bool darkMode)
        {
            // Atur latar belakang form dan gambar di PictureBox berdasarkan mode
            if (darkMode)
            {
                // Mode gelap
                pictureBoxDarkUser.Visible = true;
                pictureBoxLogoDarkUser.Visible = true;
                //Pattern & Logo
                this.BackColor = Color.DarkGray;
                pictureBoxDarkUser.Image = Properties.Resources.BlackPattern;
                pictureBoxDarkUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panelTopUser.BackColor = Color.OrangeRed;
                panelBottomUser.BackColor = Color.OrangeRed;
                pictureBoxLogoDarkUser.BackColor = Color.OrangeRed;
                //Fill Color
                btnTentangUser.FillColor = Color.OrangeRed;
                btnkeluarUser.FillColor = Color.DarkOrange;
                btnHistoryPembelian.FillColor = Color.OrangeRed;
                btnTransaksi.FillColor = Color.OrangeRed;
                btnProfilPengguna.FillColor = Color.OrangeRed;
                btnKembali.FillColor = Color.DarkOrange;
                //Fore Color
                btnTentangUser.ForeColor = Color.Black;
                btnkeluarUser.ForeColor = Color.Black;
                btnHistoryPembelian.ForeColor = Color.Black;
                btnProfilPengguna.ForeColor = Color.Black;
                btnTransaksi.ForeColor = Color.Black;
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelGreetingUser.ForeColor = Color.Black;
                labelSwitchUser.ForeColor = Color.Black;
            }
            else
            {
                // Mode Terang
                pictureBoxDarkUser.Visible = false;
                pictureBoxLogoDarkUser.Visible = false;
                // Pattern & Logo
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                pictureBoxDarkUser.Image = Properties.Resources.PatternWhite;
                pictureBoxDarkUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panelTopUser.BackColor = Color.IndianRed;
                panelBottomUser.BackColor = Color.IndianRed;
                pictureBoxLogoUser.BackColor = Color.IndianRed;
                //Fill Color
                btnTentangUser.FillColor = Color.IndianRed;
                btnkeluarUser.FillColor = Color.DarkRed;
                btnHistoryPembelian.FillColor = Color.IndianRed;
                btnTransaksi.FillColor = Color.IndianRed;
                btnProfilPengguna.FillColor = Color.IndianRed;
                btnKembali.FillColor = Color.DarkRed;
                //Fore Color
                btnTentangUser.ForeColor = Color.White;
                btnkeluarUser.ForeColor = Color.White;
                btnHistoryPembelian.ForeColor = Color.White;
                btnProfilPengguna.ForeColor = Color.White;
                btnTransaksi.ForeColor = Color.White;
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelGreetingUser.ForeColor = Color.White;
                labelSwitchUser.ForeColor = Color.White;
            }
        }

        private void InitializeCircle()
        {
            // Inisialisasi posisi lingkaran saat aplikasi dimulai
            x = this.Width / 2;
            y = this.Height / 2;

            // Menggambar ulang form
            this.Invalidate();
        }

        private void SetCircleColor()
        {
            // Mengatur warna lingkaran berdasarkan mode
            if (isDarkMode)
            {
                // Mode gelap
                circleColor = Color.OrangeRed;
            }
            else
            {
                // Mode terang
                circleColor = Color.IndianRed;
            }

            // Menggambar ulang form
            this.Invalidate();
        }


        //// LINGKARAN ////

        private void UserForm_Resize(object sender, EventArgs e)
        {
            // Mengatur kembali posisi lingkaran ketika form di-resize
            x = this.Width / 2;
            y = this.Height / 2;

            // Radius tetap sama agar lingkaran tidak berubah ukuran
            radius = 120;

            // Memaksa form untuk menggambar ulang
            this.Invalidate();
        }



        // // BAHASA // //

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Mendapatkan objek Graphics dari event Paint
            Graphics g = e.Graphics;

            // Membuat objek Rectangle yang akan menentukan batas lingkaran
            Rectangle rectangle = new Rectangle(x - radius, y - radius, 2 * radius, 2 * radius);

            // Menggambar lingkaran dengan menggunakan objek Graphics
            using (SolidBrush brush = new SolidBrush(circleColor))
            {
                g.FillEllipse(brush, rectangle);
            }
        }

        private void pictureBoxEnglishUser_Click(object sender, EventArgs e)
        {
            if (pictureBoxIndonesiaUser.Visible == false)
            {
                pictureBoxIndonesiaUser.Visible = true;
                labelGreetingUser.Text = "Welcome, Costumer!";
                labelSwitchUser.Text = "Switch Mode";
                btnTransaksi.Text = "Purchase Item";
                btnProfilPengguna.Text = "User Profile";
                btnHistoryPembelian.Text = "Purchase History";
                btnTentangUser.Text = "About";
                btnkeluarUser.Text = "Exit";
                btnKembali.Text = "Back";
            }
        }

        private void pictureBoxIndonesiaUser_Click(object sender, EventArgs e)
        {
            if (pictureBoxIndonesiaUser.Visible == true)
            {
                pictureBoxIndonesiaUser.Visible = false;
                labelGreetingUser.Text = "Selamat Datang, Pelanggan!";
                labelSwitchUser.Text = "Ganti Mode";
                btnTransaksi.Text = "Beli Barang";
                btnProfilPengguna.Text = "Profil Pengguna";
                btnHistoryPembelian.Text = "History Pembelian";
                btnTentangUser.Text = "Tentang";
                btnkeluarUser.Text = "Keluar";
                btnKembali.Text = "Kembali";
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnkeluarUser_Click(object sender, EventArgs e)
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
