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
            this.Zaposlenici = new System.Windows.Forms.Button();
            this.Artikli = new System.Windows.Forms.Button();
            this.Filmovi = new System.Windows.Forms.Button();
            this.Projekcije = new System.Windows.Forms.Button();
            this.Dvorane = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Statistika = new System.Windows.Forms.Button();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.Opcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zaposlenici
            // 
            this.Zaposlenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zaposlenici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Zaposlenici.Image = global::PI_projekt.Properties.Resources.zaposlenik;
            this.Zaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Zaposlenici.Location = new System.Drawing.Point(10, 18);
            this.Zaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.Zaposlenici.Name = "Zaposlenici";
            this.Zaposlenici.Size = new System.Drawing.Size(140, 40);
            this.Zaposlenici.TabIndex = 3;
            this.Zaposlenici.Text = "Zaposlenici";
            this.Zaposlenici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zaposlenici.UseVisualStyleBackColor = true;
            // 
            // Artikli
            // 
            this.Artikli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Artikli.Image = global::PI_projekt.Properties.Resources.kokice;
            this.Artikli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Artikli.Location = new System.Drawing.Point(80, 60);
            this.Artikli.Margin = new System.Windows.Forms.Padding(4);
            this.Artikli.Name = "Artikli";
            this.Artikli.Size = new System.Drawing.Size(140, 40);
            this.Artikli.TabIndex = 4;
            this.Artikli.Text = "Artikli";
            this.Artikli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Artikli.UseVisualStyleBackColor = true;
            this.Artikli.Click += new System.EventHandler(this.Artikli_Click);
            // 
            // Filmovi
            // 
            this.Filmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filmovi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Filmovi.Image = global::PI_projekt.Properties.Resources.Movies;
            this.Filmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filmovi.Location = new System.Drawing.Point(150, 102);
            this.Filmovi.Margin = new System.Windows.Forms.Padding(4);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(140, 40);
            this.Filmovi.TabIndex = 5;
            this.Filmovi.Text = "Filmovi";
            this.Filmovi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filmovi.UseVisualStyleBackColor = true;
            // 
            // Projekcije
            // 
            this.Projekcije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Projekcije.Image = global::PI_projekt.Properties.Resources.projekcije;
            this.Projekcije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Projekcije.Location = new System.Drawing.Point(80, 144);
            this.Projekcije.Margin = new System.Windows.Forms.Padding(4);
            this.Projekcije.Name = "Projekcije";
            this.Projekcije.Size = new System.Drawing.Size(140, 40);
            this.Projekcije.TabIndex = 6;
            this.Projekcije.Text = "Projekcije";
            this.Projekcije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Projekcije.UseVisualStyleBackColor = true;
            // 
            // Dvorane
            // 
            this.Dvorane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvorane.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dvorane.Image = global::PI_projekt.Properties.Resources.dvorana;
            this.Dvorane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dvorane.Location = new System.Drawing.Point(10, 186);
            this.Dvorane.Margin = new System.Windows.Forms.Padding(4);
            this.Dvorane.Name = "Dvorane";
            this.Dvorane.Size = new System.Drawing.Size(140, 40);
            this.Dvorane.TabIndex = 7;
            this.Dvorane.Text = "Dvorane";
            this.Dvorane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dvorane.UseVisualStyleBackColor = true;
            this.Dvorane.Click += new System.EventHandler(this.Dvorane_Click);
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Controls.Add(this.Dvorane);
            this.Opcije.Controls.Add(this.Projekcije);
            this.Opcije.Controls.Add(this.Filmovi);
            this.Opcije.Controls.Add(this.Artikli);
            this.Opcije.Controls.Add(this.Zaposlenici);
            this.Opcije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Opcije.Location = new System.Drawing.Point(13, 75);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(301, 234);
            this.Opcije.TabIndex = 9;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            this.Opcije.Enter += new System.EventHandler(this.Opcije_Enter);
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(406, 13);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(56, 16);
            this.Odjava.TabIndex = 2;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // Statistika
            // 
            this.Statistika.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Statistika.Location = new System.Drawing.Point(364, 281);
            this.Statistika.Margin = new System.Windows.Forms.Padding(4);
            this.Statistika.Name = "Statistika";
            this.Statistika.Size = new System.Drawing.Size(112, 28);
            this.Statistika.TabIndex = 8;
            this.Statistika.Text = "Statistika";
            this.Statistika.UseVisualStyleBackColor = false;
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(71, 39);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(47, 16);
            this.userRole.TabIndex = 13;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(13, 39);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(54, 16);
            this.uloga.TabIndex = 12;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(156, 13);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(108, 16);
            this.userName.TabIndex = 11;
            this.userName.Text = "korisničko ime";
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.BackColor = System.Drawing.Color.Black;
            this.korisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisnik.Location = new System.Drawing.Point(13, 13);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(136, 16);
            this.korisnik.TabIndex = 10;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 315);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.Statistika);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Odjava);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(505, 354);
            this.MinimumSize = new System.Drawing.Size(505, 354);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Opcije.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zaposlenici;
        private System.Windows.Forms.Button Artikli;
        private System.Windows.Forms.Button Filmovi;
        private System.Windows.Forms.Button Projekcije;
        private System.Windows.Forms.Button Dvorane;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Button Statistika;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label korisnik;

    }
}