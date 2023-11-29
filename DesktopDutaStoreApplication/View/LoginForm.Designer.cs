namespace DesktopDutaStoreApplication.View
{
    partial class LoginForm
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
            this.labelDutaStore = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelAkun = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDutaStore
            // 
            this.labelDutaStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDutaStore.AutoSize = true;
            this.labelDutaStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDutaStore.Location = new System.Drawing.Point(115, 150);
            this.labelDutaStore.Name = "labelDutaStore";
            this.labelDutaStore.Size = new System.Drawing.Size(114, 18);
            this.labelDutaStore.TabIndex = 26;
            this.labelDutaStore.Text = "DUTA STORE";
            // 
            // labelRegister
            // 
            this.labelRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelRegister.Location = new System.Drawing.Point(193, 427);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(58, 16);
            this.labelRegister.TabIndex = 25;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // labelAkun
            // 
            this.labelAkun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAkun.AutoSize = true;
            this.labelAkun.Location = new System.Drawing.Point(66, 427);
            this.labelAkun.Name = "labelAkun";
            this.labelAkun.Size = new System.Drawing.Size(121, 16);
            this.labelAkun.TabIndex = 24;
            this.labelAkun.Text = "Tidak punya akun?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(15, 362);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(322, 38);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(12, 307);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Masukkan Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(325, 32);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 278);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(12, 229);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Masukkan Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(325, 32);
            this.txtUsername.TabIndex = 20;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 200);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::DesktopDutaStoreApplication.Properties.Resources.Dino;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(349, 122);
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.labelDutaStore);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelAkun);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDutaStore;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelAkun;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}