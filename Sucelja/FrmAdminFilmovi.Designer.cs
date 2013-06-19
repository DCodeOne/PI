namespace PI_projekt.Sucelja
{
    partial class FrmAdminFilmovi
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
            this.lblOdjava = new System.Windows.Forms.LinkLabel();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.lblSviFilmovi = new System.Windows.Forms.Label();
            this.dgvSviFilmovi = new System.Windows.Forms.DataGridView();
            this.btnFilmoviPovratak = new System.Windows.Forms.Button();
            this.btnFilmoviOsvjezi = new System.Windows.Forms.Button();
            this.btnFilmoviDodaj = new System.Windows.Forms.Button();
            this.btnFilmoviAzuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdjava.LinkColor = System.Drawing.Color.Yellow;
            this.lblOdjava.Location = new System.Drawing.Point(625, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 23;
            this.lblOdjava.TabStop = true;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(58, 35);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 27;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(13, 35);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 26;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(112, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 25;
            this.userName.Text = "korisničko ime";
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.BackColor = System.Drawing.Color.Black;
            this.korisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisnik.Location = new System.Drawing.Point(13, 9);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(92, 13);
            this.korisnik.TabIndex = 24;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // lblSviFilmovi
            // 
            this.lblSviFilmovi.AutoSize = true;
            this.lblSviFilmovi.Location = new System.Drawing.Point(12, 60);
            this.lblSviFilmovi.Name = "lblSviFilmovi";
            this.lblSviFilmovi.Size = new System.Drawing.Size(57, 13);
            this.lblSviFilmovi.TabIndex = 28;
            this.lblSviFilmovi.Text = "Svi filmovi:";
            // 
            // dgvSviFilmovi
            // 
            this.dgvSviFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviFilmovi.Location = new System.Drawing.Point(16, 76);
            this.dgvSviFilmovi.Name = "dgvSviFilmovi";
            this.dgvSviFilmovi.Size = new System.Drawing.Size(637, 263);
            this.dgvSviFilmovi.TabIndex = 29;
            // 
            // btnFilmoviPovratak
            // 
            this.btnFilmoviPovratak.Location = new System.Drawing.Point(15, 359);
            this.btnFilmoviPovratak.Name = "btnFilmoviPovratak";
            this.btnFilmoviPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviPovratak.TabIndex = 30;
            this.btnFilmoviPovratak.Text = "Povratak";
            this.btnFilmoviPovratak.UseVisualStyleBackColor = true;
            this.btnFilmoviPovratak.Click += new System.EventHandler(this.btnFilmoviPovratak_Click);
            // 
            // btnFilmoviOsvjezi
            // 
            this.btnFilmoviOsvjezi.Location = new System.Drawing.Point(416, 359);
            this.btnFilmoviOsvjezi.Name = "btnFilmoviOsvjezi";
            this.btnFilmoviOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviOsvjezi.TabIndex = 31;
            this.btnFilmoviOsvjezi.Text = "Osvježi";
            this.btnFilmoviOsvjezi.UseVisualStyleBackColor = true;
            // 
            // btnFilmoviDodaj
            // 
            this.btnFilmoviDodaj.Location = new System.Drawing.Point(497, 359);
            this.btnFilmoviDodaj.Name = "btnFilmoviDodaj";
            this.btnFilmoviDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodaj.TabIndex = 32;
            this.btnFilmoviDodaj.Text = "Dodaj";
            this.btnFilmoviDodaj.UseVisualStyleBackColor = true;
            this.btnFilmoviDodaj.Click += new System.EventHandler(this.btnFilmoviDodaj_Click);
            // 
            // btnFilmoviAzuriraj
            // 
            this.btnFilmoviAzuriraj.Location = new System.Drawing.Point(578, 359);
            this.btnFilmoviAzuriraj.Name = "btnFilmoviAzuriraj";
            this.btnFilmoviAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviAzuriraj.TabIndex = 33;
            this.btnFilmoviAzuriraj.Text = "Ažuriraj";
            this.btnFilmoviAzuriraj.UseVisualStyleBackColor = true;
            // 
            // FrmAdminFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 403);
            this.Controls.Add(this.btnFilmoviAzuriraj);
            this.Controls.Add(this.btnFilmoviDodaj);
            this.Controls.Add(this.btnFilmoviOsvjezi);
            this.Controls.Add(this.btnFilmoviPovratak);
            this.Controls.Add(this.dgvSviFilmovi);
            this.Controls.Add(this.lblSviFilmovi);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.lblOdjava);
            this.Name = "FrmAdminFilmovi";
            this.Text = "FrmAdminFilmovi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminFilmovi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblOdjava;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label lblSviFilmovi;
        private System.Windows.Forms.DataGridView dgvSviFilmovi;
        private System.Windows.Forms.Button btnFilmoviPovratak;
        private System.Windows.Forms.Button btnFilmoviOsvjezi;
        private System.Windows.Forms.Button btnFilmoviDodaj;
        private System.Windows.Forms.Button btnFilmoviAzuriraj;
    }
}