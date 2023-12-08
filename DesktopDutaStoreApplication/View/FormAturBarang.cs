using DesktopDutaStoreApplication.Controller;
using DesktopDutaStoreApplication.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Drawing.Printing;
using System.IO;

namespace DesktopDutaStoreApplication.View
{
    public partial class FormAturBarang : Form
    {
        //Mengatur Mode
        private bool isDarkMode = false;
        private BarangController bCtrl;
        Valid val;

        public FormAturBarang()
        {
            bCtrl = new BarangController();
            val = new Valid();
            InitializeComponent();
            InitializeMode();
        }

        private void InitializeMode()
        {
            // Default mode saat aplikasi dimulai
            SetMode(isDarkMode);
        }

        private void FormAturBarang_Load(object sender, EventArgs e)
        {
            ShowBarang();
            //Mengatur Bahasa
            pictureBoxIND.Visible = false;
            pictureBoxENG.Visible = true;
            //Mengatur Batas Input
            txtIdBarang.MaxLength = 2;
            txtNamaBarang.MaxLength = 50;
            txtHarga.MaxLength = 10;
            txtStok.MaxLength = 10;
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
                btnBaca.FillColor = Color.DarkOrange;
                btnCetak.FillColor = Color.DarkOrange;
                btnClear.FillColor = Color.DarkOrange;
                btnHapus.FillColor = Color.DarkOrange;
                btnTambah.FillColor = Color.DarkOrange;
                btnUpdate.FillColor = Color.DarkOrange;
                btnUpload.FillColor = Color.DarkOrange;
                //Fore Color
                btnKembali.ForeColor = Color.Black;
                labelCopyright.ForeColor = Color.Black;
                labelSwitch.ForeColor = Color.Black;
                btnBaca.ForeColor = Color.Black;
                btnCetak.ForeColor = Color.Black;
                btnClear.ForeColor = Color.Black;
                btnHapus.ForeColor = Color.Black;
                btnUpdate.ForeColor = Color.Black;
                btnTambah.ForeColor = Color.Black;
                btnUpload.ForeColor = Color.Black;
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
                btnCetak.FillColor = Color.DarkRed;
                btnClear.FillColor = Color.DarkRed;
                btnHapus.FillColor = Color.DarkRed;
                btnTambah.FillColor = Color.DarkRed;
                btnUpdate.FillColor = Color.DarkRed;
                btnUpload.FillColor = Color.DarkRed;
                //Fore Color
                btnKembali.ForeColor = Color.White;
                labelCopyright.ForeColor = Color.White;
                labelSwitch.ForeColor = Color.White;
                btnBaca.ForeColor = Color.White;
                btnCetak.ForeColor = Color.White;
                btnClear.ForeColor = Color.White;
                btnHapus.ForeColor = Color.White;
                btnUpdate.ForeColor = Color.White;
                btnTambah.ForeColor = Color.White;
                btnUpload.ForeColor = Color.White;
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
                btnCetak.Text = "Cetak";
                btnClear.Text = "Bersih";
                btnHapus.Text = "Hapus";
                btnTambah.Text = "Tambah";
                btnUpdate.Text = "Perbarui";
                btnUpload.Text = "Unggah";
                txtCari.PlaceholderText = "Cari Barang berdasarkan ID, Nama, Harga, atau Stok";
                txtHarga.PlaceholderText = "Harga";
                txtIdBarang.PlaceholderText = "ID Barang";
                txtNamaBarang.PlaceholderText = "Nama Barang";
                txtStok.PlaceholderText = "Stok";
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
                btnCetak.Text = "Print";
                btnClear.Text = "Clean";
                btnHapus.Text = "Delete";
                btnTambah.Text = "Add";
                btnUpdate.Text = "Update";
                btnUpload.Text = "Upload";
                txtCari.PlaceholderText = "Search item by ID, Name, Price, or Stock";
                txtHarga.PlaceholderText = "Price";
                txtIdBarang.PlaceholderText = "Item ID";
                txtNamaBarang.PlaceholderText = "Item Name";
                txtStok.PlaceholderText = "Stock";
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
            this.Hide();
        }
        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdBarang.Clear();
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            txtCari.Clear();
        }
        //Tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if ((txtIdBarang.Text == "") || (txtNamaBarang.Text == "") || txtHarga.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Need Data", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val.valId(txtIdBarang.Text) && val.valUsername(txtNamaBarang.Text) && val.ValHarga(txtHarga.Text) && val.ValHarga(txtStok.Text)){
                try
                {

                    MemoryStream memori = new MemoryStream();
                    pictureBoxBarang.Image.Save(memori, pictureBoxBarang.Image.RawFormat);
                    byte[] img = memori.ToArray();
                    bCtrl.tambahBarang(txtIdBarang.Text, txtNamaBarang.Text, txtHarga.Text, txtStok.Text, img);
                    MessageBox.Show("Tambah Data Barang Berhasil", "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdBarang.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Upload
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBarang.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridViewBarang_Click(object sender, EventArgs e)
        {
            txtIdBarang.Text = dataGridViewBarang.CurrentRow.Cells[0].Value.ToString();
            txtNamaBarang.Text = dataGridViewBarang.CurrentRow.Cells[1].Value.ToString();
            txtHarga.Text = dataGridViewBarang.CurrentRow.Cells[2].Value.ToString();
            txtStok.Text = dataGridViewBarang.CurrentRow.Cells[3].Value.ToString();
            byte[] img = (byte[])dataGridViewBarang.CurrentRow.Cells[4].Value;
            MemoryStream gambar = new MemoryStream(img);
            pictureBoxBarang.Image = Image.FromStream(gambar);
        }
        //Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                bCtrl.hapusBarang(txtIdBarang.Text);
                ShowBarang();
                btnClear.PerformClick();
                MessageBox.Show("Hapus Barang Berhasil", "Hapus Barang",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtIdBarang.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Read
        private void btnBaca_Click(object sender, EventArgs e)
        {
            ShowBarang();
        }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtIdBarang.Text == "") || (txtNamaBarang.Text == "") || txtHarga.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Need Data", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                bCtrl = new BarangController();
                MemoryStream memori = new MemoryStream();
                pictureBoxBarang.Image.Save(memori, pictureBoxBarang.Image.RawFormat);
                byte[] img = memori.ToArray();
                bCtrl.updateBarang(txtIdBarang.Text, txtNamaBarang.Text, txtHarga.Text, txtStok.Text, img);
                MessageBox.Show("Update Data Barang Berhasil", "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdBarang.Focus();
                this.InitializeComponent();
                FormAturBarang fab = new FormAturBarang();
                fab.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            dataGridViewBarang.DataSource = bCtrl.searchBarang(txtCari.Text);
        }

        private void txtIdBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            printPreviewDialogBarang.Document = printDocumentBarang;
            printPreviewDialogBarang.ShowDialog();
        }

        private void printDocumentBarang_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewBarang.Width, this.dataGridViewBarang.Height);
            dataGridViewBarang.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewBarang.Width, this.dataGridViewBarang.Height));
            e.Graphics.DrawImage(btm, 100, 100);
            e.Graphics.DrawString(labelPrintDataBarang.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }
    }
}
