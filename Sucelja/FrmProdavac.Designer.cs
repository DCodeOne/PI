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
            this.korisnik = new System.Windows.Forms.Label();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.Artikli = new System.Windows.Forms.Button();
            this.Ulaznica = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.Opcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.BackColor = System.Drawing.Color.Black;
            this.korisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisnik.Location = new System.Drawing.Point(13, 18);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(136, 16);
            this.korisnik.TabIndex = 0;
            this.korisnik.Text = "Prijavljeni ste kao:";
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.Color.Black;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(382, 18);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(56, 16);
            this.Odjava.TabIndex = 1;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.Color.Black;
            this.Opcije.Controls.Add(this.Artikli);
            this.Opcije.Controls.Add(this.Ulaznica);
            this.Opcije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Opcije.Location = new System.Drawing.Point(16, 76);
            this.Opcije.Name = "Opcije";
            this.Opcije.Size = new System.Drawing.Size(202, 117);
            this.Opcije.TabIndex = 3;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // Artikli
            // 
            this.Artikli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Artikli.Image = global::PI_projekt.Properties.Resources.kokice;
            this.Artikli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Artikli.Location = new System.Drawing.Point(29, 70);
            this.Artikli.Name = "Artikli";
            this.Artikli.Size = new System.Drawing.Size(130, 30);
            this.Artikli.TabIndex = 1;
            this.Artikli.Text = "Artikli";
            this.Artikli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Artikli.UseVisualStyleBackColor = true;
            // 
            // Ulaznica
            // 
            this.Ulaznica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ulaznica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ulaznica.Image = global::PI_projekt.Properties.Resources.tiket;
            this.Ulaznica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ulaznica.Location = new System.Drawing.Point(29, 24);
            this.Ulaznica.Name = "Ulaznica";
            this.Ulaznica.Size = new System.Drawing.Size(130, 30);
            this.Ulaznica.TabIndex = 0;
            this.Ulaznica.Text = "Ulaznica";
            this.Ulaznica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ulaznica.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(156, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(108, 16);
            this.userName.TabIndex = 4;
            this.userName.Text = "korisničko ime";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(71, 44);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(47, 16);
            this.userRole.TabIndex = 6;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(13, 44);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(54, 16);
            this.uloga.TabIndex = 5;
            this.uloga.Text = "Uloga:";
            // 
            // FrmProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 205);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.korisnik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(459, 244);
            this.MinimumSize = new System.Drawing.Size(459, 244);
            this.Name = "FrmProdavac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavač";
            this.Opcije.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.Button Artikli;
        private System.Windows.Forms.Button Ulaznica;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
    }
}