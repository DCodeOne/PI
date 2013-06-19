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
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNaslovDodajArtikl
            // 
            this.lblNaslovDodajArtikl.AutoSize = true;
            this.lblNaslovDodajArtikl.Location = new System.Drawing.Point(6, 57);
            this.lblNaslovDodajArtikl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslovDodajArtikl.Name = "lblNaslovDodajArtikl";
            this.lblNaslovDodajArtikl.Size = new System.Drawing.Size(61, 13);
            this.lblNaslovDodajArtikl.TabIndex = 0;
            this.lblNaslovDodajArtikl.Text = "Dodaj Artikl";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(9, 84);
            this.lblNazivArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(37, 13);
            this.lblNazivArtikla.TabIndex = 1;
            this.lblNazivArtikla.Text = "Naziv:";
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Location = new System.Drawing.Point(9, 121);
            this.lblCijenaArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(39, 13);
            this.lblCijenaArtikla.TabIndex = 2;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(11, 156);
            this.lblMjernaJedinica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(81, 13);
            this.lblMjernaJedinica.TabIndex = 3;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // txtNazivDodajArtikl
            // 
            this.txtNazivDodajArtikl.Location = new System.Drawing.Point(97, 83);
            this.txtNazivDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivDodajArtikl.Name = "txtNazivDodajArtikl";
            this.txtNazivDodajArtikl.Size = new System.Drawing.Size(225, 20);
            this.txtNazivDodajArtikl.TabIndex = 5;
            // 
            // txtCijenaDodajArtikl
            // 
            this.txtCijenaDodajArtikl.Location = new System.Drawing.Point(97, 121);
            this.txtCijenaDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.txtCijenaDodajArtikl.Name = "txtCijenaDodajArtikl";
            this.txtCijenaDodajArtikl.Size = new System.Drawing.Size(84, 20);
            this.txtCijenaDodajArtikl.TabIndex = 6;
            // 
            // cbMjerneJedinice
            // 
            this.cbMjerneJedinice.FormattingEnabled = true;
            this.cbMjerneJedinice.Location = new System.Drawing.Point(97, 161);
            this.cbMjerneJedinice.Margin = new System.Windows.Forms.Padding(2);
            this.cbMjerneJedinice.Name = "cbMjerneJedinice";
            this.cbMjerneJedinice.Size = new System.Drawing.Size(84, 21);
            this.cbMjerneJedinice.TabIndex = 7;
            this.cbMjerneJedinice.SelectedIndexChanged += new System.EventHandler(this.cbMjerneJedinice_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(170, 219);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(64, 20);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(259, 219);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(60, 20);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(53, 33);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 22;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(8, 33);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 21;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(107, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 20;
            this.userName.Text = "korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prijavljeni ste kao:";
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(280, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(39, 13);
            this.Odjava.TabIndex = 23;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // FrmAdminArtikliDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbMjerneJedinice);
            this.Controls.Add(this.txtCijenaDodajArtikl);
            this.Controls.Add(this.txtNazivDodajArtikl);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblCijenaArtikla);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.lblNaslovDodajArtikl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdminArtikliDodaj";
            this.Text = "Administrator Dodaj Artikl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminArtikliDodaj_FormClosed);
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
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Odjava;
    }
}