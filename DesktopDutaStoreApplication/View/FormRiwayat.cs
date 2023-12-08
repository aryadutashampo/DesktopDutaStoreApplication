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

namespace DesktopDutaStoreApplication.View
{
    public partial class FormRiwayat : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        private HistoryController hCtrl;
        public FormRiwayat()
        {
            hCtrl = new HistoryController();
            InitializeComponent();
            InitializeMode();
        }

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

        private void ShowBarang()
        {
            dataGridViewHistory.DataSource = hCtrl.seeHistory();
        }


        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            ShowBarang();
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

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelSwitch.Text = "Ganti Mode";
                btnKembali.Text = "Kembali";
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
    }
}
