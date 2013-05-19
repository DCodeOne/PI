namespace PI_projekt.Sucelja
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.odjava = new System.Windows.Forms.LinkLabel();
            this.ime = new System.Windows.Forms.TextBox();
            this.identitet = new System.Windows.Forms.Label();
            this.admFilmovi = new System.Windows.Forms.Button();
            this.admProjekcije = new System.Windows.Forms.Button();
            this.admZaposlenici = new System.Windows.Forms.Button();
            this.admArtikli = new System.Windows.Forms.Button();
            this.admStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.Location = new System.Drawing.Point(400, 9);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(56, 17);
            this.odjava.TabIndex = 0;
            this.odjava.TabStop = true;
            this.odjava.Text = "odjava";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(155, 11);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(163, 20);
            this.ime.TabIndex = 1;
            // 
            // identitet
            // 
            this.identitet.AutoSize = true;
            this.identitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.identitet.Location = new System.Drawing.Point(3, 10);
            this.identitet.Name = "identitet";
            this.identitet.Size = new System.Drawing.Size(146, 18);
            this.identitet.TabIndex = 2;
            this.identitet.Text = "Prijavljeni ste kao:";
            // 
            // admFilmovi
            // 
            this.admFilmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admFilmovi.Location = new System.Drawing.Point(12, 54);
            this.admFilmovi.Name = "admFilmovi";
            this.admFilmovi.Size = new System.Drawing.Size(100, 30);
            this.admFilmovi.TabIndex = 3;
            this.admFilmovi.Text = "Filmovi";
            this.admFilmovi.UseVisualStyleBackColor = true;
            // 
            // admProjekcije
            // 
            this.admProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admProjekcije.Location = new System.Drawing.Point(65, 101);
            this.admProjekcije.Name = "admProjekcije";
            this.admProjekcije.Size = new System.Drawing.Size(100, 30);
            this.admProjekcije.TabIndex = 4;
            this.admProjekcije.Text = "Projekcije";
            this.admProjekcije.UseVisualStyleBackColor = true;
            // 
            // admZaposlenici
            // 
            this.admZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admZaposlenici.Location = new System.Drawing.Point(226, 101);
            this.admZaposlenici.Name = "admZaposlenici";
            this.admZaposlenici.Size = new System.Drawing.Size(100, 30);
            this.admZaposlenici.TabIndex = 6;
            this.admZaposlenici.Text = "Zaposlenici";
            this.admZaposlenici.UseVisualStyleBackColor = true;
            // 
            // admArtikli
            // 
            this.admArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admArtikli.Location = new System.Drawing.Point(173, 54);
            this.admArtikli.Name = "admArtikli";
            this.admArtikli.Size = new System.Drawing.Size(100, 30);
            this.admArtikli.TabIndex = 5;
            this.admArtikli.Text = "Artikli";
            this.admArtikli.UseVisualStyleBackColor = true;
            // 
            // admStatistika
            // 
            this.admStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admStatistika.Location = new System.Drawing.Point(347, 164);
            this.admStatistika.Name = "admStatistika";
            this.admStatistika.Size = new System.Drawing.Size(100, 30);
            this.admStatistika.TabIndex = 8;
            this.admStatistika.Text = "Statistika";
            this.admStatistika.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 206);
            this.Controls.Add(this.admStatistika);
            this.Controls.Add(this.admZaposlenici);
            this.Controls.Add(this.admArtikli);
            this.Controls.Add(this.admProjekcije);
            this.Controls.Add(this.admFilmovi);
            this.Controls.Add(this.identitet);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.odjava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel odjava;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label identitet;
        private System.Windows.Forms.Button admFilmovi;
        private System.Windows.Forms.Button admProjekcije;
        private System.Windows.Forms.Button admZaposlenici;
        private System.Windows.Forms.Button admArtikli;
        private System.Windows.Forms.Button admStatistika;
    }
}