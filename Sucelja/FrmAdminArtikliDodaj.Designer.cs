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
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblCijenaArtikla = new System.Windows.Forms.Label();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.txtNazivDodajArtikl = new System.Windows.Forms.TextBox();
            this.txtCijenaDodajArtikl = new System.Windows.Forms.TextBox();
            this.cbMjerneJedinice = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.panArtikl = new System.Windows.Forms.Panel();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivArtikla.Location = new System.Drawing.Point(15, 43);
            this.lblNazivArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(51, 16);
            this.lblNazivArtikla.TabIndex = 1;
            this.lblNazivArtikla.Text = "Naziv:";
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijenaArtikla.Location = new System.Drawing.Point(15, 73);
            this.lblCijenaArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(56, 16);
            this.lblCijenaArtikla.TabIndex = 2;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjernaJedinica.Location = new System.Drawing.Point(15, 103);
            this.lblMjernaJedinica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(118, 16);
            this.lblMjernaJedinica.TabIndex = 3;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // txtNazivDodajArtikl
            // 
            this.txtNazivDodajArtikl.Location = new System.Drawing.Point(140, 43);
            this.txtNazivDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivDodajArtikl.Name = "txtNazivDodajArtikl";
            this.txtNazivDodajArtikl.Size = new System.Drawing.Size(154, 20);
            this.txtNazivDodajArtikl.TabIndex = 5;
            // 
            // txtCijenaDodajArtikl
            // 
            this.txtCijenaDodajArtikl.Location = new System.Drawing.Point(140, 73);
            this.txtCijenaDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.txtCijenaDodajArtikl.Name = "txtCijenaDodajArtikl";
            this.txtCijenaDodajArtikl.Size = new System.Drawing.Size(84, 20);
            this.txtCijenaDodajArtikl.TabIndex = 6;
            // 
            // cbMjerneJedinice
            // 
            this.cbMjerneJedinice.FormattingEnabled = true;
            this.cbMjerneJedinice.Location = new System.Drawing.Point(140, 103);
            this.cbMjerneJedinice.Margin = new System.Windows.Forms.Padding(2);
            this.cbMjerneJedinice.Name = "cbMjerneJedinice";
            this.cbMjerneJedinice.Size = new System.Drawing.Size(84, 21);
            this.cbMjerneJedinice.TabIndex = 7;
            this.cbMjerneJedinice.SelectedIndexChanged += new System.EventHandler(this.cbMjerneJedinice_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(176, 158);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(80, 35);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(260, 158);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 35);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // panArtikl
            // 
            this.panArtikl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panArtikl.Location = new System.Drawing.Point(10, 19);
            this.panArtikl.Name = "panArtikl";
            this.panArtikl.Size = new System.Drawing.Size(330, 125);
            this.panArtikl.TabIndex = 11;
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArtikl.Location = new System.Drawing.Point(15, 9);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(46, 18);
            this.lblArtikl.TabIndex = 12;
            this.lblArtikl.Text = "Artikl";
            // 
            // FrmAdminArtikliDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 201);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbMjerneJedinice);
            this.Controls.Add(this.txtCijenaDodajArtikl);
            this.Controls.Add(this.txtNazivDodajArtikl);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblCijenaArtikla);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.panArtikl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminArtikliDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli - dodaj/ažuriraj";
            this.Load += new System.EventHandler(this.FrmAdminArtikliDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label lblCijenaArtikla;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.TextBox txtNazivDodajArtikl;
        private System.Windows.Forms.TextBox txtCijenaDodajArtikl;
        private System.Windows.Forms.ComboBox cbMjerneJedinice;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Panel panArtikl;
        private System.Windows.Forms.Label lblArtikl;
    }
}