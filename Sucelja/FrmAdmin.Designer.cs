namespace PI_projekt.Sucelja
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.miOpcije = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciArtikli = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciFilmovi = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciProjekcije = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciDvorane = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusnaTraka = new System.Windows.Forms.StatusStrip();
            this.sstext = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.msIzbornik.SuspendLayout();
            this.statusnaTraka.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIzbornik
            // 
            this.msIzbornik.AllowDrop = true;
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcije,
            this.miSifarnici,
            this.statistikaToolStripMenuItem});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Size = new System.Drawing.Size(560, 29);
            this.msIzbornik.TabIndex = 15;
            this.msIzbornik.Text = "Izbornik";
            // 
            // miOpcije
            // 
            this.miOpcije.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcijeOdjava,
            this.miOpcijeIzlaz});
            this.miOpcije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miOpcije.Name = "miOpcije";
            this.miOpcije.Size = new System.Drawing.Size(66, 25);
            this.miOpcije.Text = "Opcije";
            // 
            // miOpcijeOdjava
            // 
            this.miOpcijeOdjava.Name = "miOpcijeOdjava";
            this.miOpcijeOdjava.Size = new System.Drawing.Size(152, 26);
            this.miOpcijeOdjava.Text = "Odjava";
            this.miOpcijeOdjava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeOdjava_MouseUp);
            // 
            // miOpcijeIzlaz
            // 
            this.miOpcijeIzlaz.Name = "miOpcijeIzlaz";
            this.miOpcijeIzlaz.Size = new System.Drawing.Size(152, 26);
            this.miOpcijeIzlaz.Text = "Izlaz";
            this.miOpcijeIzlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeIzlaz_MouseUp);
            // 
            // miSifarnici
            // 
            this.miSifarnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSifarniciZaposlenici,
            this.miSifarniciArtikli,
            this.miSifarniciFilmovi,
            this.miSifarniciProjekcije,
            this.miSifarniciDvorane});
            this.miSifarnici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miSifarnici.Name = "miSifarnici";
            this.miSifarnici.Size = new System.Drawing.Size(78, 25);
            this.miSifarnici.Text = "Šifarnici";
            // 
            // miSifarniciZaposlenici
            // 
            this.miSifarniciZaposlenici.Name = "miSifarniciZaposlenici";
            this.miSifarniciZaposlenici.Size = new System.Drawing.Size(158, 26);
            this.miSifarniciZaposlenici.Text = "Zaposlenici";
            this.miSifarniciZaposlenici.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciZaposlenici_MouseUp);
            // 
            // miSifarniciArtikli
            // 
            this.miSifarniciArtikli.Name = "miSifarniciArtikli";
            this.miSifarniciArtikli.Size = new System.Drawing.Size(158, 26);
            this.miSifarniciArtikli.Text = "Artikli";
            this.miSifarniciArtikli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciArtikli_MouseUp);
            // 
            // miSifarniciFilmovi
            // 
            this.miSifarniciFilmovi.Name = "miSifarniciFilmovi";
            this.miSifarniciFilmovi.Size = new System.Drawing.Size(158, 26);
            this.miSifarniciFilmovi.Text = "Filmovi";
            this.miSifarniciFilmovi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciFilmovi_MouseUp);
            // 
            // miSifarniciProjekcije
            // 
            this.miSifarniciProjekcije.Name = "miSifarniciProjekcije";
            this.miSifarniciProjekcije.Size = new System.Drawing.Size(158, 26);
            this.miSifarniciProjekcije.Text = "Projekcije";
            this.miSifarniciProjekcije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciProjekcije_MouseUp);
            // 
            // miSifarniciDvorane
            // 
            this.miSifarniciDvorane.Name = "miSifarniciDvorane";
            this.miSifarniciDvorane.Size = new System.Drawing.Size(158, 26);
            this.miSifarniciDvorane.Text = "Dvorane";
            this.miSifarniciDvorane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciDvorane_MouseUp);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // statusnaTraka
            // 
            this.statusnaTraka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sstext,
            this.ssUsername});
            this.statusnaTraka.Location = new System.Drawing.Point(0, 359);
            this.statusnaTraka.Name = "statusnaTraka";
            this.statusnaTraka.Size = new System.Drawing.Size(560, 26);
            this.statusnaTraka.TabIndex = 17;
            this.statusnaTraka.Text = "status";
            // 
            // sstext
            // 
            this.sstext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sstext.ForeColor = System.Drawing.Color.Black;
            this.sstext.Name = "sstext";
            this.sstext.Size = new System.Drawing.Size(150, 21);
            this.sstext.Text = "Prijavljeni ste kao:";
            // 
            // ssUsername
            // 
            this.ssUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ssUsername.ForeColor = System.Drawing.Color.Red;
            this.ssUsername.Name = "ssUsername";
            this.ssUsername.Size = new System.Drawing.Size(85, 21);
            this.ssUsername.Text = "username";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 385);
            this.Controls.Add(this.statusnaTraka);
            this.Controls.Add(this.msIzbornik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzbornik;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(505, 354);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.statusnaTraka.ResumeLayout(false);
            this.statusnaTraka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem miOpcije;
        private System.Windows.Forms.ToolStripMenuItem miSifarnici;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeOdjava;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeIzlaz;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciArtikli;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciFilmovi;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciProjekcije;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciDvorane;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusnaTraka;
        private System.Windows.Forms.ToolStripStatusLabel sstext;
        private System.Windows.Forms.ToolStripStatusLabel ssUsername;

    }
}