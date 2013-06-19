namespace PI_projekt.Sucelja
{
    partial class FrmAdminZaposlenici
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
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.lblOdjava = new System.Windows.Forms.LinkLabel();
            this.dgvSviZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnZaposleniciPovratak = new System.Windows.Forms.Button();
            this.btnZaposleniciOsvjezi = new System.Windows.Forms.Button();
            this.btnZaposleniciDodaj = new System.Windows.Forms.Button();
            this.btnZaposleniciAzuriraj = new System.Windows.Forms.Button();
            this.lblSviZaposlenici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(50, 35);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 17;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(5, 35);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 16;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(104, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 15;
            this.userName.Text = "korisničko ime";
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.BackColor = System.Drawing.Color.Black;
            this.korisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisnik.Location = new System.Drawing.Point(5, 9);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(92, 13);
            this.korisnik.TabIndex = 14;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdjava.LinkColor = System.Drawing.Color.Yellow;
            this.lblOdjava.Location = new System.Drawing.Point(742, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 23;
            this.lblOdjava.TabStop = true;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // dgvSviZaposlenici
            // 
            this.dgvSviZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviZaposlenici.Location = new System.Drawing.Point(14, 95);
            this.dgvSviZaposlenici.Name = "dgvSviZaposlenici";
            this.dgvSviZaposlenici.Size = new System.Drawing.Size(754, 203);
            this.dgvSviZaposlenici.TabIndex = 24;
            // 
            // btnZaposleniciPovratak
            // 
            this.btnZaposleniciPovratak.Location = new System.Drawing.Point(14, 320);
            this.btnZaposleniciPovratak.Name = "btnZaposleniciPovratak";
            this.btnZaposleniciPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciPovratak.TabIndex = 25;
            this.btnZaposleniciPovratak.Text = "Povratak";
            this.btnZaposleniciPovratak.UseVisualStyleBackColor = true;
            this.btnZaposleniciPovratak.Click += new System.EventHandler(this.btnZaposleniciPovratak_Click);
            // 
            // btnZaposleniciOsvjezi
            // 
            this.btnZaposleniciOsvjezi.Location = new System.Drawing.Point(531, 320);
            this.btnZaposleniciOsvjezi.Name = "btnZaposleniciOsvjezi";
            this.btnZaposleniciOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciOsvjezi.TabIndex = 27;
            this.btnZaposleniciOsvjezi.Text = "Osvježi";
            this.btnZaposleniciOsvjezi.UseVisualStyleBackColor = true;
            // 
            // btnZaposleniciDodaj
            // 
            this.btnZaposleniciDodaj.Location = new System.Drawing.Point(612, 320);
            this.btnZaposleniciDodaj.Name = "btnZaposleniciDodaj";
            this.btnZaposleniciDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciDodaj.TabIndex = 28;
            this.btnZaposleniciDodaj.Text = "Dodaj";
            this.btnZaposleniciDodaj.UseVisualStyleBackColor = true;
            this.btnZaposleniciDodaj.Click += new System.EventHandler(this.btnZaposleniciDodaj_Click);
            // 
            // btnZaposleniciAzuriraj
            // 
            this.btnZaposleniciAzuriraj.Location = new System.Drawing.Point(693, 320);
            this.btnZaposleniciAzuriraj.Name = "btnZaposleniciAzuriraj";
            this.btnZaposleniciAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciAzuriraj.TabIndex = 29;
            this.btnZaposleniciAzuriraj.Text = "Ažuriraj";
            this.btnZaposleniciAzuriraj.UseVisualStyleBackColor = true;
            // 
            // lblSviZaposlenici
            // 
            this.lblSviZaposlenici.AutoSize = true;
            this.lblSviZaposlenici.Location = new System.Drawing.Point(12, 66);
            this.lblSviZaposlenici.Name = "lblSviZaposlenici";
            this.lblSviZaposlenici.Size = new System.Drawing.Size(80, 13);
            this.lblSviZaposlenici.TabIndex = 30;
            this.lblSviZaposlenici.Text = "Svi zaposlenici:";
            // 
            // FrmAdminZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 355);
            this.Controls.Add(this.lblSviZaposlenici);
            this.Controls.Add(this.btnZaposleniciAzuriraj);
            this.Controls.Add(this.btnZaposleniciDodaj);
            this.Controls.Add(this.btnZaposleniciOsvjezi);
            this.Controls.Add(this.btnZaposleniciPovratak);
            this.Controls.Add(this.dgvSviZaposlenici);
            this.Controls.Add(this.lblOdjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.korisnik);
            this.Name = "FrmAdminZaposlenici";
            this.Text = "FrmAdminZaposlenici";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminZaposlenici_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.LinkLabel lblOdjava;
        private System.Windows.Forms.DataGridView dgvSviZaposlenici;
        private System.Windows.Forms.Button btnZaposleniciPovratak;
        private System.Windows.Forms.Button btnZaposleniciOsvjezi;
        private System.Windows.Forms.Button btnZaposleniciDodaj;
        private System.Windows.Forms.Button btnZaposleniciAzuriraj;
        private System.Windows.Forms.Label lblSviZaposlenici;

    }
}