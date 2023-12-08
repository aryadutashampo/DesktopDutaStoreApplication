using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.Model;
using DesktopDutaStoreApplication.Validation;
using DesktopDutaStoreApplication.View;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormTransaksi : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        private BarangController bCtrl;
        Valid val;
        private Connection dbConnection;
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


        public FormTransaksi()
        {
            bCtrl = new BarangController();
            val = new Valid();
            dbConnection = new Connection();
            InitializeComponent();
            InitializeMode();
        }

        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            //Mengatur Batas Input
            txtIdBarang.MaxLength = 2;
            txtJumlah.MaxLength = 2;
            txtIdUser.Text = Convert.ToString(uIdUser);
            ShowBarang();
        }

        bool ShowBarang()
        {
            dataGridViewBarang.DataSource = bCtrl.SelectBarang
                (new MySqlConnector.MySqlCommand("SELECT * FROM barang"));
            dataGridViewBarang.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridViewBarang.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
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
                btnBayar.FillColor = Color.DarkOrange;
                btnHitung.FillColor = Color.DarkOrange;
                //Fore Color
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
                btnHitung.ForeColor = Color.Black;
                btnBayar.ForeColor = Color.Black;
            }
            else
            {
                // Mode terang
                this.BackColor = SystemColors.Control; // Atau warna latar belakang default
                panelTop.BackColor = Color.IndianRed;
                panelBottom.BackColor = Color.IndianRed;
                //Fill Color
                btnKembali.FillColor = Color.DarkRed;
                btnHitung.FillColor = Color.DarkRed;
                btnBayar.FillColor = Color.DarkRed;
                //Fore Color
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
                btnHitung.ForeColor = Color.White;
                btnBayar.ForeColor = Color.White;
            }
        }

        private void pictureBoxIND_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == true)
            {
                pictureBoxIND.Visible = false;
                labelSwitch.Text = "Ganti Mode";
                btnKembali.Text = "Kembali";
                btnBayar.Text = "Bayar";
                btnHitung.Text = "Hitung";
                txtIdUser.PlaceholderText = "ID User";
                txtIdBarang.PlaceholderText = "ID Barang";
                txtHarga.PlaceholderText = "Harga";
                txtStok.PlaceholderText = "Stok";
                txtJumlah.PlaceholderText = "Jumlah";
                txtTotalHarga.PlaceholderText = "Total Harga";
            }
        }

        private void pictureBoxENG_Click(object sender, EventArgs e)
        {
            if (pictureBoxIND.Visible == false)
            {
                pictureBoxIND.Visible = true;
                labelSwitch.Text = "Switch Mode";
                btnKembali.Text = "Back";
                btnBayar.Text = "Pay";
                btnHitung.Text = "Count";
                txtIdUser.PlaceholderText = "User ID";
                txtIdBarang.PlaceholderText = "Item ID";
                txtHarga.PlaceholderText = "Price";
                txtStok.PlaceholderText = "Stock";
                txtJumlah.PlaceholderText = "Quantity";
                txtTotalHarga.PlaceholderText = "Total Price";
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser();
            user.Show();
            this.Hide();
        }

        private void txtIdBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            // Menyimpan transaksi ke dalam tabel history
            if (int.TryParse(txtIdUser.Text, out int idPengguna) &&
                int.TryParse(txtIdBarang.Text, out int idBarang) &&
                int.TryParse(txtJumlah.Text, out int jumlah) &&
                int.TryParse(txtTotalHarga.Text, out int totalHarga))
            {
                using (MySqlConnection connection = dbConnection.GetConn())
                {
                    // Tambahkan try-catch untuk menangani kesalahan koneksi
                    try
                    {
                        // Update stok barang
                        string updateStokQuery = "UPDATE barang SET stok = stok - @jumlah WHERE id_barang = @id_barang";
                        using (MySqlCommand cmdUpdateStok = new MySqlCommand(updateStokQuery, connection))
                        {
                            cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah);
                            cmdUpdateStok.Parameters.AddWithValue("@id_barang", idBarang);
                            cmdUpdateStok.ExecuteNonQuery();
                        }

                        // Simpan transaksi ke dalam tabel history
                        string insertHistoryQuery = "INSERT INTO history (user_id, id_barang, jumlah, total) VALUES (@user_id, @id_barang, @jumlah, @total)";
                        using (MySqlCommand cmdInsertHistory = new MySqlCommand(insertHistoryQuery, connection))
                        {
                            cmdInsertHistory.Parameters.AddWithValue("@user_id", idPengguna);
                            cmdInsertHistory.Parameters.AddWithValue("@id_barang", idBarang);
                            cmdInsertHistory.Parameters.AddWithValue("@jumlah", jumlah);
                            cmdInsertHistory.Parameters.AddWithValue("@total", totalHarga);
                            cmdInsertHistory.ExecuteNonQuery();
                        }

                        MessageBox.Show("Transaksi berhasil disimpan.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Isi semua field dengan nilai yang valid.");
            }
        }
    
    


        private void dataGridViewBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengisi TextBox dengan data dari sel yang dipilih di DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBarang.Rows[e.RowIndex];
                txtIdBarang.Text = row.Cells["id_barang"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Menghitung total harga berdasarkan harga dan jumlah
            if (int.TryParse(txtJumlah.Text, out int jumlah) && int.TryParse(txtHarga.Text, out int harga))
            {
                int totalHarga = jumlah * harga;
                txtTotalHarga.Text = totalHarga.ToString();
            }
            else
            {
                MessageBox.Show("Masukkan jumlah yang valid.");
            }
        }
    }
}
