namespace PI_projekt.Artikli
{
    partial class FrmArtikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtikli));
            this.Naziv_artikla = new System.Windows.Forms.Label();
            this.Cijena = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.ComboBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.Cijena_box = new System.Windows.Forms.TextBox();
            this.Kolicina_box = new System.Windows.Forms.TextBox();
            this.Stavke_racun = new System.Windows.Forms.GroupBox();
            this.Iznos_racun = new System.Windows.Forms.Label();
            this.Ukupno = new System.Windows.Forms.TextBox();
            this.Dalje = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Prijava = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.Opcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // Naziv_artikla
            // 
            this.Naziv_artikla.AutoSize = true;
            this.Naziv_artikla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Naziv_artikla.Cursor = System.Windows.Forms.Cursors.Default;
            this.Naziv_artikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv_artikla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Naziv_artikla.Location = new System.Drawing.Point(13, 26);
            this.Naziv_artikla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Naziv_artikla.Name = "Naziv_artikla";
            this.Naziv_artikla.Size = new System.Drawing.Size(98, 16);
            this.Naziv_artikla.TabIndex = 0;
            this.Naziv_artikla.Text = "Naziv artikla:";
            this.Naziv_artikla.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cijena.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cijena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cijena.Location = new System.Drawing.Point(13, 66);
            this.Cijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(125, 16);
            this.Cijena.TabIndex = 2;
            this.Cijena.Text = "Jedinična cijena:";
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Naziv.Cursor = System.Windows.Forms.Cursors.Default;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Naziv.FormattingEnabled = true;
            this.Naziv.Location = new System.Drawing.Point(154, 23);
            this.Naziv.Margin = new System.Windows.Forms.Padding(4);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(254, 24);
            this.Naziv.TabIndex = 3;
            this.Naziv.SelectedIndexChanged += new System.EventHandler(this.Naziv_SelectedIndexChanged);
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kolicina.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kolicina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kolicina.Location = new System.Drawing.Point(13, 104);
            this.Kolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(67, 16);
            this.Kolicina.TabIndex = 4;
            this.Kolicina.Text = "Količina:";
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dodaj.Location = new System.Drawing.Point(118, 184);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 28);
            this.Dodaj.TabIndex = 5;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ponisti
            // 
            this.Ponisti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ponisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ponisti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ponisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ponisti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ponisti.Location = new System.Drawing.Point(238, 184);
            this.Ponisti.Margin = new System.Windows.Forms.Padding(4);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(112, 28);
            this.Ponisti.TabIndex = 6;
            this.Ponisti.Text = "Poništi";
            this.Ponisti.UseVisualStyleBackColor = false;
            // 
            // Cijena_box
            // 
            this.Cijena_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cijena_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cijena_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cijena_box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cijena_box.Location = new System.Drawing.Point(154, 63);
            this.Cijena_box.Margin = new System.Windows.Forms.Padding(4);
            this.Cijena_box.Name = "Cijena_box";
            this.Cijena_box.Size = new System.Drawing.Size(139, 22);
            this.Cijena_box.TabIndex = 7;
            this.Cijena_box.Text = " kn";
            // 
            // Kolicina_box
            // 
            this.Kolicina_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kolicina_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kolicina_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kolicina_box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kolicina_box.Location = new System.Drawing.Point(154, 101);
            this.Kolicina_box.Margin = new System.Windows.Forms.Padding(4);
            this.Kolicina_box.Name = "Kolicina_box";
            this.Kolicina_box.Size = new System.Drawing.Size(139, 22);
            this.Kolicina_box.TabIndex = 8;
            this.Kolicina_box.Text = "0,00";
            // 
            // Stavke_racun
            // 
            this.Stavke_racun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stavke_racun.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stavke_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stavke_racun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stavke_racun.Location = new System.Drawing.Point(8, 220);
            this.Stavke_racun.Margin = new System.Windows.Forms.Padding(4);
            this.Stavke_racun.Name = "Stavke_racun";
            this.Stavke_racun.Padding = new System.Windows.Forms.Padding(4);
            this.Stavke_racun.Size = new System.Drawing.Size(448, 155);
            this.Stavke_racun.TabIndex = 9;
            this.Stavke_racun.TabStop = false;
            this.Stavke_racun.Text = "Stavke";
            // 
            // Iznos_racun
            // 
            this.Iznos_racun.AutoSize = true;
            this.Iznos_racun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Iznos_racun.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iznos_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Iznos_racun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Iznos_racun.Location = new System.Drawing.Point(252, 386);
            this.Iznos_racun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Iznos_racun.Name = "Iznos_racun";
            this.Iznos_racun.Size = new System.Drawing.Size(48, 16);
            this.Iznos_racun.TabIndex = 10;
            this.Iznos_racun.Text = "Iznos:";
            // 
            // Ukupno
            // 
            this.Ukupno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ukupno.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ukupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ukupno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ukupno.Location = new System.Drawing.Point(308, 383);
            this.Ukupno.Margin = new System.Windows.Forms.Padding(4);
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.Size = new System.Drawing.Size(148, 22);
            this.Ukupno.TabIndex = 11;
            this.Ukupno.Text = "0,00 kn";
            // 
            // Dalje
            // 
            this.Dalje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dalje.Location = new System.Drawing.Point(344, 440);
            this.Dalje.Margin = new System.Windows.Forms.Padding(4);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(112, 35);
            this.Dalje.TabIndex = 12;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = false;
            this.Dalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(400, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(56, 16);
            this.Odjava.TabIndex = 15;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            // 
            // Prijava
            // 
            this.Prijava.AutoSize = true;
            this.Prijava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prijava.Location = new System.Drawing.Point(5, 10);
            this.Prijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(136, 16);
            this.Prijava.TabIndex = 14;
            this.Prijava.Text = "Prijavljeni ste kao:";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.user.Location = new System.Drawing.Point(162, 7);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(147, 22);
            this.user.TabIndex = 13;
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Controls.Add(this.Naziv);
            this.Opcije.Controls.Add(this.Naziv_artikla);
            this.Opcije.Controls.Add(this.Cijena);
            this.Opcije.Controls.Add(this.Kolicina);
            this.Opcije.Controls.Add(this.Cijena_box);
            this.Opcije.Controls.Add(this.Kolicina_box);
            this.Opcije.Cursor = System.Windows.Forms.Cursors.Default;
            this.Opcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opcije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Opcije.Location = new System.Drawing.Point(8, 37);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(448, 139);
            this.Opcije.TabIndex = 10;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nazad.Location = new System.Drawing.Point(7, 440);
            this.Nazad.Margin = new System.Windows.Forms.Padding(4);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(112, 35);
            this.Nazad.TabIndex = 16;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 482);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.Prijava);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.Ukupno);
            this.Controls.Add(this.Ponisti);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Iznos_racun);
            this.Controls.Add(this.Stavke_racun);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(479, 520);
            this.MinimumSize = new System.Drawing.Size(479, 520);
            this.Name = "FrmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.FrmArtikli_Load);
            this.Opcije.ResumeLayout(false);
            this.Opcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv_artikla;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.ComboBox Naziv;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Ponisti;
        private System.Windows.Forms.TextBox Cijena_box;
        private System.Windows.Forms.TextBox Kolicina_box;
        private System.Windows.Forms.GroupBox Stavke_racun;
        private System.Windows.Forms.Label Iznos_racun;
        private System.Windows.Forms.TextBox Ukupno;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label Prijava;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.Button Nazad;

    }
}