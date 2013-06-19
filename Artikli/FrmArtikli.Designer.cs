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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtikli));
            this.Naziv_artikla = new System.Windows.Forms.Label();
            this.Cijena = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.ComboBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.Cijena_box = new System.Windows.Forms.TextBox();
            this.KolicinaBox = new System.Windows.Forms.TextBox();
            this.Stavke_racun = new System.Windows.Forms.GroupBox();
            this.Stavke = new System.Windows.Forms.DataGridView();
            this.Iznos_racun = new System.Windows.Forms.Label();
            this.Ukupno = new System.Windows.Forms.TextBox();
            this.Dalje = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.NazivCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KolicinaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stavke_racun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).BeginInit();
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
            this.Naziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.Dodaj.Location = new System.Drawing.Point(118, 211);
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
            this.Ponisti.Location = new System.Drawing.Point(238, 211);
            this.Ponisti.Margin = new System.Windows.Forms.Padding(4);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(112, 28);
            this.Ponisti.TabIndex = 6;
            this.Ponisti.Text = "Poništi";
            this.Ponisti.UseVisualStyleBackColor = false;
            this.Ponisti.Click += new System.EventHandler(this.Ponisti_Click);
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
            this.Cijena_box.ReadOnly = true;
            this.Cijena_box.Size = new System.Drawing.Size(139, 22);
            this.Cijena_box.TabIndex = 7;
            this.Cijena_box.Text = " kn";
            // 
            // KolicinaBox
            // 
            this.KolicinaBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KolicinaBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.KolicinaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KolicinaBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KolicinaBox.Location = new System.Drawing.Point(154, 101);
            this.KolicinaBox.Margin = new System.Windows.Forms.Padding(4);
            this.KolicinaBox.Name = "KolicinaBox";
            this.KolicinaBox.Size = new System.Drawing.Size(139, 22);
            this.KolicinaBox.TabIndex = 8;
            this.KolicinaBox.Text = "1";
            this.KolicinaBox.TextChanged += new System.EventHandler(this.KolicinaBox_TextChanged);
            // 
            // Stavke_racun
            // 
            this.Stavke_racun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stavke_racun.Controls.Add(this.Stavke);
            this.Stavke_racun.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stavke_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stavke_racun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stavke_racun.Location = new System.Drawing.Point(8, 247);
            this.Stavke_racun.Margin = new System.Windows.Forms.Padding(4);
            this.Stavke_racun.Name = "Stavke_racun";
            this.Stavke_racun.Padding = new System.Windows.Forms.Padding(4);
            this.Stavke_racun.Size = new System.Drawing.Size(448, 155);
            this.Stavke_racun.TabIndex = 9;
            this.Stavke_racun.TabStop = false;
            this.Stavke_racun.Text = "Stavke";
            // 
            // Stavke
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Stavke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Stavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivCol,
            this.CijenaCol,
            this.KolicinaCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stavke.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stavke.Location = new System.Drawing.Point(5, 17);
            this.Stavke.Name = "Stavke";
            this.Stavke.ReadOnly = true;
            this.Stavke.Size = new System.Drawing.Size(436, 133);
            this.Stavke.TabIndex = 21;
            // 
            // Iznos_racun
            // 
            this.Iznos_racun.AutoSize = true;
            this.Iznos_racun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Iznos_racun.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iznos_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Iznos_racun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Iznos_racun.Location = new System.Drawing.Point(252, 412);
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
            this.Ukupno.Location = new System.Drawing.Point(308, 409);
            this.Ukupno.Margin = new System.Windows.Forms.Padding(4);
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.ReadOnly = true;
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
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Controls.Add(this.Naziv);
            this.Opcije.Controls.Add(this.Naziv_artikla);
            this.Opcije.Controls.Add(this.Cijena);
            this.Opcije.Controls.Add(this.Kolicina);
            this.Opcije.Controls.Add(this.Cijena_box);
            this.Opcije.Controls.Add(this.KolicinaBox);
            this.Opcije.Cursor = System.Windows.Forms.Cursors.Default;
            this.Opcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opcije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Opcije.Location = new System.Drawing.Point(8, 64);
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
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(68, 35);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(47, 16);
            this.userRole.TabIndex = 20;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(10, 35);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(54, 16);
            this.uloga.TabIndex = 19;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(153, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(108, 16);
            this.userName.TabIndex = 18;
            this.userName.Text = "korisničko ime";
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.BackColor = System.Drawing.Color.Black;
            this.korisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisnik.Location = new System.Drawing.Point(10, 9);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(136, 16);
            this.korisnik.TabIndex = 17;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // NazivCol
            // 
            this.NazivCol.HeaderText = "Naziv";
            this.NazivCol.Name = "NazivCol";
            this.NazivCol.ReadOnly = true;
            this.NazivCol.Width = 240;
            // 
            // CijenaCol
            // 
            this.CijenaCol.HeaderText = "Cijena";
            this.CijenaCol.Name = "CijenaCol";
            this.CijenaCol.ReadOnly = true;
            this.CijenaCol.Width = 70;
            // 
            // KolicinaCol
            // 
            this.KolicinaCol.HeaderText = "Kolicina";
            this.KolicinaCol.Name = "KolicinaCol";
            this.KolicinaCol.ReadOnly = true;
            this.KolicinaCol.Width = 70;
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 482);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Odjava);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmArtikli_FormClosed);
            this.Load += new System.EventHandler(this.FrmArtikli_Load);
            this.Stavke_racun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).EndInit();
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
        private System.Windows.Forms.TextBox KolicinaBox;
        private System.Windows.Forms.GroupBox Stavke_racun;
        private System.Windows.Forms.Label Iznos_racun;
        private System.Windows.Forms.TextBox Ukupno;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.DataGridView Stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KolicinaCol;

    }
}