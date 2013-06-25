namespace PI_projekt.Sucelja
{
    partial class FrmAdminProjekcijeDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminProjekcijeDodaj));
            this.lblProjekcijeDodajTrajanjeMin = new System.Windows.Forms.Label();
            this.txtProjekcijeDodajTrajanje = new System.Windows.Forms.TextBox();
            this.lblProjekcijeDodajTrajanje = new System.Windows.Forms.Label();
            this.lblProjekcijeDodajIdDvorane = new System.Windows.Forms.Label();
            this.btnFilmoviDodajOdustani = new System.Windows.Forms.Button();
            this.btnFilmoviDodajSpremi = new System.Windows.Forms.Button();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.txtProjekcijeDodajCijena = new System.Windows.Forms.TextBox();
            this.lblProjekcijeDodajCijena = new System.Windows.Forms.Label();
            this.lblProjekcijeDodajDatum = new System.Windows.Forms.Label();
            this.cbBrojDvorana = new System.Windows.Forms.ComboBox();
            this.cbNazivFilma = new System.Windows.Forms.ComboBox();
            this.lbVrsteProjekcija = new System.Windows.Forms.ListBox();
            this.lbOdabrane = new System.Windows.Forms.ListBox();
            this.lblDodaj = new System.Windows.Forms.Button();
            this.lblUkloni = new System.Windows.Forms.Button();
            this.lblVrsteProjekcija = new System.Windows.Forms.Label();
            this.lblOdabrane = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.panProjekcija = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panProjekcija.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjekcijeDodajTrajanjeMin
            // 
            this.lblProjekcijeDodajTrajanjeMin.AutoSize = true;
            this.lblProjekcijeDodajTrajanjeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcijeDodajTrajanjeMin.Location = new System.Drawing.Point(248, 91);
            this.lblProjekcijeDodajTrajanjeMin.Name = "lblProjekcijeDodajTrajanjeMin";
            this.lblProjekcijeDodajTrajanjeMin.Size = new System.Drawing.Size(53, 16);
            this.lblProjekcijeDodajTrajanjeMin.TabIndex = 47;
            this.lblProjekcijeDodajTrajanjeMin.Text = "minuta";
            // 
            // txtProjekcijeDodajTrajanje
            // 
            this.txtProjekcijeDodajTrajanje.Location = new System.Drawing.Point(138, 91);
            this.txtProjekcijeDodajTrajanje.Name = "txtProjekcijeDodajTrajanje";
            this.txtProjekcijeDodajTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtProjekcijeDodajTrajanje.TabIndex = 56;
            // 
            // lblProjekcijeDodajTrajanje
            // 
            this.lblProjekcijeDodajTrajanje.AutoSize = true;
            this.lblProjekcijeDodajTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcijeDodajTrajanje.Location = new System.Drawing.Point(8, 91);
            this.lblProjekcijeDodajTrajanje.Name = "lblProjekcijeDodajTrajanje";
            this.lblProjekcijeDodajTrajanje.Size = new System.Drawing.Size(70, 16);
            this.lblProjekcijeDodajTrajanje.TabIndex = 44;
            this.lblProjekcijeDodajTrajanje.Text = "Trajanje:";
            // 
            // lblProjekcijeDodajIdDvorane
            // 
            this.lblProjekcijeDodajIdDvorane.AutoSize = true;
            this.lblProjekcijeDodajIdDvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcijeDodajIdDvorane.Location = new System.Drawing.Point(8, 31);
            this.lblProjekcijeDodajIdDvorane.Name = "lblProjekcijeDodajIdDvorane";
            this.lblProjekcijeDodajIdDvorane.Size = new System.Drawing.Size(101, 16);
            this.lblProjekcijeDodajIdDvorane.TabIndex = 43;
            this.lblProjekcijeDodajIdDvorane.Text = "Broj dvorane:";
            // 
            // btnFilmoviDodajOdustani
            // 
            this.btnFilmoviDodajOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajOdustani.Location = new System.Drawing.Point(297, 367);
            this.btnFilmoviDodajOdustani.Name = "btnFilmoviDodajOdustani";
            this.btnFilmoviDodajOdustani.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviDodajOdustani.TabIndex = 64;
            this.btnFilmoviDodajOdustani.Text = "Odustani";
            this.btnFilmoviDodajOdustani.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajOdustani.Click += new System.EventHandler(this.btnProjekcijeDodajOdustani_Click);
            // 
            // btnFilmoviDodajSpremi
            // 
            this.btnFilmoviDodajSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodajSpremi.Location = new System.Drawing.Point(210, 367);
            this.btnFilmoviDodajSpremi.Name = "btnFilmoviDodajSpremi";
            this.btnFilmoviDodajSpremi.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviDodajSpremi.TabIndex = 63;
            this.btnFilmoviDodajSpremi.Text = "Spremi";
            this.btnFilmoviDodajSpremi.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajSpremi.Click += new System.EventHandler(this.btnFilmoviDodajSpremi_Click);
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivFilma.Location = new System.Drawing.Point(8, 61);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(88, 16);
            this.lblNazivFilma.TabIndex = 48;
            this.lblNazivFilma.Text = "Naziv filma:";
            // 
            // txtProjekcijeDodajCijena
            // 
            this.txtProjekcijeDodajCijena.Location = new System.Drawing.Point(138, 121);
            this.txtProjekcijeDodajCijena.Name = "txtProjekcijeDodajCijena";
            this.txtProjekcijeDodajCijena.Size = new System.Drawing.Size(100, 20);
            this.txtProjekcijeDodajCijena.TabIndex = 57;
            // 
            // lblProjekcijeDodajCijena
            // 
            this.lblProjekcijeDodajCijena.AutoSize = true;
            this.lblProjekcijeDodajCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcijeDodajCijena.Location = new System.Drawing.Point(8, 121);
            this.lblProjekcijeDodajCijena.Name = "lblProjekcijeDodajCijena";
            this.lblProjekcijeDodajCijena.Size = new System.Drawing.Size(117, 16);
            this.lblProjekcijeDodajCijena.TabIndex = 50;
            this.lblProjekcijeDodajCijena.Text = "Cijena ulaznice:";
            // 
            // lblProjekcijeDodajDatum
            // 
            this.lblProjekcijeDodajDatum.AutoSize = true;
            this.lblProjekcijeDodajDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcijeDodajDatum.Location = new System.Drawing.Point(8, 151);
            this.lblProjekcijeDodajDatum.Name = "lblProjekcijeDodajDatum";
            this.lblProjekcijeDodajDatum.Size = new System.Drawing.Size(56, 16);
            this.lblProjekcijeDodajDatum.TabIndex = 52;
            this.lblProjekcijeDodajDatum.Text = "Datum:";
            // 
            // cbBrojDvorana
            // 
            this.cbBrojDvorana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrojDvorana.FormattingEnabled = true;
            this.cbBrojDvorana.Location = new System.Drawing.Point(138, 31);
            this.cbBrojDvorana.Name = "cbBrojDvorana";
            this.cbBrojDvorana.Size = new System.Drawing.Size(120, 21);
            this.cbBrojDvorana.TabIndex = 54;
            // 
            // cbNazivFilma
            // 
            this.cbNazivFilma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivFilma.FormattingEnabled = true;
            this.cbNazivFilma.Location = new System.Drawing.Point(138, 61);
            this.cbNazivFilma.Name = "cbNazivFilma";
            this.cbNazivFilma.Size = new System.Drawing.Size(197, 21);
            this.cbNazivFilma.TabIndex = 55;
            // 
            // lbVrsteProjekcija
            // 
            this.lbVrsteProjekcija.DisplayMember = "Naziv";
            this.lbVrsteProjekcija.FormattingEnabled = true;
            this.lbVrsteProjekcija.Location = new System.Drawing.Point(11, 221);
            this.lbVrsteProjekcija.Name = "lbVrsteProjekcija";
            this.lbVrsteProjekcija.Size = new System.Drawing.Size(120, 95);
            this.lbVrsteProjekcija.TabIndex = 59;
            this.lbVrsteProjekcija.ValueMember = "IdVrste";
            // 
            // lbOdabrane
            // 
            this.lbOdabrane.DisplayMember = "Naziv";
            this.lbOdabrane.FormattingEnabled = true;
            this.lbOdabrane.Location = new System.Drawing.Point(215, 221);
            this.lbOdabrane.Name = "lbOdabrane";
            this.lbOdabrane.Size = new System.Drawing.Size(120, 95);
            this.lbOdabrane.TabIndex = 61;
            this.lbOdabrane.ValueMember = "IdVrste";
            // 
            // lblDodaj
            // 
            this.lblDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodaj.Location = new System.Drawing.Point(138, 231);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(70, 30);
            this.lblDodaj.TabIndex = 60;
            this.lblDodaj.Text = "Dodaj";
            this.lblDodaj.UseVisualStyleBackColor = true;
            this.lblDodaj.Click += new System.EventHandler(this.lblDodaj_Click);
            // 
            // lblUkloni
            // 
            this.lblUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkloni.Location = new System.Drawing.Point(138, 276);
            this.lblUkloni.Name = "lblUkloni";
            this.lblUkloni.Size = new System.Drawing.Size(70, 30);
            this.lblUkloni.TabIndex = 62;
            this.lblUkloni.Text = "Ukloni";
            this.lblUkloni.UseVisualStyleBackColor = true;
            this.lblUkloni.Click += new System.EventHandler(this.lblUkloni_Click);
            // 
            // lblVrsteProjekcija
            // 
            this.lblVrsteProjekcija.AutoSize = true;
            this.lblVrsteProjekcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrsteProjekcija.Location = new System.Drawing.Point(8, 191);
            this.lblVrsteProjekcija.Name = "lblVrsteProjekcija";
            this.lblVrsteProjekcija.Size = new System.Drawing.Size(121, 16);
            this.lblVrsteProjekcija.TabIndex = 61;
            this.lblVrsteProjekcija.Text = "Vrste projekcija:";
            // 
            // lblOdabrane
            // 
            this.lblOdabrane.AutoSize = true;
            this.lblOdabrane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabrane.Location = new System.Drawing.Point(212, 191);
            this.lblOdabrane.Name = "lblOdabrane";
            this.lblOdabrane.Size = new System.Drawing.Size(119, 16);
            this.lblOdabrane.TabIndex = 62;
            this.lblOdabrane.Text = "Odabrane vrste:";
            // 
            // dtDatum
            // 
            this.dtDatum.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatum.Location = new System.Drawing.Point(138, 151);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.ShowUpDown = true;
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 58;
            // 
            // panProjekcija
            // 
            this.panProjekcija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panProjekcija.Controls.Add(this.cbBrojDvorana);
            this.panProjekcija.Controls.Add(this.dtDatum);
            this.panProjekcija.Controls.Add(this.lblProjekcijeDodajIdDvorane);
            this.panProjekcija.Controls.Add(this.lblOdabrane);
            this.panProjekcija.Controls.Add(this.lblProjekcijeDodajTrajanje);
            this.panProjekcija.Controls.Add(this.lblVrsteProjekcija);
            this.panProjekcija.Controls.Add(this.txtProjekcijeDodajTrajanje);
            this.panProjekcija.Controls.Add(this.lblUkloni);
            this.panProjekcija.Controls.Add(this.lblProjekcijeDodajTrajanjeMin);
            this.panProjekcija.Controls.Add(this.lblDodaj);
            this.panProjekcija.Controls.Add(this.lblNazivFilma);
            this.panProjekcija.Controls.Add(this.lbOdabrane);
            this.panProjekcija.Controls.Add(this.lblProjekcijeDodajCijena);
            this.panProjekcija.Controls.Add(this.lbVrsteProjekcija);
            this.panProjekcija.Controls.Add(this.txtProjekcijeDodajCijena);
            this.panProjekcija.Controls.Add(this.cbNazivFilma);
            this.panProjekcija.Controls.Add(this.lblProjekcijeDodajDatum);
            this.panProjekcija.Location = new System.Drawing.Point(12, 25);
            this.panProjekcija.Name = "panProjekcija";
            this.panProjekcija.Size = new System.Drawing.Size(365, 327);
            this.panProjekcija.TabIndex = 65;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(16, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(83, 18);
            this.lblNaslov.TabIndex = 66;
            this.lblNaslov.Text = "Projekcija";
            // 
            // FrmAdminProjekcijeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 410);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnFilmoviDodajOdustani);
            this.Controls.Add(this.btnFilmoviDodajSpremi);
            this.Controls.Add(this.panProjekcija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminProjekcijeDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekcije - dodaj/ažuriraj";
            this.Load += new System.EventHandler(this.FrmAdminProjekcijeDodaj_Load);
            this.panProjekcija.ResumeLayout(false);
            this.panProjekcija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjekcijeDodajTrajanjeMin;
        private System.Windows.Forms.TextBox txtProjekcijeDodajTrajanje;
        private System.Windows.Forms.Label lblProjekcijeDodajTrajanje;
        private System.Windows.Forms.Label lblProjekcijeDodajIdDvorane;
        private System.Windows.Forms.Button btnFilmoviDodajOdustani;
        private System.Windows.Forms.Button btnFilmoviDodajSpremi;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.TextBox txtProjekcijeDodajCijena;
        private System.Windows.Forms.Label lblProjekcijeDodajCijena;
        private System.Windows.Forms.Label lblProjekcijeDodajDatum;
        private System.Windows.Forms.ComboBox cbBrojDvorana;
        private System.Windows.Forms.ComboBox cbNazivFilma;
        private System.Windows.Forms.ListBox lbVrsteProjekcija;
        private System.Windows.Forms.ListBox lbOdabrane;
        private System.Windows.Forms.Button lblDodaj;
        private System.Windows.Forms.Button lblUkloni;
        private System.Windows.Forms.Label lblVrsteProjekcija;
        private System.Windows.Forms.Label lblOdabrane;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Panel panProjekcija;
        private System.Windows.Forms.Label lblNaslov;
    }
}