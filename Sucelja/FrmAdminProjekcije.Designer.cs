namespace PI_projekt.Sucelja
{
    partial class FrmAdminProjekcije
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
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.lblOdjava = new System.Windows.Forms.LinkLabel();
            this.dgvSveProjekcije = new System.Windows.Forms.DataGridView();
            this.btnProjekcijePovratak = new System.Windows.Forms.Button();
            this.btnProjekcijeOsvjezi = new System.Windows.Forms.Button();
            this.btnProjekcijeDodaj = new System.Windows.Forms.Button();
            this.btnProjekcijeAžuriraj = new System.Windows.Forms.Button();
            this.lblSveProjekcije = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(58, 35);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 21;
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
            this.uloga.TabIndex = 20;
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
            this.userName.TabIndex = 19;
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
            this.korisnik.TabIndex = 18;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdjava.LinkColor = System.Drawing.Color.Yellow;
            this.lblOdjava.Location = new System.Drawing.Point(678, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 22;
            this.lblOdjava.TabStop = true;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // dgvSveProjekcije
            // 
            this.dgvSveProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveProjekcije.Location = new System.Drawing.Point(14, 98);
            this.dgvSveProjekcije.Name = "dgvSveProjekcije";
            this.dgvSveProjekcije.Size = new System.Drawing.Size(693, 226);
            this.dgvSveProjekcije.TabIndex = 23;
            // 
            // btnProjekcijePovratak
            // 
            this.btnProjekcijePovratak.Location = new System.Drawing.Point(12, 338);
            this.btnProjekcijePovratak.Name = "btnProjekcijePovratak";
            this.btnProjekcijePovratak.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijePovratak.TabIndex = 24;
            this.btnProjekcijePovratak.Text = "Povrtak";
            this.btnProjekcijePovratak.UseVisualStyleBackColor = true;
            this.btnProjekcijePovratak.Click += new System.EventHandler(this.btnProjekcijePovratak_Click);
            // 
            // btnProjekcijeOsvjezi
            // 
            this.btnProjekcijeOsvjezi.Location = new System.Drawing.Point(470, 338);
            this.btnProjekcijeOsvjezi.Name = "btnProjekcijeOsvjezi";
            this.btnProjekcijeOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeOsvjezi.TabIndex = 25;
            this.btnProjekcijeOsvjezi.Text = "Osvježi";
            this.btnProjekcijeOsvjezi.UseVisualStyleBackColor = true;
            // 
            // btnProjekcijeDodaj
            // 
            this.btnProjekcijeDodaj.Location = new System.Drawing.Point(551, 338);
            this.btnProjekcijeDodaj.Name = "btnProjekcijeDodaj";
            this.btnProjekcijeDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeDodaj.TabIndex = 26;
            this.btnProjekcijeDodaj.Text = "Dodaj";
            this.btnProjekcijeDodaj.UseVisualStyleBackColor = true;
            this.btnProjekcijeDodaj.Click += new System.EventHandler(this.btnProjekcijeDodaj_Click);
            // 
            // btnProjekcijeAžuriraj
            // 
            this.btnProjekcijeAžuriraj.Location = new System.Drawing.Point(632, 338);
            this.btnProjekcijeAžuriraj.Name = "btnProjekcijeAžuriraj";
            this.btnProjekcijeAžuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeAžuriraj.TabIndex = 27;
            this.btnProjekcijeAžuriraj.Text = "Ažuriraj";
            this.btnProjekcijeAžuriraj.UseVisualStyleBackColor = true;
            // 
            // lblSveProjekcije
            // 
            this.lblSveProjekcije.AutoSize = true;
            this.lblSveProjekcije.Location = new System.Drawing.Point(14, 72);
            this.lblSveProjekcije.Name = "lblSveProjekcije";
            this.lblSveProjekcije.Size = new System.Drawing.Size(77, 13);
            this.lblSveProjekcije.TabIndex = 28;
            this.lblSveProjekcije.Text = "Sve projekcije:";
            // 
            // FrmAdminProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 373);
            this.Controls.Add(this.lblSveProjekcije);
            this.Controls.Add(this.btnProjekcijeAžuriraj);
            this.Controls.Add(this.btnProjekcijeDodaj);
            this.Controls.Add(this.btnProjekcijeOsvjezi);
            this.Controls.Add(this.btnProjekcijePovratak);
            this.Controls.Add(this.dgvSveProjekcije);
            this.Controls.Add(this.lblOdjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.korisnik);
            this.Name = "FrmAdminProjekcije";
            this.Text = "FrmAdminProjekcije";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminProjekcije_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.LinkLabel lblOdjava;
        private System.Windows.Forms.DataGridView dgvSveProjekcije;
        private System.Windows.Forms.Button btnProjekcijePovratak;
        private System.Windows.Forms.Button btnProjekcijeOsvjezi;
        private System.Windows.Forms.Button btnProjekcijeDodaj;
        private System.Windows.Forms.Button btnProjekcijeAžuriraj;
        private System.Windows.Forms.Label lblSveProjekcije;
    }
}