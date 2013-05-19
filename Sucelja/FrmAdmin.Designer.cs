namespace PI_projekt.Sucelja
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.Zaposlenici = new System.Windows.Forms.Button();
            this.Artikli = new System.Windows.Forms.Button();
            this.Filmovi = new System.Windows.Forms.Button();
            this.Projekcije = new System.Windows.Forms.Button();
            this.Dvorane = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.TextBox();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Prijava = new System.Windows.Forms.Label();
            this.Statistika = new System.Windows.Forms.Button();
            this.Opcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zaposlenici
            // 
            this.Zaposlenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zaposlenici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Zaposlenici.Image = global::PI_projekt.Properties.Resources.zaposlenik;
            this.Zaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Zaposlenici.Location = new System.Drawing.Point(10, 20);
            this.Zaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.Zaposlenici.Name = "Zaposlenici";
            this.Zaposlenici.Size = new System.Drawing.Size(140, 40);
            this.Zaposlenici.TabIndex = 3;
            this.Zaposlenici.Text = "Zaposlenici";
            this.Zaposlenici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zaposlenici.UseVisualStyleBackColor = true;
            // 
            // Artikli
            // 
            this.Artikli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Artikli.Image = global::PI_projekt.Properties.Resources.kokice;
            this.Artikli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Artikli.Location = new System.Drawing.Point(80, 70);
            this.Artikli.Margin = new System.Windows.Forms.Padding(4);
            this.Artikli.Name = "Artikli";
            this.Artikli.Size = new System.Drawing.Size(140, 40);
            this.Artikli.TabIndex = 4;
            this.Artikli.Text = "Artikli";
            this.Artikli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Artikli.UseVisualStyleBackColor = true;
            // 
            // Filmovi
            // 
            this.Filmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filmovi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Filmovi.Image = global::PI_projekt.Properties.Resources.Movies;
            this.Filmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filmovi.Location = new System.Drawing.Point(150, 120);
            this.Filmovi.Margin = new System.Windows.Forms.Padding(4);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(140, 40);
            this.Filmovi.TabIndex = 5;
            this.Filmovi.Text = "Filmovi";
            this.Filmovi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filmovi.UseVisualStyleBackColor = true;
            // 
            // Projekcije
            // 
            this.Projekcije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Projekcije.Image = global::PI_projekt.Properties.Resources.projekcije;
            this.Projekcije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Projekcije.Location = new System.Drawing.Point(80, 170);
            this.Projekcije.Margin = new System.Windows.Forms.Padding(4);
            this.Projekcije.Name = "Projekcije";
            this.Projekcije.Size = new System.Drawing.Size(140, 40);
            this.Projekcije.TabIndex = 6;
            this.Projekcije.Text = "Projekcije";
            this.Projekcije.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Projekcije.UseVisualStyleBackColor = true;
            // 
            // Dvorane
            // 
            this.Dvorane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvorane.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dvorane.Image = global::PI_projekt.Properties.Resources.dvorana;
            this.Dvorane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dvorane.Location = new System.Drawing.Point(10, 220);
            this.Dvorane.Margin = new System.Windows.Forms.Padding(4);
            this.Dvorane.Name = "Dvorane";
            this.Dvorane.Size = new System.Drawing.Size(140, 40);
            this.Dvorane.TabIndex = 7;
            this.Dvorane.Text = "Dvorane";
            this.Dvorane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dvorane.UseVisualStyleBackColor = true;
            this.Dvorane.Click += new System.EventHandler(this.Dvorane_Click);
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Controls.Add(this.Dvorane);
            this.Opcije.Controls.Add(this.Projekcije);
            this.Opcije.Controls.Add(this.Filmovi);
            this.Opcije.Controls.Add(this.Artikli);
            this.Opcije.Controls.Add(this.Zaposlenici);
            this.Opcije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Opcije.Location = new System.Drawing.Point(16, 36);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(301, 273);
            this.Opcije.TabIndex = 9;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            this.Opcije.Enter += new System.EventHandler(this.Opcije_Enter);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.user.Location = new System.Drawing.Point(170, 6);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(147, 22);
            this.user.TabIndex = 0;
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(420, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(56, 16);
            this.Odjava.TabIndex = 2;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // Prijava
            // 
            this.Prijava.AutoSize = true;
            this.Prijava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prijava.Location = new System.Drawing.Point(13, 9);
            this.Prijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(136, 16);
            this.Prijava.TabIndex = 1;
            this.Prijava.Text = "Prijavljeni ste kao:";
            this.Prijava.Click += new System.EventHandler(this.label1_Click);
            // 
            // Statistika
            // 
            this.Statistika.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Statistika.Location = new System.Drawing.Point(364, 281);
            this.Statistika.Margin = new System.Windows.Forms.Padding(4);
            this.Statistika.Name = "Statistika";
            this.Statistika.Size = new System.Drawing.Size(112, 28);
            this.Statistika.TabIndex = 8;
            this.Statistika.Text = "Statistika";
            this.Statistika.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 315);
            this.Controls.Add(this.Statistika);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.Prijava);
            this.Controls.Add(this.user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(505, 354);
            this.MinimumSize = new System.Drawing.Size(505, 354);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Opcije.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zaposlenici;
        private System.Windows.Forms.Button Artikli;
        private System.Windows.Forms.Button Filmovi;
        private System.Windows.Forms.Button Projekcije;
        private System.Windows.Forms.Button Dvorane;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label Prijava;
        private System.Windows.Forms.Button Statistika;

    }
}