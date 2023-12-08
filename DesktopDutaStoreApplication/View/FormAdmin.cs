using DesktopDutaStoreApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication
{
    public partial class FormAdmin : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        //Variabel Untuk Mengatur Lingkaran
        private int x;
        private int y;
        private int radius = 120;
        private Color circleColor = Color.IndianRed;

        public FormAdmin()
        {
            InitializeComponent();
            InitializeMode();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            //Mengatur Mode
            pictureBoxLight.Visible = true;
            pictureBoxDark.Visible = false;
            //Mengatur Logo
            pictureBoxLogoWhite.Visible = true;
            pictureBoxLogoDarkAdmin.Visible = false;


            // Menambahkan event handler Paint dan Resize saat form dimuat
            this.Paint += new PaintEventHandler(pictureBox_Paint);
            this.Resize += new EventHandler(AdminForm_Resize);

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

        private void toggleSwithMode_CheckedChanged(object sender, EventArgs e)
        {
            // Ganti mode saat CheckBox diubah
            isDarkMode = toggleSwithMode.Checked;
            SetMode(isDarkMode);
            SetCircleColor();
        }

        private void SetMode(bool darkMode)
        {
            // Atur latar belakang form dan gambar di PictureBox berdasarkan mode
            if (darkMode)
            {
                // Mode gelap
                pictureBoxDark.Visible = true;
                pictureBoxLogoDarkAdmin.Visible = true;
                //Pattern
                this.BackColor = Color.DarkGray;
                pictureBoxDark.Image = Properties.Resources.BlackPattern;
                pictureBoxDark.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panelTop.BackColor = Color.OrangeRed;
                panelBottom.BackColor = Color.OrangeRed;
                pictureBoxLogoDarkAdmin.BackColor = Color.OrangeRed;
                //Fill Color
                btnAbout.FillColor = Color.OrangeRed;
                btnExit.FillColor = Color.DarkOrange;
                btnHistory.FillColor = Color.OrangeRed;
                btnManageBarang.FillColor = Color.OrangeRed;
                btnManagePelanggan.FillColor = Color.OrangeRed;
                btnKembali.FillColor = Color.DarkOrange;
                //Fore Color
                btnAbout.ForeColor = Color.Black;
                btnExit.ForeColor = Color.Black;
                btnHistory.ForeColor = Color.Black;
                btnManageBarang.ForeColor = Color.Black;
                btnManagePelanggan.ForeColor = Color.Black;
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelGreeting.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
            }
            else
            {
                pictureBoxDark.Visible = false;
                pictureBoxLogoDarkAdmin.Visible = false;
                // Mode terang
                //Pattern
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                pictureBoxDark.Image = Properties.Resources.PatternWhite;
                pictureBoxDark.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panelTop.BackColor = Color.IndianRed;
                panelBottom.BackColor = Color.IndianRed;
                pictureBoxLogoWhite.BackColor = Color.IndianRed;
                //Fill Color
                btnAbout.FillColor = Color.IndianRed;
                btnExit.FillColor = Color.DarkRed;
                btnHistory.FillColor = Color.IndianRed;
                btnManageBarang.FillColor = Color.IndianRed;
                btnManagePelanggan.FillColor = Color.IndianRed;
                btnKembali.FillColor = Color.DarkRed;
                //Fore Color
                btnAbout.ForeColor = Color.White;
                btnExit.ForeColor = Color.White;
                btnHistory.ForeColor = Color.White;
                btnManageBarang.ForeColor = Color.White;
                btnManagePelanggan.ForeColor = Color.White;
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelGreeting.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
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

        private void AdminForm_Resize(object sender, EventArgs e)
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
        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelGreeting.Text = "Selamat Datang, Admin!";
                labelSwitch.Text = "Ganti Mode";
                btnManageBarang.Text = "Atur Barang";
                btnManagePelanggan.Text = "Atur Pelanggan";
                btnHistory.Text = "Riwayat";
                btnAbout.Text = "Tentang";
                btnExit.Text = "Keluar";
                btnKembali.Text = "Kembali";
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelGreeting.Text = "Welcome, Admin!";
                labelSwitch.Text = "Switch Mode";
                btnManageBarang.Text = "Manage Items";
                btnManagePelanggan.Text = "Manage Costumer";
                btnHistory.Text = "History";
                btnAbout.Text = "About";
                btnExit.Text = "Exit";
                btnKembali.Text = "Back";
            }
        }

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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormLogin lf = new FormLogin();
            this.Hide();
            lf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            string waUrl = "https://wa.link/2b98uf";
            Process.Start(waUrl);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormTentang formTentang = new FormTentang();
            formTentang.SetRoleAdmin(); // Tentukan peran admin
            formTentang.Show();
            this.Hide();
        }

        private void btnHistoryPenjualan_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.SetRoleAdmin(); // Tentukan peran admin
            formRiwayat.Show();
            this.Hide();
        }

        private void btnManagePelanggan_Click(object sender, EventArgs e)
        {
            FormAturPelanggan fp = new FormAturPelanggan();
            fp.Show();
            this.Hide();
        }

        private void btnManageBarang_Click(object sender, EventArgs e)
        {
            FormAturBarang fb = new FormAturBarang();
            fb.Show();
            this.Hide();
        }
    }
}
