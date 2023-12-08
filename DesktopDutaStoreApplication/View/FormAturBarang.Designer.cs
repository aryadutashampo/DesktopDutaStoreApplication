namespace DesktopDutaStoreApplication.View
{
    partial class FormAturBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAturBarang));
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelSwitch = new System.Windows.Forms.Label();
            this.pictureBoxIND = new System.Windows.Forms.PictureBox();
            this.pictureBoxENG = new System.Windows.Forms.PictureBox();
            this.toggleSwithMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPrintDataBarang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewBarang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtIdBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaca = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCetak = new Guna.UI2.WinForms.Guna2Button();
            this.printDocumentBarang = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBarang = new System.Windows.Forms.PrintPreviewDialog();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
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
            this.panelTop.Controls.Add(this.labelPrintDataBarang);
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
            // labelPrintDataBarang
            // 
            this.labelPrintDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelPrintDataBarang.Location = new System.Drawing.Point(0, 2);
            this.labelPrintDataBarang.Name = "labelPrintDataBarang";
            this.labelPrintDataBarang.Size = new System.Drawing.Size(0, 0);
            this.labelPrintDataBarang.TabIndex = 8;
            this.labelPrintDataBarang.Text = null;
            // 
            // dataGridViewBarang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewBarang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBarang.ColumnHeadersHeight = 4;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBarang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBarang.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewBarang.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersVisible = false;
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(817, 299);
            this.dataGridViewBarang.TabIndex = 18;
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
            this.dataGridViewBarang.Click += new System.EventHandler(this.dataGridViewBarang_Click);
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
            this.txtIdBarang.Location = new System.Drawing.Point(12, 374);
            this.txtIdBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.PasswordChar = '\0';
            this.txtIdBarang.PlaceholderText = "ID Barang";
            this.txtIdBarang.SelectedText = "";
            this.txtIdBarang.Size = new System.Drawing.Size(185, 32);
            this.txtIdBarang.TabIndex = 23;
            this.txtIdBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBarang_KeyPress);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNamaBarang.BorderColor = System.Drawing.Color.IndianRed;
            this.txtNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaBarang.DefaultText = "";
            this.txtNamaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.Location = new System.Drawing.Point(12, 414);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.PlaceholderText = "Nama Barang";
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.Size = new System.Drawing.Size(185, 32);
            this.txtNamaBarang.TabIndex = 24;
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
            this.txtStok.Location = new System.Drawing.Point(203, 414);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.PasswordChar = '\0';
            this.txtStok.PlaceholderText = "Stok";
            this.txtStok.SelectedText = "";
            this.txtStok.Size = new System.Drawing.Size(185, 32);
            this.txtStok.TabIndex = 26;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
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
            this.txtHarga.Location = new System.Drawing.Point(203, 374);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderText = "Harga";
            this.txtHarga.SelectedText = "";
            this.txtHarga.Size = new System.Drawing.Size(185, 32);
            this.txtHarga.TabIndex = 25;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxBarang.BackColor = System.Drawing.Color.White;
            this.pictureBoxBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBarang.Location = new System.Drawing.Point(729, 374);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(100, 103);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarang.TabIndex = 27;
            this.pictureBoxBarang.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.IndianRed;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(729, 473);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 34);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Unggah";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(621, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Bersih";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(515, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Perbarui";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBaca
            // 
            this.btnBaca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBaca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaca.FillColor = System.Drawing.Color.IndianRed;
            this.btnBaca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaca.ForeColor = System.Drawing.Color.White;
            this.btnBaca.Location = new System.Drawing.Point(515, 374);
            this.btnBaca.Name = "btnBaca";
            this.btnBaca.Size = new System.Drawing.Size(100, 34);
            this.btnBaca.TabIndex = 31;
            this.btnBaca.Text = "Baca";
            this.btnBaca.Click += new System.EventHandler(this.btnBaca_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.IndianRed;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(409, 414);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 34);
            this.btnHapus.TabIndex = 32;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.FillColor = System.Drawing.Color.IndianRed;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(409, 374);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 34);
            this.btnTambah.TabIndex = 33;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtCari
            // 
            this.txtCari.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCari.BorderColor = System.Drawing.Color.IndianRed;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(12, 454);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "Cari Barang berdasarkan ID, Nama, Harga, atau Stok";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(376, 32);
            this.txtCari.TabIndex = 34;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCetak.FillColor = System.Drawing.Color.IndianRed;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(621, 414);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(100, 34);
            this.btnCetak.TabIndex = 35;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // printDocumentBarang
            // 
            this.printDocumentBarang.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBarang_PrintPage);
            // 
            // printPreviewDialogBarang
            // 
            this.printPreviewDialogBarang.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBarang.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBarang.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBarang.Enabled = true;
            this.printPreviewDialogBarang.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBarang.Icon")));
            this.printPreviewDialogBarang.Name = "printPreviewDialogBarang";
            this.printPreviewDialogBarang.Visible = false;
            // 
            // FormAturBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBaca);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBoxBarang);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtIdBarang);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAturBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormAturBarang_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtNamaBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtStok;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnBaca;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnCetak;
        private System.Drawing.Printing.PrintDocument printDocumentBarang;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBarang;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrintDataBarang;
    }
}