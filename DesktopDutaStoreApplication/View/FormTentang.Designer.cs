namespace DesktopDutaStoreApplication.View
{
    partial class FormTentang
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
            this.pictureBoxENG = new System.Windows.Forms.PictureBox();
            this.pictureBoxIND = new System.Windows.Forms.PictureBox();
            this.labelSwitch = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTeksTentang = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
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
            this.panelTop.TabIndex = 14;
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
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.IndianRed;
            this.panelBottom.Controls.Add(this.btnKembali);
            this.panelBottom.Controls.Add(this.labelCopyright);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 525);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(841, 42);
            this.panelBottom.TabIndex = 15;
            // 
            // txtTeksTentang
            // 
            this.txtTeksTentang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTeksTentang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeksTentang.DefaultText = "";
            this.txtTeksTentang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeksTentang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeksTentang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeksTentang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeksTentang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeksTentang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeksTentang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeksTentang.Location = new System.Drawing.Point(12, 57);
            this.txtTeksTentang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTeksTentang.Multiline = true;
            this.txtTeksTentang.Name = "txtTeksTentang";
            this.txtTeksTentang.PasswordChar = '\0';
            this.txtTeksTentang.PlaceholderText = "";
            this.txtTeksTentang.SelectedText = "";
            this.txtTeksTentang.Size = new System.Drawing.Size(817, 459);
            this.txtTeksTentang.TabIndex = 17;
            // 
            // FormTentang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.txtTeksTentang);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormTentang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTentang";
            this.Load += new System.EventHandler(this.FormTentang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIND)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwithMode;
        private System.Windows.Forms.PictureBox pictureBoxENG;
        private System.Windows.Forms.PictureBox pictureBoxIND;
        private System.Windows.Forms.Label labelSwitch;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelCopyright;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2TextBox txtTeksTentang;
    }
}