namespace PI_projekt.Sucelja
{
    partial class FrmAdminDvoraneDodaj
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblDodajDvoranuNaziv = new System.Windows.Forms.Label();
            this.lblDodajDvoranuBrSjedala = new System.Windows.Forms.Label();
            this.txtDodajDvoranuNaziv = new System.Windows.Forms.TextBox();
            this.txtDodajDvoranuBrSjedala = new System.Windows.Forms.TextBox();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(165, 146);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(257, 146);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblDodajDvoranuNaziv
            // 
            this.lblDodajDvoranuNaziv.AutoSize = true;
            this.lblDodajDvoranuNaziv.Location = new System.Drawing.Point(12, 65);
            this.lblDodajDvoranuNaziv.Name = "lblDodajDvoranuNaziv";
            this.lblDodajDvoranuNaziv.Size = new System.Drawing.Size(79, 13);
            this.lblDodajDvoranuNaziv.TabIndex = 2;
            this.lblDodajDvoranuNaziv.Text = "Naziv dvorane:";
            // 
            // lblDodajDvoranuBrSjedala
            // 
            this.lblDodajDvoranuBrSjedala.AutoSize = true;
            this.lblDodajDvoranuBrSjedala.Location = new System.Drawing.Point(12, 101);
            this.lblDodajDvoranuBrSjedala.Name = "lblDodajDvoranuBrSjedala";
            this.lblDodajDvoranuBrSjedala.Size = new System.Drawing.Size(64, 13);
            this.lblDodajDvoranuBrSjedala.TabIndex = 3;
            this.lblDodajDvoranuBrSjedala.Text = "Broj sjedala:";
            // 
            // txtDodajDvoranuNaziv
            // 
            this.txtDodajDvoranuNaziv.Location = new System.Drawing.Point(97, 62);
            this.txtDodajDvoranuNaziv.Name = "txtDodajDvoranuNaziv";
            this.txtDodajDvoranuNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtDodajDvoranuNaziv.TabIndex = 4;
            // 
            // txtDodajDvoranuBrSjedala
            // 
            this.txtDodajDvoranuBrSjedala.AcceptsReturn = true;
            this.txtDodajDvoranuBrSjedala.Location = new System.Drawing.Point(97, 98);
            this.txtDodajDvoranuBrSjedala.Name = "txtDodajDvoranuBrSjedala";
            this.txtDodajDvoranuBrSjedala.Size = new System.Drawing.Size(100, 20);
            this.txtDodajDvoranuBrSjedala.TabIndex = 5;
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(57, 33);
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
            this.uloga.Location = new System.Drawing.Point(12, 33);
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
            this.userName.Location = new System.Drawing.Point(111, 9);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.Odjava.Location = new System.Drawing.Point(292, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(39, 13);
            this.Odjava.TabIndex = 23;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // FrmAdminDvoraneDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDodajDvoranuBrSjedala);
            this.Controls.Add(this.txtDodajDvoranuNaziv);
            this.Controls.Add(this.lblDodajDvoranuBrSjedala);
            this.Controls.Add(this.lblDodajDvoranuNaziv);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Name = "FrmAdminDvoraneDodaj";
            this.Text = "Administrator Dodaj Dvoranu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminDvoraneDodaj_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminDvoraneDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblDodajDvoranuNaziv;
        private System.Windows.Forms.Label lblDodajDvoranuBrSjedala;
        private System.Windows.Forms.TextBox txtDodajDvoranuNaziv;
        private System.Windows.Forms.TextBox txtDodajDvoranuBrSjedala;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Odjava;
    }
}