namespace PI_projekt.Ulaznica
{
    partial class FrmUlaznica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUlaznica));
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Prijava = new System.Windows.Forms.Label();
            this.lblDatumProjekcije = new System.Windows.Forms.Label();
            this.lblNazivProjekcije = new System.Windows.Forms.Label();
            this.cbNazivProjekcije = new System.Windows.Forms.ComboBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.Dalje = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.txtDvorana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbSlobodna = new System.Windows.Forms.ListBox();
            this.lbOdabrana = new System.Windows.Forms.ListBox();
            this.cbDatum = new System.Windows.Forms.ComboBox();
            this.lblSjedalo = new System.Windows.Forms.Label();
            this.lblDvorana = new System.Windows.Forms.Label();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.lblKn = new System.Windows.Forms.Label();
            this.lblMinuta = new System.Windows.Forms.Label();
            this.txtProdanoUlaznica = new System.Windows.Forms.TextBox();
            this.txtBrojMjesta = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtVrijemeTrajanja = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.lbZanr = new System.Windows.Forms.ListBox();
            this.lbVrstaProjekcije = new System.Windows.Forms.ListBox();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblVrstaProjekcije = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblProdanoUlaznica = new System.Windows.Forms.Label();
            this.lblBrojMjesta = new System.Windows.Forms.Label();
            this.lblVrijemeTrajanja = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.lblKn2 = new System.Windows.Forms.Label();
            this.lblPopust = new System.Windows.Forms.Label();
            this.cbPopust = new System.Windows.Forms.ComboBox();
            this.Opcije.SuspendLayout();
            this.gbDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(1074, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(63, 20);
            this.Odjava.TabIndex = 18;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            // 
            // Prijava
            // 
            this.Prijava.AutoSize = true;
            this.Prijava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Prijava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijava.Location = new System.Drawing.Point(9, 9);
            this.Prijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(165, 20);
            this.Prijava.TabIndex = 17;
            this.Prijava.Text = "Prijavljeni ste kao:";
            // 
            // lblDatumProjekcije
            // 
            this.lblDatumProjekcije.AutoSize = true;
            this.lblDatumProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDatumProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatumProjekcije.Location = new System.Drawing.Point(7, 64);
            this.lblDatumProjekcije.Name = "lblDatumProjekcije";
            this.lblDatumProjekcije.Size = new System.Drawing.Size(157, 20);
            this.lblDatumProjekcije.TabIndex = 19;
            this.lblDatumProjekcije.Text = "Datum projekcije:";
            // 
            // lblNazivProjekcije
            // 
            this.lblNazivProjekcije.AutoSize = true;
            this.lblNazivProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNazivProjekcije.Location = new System.Drawing.Point(7, 33);
            this.lblNazivProjekcije.Name = "lblNazivProjekcije";
            this.lblNazivProjekcije.Size = new System.Drawing.Size(151, 20);
            this.lblNazivProjekcije.TabIndex = 20;
            this.lblNazivProjekcije.Text = "Naziv Projekcije:";
            // 
            // cbNazivProjekcije
            // 
            this.cbNazivProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbNazivProjekcije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNazivProjekcije.FormattingEnabled = true;
            this.cbNazivProjekcije.Location = new System.Drawing.Point(165, 30);
            this.cbNazivProjekcije.Name = "cbNazivProjekcije";
            this.cbNazivProjekcije.Size = new System.Drawing.Size(333, 28);
            this.cbNazivProjekcije.TabIndex = 21;
            this.cbNazivProjekcije.SelectedIndexChanged += new System.EventHandler(this.cbNazivProjekcije_SelectedIndexChanged);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nazad.Location = new System.Drawing.Point(34, 547);
            this.Nazad.Margin = new System.Windows.Forms.Padding(4);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(112, 35);
            this.Nazad.TabIndex = 26;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Dalje
            // 
            this.Dalje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dalje.Location = new System.Drawing.Point(966, 547);
            this.Dalje.Margin = new System.Windows.Forms.Padding(4);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(112, 35);
            this.Dalje.TabIndex = 25;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = false;
            this.Dalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Opcije.Controls.Add(this.cbPopust);
            this.Opcije.Controls.Add(this.lblPopust);
            this.Opcije.Controls.Add(this.txtDvorana);
            this.Opcije.Controls.Add(this.label1);
            this.Opcije.Controls.Add(this.btnUkloni);
            this.Opcije.Controls.Add(this.btnDodaj);
            this.Opcije.Controls.Add(this.lbSlobodna);
            this.Opcije.Controls.Add(this.lbOdabrana);
            this.Opcije.Controls.Add(this.cbDatum);
            this.Opcije.Controls.Add(this.lblSjedalo);
            this.Opcije.Controls.Add(this.lblDvorana);
            this.Opcije.Controls.Add(this.lblDatumProjekcije);
            this.Opcije.Controls.Add(this.lblNazivProjekcije);
            this.Opcije.Controls.Add(this.cbNazivProjekcije);
            this.Opcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Location = new System.Drawing.Point(34, 46);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(540, 472);
            this.Opcije.TabIndex = 27;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // txtDvorana
            // 
            this.txtDvorana.Location = new System.Drawing.Point(165, 96);
            this.txtDvorana.Name = "txtDvorana";
            this.txtDvorana.ReadOnly = true;
            this.txtDvorana.Size = new System.Drawing.Size(333, 26);
            this.txtDvorana.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Odabrano:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(116, 304);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(43, 30);
            this.btnUkloni.TabIndex = 36;
            this.btnUkloni.Text = "<--";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(116, 258);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(43, 28);
            this.btnDodaj.TabIndex = 35;
            this.btnDodaj.Text = "-->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbSlobodna
            // 
            this.lbSlobodna.FormattingEnabled = true;
            this.lbSlobodna.ItemHeight = 20;
            this.lbSlobodna.Location = new System.Drawing.Point(24, 215);
            this.lbSlobodna.Name = "lbSlobodna";
            this.lbSlobodna.Size = new System.Drawing.Size(88, 244);
            this.lbSlobodna.TabIndex = 34;
            // 
            // lbOdabrana
            // 
            this.lbOdabrana.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.lbOdabrana.FormattingEnabled = true;
            this.lbOdabrana.ItemHeight = 20;
            this.lbOdabrana.Location = new System.Drawing.Point(165, 215);
            this.lbOdabrana.Name = "lbOdabrana";
            this.lbOdabrana.Size = new System.Drawing.Size(81, 244);
            this.lbOdabrana.TabIndex = 33;
            // 
            // cbDatum
            // 
            this.cbDatum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbDatum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDatum.FormattingEnabled = true;
            this.cbDatum.Location = new System.Drawing.Point(165, 64);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(333, 28);
            this.cbDatum.TabIndex = 32;
            this.cbDatum.SelectedIndexChanged += new System.EventHandler(this.cbDatum_SelectedIndexChanged);
            // 
            // lblSjedalo
            // 
            this.lblSjedalo.AutoSize = true;
            this.lblSjedalo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSjedalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSjedalo.Location = new System.Drawing.Point(20, 186);
            this.lblSjedalo.Name = "lblSjedalo";
            this.lblSjedalo.Size = new System.Drawing.Size(92, 20);
            this.lblSjedalo.TabIndex = 31;
            this.lblSjedalo.Text = "Slobodno:";
            // 
            // lblDvorana
            // 
            this.lblDvorana.AutoSize = true;
            this.lblDvorana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDvorana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDvorana.Location = new System.Drawing.Point(7, 99);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(85, 20);
            this.lblDvorana.TabIndex = 29;
            this.lblDvorana.Text = "Dvorana:";
            // 
            // gbDetalji
            // 
            this.gbDetalji.Controls.Add(this.lblKn);
            this.gbDetalji.Controls.Add(this.lblMinuta);
            this.gbDetalji.Controls.Add(this.txtProdanoUlaznica);
            this.gbDetalji.Controls.Add(this.txtBrojMjesta);
            this.gbDetalji.Controls.Add(this.txtCijena);
            this.gbDetalji.Controls.Add(this.txtVrijemeTrajanja);
            this.gbDetalji.Controls.Add(this.txtFilm);
            this.gbDetalji.Controls.Add(this.lbZanr);
            this.gbDetalji.Controls.Add(this.lbVrstaProjekcije);
            this.gbDetalji.Controls.Add(this.lblZanr);
            this.gbDetalji.Controls.Add(this.lblVrstaProjekcije);
            this.gbDetalji.Controls.Add(this.label7);
            this.gbDetalji.Controls.Add(this.lblCijena);
            this.gbDetalji.Controls.Add(this.lblProdanoUlaznica);
            this.gbDetalji.Controls.Add(this.lblBrojMjesta);
            this.gbDetalji.Controls.Add(this.lblVrijemeTrajanja);
            this.gbDetalji.Controls.Add(this.lblFilm);
            this.gbDetalji.Location = new System.Drawing.Point(605, 46);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(473, 471);
            this.gbDetalji.TabIndex = 28;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji:";
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.Location = new System.Drawing.Point(304, 106);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(31, 20);
            this.lblKn.TabIndex = 16;
            this.lblKn.Text = "Kn";
            // 
            // lblMinuta
            // 
            this.lblMinuta.AutoSize = true;
            this.lblMinuta.Location = new System.Drawing.Point(304, 70);
            this.lblMinuta.Name = "lblMinuta";
            this.lblMinuta.Size = new System.Drawing.Size(65, 20);
            this.lblMinuta.TabIndex = 15;
            this.lblMinuta.Text = "Minuta";
            // 
            // txtProdanoUlaznica
            // 
            this.txtProdanoUlaznica.Location = new System.Drawing.Point(184, 161);
            this.txtProdanoUlaznica.Name = "txtProdanoUlaznica";
            this.txtProdanoUlaznica.ReadOnly = true;
            this.txtProdanoUlaznica.Size = new System.Drawing.Size(114, 26);
            this.txtProdanoUlaznica.TabIndex = 14;
            // 
            // txtBrojMjesta
            // 
            this.txtBrojMjesta.Location = new System.Drawing.Point(184, 130);
            this.txtBrojMjesta.Name = "txtBrojMjesta";
            this.txtBrojMjesta.ReadOnly = true;
            this.txtBrojMjesta.Size = new System.Drawing.Size(114, 26);
            this.txtBrojMjesta.TabIndex = 13;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(184, 99);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(114, 26);
            this.txtCijena.TabIndex = 12;
            // 
            // txtVrijemeTrajanja
            // 
            this.txtVrijemeTrajanja.Location = new System.Drawing.Point(184, 67);
            this.txtVrijemeTrajanja.Name = "txtVrijemeTrajanja";
            this.txtVrijemeTrajanja.ReadOnly = true;
            this.txtVrijemeTrajanja.Size = new System.Drawing.Size(114, 26);
            this.txtVrijemeTrajanja.TabIndex = 11;
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(184, 30);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(273, 26);
            this.txtFilm.TabIndex = 10;
            // 
            // lbZanr
            // 
            this.lbZanr.FormattingEnabled = true;
            this.lbZanr.ItemHeight = 20;
            this.lbZanr.Location = new System.Drawing.Point(268, 238);
            this.lbZanr.Name = "lbZanr";
            this.lbZanr.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbZanr.Size = new System.Drawing.Size(189, 164);
            this.lbZanr.TabIndex = 9;
            // 
            // lbVrstaProjekcije
            // 
            this.lbVrstaProjekcije.FormattingEnabled = true;
            this.lbVrstaProjekcije.ItemHeight = 20;
            this.lbVrstaProjekcije.Location = new System.Drawing.Point(39, 238);
            this.lbVrstaProjekcije.Name = "lbVrstaProjekcije";
            this.lbVrstaProjekcije.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbVrstaProjekcije.Size = new System.Drawing.Size(195, 164);
            this.lbVrstaProjekcije.TabIndex = 8;
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(264, 215);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(52, 20);
            this.lblZanr.TabIndex = 7;
            this.lblZanr.Text = "Žanr:";
            // 
            // lblVrstaProjekcije
            // 
            this.lblVrstaProjekcije.AutoSize = true;
            this.lblVrstaProjekcije.Location = new System.Drawing.Point(36, 215);
            this.lblVrstaProjekcije.Name = "lblVrstaProjekcije";
            this.lblVrstaProjekcije.Size = new System.Drawing.Size(147, 20);
            this.lblVrstaProjekcije.TabIndex = 6;
            this.lblVrstaProjekcije.Text = "Vrsta projekcije:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 5;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(30, 102);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(68, 20);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena:";
            // 
            // lblProdanoUlaznica
            // 
            this.lblProdanoUlaznica.AutoSize = true;
            this.lblProdanoUlaznica.Location = new System.Drawing.Point(29, 164);
            this.lblProdanoUlaznica.Name = "lblProdanoUlaznica";
            this.lblProdanoUlaznica.Size = new System.Drawing.Size(154, 20);
            this.lblProdanoUlaznica.TabIndex = 3;
            this.lblProdanoUlaznica.Text = "Prodano ulaznica";
            // 
            // lblBrojMjesta
            // 
            this.lblBrojMjesta.AutoSize = true;
            this.lblBrojMjesta.Location = new System.Drawing.Point(30, 133);
            this.lblBrojMjesta.Name = "lblBrojMjesta";
            this.lblBrojMjesta.Size = new System.Drawing.Size(118, 20);
            this.lblBrojMjesta.TabIndex = 2;
            this.lblBrojMjesta.Text = "Broj mjesta: ";
            // 
            // lblVrijemeTrajanja
            // 
            this.lblVrijemeTrajanja.AutoSize = true;
            this.lblVrijemeTrajanja.Location = new System.Drawing.Point(30, 70);
            this.lblVrijemeTrajanja.Name = "lblVrijemeTrajanja";
            this.lblVrijemeTrajanja.Size = new System.Drawing.Size(148, 20);
            this.lblVrijemeTrajanja.TabIndex = 1;
            this.lblVrijemeTrajanja.Text = "Vrijeme trajanja:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(30, 33);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(51, 20);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(379, 529);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(77, 20);
            this.lblUkupno.TabIndex = 39;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(460, 525);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(88, 26);
            this.txtSuma.TabIndex = 40;
            // 
            // lblKn2
            // 
            this.lblKn2.AutoSize = true;
            this.lblKn2.Location = new System.Drawing.Point(553, 529);
            this.lblKn2.Name = "lblKn2";
            this.lblKn2.Size = new System.Drawing.Size(31, 20);
            this.lblKn2.TabIndex = 41;
            this.lblKn2.Text = "Kn";
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(7, 136);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(73, 20);
            this.lblPopust.TabIndex = 39;
            this.lblPopust.Text = "Popust:";
            // 
            // cbPopust
            // 
            this.cbPopust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPopust.FormattingEnabled = true;
            this.cbPopust.Location = new System.Drawing.Point(165, 128);
            this.cbPopust.Name = "cbPopust";
            this.cbPopust.Size = new System.Drawing.Size(332, 28);
            this.cbPopust.TabIndex = 40;
            this.cbPopust.SelectedIndexChanged += new System.EventHandler(this.cbPopust_SelectedIndexChanged);
            // 
            // FrmUlaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 613);
            this.Controls.Add(this.lblKn2);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.Prijava);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUlaznica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaznica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUlaznica_FormClosed);
            this.Load += new System.EventHandler(this.FrmUlaznica_Load);
            this.Opcije.ResumeLayout(false);
            this.Opcije.PerformLayout();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label Prijava;
        private System.Windows.Forms.Label lblDatumProjekcije;
        private System.Windows.Forms.Label lblNazivProjekcije;
        private System.Windows.Forms.ComboBox cbNazivProjekcije;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.Label lblDvorana;
        private System.Windows.Forms.Label lblSjedalo;
        private System.Windows.Forms.ComboBox cbDatum;
        private System.Windows.Forms.ListBox lbOdabrana;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbSlobodna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDvorana;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblVrstaProjekcije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblProdanoUlaznica;
        private System.Windows.Forms.Label lblBrojMjesta;
        private System.Windows.Forms.Label lblVrijemeTrajanja;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.ListBox lbZanr;
        private System.Windows.Forms.ListBox lbVrstaProjekcije;
        private System.Windows.Forms.Label lblKn;
        private System.Windows.Forms.Label lblMinuta;
        private System.Windows.Forms.TextBox txtProdanoUlaznica;
        private System.Windows.Forms.TextBox txtBrojMjesta;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtVrijemeTrajanja;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblKn2;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.ComboBox cbPopust;
    }
}