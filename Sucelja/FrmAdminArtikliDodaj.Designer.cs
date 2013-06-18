namespace PI_projekt.Sucelja
{
    partial class FrmAdminArtikliDodaj
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
            this.lblNaslovDodajArtikl = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblCijenaArtikla = new System.Windows.Forms.Label();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.txtNazivDodajArtikl = new System.Windows.Forms.TextBox();
            this.txtCijenaDodajArtikl = new System.Windows.Forms.TextBox();
            this.cbMjerneJedinice = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslovDodajArtikl
            // 
            this.lblNaslovDodajArtikl.AutoSize = true;
            this.lblNaslovDodajArtikl.Location = new System.Drawing.Point(118, 9);
            this.lblNaslovDodajArtikl.Name = "lblNaslovDodajArtikl";
            this.lblNaslovDodajArtikl.Size = new System.Drawing.Size(80, 17);
            this.lblNaslovDodajArtikl.TabIndex = 0;
            this.lblNaslovDodajArtikl.Text = "Dodaj Artikl";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(27, 43);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(47, 17);
            this.lblNazivArtikla.TabIndex = 1;
            this.lblNazivArtikla.Text = "Naziv:";
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Location = new System.Drawing.Point(27, 88);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(51, 17);
            this.lblCijenaArtikla.TabIndex = 2;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(29, 132);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(107, 17);
            this.lblMjernaJedinica.TabIndex = 3;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // txtNazivDodajArtikl
            // 
            this.txtNazivDodajArtikl.Location = new System.Drawing.Point(144, 42);
            this.txtNazivDodajArtikl.Name = "txtNazivDodajArtikl";
            this.txtNazivDodajArtikl.Size = new System.Drawing.Size(299, 22);
            this.txtNazivDodajArtikl.TabIndex = 5;
            // 
            // txtCijenaDodajArtikl
            // 
            this.txtCijenaDodajArtikl.Location = new System.Drawing.Point(144, 88);
            this.txtCijenaDodajArtikl.Name = "txtCijenaDodajArtikl";
            this.txtCijenaDodajArtikl.Size = new System.Drawing.Size(110, 22);
            this.txtCijenaDodajArtikl.TabIndex = 6;
            // 
            // cbMjerneJedinice
            // 
            this.cbMjerneJedinice.FormattingEnabled = true;
            this.cbMjerneJedinice.Location = new System.Drawing.Point(144, 138);
            this.cbMjerneJedinice.Name = "cbMjerneJedinice";
            this.cbMjerneJedinice.Size = new System.Drawing.Size(110, 24);
            this.cbMjerneJedinice.TabIndex = 7;
            this.cbMjerneJedinice.SelectedIndexChanged += new System.EventHandler(this.cbMjerneJedinice_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(348, 179);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 24);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(253, 178);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 25);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmAdminArtikliDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbMjerneJedinice);
            this.Controls.Add(this.txtCijenaDodajArtikl);
            this.Controls.Add(this.txtNazivDodajArtikl);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblCijenaArtikla);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.lblNaslovDodajArtikl);
            this.Name = "FrmAdminArtikliDodaj";
            this.Text = "FrmAdminArtikliDodaj";
            this.Load += new System.EventHandler(this.FrmAdminArtikliDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovDodajArtikl;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label lblCijenaArtikla;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.TextBox txtNazivDodajArtikl;
        private System.Windows.Forms.TextBox txtCijenaDodajArtikl;
        private System.Windows.Forms.ComboBox cbMjerneJedinice;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}