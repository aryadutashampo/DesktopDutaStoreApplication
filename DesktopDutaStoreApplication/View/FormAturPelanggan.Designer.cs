namespace DesktopDutaStoreApplication.View
{
    partial class FormAturPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAturPelanggan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelSwitch = new System.Windows.Forms.Label();
            this.pictureBoxIND = new System.Windows.Forms.PictureBox();
            this.pictureBoxENG = new System.Windows.Forms.PictureBox();
            this.toggleSwithMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPrintData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPrintAkun = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewAKunPelanggan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtIdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaca = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnCetakAkun = new Guna.UI2.WinForms.Guna2Button();
            this.printDocumentPelanggan = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogPelanggan = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewDataPelanggan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDocumentDataPelanggan = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogDataPelanggan = new System.Windows.Forms.PrintPreviewDialog();
            this.btnCetakData = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAKunPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPelanggan)).BeginInit();
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
            this.panelTop.Controls.Add(this.labelPrintData);
            this.panelTop.Controls.Add(this.labelPrintAkun);
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
            // labelPrintData
            // 
            this.labelPrintData.BackColor = System.Drawing.Color.Transparent;
            this.labelPrintData.Location = new System.Drawing.Point(810, 12);
            this.labelPrintData.Name = "labelPrintData";
            this.labelPrintData.Size = new System.Drawing.Size(0, 0);
            this.labelPrintData.TabIndex = 9;
            this.labelPrintData.Text = null;
            // 
            // labelPrintAkun
            // 
            this.labelPrintAkun.BackColor = System.Drawing.Color.Transparent;
            this.labelPrintAkun.Location = new System.Drawing.Point(0, 3);
            this.labelPrintAkun.Name = "labelPrintAkun";
            this.labelPrintAkun.Size = new System.Drawing.Size(3, 2);
            this.labelPrintAkun.TabIndex = 8;
            this.labelPrintAkun.Text = null;
            // 
            // dataGridViewAKunPelanggan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewAKunPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAKunPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAKunPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAKunPelanggan.ColumnHeadersHeight = 4;
            this.dataGridViewAKunPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAKunPelanggan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAKunPelanggan.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewAKunPelanggan.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewAKunPelanggan.Name = "dataGridViewAKunPelanggan";
            this.dataGridViewAKunPelanggan.RowHeadersVisible = false;
            this.dataGridViewAKunPelanggan.RowHeadersWidth = 51;
            this.dataGridViewAKunPelanggan.RowTemplate.Height = 24;
            this.dataGridViewAKunPelanggan.Size = new System.Drawing.Size(817, 131);
            this.dataGridViewAKunPelanggan.TabIndex = 35;
            this.dataGridViewAKunPelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAKunPelanggan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAKunPelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAKunPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAKunPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAKunPelanggan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAKunPelanggan.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAKunPelanggan.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewAKunPelanggan.ThemeStyle.ReadOnly = false;
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAKunPelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtIdUser.Location = new System.Drawing.Point(12, 344);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.PasswordChar = '\0';
            this.txtIdUser.PlaceholderText = "ID Pelanggan";
            this.txtIdUser.SelectedText = "";
            this.txtIdUser.Size = new System.Drawing.Size(185, 32);
            this.txtIdUser.TabIndex = 36;
            this.txtIdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUser_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNama.BorderColor = System.Drawing.Color.IndianRed;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(12, 384);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "Nama Lengkap";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(185, 32);
            this.txtNama.TabIndex = 37;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtemail.BorderColor = System.Drawing.Color.IndianRed;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(203, 346);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(185, 32);
            this.txtemail.TabIndex = 39;
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
            this.txtCari.Location = new System.Drawing.Point(12, 469);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "Cari Pelanggan";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(376, 32);
            this.txtCari.TabIndex = 47;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.DarkRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(730, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 74);
            this.btnClear.TabIndex = 42;
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
            this.btnUpdate.FillColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(624, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 43;
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
            this.btnBaca.FillColor = System.Drawing.Color.DarkRed;
            this.btnBaca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaca.ForeColor = System.Drawing.Color.White;
            this.btnBaca.Location = new System.Drawing.Point(624, 342);
            this.btnBaca.Name = "btnBaca";
            this.btnBaca.Size = new System.Drawing.Size(100, 34);
            this.btnBaca.TabIndex = 44;
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
            this.btnHapus.FillColor = System.Drawing.Color.DarkRed;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(518, 382);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 34);
            this.btnHapus.TabIndex = 45;
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
            this.btnTambah.FillColor = System.Drawing.Color.DarkRed;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(518, 342);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 34);
            this.btnTambah.TabIndex = 46;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCetakAkun
            // 
            this.btnCetakAkun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCetakAkun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakAkun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakAkun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetakAkun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCetakAkun.FillColor = System.Drawing.Color.DarkRed;
            this.btnCetakAkun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCetakAkun.ForeColor = System.Drawing.Color.White;
            this.btnCetakAkun.Location = new System.Drawing.Point(518, 422);
            this.btnCetakAkun.Name = "btnCetakAkun";
            this.btnCetakAkun.Size = new System.Drawing.Size(159, 34);
            this.btnCetakAkun.TabIndex = 48;
            this.btnCetakAkun.Text = "Cetak Akun";
            this.btnCetakAkun.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocumentPelanggan
            // 
            this.printDocumentPelanggan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPelanggan_PrintPage);
            // 
            // printPreviewDialogPelanggan
            // 
            this.printPreviewDialogPelanggan.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPelanggan.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPelanggan.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogPelanggan.Enabled = true;
            this.printPreviewDialogPelanggan.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPelanggan.Icon")));
            this.printPreviewDialogPelanggan.Name = "printPreviewDialogPelanggan";
            this.printPreviewDialogPelanggan.Visible = false;
            // 
            // dataGridViewDataPelanggan
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewDataPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDataPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDataPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDataPelanggan.ColumnHeadersHeight = 4;
            this.dataGridViewDataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDataPelanggan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDataPelanggan.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewDataPelanggan.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewDataPelanggan.Name = "dataGridViewDataPelanggan";
            this.dataGridViewDataPelanggan.RowHeadersVisible = false;
            this.dataGridViewDataPelanggan.RowHeadersWidth = 51;
            this.dataGridViewDataPelanggan.RowTemplate.Height = 24;
            this.dataGridViewDataPelanggan.Size = new System.Drawing.Size(817, 131);
            this.dataGridViewDataPelanggan.TabIndex = 49;
            this.dataGridViewDataPelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDataPelanggan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewDataPelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDataPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewDataPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDataPelanggan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDataPelanggan.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDataPelanggan.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewDataPelanggan.ThemeStyle.ReadOnly = false;
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDataPelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsername.BorderColor = System.Drawing.Color.IndianRed;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(12, 424);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Nama Pengguna";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(185, 32);
            this.txtUsername.TabIndex = 50;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.BorderColor = System.Drawing.Color.IndianRed;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(203, 386);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Kata Kunci";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(185, 32);
            this.txtPassword.TabIndex = 51;
            // 
            // printDocumentDataPelanggan
            // 
            this.printDocumentDataPelanggan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDataPelanggan_PrintPage);
            // 
            // printPreviewDialogDataPelanggan
            // 
            this.printPreviewDialogDataPelanggan.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDataPelanggan.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDataPelanggan.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogDataPelanggan.Enabled = true;
            this.printPreviewDialogDataPelanggan.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogDataPelanggan.Icon")));
            this.printPreviewDialogDataPelanggan.Name = "printPreviewDialogPelanggan";
            this.printPreviewDialogDataPelanggan.Visible = false;
            // 
            // btnCetakData
            // 
            this.btnCetakData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCetakData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetakData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCetakData.FillColor = System.Drawing.Color.DarkRed;
            this.btnCetakData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCetakData.ForeColor = System.Drawing.Color.White;
            this.btnCetakData.Location = new System.Drawing.Point(683, 422);
            this.btnCetakData.Name = "btnCetakData";
            this.btnCetakData.Size = new System.Drawing.Size(147, 34);
            this.btnCetakData.TabIndex = 52;
            this.btnCetakData.Text = "Cetak Data";
            this.btnCetakData.Click += new System.EventHandler(this.btnCetakData_Click);
            // 
            // FormAturPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.btnCetakData);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dataGridViewDataPelanggan);
            this.Controls.Add(this.btnCetakAkun);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBaca);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.dataGridViewAKunPelanggan);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAturPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAturPelanggan";
            this.Load += new System.EventHandler(this.FormAturPelanggan_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAKunPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPelanggan)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAKunPelanggan;
        private Guna.UI2.WinForms.Guna2TextBox txtIdUser;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnBaca;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnCetakAkun;
        private System.Drawing.Printing.PrintDocument printDocumentPelanggan;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPelanggan;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewDataPelanggan;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrintAkun;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrintData;
        private System.Drawing.Printing.PrintDocument printDocumentDataPelanggan;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogDataPelanggan;
        private Guna.UI2.WinForms.Guna2Button btnCetakData;
    }
}