namespace PI_projekt.Sucelja
{
    partial class FrmAdminFilmoviDodaj
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
            this.btnFilmoviDodajSpremi = new System.Windows.Forms.Button();
            this.btnFilmoviDodajOdustani = new System.Windows.Forms.Button();
            this.lblFilmoviDodajNaziv = new System.Windows.Forms.Label();
            this.lblFilmoviDodajTrajanje = new System.Windows.Forms.Label();
            this.txtDodajFilmNaziv = new System.Windows.Forms.TextBox();
            this.txtFilmoviDodajTrajanje = new System.Windows.Forms.TextBox();
            this.lblFilmoviDodajTrajanjeMin = new System.Windows.Forms.Label();
            this.lblDilmoviDodajZanrovi = new System.Windows.Forms.Label();
            this.lblFilmoviDodajZanroviOdabrani = new System.Windows.Forms.Label();
            this.lbFilmoviDodajZanrovi = new System.Windows.Forms.ListBox();
            this.lbFilmoviDodajZanroviOdabrani = new System.Windows.Forms.ListBox();
            this.btnFilmoviDodajDodajLb = new System.Windows.Forms.Button();
            this.btnFilmoviDodajUkloniLb = new System.Windows.Forms.Button();
            this.lblNaslovAdminFilmoviDodaj = new System.Windows.Forms.Label();
            this.txtFilmoviDodajSinopsis = new System.Windows.Forms.TextBox();
            this.txtFilmoviDodajRedatelj = new System.Windows.Forms.TextBox();
            this.lblFilmoviDodajSinopsis = new System.Windows.Forms.Label();
            this.lblFilmoviDodajRedatelj = new System.Windows.Forms.Label();
            this.txtFilmoviDodajGlumci = new System.Windows.Forms.TextBox();
            this.lblFilmoviDodajGlumci = new System.Windows.Forms.Label();
            this.txtFilmoviDodajGodina = new System.Windows.Forms.TextBox();
            this.lblFilmoviDodajGodina = new System.Windows.Forms.Label();
            this.panFilm = new System.Windows.Forms.Panel();
            this.panFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilmoviDodajSpremi
            // 
            this.btnFilmoviDodajSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajSpremi.Location = new System.Drawing.Point(182, 499);
            this.btnFilmoviDodajSpremi.Name = "btnFilmoviDodajSpremi";
            this.btnFilmoviDodajSpremi.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviDodajSpremi.TabIndex = 29;
            this.btnFilmoviDodajSpremi.Text = "Spremi";
            this.btnFilmoviDodajSpremi.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajSpremi.Click += new System.EventHandler(this.btnFilmoviDodajSpremi_Click);
            // 
            // btnFilmoviDodajOdustani
            // 
            this.btnFilmoviDodajOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajOdustani.Location = new System.Drawing.Point(268, 499);
            this.btnFilmoviDodajOdustani.Name = "btnFilmoviDodajOdustani";
            this.btnFilmoviDodajOdustani.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviDodajOdustani.TabIndex = 30;
            this.btnFilmoviDodajOdustani.Text = "Odustani";
            this.btnFilmoviDodajOdustani.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajOdustani.Click += new System.EventHandler(this.btnFilmoviDodajOdustani_Click);
            // 
            // lblFilmoviDodajNaziv
            // 
            this.lblFilmoviDodajNaziv.AutoSize = true;
            this.lblFilmoviDodajNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajNaziv.Location = new System.Drawing.Point(15, 43);
            this.lblFilmoviDodajNaziv.Name = "lblFilmoviDodajNaziv";
            this.lblFilmoviDodajNaziv.Size = new System.Drawing.Size(88, 16);
            this.lblFilmoviDodajNaziv.TabIndex = 31;
            this.lblFilmoviDodajNaziv.Text = "Naziv filma:";
            // 
            // lblFilmoviDodajTrajanje
            // 
            this.lblFilmoviDodajTrajanje.AutoSize = true;
            this.lblFilmoviDodajTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajTrajanje.Location = new System.Drawing.Point(4, 53);
            this.lblFilmoviDodajTrajanje.Name = "lblFilmoviDodajTrajanje";
            this.lblFilmoviDodajTrajanje.Size = new System.Drawing.Size(70, 16);
            this.lblFilmoviDodajTrajanje.TabIndex = 32;
            this.lblFilmoviDodajTrajanje.Text = "Trajanje:";
            // 
            // txtDodajFilmNaziv
            // 
            this.txtDodajFilmNaziv.Location = new System.Drawing.Point(100, 23);
            this.txtDodajFilmNaziv.Name = "txtDodajFilmNaziv";
            this.txtDodajFilmNaziv.Size = new System.Drawing.Size(230, 20);
            this.txtDodajFilmNaziv.TabIndex = 33;
            // 
            // txtFilmoviDodajTrajanje
            // 
            this.txtFilmoviDodajTrajanje.Location = new System.Drawing.Point(100, 52);
            this.txtFilmoviDodajTrajanje.Name = "txtFilmoviDodajTrajanje";
            this.txtFilmoviDodajTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtFilmoviDodajTrajanje.TabIndex = 34;
            // 
            // lblFilmoviDodajTrajanjeMin
            // 
            this.lblFilmoviDodajTrajanjeMin.AutoSize = true;
            this.lblFilmoviDodajTrajanjeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajTrajanjeMin.Location = new System.Drawing.Point(216, 53);
            this.lblFilmoviDodajTrajanjeMin.Name = "lblFilmoviDodajTrajanjeMin";
            this.lblFilmoviDodajTrajanjeMin.Size = new System.Drawing.Size(53, 16);
            this.lblFilmoviDodajTrajanjeMin.TabIndex = 35;
            this.lblFilmoviDodajTrajanjeMin.Text = "minuta";
            // 
            // lblDilmoviDodajZanrovi
            // 
            this.lblDilmoviDodajZanrovi.AutoSize = true;
            this.lblDilmoviDodajZanrovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDilmoviDodajZanrovi.Location = new System.Drawing.Point(4, 320);
            this.lblDilmoviDodajZanrovi.Name = "lblDilmoviDodajZanrovi";
            this.lblDilmoviDodajZanrovi.Size = new System.Drawing.Size(64, 16);
            this.lblDilmoviDodajZanrovi.TabIndex = 36;
            this.lblDilmoviDodajZanrovi.Text = "Žanrovi:";
            // 
            // lblFilmoviDodajZanroviOdabrani
            // 
            this.lblFilmoviDodajZanroviOdabrani.AutoSize = true;
            this.lblFilmoviDodajZanroviOdabrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajZanroviOdabrani.Location = new System.Drawing.Point(200, 320);
            this.lblFilmoviDodajZanroviOdabrani.Name = "lblFilmoviDodajZanroviOdabrani";
            this.lblFilmoviDodajZanroviOdabrani.Size = new System.Drawing.Size(130, 16);
            this.lblFilmoviDodajZanroviOdabrani.TabIndex = 37;
            this.lblFilmoviDodajZanroviOdabrani.Text = "Odabrani žanrovi:";
            // 
            // lbFilmoviDodajZanrovi
            // 
            this.lbFilmoviDodajZanrovi.DisplayMember = "Naziv";
            this.lbFilmoviDodajZanrovi.FormattingEnabled = true;
            this.lbFilmoviDodajZanrovi.Location = new System.Drawing.Point(7, 350);
            this.lbFilmoviDodajZanrovi.Name = "lbFilmoviDodajZanrovi";
            this.lbFilmoviDodajZanrovi.Size = new System.Drawing.Size(120, 95);
            this.lbFilmoviDodajZanrovi.TabIndex = 38;
            this.lbFilmoviDodajZanrovi.ValueMember = "idZanra";
            // 
            // lbFilmoviDodajZanroviOdabrani
            // 
            this.lbFilmoviDodajZanroviOdabrani.DisplayMember = "Naziv";
            this.lbFilmoviDodajZanroviOdabrani.FormattingEnabled = true;
            this.lbFilmoviDodajZanroviOdabrani.Location = new System.Drawing.Point(210, 350);
            this.lbFilmoviDodajZanroviOdabrani.Name = "lbFilmoviDodajZanroviOdabrani";
            this.lbFilmoviDodajZanroviOdabrani.Size = new System.Drawing.Size(120, 95);
            this.lbFilmoviDodajZanroviOdabrani.TabIndex = 39;
            // 
            // btnFilmoviDodajDodajLb
            // 
            this.btnFilmoviDodajDodajLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajDodajLb.Location = new System.Drawing.Point(134, 364);
            this.btnFilmoviDodajDodajLb.Name = "btnFilmoviDodajDodajLb";
            this.btnFilmoviDodajDodajLb.Size = new System.Drawing.Size(70, 30);
            this.btnFilmoviDodajDodajLb.TabIndex = 40;
            this.btnFilmoviDodajDodajLb.Text = "Dodaj";
            this.btnFilmoviDodajDodajLb.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajDodajLb.Click += new System.EventHandler(this.btnFilmoviDodajDodajLb_Click);
            // 
            // btnFilmoviDodajUkloniLb
            // 
            this.btnFilmoviDodajUkloniLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajUkloniLb.Location = new System.Drawing.Point(134, 400);
            this.btnFilmoviDodajUkloniLb.Name = "btnFilmoviDodajUkloniLb";
            this.btnFilmoviDodajUkloniLb.Size = new System.Drawing.Size(70, 30);
            this.btnFilmoviDodajUkloniLb.TabIndex = 41;
            this.btnFilmoviDodajUkloniLb.Text = "Ukloni";
            this.btnFilmoviDodajUkloniLb.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajUkloniLb.Click += new System.EventHandler(this.btnFilmoviDodajOdustaniLb_Click);
            // 
            // lblNaslovAdminFilmoviDodaj
            // 
            this.lblNaslovAdminFilmoviDodaj.AutoSize = true;
            this.lblNaslovAdminFilmoviDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovAdminFilmoviDodaj.Location = new System.Drawing.Point(15, 9);
            this.lblNaslovAdminFilmoviDodaj.Name = "lblNaslovAdminFilmoviDodaj";
            this.lblNaslovAdminFilmoviDodaj.Size = new System.Drawing.Size(40, 18);
            this.lblNaslovAdminFilmoviDodaj.TabIndex = 42;
            this.lblNaslovAdminFilmoviDodaj.Text = "Film";
            // 
            // txtFilmoviDodajSinopsis
            // 
            this.txtFilmoviDodajSinopsis.Location = new System.Drawing.Point(98, 228);
            this.txtFilmoviDodajSinopsis.Multiline = true;
            this.txtFilmoviDodajSinopsis.Name = "txtFilmoviDodajSinopsis";
            this.txtFilmoviDodajSinopsis.Size = new System.Drawing.Size(232, 84);
            this.txtFilmoviDodajSinopsis.TabIndex = 46;
            // 
            // txtFilmoviDodajRedatelj
            // 
            this.txtFilmoviDodajRedatelj.Location = new System.Drawing.Point(98, 80);
            this.txtFilmoviDodajRedatelj.Name = "txtFilmoviDodajRedatelj";
            this.txtFilmoviDodajRedatelj.Size = new System.Drawing.Size(230, 20);
            this.txtFilmoviDodajRedatelj.TabIndex = 45;
            // 
            // lblFilmoviDodajSinopsis
            // 
            this.lblFilmoviDodajSinopsis.AutoSize = true;
            this.lblFilmoviDodajSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajSinopsis.Location = new System.Drawing.Point(4, 229);
            this.lblFilmoviDodajSinopsis.Name = "lblFilmoviDodajSinopsis";
            this.lblFilmoviDodajSinopsis.Size = new System.Drawing.Size(72, 16);
            this.lblFilmoviDodajSinopsis.TabIndex = 44;
            this.lblFilmoviDodajSinopsis.Text = "Sinopsis:";
            // 
            // lblFilmoviDodajRedatelj
            // 
            this.lblFilmoviDodajRedatelj.AutoSize = true;
            this.lblFilmoviDodajRedatelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajRedatelj.Location = new System.Drawing.Point(4, 81);
            this.lblFilmoviDodajRedatelj.Name = "lblFilmoviDodajRedatelj";
            this.lblFilmoviDodajRedatelj.Size = new System.Drawing.Size(71, 16);
            this.lblFilmoviDodajRedatelj.TabIndex = 43;
            this.lblFilmoviDodajRedatelj.Text = "Redatelj:";
            // 
            // txtFilmoviDodajGlumci
            // 
            this.txtFilmoviDodajGlumci.Location = new System.Drawing.Point(98, 137);
            this.txtFilmoviDodajGlumci.Multiline = true;
            this.txtFilmoviDodajGlumci.Name = "txtFilmoviDodajGlumci";
            this.txtFilmoviDodajGlumci.Size = new System.Drawing.Size(230, 85);
            this.txtFilmoviDodajGlumci.TabIndex = 48;
            // 
            // lblFilmoviDodajGlumci
            // 
            this.lblFilmoviDodajGlumci.AutoSize = true;
            this.lblFilmoviDodajGlumci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajGlumci.Location = new System.Drawing.Point(4, 137);
            this.lblFilmoviDodajGlumci.Name = "lblFilmoviDodajGlumci";
            this.lblFilmoviDodajGlumci.Size = new System.Drawing.Size(59, 16);
            this.lblFilmoviDodajGlumci.TabIndex = 47;
            this.lblFilmoviDodajGlumci.Text = "Glumci:";
            // 
            // txtFilmoviDodajGodina
            // 
            this.txtFilmoviDodajGodina.Location = new System.Drawing.Point(98, 109);
            this.txtFilmoviDodajGodina.Name = "txtFilmoviDodajGodina";
            this.txtFilmoviDodajGodina.Size = new System.Drawing.Size(230, 20);
            this.txtFilmoviDodajGodina.TabIndex = 50;
            // 
            // lblFilmoviDodajGodina
            // 
            this.lblFilmoviDodajGodina.AutoSize = true;
            this.lblFilmoviDodajGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmoviDodajGodina.Location = new System.Drawing.Point(4, 110);
            this.lblFilmoviDodajGodina.Name = "lblFilmoviDodajGodina";
            this.lblFilmoviDodajGodina.Size = new System.Drawing.Size(62, 16);
            this.lblFilmoviDodajGodina.TabIndex = 49;
            this.lblFilmoviDodajGodina.Text = "Godina:";
            // 
            // panFilm
            // 
            this.panFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFilm.Controls.Add(this.txtFilmoviDodajSinopsis);
            this.panFilm.Controls.Add(this.btnFilmoviDodajUkloniLb);
            this.panFilm.Controls.Add(this.txtFilmoviDodajGlumci);
            this.panFilm.Controls.Add(this.btnFilmoviDodajDodajLb);
            this.panFilm.Controls.Add(this.lblFilmoviDodajSinopsis);
            this.panFilm.Controls.Add(this.lbFilmoviDodajZanroviOdabrani);
            this.panFilm.Controls.Add(this.txtFilmoviDodajGodina);
            this.panFilm.Controls.Add(this.lblFilmoviDodajZanroviOdabrani);
            this.panFilm.Controls.Add(this.lbFilmoviDodajZanrovi);
            this.panFilm.Controls.Add(this.lblFilmoviDodajGlumci);
            this.panFilm.Controls.Add(this.txtDodajFilmNaziv);
            this.panFilm.Controls.Add(this.lblDilmoviDodajZanrovi);
            this.panFilm.Controls.Add(this.lblFilmoviDodajGodina);
            this.panFilm.Controls.Add(this.lblFilmoviDodajTrajanje);
            this.panFilm.Controls.Add(this.txtFilmoviDodajTrajanje);
            this.panFilm.Controls.Add(this.lblFilmoviDodajTrajanjeMin);
            this.panFilm.Controls.Add(this.lblFilmoviDodajRedatelj);
            this.panFilm.Controls.Add(this.txtFilmoviDodajRedatelj);
            this.panFilm.Location = new System.Drawing.Point(10, 19);
            this.panFilm.Name = "panFilm";
            this.panFilm.Size = new System.Drawing.Size(338, 456);
            this.panFilm.TabIndex = 51;
            // 
            // FrmAdminFilmoviDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 550);
            this.Controls.Add(this.lblNaslovAdminFilmoviDodaj);
            this.Controls.Add(this.lblFilmoviDodajNaziv);
            this.Controls.Add(this.btnFilmoviDodajOdustani);
            this.Controls.Add(this.btnFilmoviDodajSpremi);
            this.Controls.Add(this.panFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminFilmoviDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmovi - dodaj/ažuriraj";
            this.Load += new System.EventHandler(this.FrmAdminFilmDodaj_Load);
            this.panFilm.ResumeLayout(false);
            this.panFilm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilmoviDodajSpremi;
        private System.Windows.Forms.Button btnFilmoviDodajOdustani;
        private System.Windows.Forms.Label lblFilmoviDodajNaziv;
        private System.Windows.Forms.Label lblFilmoviDodajTrajanje;
        private System.Windows.Forms.TextBox txtDodajFilmNaziv;
        private System.Windows.Forms.TextBox txtFilmoviDodajTrajanje;
        private System.Windows.Forms.Label lblFilmoviDodajTrajanjeMin;
        private System.Windows.Forms.Label lblDilmoviDodajZanrovi;
        private System.Windows.Forms.Label lblFilmoviDodajZanroviOdabrani;
        private System.Windows.Forms.ListBox lbFilmoviDodajZanrovi;
        private System.Windows.Forms.ListBox lbFilmoviDodajZanroviOdabrani;
        private System.Windows.Forms.Button btnFilmoviDodajDodajLb;
        private System.Windows.Forms.Button btnFilmoviDodajUkloniLb;
        private System.Windows.Forms.Label lblNaslovAdminFilmoviDodaj;
        private System.Windows.Forms.TextBox txtFilmoviDodajSinopsis;
        private System.Windows.Forms.TextBox txtFilmoviDodajRedatelj;
        private System.Windows.Forms.Label lblFilmoviDodajSinopsis;
        private System.Windows.Forms.Label lblFilmoviDodajRedatelj;
        private System.Windows.Forms.TextBox txtFilmoviDodajGlumci;
        private System.Windows.Forms.Label lblFilmoviDodajGlumci;
        private System.Windows.Forms.TextBox txtFilmoviDodajGodina;
        private System.Windows.Forms.Label lblFilmoviDodajGodina;
        private System.Windows.Forms.Panel panFilm;
    }
}