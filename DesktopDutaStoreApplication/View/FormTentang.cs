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
    public partial class FormTentang : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        //Mengatur Role
        private bool isAdmin = false;


        // Metode untuk menetapkan peran admin
        public void SetRoleAdmin()
        {
            isAdmin = true;
        }

        // Metode untuk menetapkan peran user
        public void SetRoleUser()
        {
            isAdmin = false;
        }
        public FormTentang()
        {
            InitializeComponent();
            InitializeMode();
            ListFitur();
        }

        private void ListFitur()
        {
            // Tambahkan teks berbentuk list
            string listText = "Aplikasi ini dibuat untuk memenuhi UAS Pelatihan Fundamental C#. Dutastore merupakan Sistem Informasi yang dirancang untuk mempermudah proses transaksi dan pengelolaan data bagi pelanggan dan administrator. Dutastore dibangun dengan tujuan memberikan pengalaman berbelanja yang efisien dan menyeluruh, DutaStore menyediakan antarmuka yang ramah pengguna untuk mengakses dan mengelola informasi produk serta data pengguna. Fitur yang ada di aplikasi ini antara lain : \r\n1. Sign In & Sign Up\r\n2. Dark & Light Mode\r\n3. Language Switch\r\n4. CRUD\r\n5. Maximize Form\r\n6. Searching\r\n7. Print \r\nAplikasi ini menggunakan Bunifu dan Guna UI untuk framework tampilan, C# dan sqlconnector di bagian backend dan mysql dalam database. Mohon maaf apabila masih kurang dalam banyak hal selama pelatihan, terimakasih atas ilmu yang diberikan dan semoga selalu diberikan kesehatan dan perlindungan";
            txtTeksTentang.Text = listText;
            this.Controls.Add(txtTeksTentang);
        }
        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                FormUser formUser = new FormUser();
                formUser.Show();
                this.Hide();
            }
        }

        private void FormTentang_Load(object sender, EventArgs e)
        {
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
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
                //Fore Color
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
            }
            else
            {
                // Mode terang
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                panelTop.BackColor = Color.IndianRed;
                panelBottom.BackColor = Color.IndianRed;
                //Fill Color
                btnKembali.FillColor = Color.DarkRed;
                //Fore Color
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelSwitch.Text = "Switch Mode";
                btnKembali.Text = "Back";
            }
        }

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelSwitch.Text = "Ganti Mode";
                btnKembali.Text = "Kembali";
            }
        }
    }
}
