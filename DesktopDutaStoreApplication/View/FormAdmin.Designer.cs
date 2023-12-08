namespace DesktopDutaStoreApplication
{
    partial class FormAdmin
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
            this.toggleSwithMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelSwitch = new System.Windows.Forms.Label();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.btnManageBarang = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagePelanggan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxLogoDarkAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxIND = new System.Windows.Forms.PictureBox();
            this.pictureBoxENG = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogoWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxDark = new System.Windows.Forms.PictureBox();
            this.pictureBoxLight = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDarkAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).BeginInit();
            this.SuspendLayout();
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
            this.panelTop.Controls.Add(this.labelGreeting);
            this.panelTop.Controls.Add(this.pictureBoxENG);
            this.panelTop.Controls.Add(this.toggleSwithMode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(841, 42);
            this.panelTop.TabIndex = 3;
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
            // labelGreeting
            // 
            this.labelGreeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.ForeColor = System.Drawing.Color.White;
            this.labelGreeting.Location = new System.Drawing.Point(338, 16);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(151, 16);
            this.labelGreeting.TabIndex = 6;
            this.labelGreeting.Text = "Selamat Datang, Admin!";
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
            this.panelBottom.TabIndex = 4;
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
            // btnManageBarang
            // 
            this.btnManageBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageBarang.FillColor = System.Drawing.Color.IndianRed;
            this.btnManageBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManageBarang.ForeColor = System.Drawing.Color.White;
            this.btnManageBarang.Location = new System.Drawing.Point(12, 81);
            this.btnManageBarang.Name = "btnManageBarang";
            this.btnManageBarang.Size = new System.Drawing.Size(206, 73);
            this.btnManageBarang.TabIndex = 7;
            this.btnManageBarang.Text = "Atur Barang";
            this.btnManageBarang.Click += new System.EventHandler(this.btnManageBarang_Click);
            // 
            // btnManagePelanggan
            // 
            this.btnManagePelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManagePelanggan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManagePelanggan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManagePelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManagePelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManagePelanggan.FillColor = System.Drawing.Color.IndianRed;
            this.btnManagePelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManagePelanggan.ForeColor = System.Drawing.Color.White;
            this.btnManagePelanggan.Location = new System.Drawing.Point(12, 434);
            this.btnManagePelanggan.Name = "btnManagePelanggan";
            this.btnManagePelanggan.Size = new System.Drawing.Size(206, 73);
            this.btnManagePelanggan.TabIndex = 8;
            this.btnManagePelanggan.Text = "Atur Pelanggan";
            this.btnManagePelanggan.Click += new System.EventHandler(this.btnManagePelanggan_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.IndianRed;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(623, 81);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(206, 73);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "Riwayat";
            this.btnHistory.Click += new System.EventHandler(this.btnHistoryPenjualan_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.IndianRed;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(623, 434);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(206, 73);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "Tentang";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(359, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Keluar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxLogoDarkAdmin
            // 
            this.pictureBoxLogoDarkAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogoDarkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoDarkAdmin.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.LogoWhite;
            this.pictureBoxLogoDarkAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoDarkAdmin.Location = new System.Drawing.Point(322, 208);
            this.pictureBoxLogoDarkAdmin.Name = "pictureBoxLogoDarkAdmin";
            this.pictureBoxLogoDarkAdmin.Size = new System.Drawing.Size(197, 198);
            this.pictureBoxLogoDarkAdmin.TabIndex = 6;
            this.pictureBoxLogoDarkAdmin.TabStop = false;
            this.pictureBoxLogoDarkAdmin.Click += new System.EventHandler(this.pictureBoxLogo_Click);
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
            // pictureBoxLogoWhite
            // 
            this.pictureBoxLogoWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogoWhite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoWhite.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.LogoDark;
            this.pictureBoxLogoWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoWhite.Location = new System.Drawing.Point(322, 208);
            this.pictureBoxLogoWhite.Name = "pictureBoxLogoWhite";
            this.pictureBoxLogoWhite.Size = new System.Drawing.Size(197, 198);
            this.pictureBoxLogoWhite.TabIndex = 1;
            this.pictureBoxLogoWhite.TabStop = false;
            this.pictureBoxLogoWhite.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // pictureBoxDark
            // 
            this.pictureBoxDark.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.BlackPattern;
            this.pictureBoxDark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDark.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDark.Name = "pictureBoxDark";
            this.pictureBoxDark.Size = new System.Drawing.Size(841, 567);
            this.pictureBoxDark.TabIndex = 0;
            this.pictureBoxDark.TabStop = false;
            this.pictureBoxDark.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // pictureBoxLight
            // 
            this.pictureBoxLight.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.PatternWhite;
            this.pictureBoxLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLight.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLight.Name = "pictureBoxLight";
            this.pictureBoxLight.Size = new System.Drawing.Size(841, 567);
            this.pictureBoxLight.TabIndex = 5;
            this.pictureBoxLight.TabStop = false;
            this.pictureBoxLight.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnManagePelanggan);
            this.Controls.Add(this.btnManageBarang);
            this.Controls.Add(this.pictureBoxLogoDarkAdmin);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBoxLogoWhite);
            this.Controls.Add(this.pictureBoxDark);
            this.Controls.Add(this.pictureBoxLight);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Resize += new System.EventHandler(this.AdminForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDarkAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDark;
        private System.Windows.Forms.PictureBox pictureBoxLogoWhite;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwithMode;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.PictureBox pictureBoxIND;
        private System.Windows.Forms.PictureBox pictureBoxENG;
        private System.Windows.Forms.Label labelSwitch;
        private System.Windows.Forms.PictureBox pictureBoxLight;
        private System.Windows.Forms.PictureBox pictureBoxLogoDarkAdmin;
        private Guna.UI2.WinForms.Guna2Button btnManageBarang;
        private Guna.UI2.WinForms.Guna2Button btnManagePelanggan;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Label labelCopyright;
    }
}

