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
            this.lblDatumProjekcije = new System.Windows.Forms.Label();
            this.lblNazivProjekcije = new System.Windows.Forms.Label();
            this.cbNazivProjekcije = new System.Windows.Forms.ComboBox();
            this.Dalje = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.cbPopust = new System.Windows.Forms.ComboBox();
            this.lblPopust = new System.Windows.Forms.Label();
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
            this.lblPopust2 = new System.Windows.Forms.Label();
            this.lblUkupno2 = new System.Windows.Forms.Label();
            this.lblKn3 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Opcije.SuspendLayout();
            this.gbDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatumProjekcije
            // 
            this.lblDatumProjekcije.AutoSize = true;
            this.lblDatumProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatumProjekcije.Location = new System.Drawing.Point(7, 64);
            this.lblDatumProjekcije.Name = "lblDatumProjekcije";
            this.lblDatumProjekcije.Size = new System.Drawing.Size(129, 16);
            this.lblDatumProjekcije.TabIndex = 19;
            this.lblDatumProjekcije.Text = "Datum projekcije:";
            // 
            // lblNazivProjekcije
            // 
            this.lblNazivProjekcije.AutoSize = true;
            this.lblNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNazivProjekcije.Location = new System.Drawing.Point(7, 33);
            this.lblNazivProjekcije.Name = "lblNazivProjekcije";
            this.lblNazivProjekcije.Size = new System.Drawing.Size(125, 16);
            this.lblNazivProjekcije.TabIndex = 20;
            this.lblNazivProjekcije.Text = "Naziv Projekcije:";
            // 
            // cbNazivProjekcije
            // 
            this.cbNazivProjekcije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNazivProjekcije.FormattingEnabled = true;
            this.cbNazivProjekcije.Location = new System.Drawing.Point(165, 30);
            this.cbNazivProjekcije.Name = "cbNazivProjekcije";
            this.cbNazivProjekcije.Size = new System.Drawing.Size(333, 24);
            this.cbNazivProjekcije.TabIndex = 21;
            this.cbNazivProjekcije.SelectedIndexChanged += new System.EventHandler(this.cbNazivProjekcije_SelectedIndexChanged);
            // 
            // Dalje
            // 
            this.Dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dalje.Location = new System.Drawing.Point(925, 510);
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
            this.Opcije.Location = new System.Drawing.Point(13, 13);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(540, 472);
            this.Opcije.TabIndex = 27;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // cbPopust
            // 
            this.cbPopust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPopust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbPopust.FormattingEnabled = true;
            this.cbPopust.Location = new System.Drawing.Point(165, 128);
            this.cbPopust.Name = "cbPopust";
            this.cbPopust.Size = new System.Drawing.Size(332, 24);
            this.cbPopust.TabIndex = 40;
            this.cbPopust.SelectedIndexChanged += new System.EventHandler(this.cbPopust_SelectedIndexChanged);
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPopust.Location = new System.Drawing.Point(7, 136);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(60, 16);
            this.lblPopust.TabIndex = 39;
            this.lblPopust.Text = "Popust:";
            // 
            // txtDvorana
            // 
            this.txtDvorana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDvorana.Location = new System.Drawing.Point(165, 96);
            this.txtDvorana.Name = "txtDvorana";
            this.txtDvorana.ReadOnly = true;
            this.txtDvorana.Size = new System.Drawing.Size(333, 22);
            this.txtDvorana.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(147, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Odabrano:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUkloni.Location = new System.Drawing.Point(102, 288);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(43, 30);
            this.btnUkloni.TabIndex = 36;
            this.btnUkloni.Text = "<--";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodaj.Location = new System.Drawing.Point(102, 242);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(43, 28);
            this.btnDodaj.TabIndex = 35;
            this.btnDodaj.Text = "-->";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbSlobodna
            // 
            this.lbSlobodna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSlobodna.FormattingEnabled = true;
            this.lbSlobodna.ItemHeight = 16;
            this.lbSlobodna.Location = new System.Drawing.Point(10, 199);
            this.lbSlobodna.Name = "lbSlobodna";
            this.lbSlobodna.Size = new System.Drawing.Size(88, 244);
            this.lbSlobodna.TabIndex = 34;
            // 
            // lbOdabrana
            // 
            this.lbOdabrana.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.lbOdabrana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbOdabrana.FormattingEnabled = true;
            this.lbOdabrana.ItemHeight = 16;
            this.lbOdabrana.Location = new System.Drawing.Point(151, 199);
            this.lbOdabrana.Name = "lbOdabrana";
            this.lbOdabrana.Size = new System.Drawing.Size(81, 244);
            this.lbOdabrana.TabIndex = 33;
            // 
            // cbDatum
            // 
            this.cbDatum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDatum.FormattingEnabled = true;
            this.cbDatum.Location = new System.Drawing.Point(165, 64);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(333, 24);
            this.cbDatum.TabIndex = 32;
            this.cbDatum.SelectedIndexChanged += new System.EventHandler(this.cbDatum_SelectedIndexChanged);
            // 
            // lblSjedalo
            // 
            this.lblSjedalo.AutoSize = true;
            this.lblSjedalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSjedalo.Location = new System.Drawing.Point(6, 170);
            this.lblSjedalo.Name = "lblSjedalo";
            this.lblSjedalo.Size = new System.Drawing.Size(79, 16);
            this.lblSjedalo.TabIndex = 31;
            this.lblSjedalo.Text = "Slobodno:";
            // 
            // lblDvorana
            // 
            this.lblDvorana.AutoSize = true;
            this.lblDvorana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDvorana.Location = new System.Drawing.Point(7, 99);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(71, 16);
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
            this.gbDetalji.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDetalji.Location = new System.Drawing.Point(564, 14);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(473, 471);
            this.gbDetalji.TabIndex = 28;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji:";
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKn.Location = new System.Drawing.Point(304, 102);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(25, 16);
            this.lblKn.TabIndex = 16;
            this.lblKn.Text = "Kn";
            // 
            // lblMinuta
            // 
            this.lblMinuta.AutoSize = true;
            this.lblMinuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinuta.Location = new System.Drawing.Point(304, 70);
            this.lblMinuta.Name = "lblMinuta";
            this.lblMinuta.Size = new System.Drawing.Size(53, 16);
            this.lblMinuta.TabIndex = 15;
            this.lblMinuta.Text = "Minuta";
            // 
            // txtProdanoUlaznica
            // 
            this.txtProdanoUlaznica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProdanoUlaznica.Location = new System.Drawing.Point(184, 161);
            this.txtProdanoUlaznica.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtProdanoUlaznica.Name = "txtProdanoUlaznica";
            this.txtProdanoUlaznica.ReadOnly = true;
            this.txtProdanoUlaznica.Size = new System.Drawing.Size(114, 22);
            this.txtProdanoUlaznica.TabIndex = 14;
            this.txtProdanoUlaznica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBrojMjesta
            // 
            this.txtBrojMjesta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBrojMjesta.Location = new System.Drawing.Point(184, 130);
            this.txtBrojMjesta.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtBrojMjesta.Name = "txtBrojMjesta";
            this.txtBrojMjesta.ReadOnly = true;
            this.txtBrojMjesta.Size = new System.Drawing.Size(114, 22);
            this.txtBrojMjesta.TabIndex = 13;
            this.txtBrojMjesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCijena
            // 
            this.txtCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCijena.Location = new System.Drawing.Point(184, 99);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(114, 22);
            this.txtCijena.TabIndex = 12;
            this.txtCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVrijemeTrajanja
            // 
            this.txtVrijemeTrajanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVrijemeTrajanja.Location = new System.Drawing.Point(184, 67);
            this.txtVrijemeTrajanja.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtVrijemeTrajanja.Name = "txtVrijemeTrajanja";
            this.txtVrijemeTrajanja.ReadOnly = true;
            this.txtVrijemeTrajanja.Size = new System.Drawing.Size(114, 22);
            this.txtVrijemeTrajanja.TabIndex = 11;
            this.txtVrijemeTrajanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFilm
            // 
            this.txtFilm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFilm.Location = new System.Drawing.Point(184, 30);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(273, 22);
            this.txtFilm.TabIndex = 10;
            // 
            // lbZanr
            // 
            this.lbZanr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbZanr.FormattingEnabled = true;
            this.lbZanr.ItemHeight = 16;
            this.lbZanr.Location = new System.Drawing.Point(268, 238);
            this.lbZanr.Name = "lbZanr";
            this.lbZanr.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbZanr.Size = new System.Drawing.Size(190, 148);
            this.lbZanr.TabIndex = 9;
            // 
            // lbVrstaProjekcije
            // 
            this.lbVrstaProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVrstaProjekcije.FormattingEnabled = true;
            this.lbVrstaProjekcije.ItemHeight = 16;
            this.lbVrstaProjekcije.Location = new System.Drawing.Point(33, 238);
            this.lbVrstaProjekcije.Name = "lbVrstaProjekcije";
            this.lbVrstaProjekcije.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbVrstaProjekcije.Size = new System.Drawing.Size(190, 148);
            this.lbVrstaProjekcije.TabIndex = 8;
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblZanr.Location = new System.Drawing.Point(264, 215);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(43, 16);
            this.lblZanr.TabIndex = 7;
            this.lblZanr.Text = "Žanr:";
            // 
            // lblVrstaProjekcije
            // 
            this.lblVrstaProjekcije.AutoSize = true;
            this.lblVrstaProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVrstaProjekcije.Location = new System.Drawing.Point(30, 215);
            this.lblVrstaProjekcije.Name = "lblVrstaProjekcije";
            this.lblVrstaProjekcije.Size = new System.Drawing.Size(121, 16);
            this.lblVrstaProjekcije.TabIndex = 6;
            this.lblVrstaProjekcije.Text = "Vrsta projekcije:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 5;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCijena.Location = new System.Drawing.Point(30, 102);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(56, 16);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena:";
            // 
            // lblProdanoUlaznica
            // 
            this.lblProdanoUlaznica.AutoSize = true;
            this.lblProdanoUlaznica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProdanoUlaznica.Location = new System.Drawing.Point(29, 164);
            this.lblProdanoUlaznica.Name = "lblProdanoUlaznica";
            this.lblProdanoUlaznica.Size = new System.Drawing.Size(128, 16);
            this.lblProdanoUlaznica.TabIndex = 3;
            this.lblProdanoUlaznica.Text = "Prodano ulaznica";
            // 
            // lblBrojMjesta
            // 
            this.lblBrojMjesta.AutoSize = true;
            this.lblBrojMjesta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrojMjesta.Location = new System.Drawing.Point(30, 133);
            this.lblBrojMjesta.Name = "lblBrojMjesta";
            this.lblBrojMjesta.Size = new System.Drawing.Size(94, 16);
            this.lblBrojMjesta.TabIndex = 2;
            this.lblBrojMjesta.Text = "Broj mjesta: ";
            // 
            // lblVrijemeTrajanja
            // 
            this.lblVrijemeTrajanja.AutoSize = true;
            this.lblVrijemeTrajanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVrijemeTrajanja.Location = new System.Drawing.Point(30, 70);
            this.lblVrijemeTrajanja.Name = "lblVrijemeTrajanja";
            this.lblVrijemeTrajanja.Size = new System.Drawing.Size(121, 16);
            this.lblVrijemeTrajanja.TabIndex = 1;
            this.lblVrijemeTrajanja.Text = "Vrijeme trajanja:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFilm.Location = new System.Drawing.Point(30, 33);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(41, 16);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUkupno.Location = new System.Drawing.Point(561, 488);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(98, 16);
            this.lblUkupno.TabIndex = 39;
            this.lblUkupno.Text = "Bez popusta:";
            // 
            // txtSuma
            // 
            this.txtSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSuma.Location = new System.Drawing.Point(662, 488);
            this.txtSuma.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(90, 22);
            this.txtSuma.TabIndex = 40;
            this.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblKn2
            // 
            this.lblKn2.AutoSize = true;
            this.lblKn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKn2.Location = new System.Drawing.Point(760, 519);
            this.lblKn2.Name = "lblKn2";
            this.lblKn2.Size = new System.Drawing.Size(25, 16);
            this.lblKn2.TabIndex = 41;
            this.lblKn2.Text = "Kn";
            // 
            // lblPopust2
            // 
            this.lblPopust2.AutoSize = true;
            this.lblPopust2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPopust2.Location = new System.Drawing.Point(561, 519);
            this.lblPopust2.Name = "lblPopust2";
            this.lblPopust2.Size = new System.Drawing.Size(60, 16);
            this.lblPopust2.TabIndex = 42;
            this.lblPopust2.Text = "Popust:";
            // 
            // lblUkupno2
            // 
            this.lblUkupno2.AutoSize = true;
            this.lblUkupno2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUkupno2.Location = new System.Drawing.Point(561, 550);
            this.lblUkupno2.Name = "lblUkupno2";
            this.lblUkupno2.Size = new System.Drawing.Size(65, 16);
            this.lblUkupno2.TabIndex = 43;
            this.lblUkupno2.Text = "Ukupno:";
            // 
            // lblKn3
            // 
            this.lblKn3.AutoSize = true;
            this.lblKn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKn3.Location = new System.Drawing.Point(760, 550);
            this.lblKn3.Name = "lblKn3";
            this.lblKn3.Size = new System.Drawing.Size(25, 16);
            this.lblKn3.TabIndex = 44;
            this.lblKn3.Text = "Kn";
            // 
            // txtPopust
            // 
            this.txtPopust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPopust.Location = new System.Drawing.Point(662, 516);
            this.txtPopust.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(90, 22);
            this.txtPopust.TabIndex = 45;
            this.txtPopust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUkupno
            // 
            this.txtUkupno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUkupno.Location = new System.Drawing.Point(662, 547);
            this.txtUkupno.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(90, 22);
            this.txtUkupno.TabIndex = 46;
            this.txtUkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1054, 584);
            this.shapeContainer1.TabIndex = 47;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 562;
            this.lineShape1.X2 = 842;
            this.lineShape1.Y1 = 542;
            this.lineShape1.Y2 = 542;
            // 
            // FrmUlaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 584);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.lblKn3);
            this.Controls.Add(this.lblUkupno2);
            this.Controls.Add(this.lblPopust2);
            this.Controls.Add(this.lblKn2);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUlaznica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaznica";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmUlaznica_Load);
            this.Opcije.ResumeLayout(false);
            this.Opcije.PerformLayout();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumProjekcije;
        private System.Windows.Forms.Label lblNazivProjekcije;
        private System.Windows.Forms.ComboBox cbNazivProjekcije;
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
        private System.Windows.Forms.Label lblPopust2;
        private System.Windows.Forms.Label lblUkupno2;
        private System.Windows.Forms.Label lblKn3;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtUkupno;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}