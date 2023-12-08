using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using DesktopDutaStoreApplication.Validation;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormAturPelanggan : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        Valid val = new Valid();
        private Pelanggancontroller pCtrl;


        public FormAturPelanggan()
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
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
                // Mode gelap
                this.BackColor = Color.Black;
                panelTop.BackColor = Color.OrangeRed;
                panelBottom.BackColor = Color.OrangeRed;
                btnKembali.FillColor = Color.DarkOrange;
                btnBaca.FillColor = Color.DarkOrange;
                btnCetakAkun.FillColor = Color.DarkOrange;
                btnCetakData.FillColor = Color.DarkOrange;
                btnClear.FillColor = Color.DarkOrange;
                btnHapus.FillColor = Color.DarkOrange;
                btnTambah.FillColor = Color.DarkOrange;
                btnUpdate.FillColor = Color.DarkOrange;
                //Fore Color
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
                btnBaca.ForeColor = Color.Black;
                btnCetakAkun.ForeColor = Color.Black;
                btnCetakData.ForeColor = Color.Black;
                btnClear.ForeColor = Color.Black;
                btnHapus.ForeColor = Color.Black;
                btnUpdate.ForeColor = Color.Black;
                btnTambah.ForeColor = Color.Black;
            }
            else
            {
                // Mode terang
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                panelTop.BackColor = Color.IndianRed;
                panelBottom.BackColor = Color.IndianRed;
                //Fill Color
                btnKembali.FillColor = Color.DarkRed;
                btnBaca.FillColor = Color.DarkRed;
                btnCetakAkun.FillColor = Color.DarkRed;
                btnCetakData.FillColor = Color.DarkRed;
                btnClear.FillColor = Color.DarkRed;
                btnHapus.FillColor = Color.DarkRed;
                btnTambah.FillColor = Color.DarkRed;
                btnUpdate.FillColor = Color.DarkRed;
                //Fore Color
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
                btnBaca.ForeColor = Color.White;
                btnCetakAkun.ForeColor = Color.White;
                btnCetakData.ForeColor = Color.White;
                btnClear.ForeColor = Color.White;
                btnHapus.ForeColor = Color.White;
                btnUpdate.ForeColor = Color.White;
                btnTambah.ForeColor = Color.White;
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelSwitch.Text = "Switch Mode";
                btnKembali.Text = "Back";
                btnBaca.Text = "Read";
                btnCetakAkun.Text = "Print Acc";
                btnCetakData.Text = "Print Data";
                btnClear.Text = "Clean";
                btnHapus.Text = "Delete";
                btnTambah.Text = "Add";
                btnUpdate.Text = "Update";
                txtCari.PlaceholderText = "Search User";
                txtemail.PlaceholderText = "Email";
                txtIdUser.PlaceholderText = "ID User";
                txtNama.PlaceholderText = "Fullname";
                txtUsername.PlaceholderText = "Username";
                txtPassword.PlaceholderText = "Password";

            }
        }

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelSwitch.Text = "Ganti Mode";
                btnKembali.Text = "Kembali";
                btnBaca.Text = "Baca";
                btnCetakAkun.Text = "Cetak Akun";
                btnCetakData.Text = "Cetak Data";
                btnClear.Text = "Bersih";
                btnHapus.Text = "Hapus";
                btnTambah.Text = "Tambah";
                btnUpdate.Text = "Perbarui";
                txtCari.PlaceholderText = "Cari Pelanggan";
                txtemail.PlaceholderText = "Email";
                txtIdUser.PlaceholderText = "ID Pelanggan";
                txtNama.PlaceholderText = "Nama Lengkap";
                txtUsername.PlaceholderText = "Nama Pengguna";
                txtPassword.PlaceholderText = "Kata Kunci";
            }
        }

        private void FormAturPelanggan_Load(object sender, EventArgs e)
        {
            //Mengatur Batas Input
            txtIdUser.MaxLength = 2;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 8;
            txtNama.MaxLength = 20;
            txtemail.MaxLength = 30;
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            ShowTable();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if ((txtIdUser.Text == ""))
            {
                MessageBox.Show("Need Data", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val.valId(txtIdUser.Text) && val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text) && val.valNama(txtNama.Text) && val.valEmail(txtemail.Text))
            {
                try
                {
                    pCtrl = new Pelanggancontroller();
                    pCtrl.tambahAkunPelanggan(txtIdUser.Text, txtUsername.Text, txtPassword.Text);
                    pCtrl.tambahDataPelanggan(txtIdUser.Text, txtNama.Text, txtemail.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtIdUser.Focus();
                    MessageBox.Show("Data disimpan");

                    FormAturPelanggan fp = new FormAturPelanggan();
                    fp.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnBaca_Click(object sender, EventArgs e)
        {
            dataGridViewAKunPelanggan.DataSource = pCtrl.tampilAkunPelanggan();
            dataGridViewAKunPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDataPelanggan.DataSource = pCtrl.tampilDataPelanggan();
            dataGridViewDataPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void ShowTable()
        {
            dataGridViewAKunPelanggan.DataSource = pCtrl.SelectAkunPelanggan(new MySqlConnector.MySqlCommand("SELECT * FROM akun_pelanggan"));
            dataGridViewDataPelanggan.DataSource = pCtrl.SelectDataPelanggan(new MySqlConnector.MySqlCommand("SELECT * FROM info_pelanggan"));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
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
            FormAturPelanggan fp = new FormAturPelanggan();
            fp.Show();
            this.Hide();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdUser.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Clear();
            txtemail.Clear();
            txtCari.Clear();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            dataGridViewAKunPelanggan.DataSource = pCtrl.searchAkunPelanggan(txtCari.Text);
            dataGridViewDataPelanggan.DataSource = pCtrl.searchDataPelanggan(txtCari.Text);
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogPelanggan.Document = printDocumentPelanggan;
            printPreviewDialogPelanggan.ShowDialog();
        }

        private void printDocumentPelanggan_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btm1 = new Bitmap(this.dataGridViewAKunPelanggan.Width, this.dataGridViewAKunPelanggan.Height);
            dataGridViewAKunPelanggan.DrawToBitmap(btm1, new Rectangle(0, 0, this.dataGridViewAKunPelanggan.Width, this.dataGridViewAKunPelanggan.Height));
            e.Graphics.DrawImage(btm1, 100, 100);
            e.Graphics.DrawString(labelPrintAkun.Text, new Font("Segoe UI", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void printDocumentDataPelanggan_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btm2 = new Bitmap(this.dataGridViewDataPelanggan.Width, this.dataGridViewDataPelanggan.Height);
            dataGridViewDataPelanggan.DrawToBitmap(btm2, new Rectangle(0, 0, this.dataGridViewDataPelanggan.Width, this.dataGridViewDataPelanggan.Height));
            e.Graphics.DrawImage(btm2, 100, 100);
            e.Graphics.DrawString(labelPrintData.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void btnCetakData_Click(object sender, EventArgs e)
        {
            printPreviewDialogDataPelanggan.Document = printDocumentDataPelanggan;
            printPreviewDialogDataPelanggan.ShowDialog();
        }

        private void txtIdUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }
    }
}
