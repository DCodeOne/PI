namespace PI_projekt.Sucelja
{
    partial class FrmProdavac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdavac));
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.miOpcije = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciUlaznica = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciArtikli = new System.Windows.Forms.ToolStripMenuItem();
            this.statusnaTraka = new System.Windows.Forms.StatusStrip();
            this.sstext = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.msIzbornik.SuspendLayout();
            this.statusnaTraka.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIzbornik
            // 
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcije,
            this.miSifarnici});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Padding = new System.Windows.Forms.Padding(18, 5, 0, 5);
            this.msIzbornik.Size = new System.Drawing.Size(699, 35);
            this.msIzbornik.TabIndex = 7;
            this.msIzbornik.Text = "Izbornik";
            // 
            // miOpcije
            // 
            this.miOpcije.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcijeOdjava,
            this.miOpcijeIzlaz});
            this.miOpcije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miOpcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.miOpcije.Image = global::PI_projekt.Properties.Resources.imgOpcije;
            this.miOpcije.Name = "miOpcije";
            this.miOpcije.Padding = new System.Windows.Forms.Padding(12, 0, 4, 0);
            this.miOpcije.Size = new System.Drawing.Size(95, 25);
            this.miOpcije.Text = "Opcije";
            // 
            // miOpcijeOdjava
            // 
            this.miOpcijeOdjava.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miOpcijeOdjava.Image = global::PI_projekt.Properties.Resources.imgOdjava;
            this.miOpcijeOdjava.Name = "miOpcijeOdjava";
            this.miOpcijeOdjava.Size = new System.Drawing.Size(130, 26);
            this.miOpcijeOdjava.Text = "Odjava";
            this.miOpcijeOdjava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeOdjava_MouseUp);
            // 
            // miOpcijeIzlaz
            // 
            this.miOpcijeIzlaz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miOpcijeIzlaz.Image = global::PI_projekt.Properties.Resources.imgIzlaz;
            this.miOpcijeIzlaz.Name = "miOpcijeIzlaz";
            this.miOpcijeIzlaz.Size = new System.Drawing.Size(130, 26);
            this.miOpcijeIzlaz.Text = "Izlaz";
            this.miOpcijeIzlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeIzlaz_MouseUp);
            // 
            // miSifarnici
            // 
            this.miSifarnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSifarniciUlaznica,
            this.miSifarniciArtikli});
            this.miSifarnici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miSifarnici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.miSifarnici.Image = global::PI_projekt.Properties.Resources.imgSifarnici;
            this.miSifarnici.Name = "miSifarnici";
            this.miSifarnici.Padding = new System.Windows.Forms.Padding(12, 0, 4, 0);
            this.miSifarnici.Size = new System.Drawing.Size(109, 25);
            this.miSifarnici.Text = "Šifarnici";
            // 
            // miSifarniciUlaznica
            // 
            this.miSifarniciUlaznica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miSifarniciUlaznica.Image = global::PI_projekt.Properties.Resources.imgUlaznice;
            this.miSifarniciUlaznica.Name = "miSifarniciUlaznica";
            this.miSifarniciUlaznica.Size = new System.Drawing.Size(139, 26);
            this.miSifarniciUlaznica.Text = "Ulaznica";
            this.miSifarniciUlaznica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciUlaznica_MouseUp);
            // 
            // miSifarniciArtikli
            // 
            this.miSifarniciArtikli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miSifarniciArtikli.Image = global::PI_projekt.Properties.Resources.imgArtikli;
            this.miSifarniciArtikli.Name = "miSifarniciArtikli";
            this.miSifarniciArtikli.Size = new System.Drawing.Size(139, 26);
            this.miSifarniciArtikli.Text = "Artikli";
            this.miSifarniciArtikli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciArtikli_MouseUp);
            // 
            // statusnaTraka
            // 
            this.statusnaTraka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sstext,
            this.ssUsername});
            this.statusnaTraka.Location = new System.Drawing.Point(0, 391);
            this.statusnaTraka.Name = "statusnaTraka";
            this.statusnaTraka.Size = new System.Drawing.Size(699, 36);
            this.statusnaTraka.TabIndex = 9;
            this.statusnaTraka.Text = "status";
            // 
            // sstext
            // 
            this.sstext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sstext.ForeColor = System.Drawing.Color.Black;
            this.sstext.Name = "sstext";
            this.sstext.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sstext.Size = new System.Drawing.Size(150, 31);
            this.sstext.Text = "Prijavljeni ste kao:";
            // 
            // ssUsername
            // 
            this.ssUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssUsername.ForeColor = System.Drawing.Color.Red;
            this.ssUsername.Name = "ssUsername";
            this.ssUsername.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ssUsername.Size = new System.Drawing.Size(85, 31);
            this.ssUsername.Text = "username";
            // 
            // FrmProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.imgPozadina;
            this.ClientSize = new System.Drawing.Size(699, 427);
            this.Controls.Add(this.statusnaTraka);
            this.Controls.Add(this.msIzbornik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzbornik;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdavac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavač";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProdavac_FormClosed);
            this.Load += new System.EventHandler(this.FrmProdavac_Load);
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.statusnaTraka.ResumeLayout(false);
            this.statusnaTraka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem miOpcije;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeOdjava;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeIzlaz;
        private System.Windows.Forms.ToolStripMenuItem miSifarnici;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciUlaznica;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciArtikli;
        private System.Windows.Forms.StatusStrip statusnaTraka;
        private System.Windows.Forms.ToolStripStatusLabel sstext;
        private System.Windows.Forms.ToolStripStatusLabel ssUsername;
    }
}