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
            this.naziv = new System.Windows.Forms.ComboBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.jedinicnaCijena = new System.Windows.Forms.TextBox();
            this.Stavke_racun = new System.Windows.Forms.GroupBox();
            this.Stavke = new System.Windows.Forms.DataGridView();
            this.NazivCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KolicinaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos_racuna = new System.Windows.Forms.Label();
            this.ukupanIznos = new System.Windows.Forms.TextBox();
            this.Dalje = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.kolicinaNum = new System.Windows.Forms.NumericUpDown();
            this.Nacin_placanja = new System.Windows.Forms.Label();
            this.nacinPlacanja = new System.Windows.Forms.ComboBox();
            this.Stavke_racun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).BeginInit();
            this.Opcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv_artikla
            // 
            this.Naziv_artikla.AutoSize = true;
            this.Naziv_artikla.Cursor = System.Windows.Forms.Cursors.Default;
            this.Naziv_artikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv_artikla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Cijena.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cijena.Location = new System.Drawing.Point(13, 66);
            this.Cijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(125, 16);
            this.Cijena.TabIndex = 2;
            this.Cijena.Text = "Jedinična cijena:";
            // 
            // naziv
            // 
            this.naziv.Cursor = System.Windows.Forms.Cursors.Default;
            this.naziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naziv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.naziv.FormattingEnabled = true;
            this.naziv.Location = new System.Drawing.Point(154, 23);
            this.naziv.Margin = new System.Windows.Forms.Padding(4);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(254, 24);
            this.naziv.TabIndex = 3;
            this.naziv.SelectedIndexChanged += new System.EventHandler(this.Naziv_SelectedIndexChanged);
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kolicina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kolicina.Location = new System.Drawing.Point(13, 104);
            this.Kolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(67, 16);
            this.Kolicina.TabIndex = 4;
            this.Kolicina.Text = "Količina:";
            // 
            // Dodaj
            // 
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dodaj.Location = new System.Drawing.Point(120, 160);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 35);
            this.Dodaj.TabIndex = 5;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ponisti
            // 
            this.Ponisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ponisti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ponisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ponisti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ponisti.Location = new System.Drawing.Point(240, 160);
            this.Ponisti.Margin = new System.Windows.Forms.Padding(4);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(112, 35);
            this.Ponisti.TabIndex = 6;
            this.Ponisti.Text = "Poništi";
            this.Ponisti.UseVisualStyleBackColor = false;
            this.Ponisti.Click += new System.EventHandler(this.Ponisti_Click);
            // 
            // jedinicnaCijena
            // 
            this.jedinicnaCijena.Cursor = System.Windows.Forms.Cursors.Default;
            this.jedinicnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jedinicnaCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jedinicnaCijena.Location = new System.Drawing.Point(154, 63);
            this.jedinicnaCijena.Margin = new System.Windows.Forms.Padding(4);
            this.jedinicnaCijena.Name = "jedinicnaCijena";
            this.jedinicnaCijena.ReadOnly = true;
            this.jedinicnaCijena.Size = new System.Drawing.Size(139, 22);
            this.jedinicnaCijena.TabIndex = 7;
            this.jedinicnaCijena.Text = " kn";
            // 
            // Stavke_racun
            // 
            this.Stavke_racun.Controls.Add(this.Stavke);
            this.Stavke_racun.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stavke_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stavke_racun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stavke_racun.Location = new System.Drawing.Point(13, 203);
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
            this.Stavke.Location = new System.Drawing.Point(5, 17);
            this.Stavke.Name = "Stavke";
            this.Stavke.ReadOnly = true;
            this.Stavke.Size = new System.Drawing.Size(436, 133);
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
            // Iznos_racuna
            // 
            this.Iznos_racuna.AutoSize = true;
            this.Iznos_racuna.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iznos_racuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Iznos_racuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Iznos_racuna.Location = new System.Drawing.Point(257, 369);
            this.Iznos_racuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Iznos_racuna.Name = "Iznos_racuna";
            this.Iznos_racuna.Size = new System.Drawing.Size(48, 16);
            this.Iznos_racuna.TabIndex = 10;
            this.Iznos_racuna.Text = "Iznos:";
            // 
            // ukupanIznos
            // 
            this.ukupanIznos.Cursor = System.Windows.Forms.Cursors.Default;
            this.ukupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ukupanIznos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ukupanIznos.Location = new System.Drawing.Point(313, 366);
            this.ukupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.ukupanIznos.Name = "ukupanIznos";
            this.ukupanIznos.ReadOnly = true;
            this.ukupanIznos.Size = new System.Drawing.Size(148, 22);
            this.ukupanIznos.TabIndex = 11;
            this.ukupanIznos.Text = "0,00 kn";
            // 
            // Dalje
            // 
            this.Dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dalje.Location = new System.Drawing.Point(349, 433);
            this.Dalje.Margin = new System.Windows.Forms.Padding(4);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(112, 35);
            this.Dalje.TabIndex = 12;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = false;
            this.Dalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // Opcije
            // 
            this.Opcije.Controls.Add(this.kolicinaNum);
            this.Opcije.Controls.Add(this.naziv);
            this.Opcije.Controls.Add(this.Naziv_artikla);
            this.Opcije.Controls.Add(this.Cijena);
            this.Opcije.Controls.Add(this.Kolicina);
            this.Opcije.Controls.Add(this.jedinicnaCijena);
            this.Opcije.Cursor = System.Windows.Forms.Cursors.Default;
            this.Opcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Location = new System.Drawing.Point(13, 13);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(448, 139);
            this.Opcije.TabIndex = 10;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // kolicinaNum
            // 
            this.kolicinaNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kolicinaNum.Location = new System.Drawing.Point(154, 101);
            this.kolicinaNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kolicinaNum.Name = "kolicinaNum";
            this.kolicinaNum.Size = new System.Drawing.Size(120, 22);
            this.kolicinaNum.TabIndex = 21;
            this.kolicinaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nacin_placanja
            // 
            this.Nacin_placanja.AutoSize = true;
            this.Nacin_placanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nacin_placanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nacin_placanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nacin_placanja.Location = new System.Drawing.Point(189, 404);
            this.Nacin_placanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nacin_placanja.Name = "Nacin_placanja";
            this.Nacin_placanja.Size = new System.Drawing.Size(116, 16);
            this.Nacin_placanja.TabIndex = 21;
            this.Nacin_placanja.Text = "Način plaćanja:";
            // 
            // nacinPlacanja
            // 
            this.nacinPlacanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.nacinPlacanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nacinPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nacinPlacanja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nacinPlacanja.FormattingEnabled = true;
            this.nacinPlacanja.Location = new System.Drawing.Point(313, 399);
            this.nacinPlacanja.Margin = new System.Windows.Forms.Padding(4);
            this.nacinPlacanja.Name = "nacinPlacanja";
            this.nacinPlacanja.Size = new System.Drawing.Size(148, 24);
            this.nacinPlacanja.TabIndex = 22;
            this.nacinPlacanja.SelectedIndexChanged += new System.EventHandler(this.nacinPlacanja_SelectedIndexChanged);
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 486);
            this.Controls.Add(this.nacinPlacanja);
            this.Controls.Add(this.Nacin_placanja);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.ukupanIznos);
            this.Controls.Add(this.Ponisti);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Iznos_racuna);
            this.Controls.Add(this.Stavke_racun);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmArtikli_Load);
            this.Stavke_racun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stavke)).EndInit();
            this.Opcije.ResumeLayout(false);
            this.Opcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv_artikla;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.ComboBox naziv;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Ponisti;
        private System.Windows.Forms.TextBox jedinicnaCijena;
        private System.Windows.Forms.GroupBox Stavke_racun;
        private System.Windows.Forms.Label Iznos_racuna;
        private System.Windows.Forms.TextBox ukupanIznos;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.DataGridView Stavke;
        private System.Windows.Forms.NumericUpDown kolicinaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KolicinaCol;
        private System.Windows.Forms.Label Nacin_placanja;
        private System.Windows.Forms.ComboBox nacinPlacanja;

    }
}