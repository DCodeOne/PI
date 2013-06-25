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
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.gbStavkeRacun = new System.Windows.Forms.GroupBox();
            this.Stavke = new System.Windows.Forms.DataGridView();
            this.NazivCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KolicinaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIznosRacuna = new System.Windows.Forms.Label();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.btnDalje = new System.Windows.Forms.Button();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.gbStavkeRacun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).BeginInit();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivArtikla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNazivArtikla.Location = new System.Drawing.Point(13, 26);
            this.lblNazivArtikla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(98, 16);
            this.lblNazivArtikla.TabIndex = 0;
            this.lblNazivArtikla.Text = "Naziv artikla:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCijena.Location = new System.Drawing.Point(13, 66);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(125, 16);
            this.lblCijena.TabIndex = 2;
            this.lblCijena.Text = "Jedinična cijena:";
            // 
            // cbNaziv
            // 
            this.cbNaziv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbNaziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNaziv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(154, 23);
            this.cbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(254, 24);
            this.cbNaziv.TabIndex = 3;
            this.cbNaziv.SelectedIndexChanged += new System.EventHandler(this.Naziv_SelectedIndexChanged);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKolicina.Location = new System.Drawing.Point(13, 104);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(67, 16);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodaj.Location = new System.Drawing.Point(120, 160);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 35);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonisti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPonisti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPonisti.Location = new System.Drawing.Point(240, 160);
            this.btnPonisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(112, 35);
            this.btnPonisti.TabIndex = 6;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.Ponisti_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCijena.Location = new System.Drawing.Point(154, 63);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(139, 22);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.Text = " kn";
            // 
            // gbStavkeRacun
            // 
            this.gbStavkeRacun.Controls.Add(this.Stavke);
            this.gbStavkeRacun.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbStavkeRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbStavkeRacun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbStavkeRacun.Location = new System.Drawing.Point(13, 203);
            this.gbStavkeRacun.Margin = new System.Windows.Forms.Padding(4);
            this.gbStavkeRacun.Name = "gbStavkeRacun";
            this.gbStavkeRacun.Padding = new System.Windows.Forms.Padding(4);
            this.gbStavkeRacun.Size = new System.Drawing.Size(448, 155);
            this.gbStavkeRacun.TabIndex = 9;
            this.gbStavkeRacun.TabStop = false;
            this.gbStavkeRacun.Text = "Stavke";
            // 
            // Stavke
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Stavke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Stavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivCol,
            this.CijenaCol,
            this.KolicinaCol});
            this.Stavke.Location = new System.Drawing.Point(28, 22);
            this.Stavke.Name = "Stavke";
            this.Stavke.ReadOnly = true;
            this.Stavke.RowHeadersVisible = false;
            this.Stavke.Size = new System.Drawing.Size(389, 133);
            this.Stavke.TabIndex = 21;
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
            this.KolicinaCol.HeaderText = "Količina";
            this.KolicinaCol.Name = "KolicinaCol";
            this.KolicinaCol.ReadOnly = true;
            this.KolicinaCol.Width = 70;
            // 
            // lblIznosRacuna
            // 
            this.lblIznosRacuna.AutoSize = true;
            this.lblIznosRacuna.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIznosRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznosRacuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIznosRacuna.Location = new System.Drawing.Point(257, 369);
            this.lblIznosRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIznosRacuna.Name = "lblIznosRacuna";
            this.lblIznosRacuna.Size = new System.Drawing.Size(48, 16);
            this.lblIznosRacuna.TabIndex = 10;
            this.lblIznosRacuna.Text = "Iznos:";
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkupanIznos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUkupanIznos.Location = new System.Drawing.Point(313, 366);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.ReadOnly = true;
            this.txtUkupanIznos.Size = new System.Drawing.Size(148, 22);
            this.txtUkupanIznos.TabIndex = 11;
            this.txtUkupanIznos.Text = "0,00 kn";
            // 
            // btnDalje
            // 
            this.btnDalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDalje.Location = new System.Drawing.Point(349, 433);
            this.btnDalje.Margin = new System.Windows.Forms.Padding(4);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(112, 35);
            this.btnDalje.TabIndex = 12;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // gbOpcije
            // 
            this.gbOpcije.Controls.Add(this.numKolicina);
            this.gbOpcije.Controls.Add(this.cbNaziv);
            this.gbOpcije.Controls.Add(this.lblNazivArtikla);
            this.gbOpcije.Controls.Add(this.lblCijena);
            this.gbOpcije.Controls.Add(this.lblKolicina);
            this.gbOpcije.Controls.Add(this.txtCijena);
            this.gbOpcije.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbOpcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOpcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOpcije.Location = new System.Drawing.Point(13, 13);
            this.gbOpcije.Margin = new System.Windows.Forms.Padding(4);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Padding = new System.Windows.Forms.Padding(4);
            this.gbOpcije.Size = new System.Drawing.Size(448, 139);
            this.gbOpcije.TabIndex = 10;
            this.gbOpcije.TabStop = false;
            this.gbOpcije.Text = "Opcije";
            // 
            // numKolicina
            // 
            this.numKolicina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numKolicina.Location = new System.Drawing.Point(154, 101);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 22);
            this.numKolicina.TabIndex = 21;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNacinPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNacinPlacanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(189, 404);
            this.lblNacinPlacanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(116, 16);
            this.lblNacinPlacanja.TabIndex = 21;
            this.lblNacinPlacanja.Text = "Način plaćanja:";
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbNacinPlacanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNacinPlacanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(313, 399);
            this.cbNacinPlacanja.Margin = new System.Windows.Forms.Padding(4);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(148, 24);
            this.cbNacinPlacanja.TabIndex = 22;
            this.cbNacinPlacanja.SelectedIndexChanged += new System.EventHandler(this.nacinPlacanja_SelectedIndexChanged);
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 486);
            this.Controls.Add(this.cbNacinPlacanja);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblIznosRacuna);
            this.Controls.Add(this.gbStavkeRacun);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmArtikli_Load);
            this.gbStavkeRacun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            this.gbOpcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.GroupBox gbStavkeRacun;
        private System.Windows.Forms.Label lblIznosRacuna;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.GroupBox gbOpcije;
        private System.Windows.Forms.DataGridView Stavke;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KolicinaCol;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;

    }
}