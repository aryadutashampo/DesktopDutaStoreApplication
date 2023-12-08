namespace DesktopDutaStoreApplication.View
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelSwitch = new System.Windows.Forms.Label();
            this.pictureBoxIND = new System.Windows.Forms.PictureBox();
            this.pictureBoxENG = new System.Windows.Forms.PictureBox();
            this.toggleSwithMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewBarang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtIdBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.btnHitung = new Guna.UI2.WinForms.Guna2Button();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.IndianRed;
            this.panelBottom.Controls.Add(this.btnKembali);
            this.panelBottom.Controls.Add(this.labelCopyright);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 525);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(841, 42);
            this.panelBottom.TabIndex = 17;
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.DarkRed;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(12, 8);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(106, 25);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(356, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(133, 16);
            this.labelCopyright.TabIndex = 0;
            this.labelCopyright.Text = "© 2023 Dutastore, Inc.";
            // 
            // labelSwitch
            // 
            this.labelSwitch.AutoSize = true;
            this.labelSwitch.ForeColor = System.Drawing.Color.White;
            this.labelSwitch.Location = new System.Drawing.Point(53, 16);
            this.labelSwitch.Name = "labelSwitch";
            this.labelSwitch.Size = new System.Drawing.Size(76, 16);
            this.labelSwitch.TabIndex = 7;
            this.labelSwitch.Text = "Ganti Mode";
            // 
            // pictureBoxIND
            // 
            this.pictureBoxIND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxIND.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.Indonesia;
            this.pictureBoxIND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIND.Location = new System.Drawing.Point(774, 3);
            this.pictureBoxIND.Name = "pictureBoxIND";
            this.pictureBoxIND.Size = new System.Drawing.Size(64, 34);
            this.pictureBoxIND.TabIndex = 6;
            this.pictureBoxIND.TabStop = false;
            this.pictureBoxIND.Click += new System.EventHandler(this.pictureBoxIND_Click);
            // 
            // pictureBoxENG
            // 
            this.pictureBoxENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxENG.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.English;
            this.pictureBoxENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxENG.Location = new System.Drawing.Point(774, 3);
            this.pictureBoxENG.Name = "pictureBoxENG";
            this.pictureBoxENG.Size = new System.Drawing.Size(64, 34);
            this.pictureBoxENG.TabIndex = 5;
            this.pictureBoxENG.TabStop = false;
            this.pictureBoxENG.Click += new System.EventHandler(this.pictureBoxENG_Click);
            // 
            // toggleSwithMode
            // 
            this.toggleSwithMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwithMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwithMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwithMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwithMode.Location = new System.Drawing.Point(12, 12);
            this.toggleSwithMode.Name = "toggleSwithMode";
            this.toggleSwithMode.Size = new System.Drawing.Size(35, 20);
            this.toggleSwithMode.TabIndex = 2;
            this.toggleSwithMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwithMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwithMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwithMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwithMode.CheckedChanged += new System.EventHandler(this.toggleSwithMode_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.IndianRed;
            this.panelTop.Controls.Add(this.labelSwitch);
            this.panelTop.Controls.Add(this.pictureBoxIND);
            this.panelTop.Controls.Add(this.pictureBoxENG);
            this.panelTop.Controls.Add(this.toggleSwithMode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(841, 42);
            this.panelTop.TabIndex = 16;
            // 
            // dataGridViewBarang
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewBarang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewBarang.ColumnHeadersHeight = 4;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBarang.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewBarang.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewBarang.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersVisible = false;
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(817, 299);
            this.dataGridViewBarang.TabIndex = 19;
            this.dataGridViewBarang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBarang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewBarang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBarang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewBarang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBarang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBarang.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewBarang.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewBarang.ThemeStyle.ReadOnly = false;
            this.dataGridViewBarang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBarang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBarang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBarang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBarang.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewBarang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBarang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellClick);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIdBarang.BorderColor = System.Drawing.Color.IndianRed;
            this.txtIdBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBarang.DefaultText = "";
            this.txtIdBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBarang.Location = new System.Drawing.Point(439, 373);
            this.txtIdBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.PasswordChar = '\0';
            this.txtIdBarang.PlaceholderText = "ID Barang";
            this.txtIdBarang.SelectedText = "";
            this.txtIdBarang.Size = new System.Drawing.Size(185, 32);
            this.txtIdBarang.TabIndex = 24;
            this.txtIdBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBarang_KeyPress);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtJumlah.BorderColor = System.Drawing.Color.IndianRed;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = "";
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Location = new System.Drawing.Point(644, 373);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "Masukkan Jumlah";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.Size = new System.Drawing.Size(185, 32);
            this.txtJumlah.TabIndex = 25;
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalHarga.BorderColor = System.Drawing.Color.IndianRed;
            this.txtTotalHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalHarga.DefaultText = "";
            this.txtTotalHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHarga.Enabled = false;
            this.txtTotalHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHarga.Location = new System.Drawing.Point(644, 413);
            this.txtTotalHarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.PasswordChar = '\0';
            this.txtTotalHarga.PlaceholderText = "Total";
            this.txtTotalHarga.SelectedText = "";
            this.txtTotalHarga.Size = new System.Drawing.Size(185, 32);
            this.txtTotalHarga.TabIndex = 26;
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBayar.FillColor = System.Drawing.Color.IndianRed;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(644, 479);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(185, 40);
            this.btnBayar.TabIndex = 27;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHitung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHitung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHitung.FillColor = System.Drawing.Color.IndianRed;
            this.btnHitung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Location = new System.Drawing.Point(439, 479);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(185, 40);
            this.btnHitung.TabIndex = 31;
            this.btnHitung.Text = "Hitung Total";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtHarga.BorderColor = System.Drawing.Color.IndianRed;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Location = new System.Drawing.Point(248, 413);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderText = "Harga";
            this.txtHarga.SelectedText = "";
            this.txtHarga.Size = new System.Drawing.Size(185, 32);
            this.txtHarga.TabIndex = 32;
            // 
            // txtStok
            // 
            this.txtStok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtStok.BorderColor = System.Drawing.Color.IndianRed;
            this.txtStok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStok.DefaultText = "";
            this.txtStok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStok.Location = new System.Drawing.Point(439, 413);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.PasswordChar = '\0';
            this.txtStok.PlaceholderText = "Stok";
            this.txtStok.SelectedText = "";
            this.txtStok.Size = new System.Drawing.Size(185, 32);
            this.txtStok.TabIndex = 33;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIdUser.BorderColor = System.Drawing.Color.IndianRed;
            this.txtIdUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUser.DefaultText = "";
            this.txtIdUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.Location = new System.Drawing.Point(248, 373);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.PasswordChar = '\0';
            this.txtIdUser.PlaceholderText = "ID User";
            this.txtIdUser.SelectedText = "";
            this.txtIdUser.Size = new System.Drawing.Size(185, 32);
            this.txtIdUser.TabIndex = 34;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtIdBarang);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelSwitch;
        private System.Windows.Forms.PictureBox pictureBoxIND;
        private System.Windows.Forms.PictureBox pictureBoxENG;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwithMode;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalHarga;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2Button btnHitung;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2TextBox txtStok;
        private Guna.UI2.WinForms.Guna2TextBox txtIdUser;
    }
}