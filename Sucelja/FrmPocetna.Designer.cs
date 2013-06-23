namespace PI_projekt.Sucelja
{
    partial class FrmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetna));
            this.Prijava = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.KorIme = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.KorisnickoIme = new System.Windows.Forms.Label();
            this.Lozinka = new System.Windows.Forms.Label();
            this.podaci = new System.Windows.Forms.GroupBox();
            this.zaglavlje = new System.Windows.Forms.GroupBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.podaci.SuspendLayout();
            this.zaglavlje.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prijava
            // 
            this.Prijava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Prijava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prijava.Location = new System.Drawing.Point(12, 362);
            this.Prijava.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(160, 46);
            this.Prijava.TabIndex = 0;
            this.Prijava.Text = "Prijava";
            this.Prijava.UseVisualStyleBackColor = false;
            this.Prijava.Click += new System.EventHandler(this.Prijava_Click);
            // 
            // Ponisti
            // 
            this.Ponisti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ponisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ponisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ponisti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ponisti.Location = new System.Drawing.Point(287, 362);
            this.Ponisti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(160, 46);
            this.Ponisti.TabIndex = 1;
            this.Ponisti.Text = "Poništi";
            this.Ponisti.UseVisualStyleBackColor = false;
            this.Ponisti.Click += new System.EventHandler(this.Ponisti_Click);
            // 
            // KorIme
            // 
            this.KorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorIme.Location = new System.Drawing.Point(160, 27);
            this.KorIme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KorIme.Name = "KorIme";
            this.KorIme.Size = new System.Drawing.Size(205, 22);
            this.KorIme.TabIndex = 5;
            this.KorIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KorIme_KeyDown);
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass.Location = new System.Drawing.Point(160, 67);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(205, 22);
            this.Pass.TabIndex = 6;
            this.Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass_KeyDown);
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorisnickoIme.Location = new System.Drawing.Point(4, 30);
            this.KorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(113, 16);
            this.KorisnickoIme.TabIndex = 7;
            this.KorisnickoIme.Text = "Korisničko ime:";
            // 
            // Lozinka
            // 
            this.Lozinka.AutoSize = true;
            this.Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lozinka.Location = new System.Drawing.Point(4, 74);
            this.Lozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(65, 16);
            this.Lozinka.TabIndex = 8;
            this.Lozinka.Text = "Lozinka:";
            // 
            // podaci
            // 
            this.podaci.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.podaci.Controls.Add(this.Lozinka);
            this.podaci.Controls.Add(this.KorisnickoIme);
            this.podaci.Controls.Add(this.Pass);
            this.podaci.Controls.Add(this.KorIme);
            this.podaci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.podaci.Location = new System.Drawing.Point(12, 233);
            this.podaci.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.podaci.Name = "podaci";
            this.podaci.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.podaci.Size = new System.Drawing.Size(435, 113);
            this.podaci.TabIndex = 9;
            this.podaci.TabStop = false;
            this.podaci.Text = "Korisnički podaci";
            // 
            // zaglavlje
            // 
            this.zaglavlje.BackgroundImage = global::PI_projekt.Properties.Resources.zaglavlje2;
            this.zaglavlje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zaglavlje.Controls.Add(this.btnIzlaz);
            this.zaglavlje.Location = new System.Drawing.Point(12, 12);
            this.zaglavlje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zaglavlje.Name = "zaglavlje";
            this.zaglavlje.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zaglavlje.Size = new System.Drawing.Size(435, 215);
            this.zaglavlje.TabIndex = 10;
            this.zaglavlje.TabStop = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzlaz.Location = new System.Drawing.Point(360, 0);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 13;
            this.btnIzlaz.Text = "IZLAZ";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 420);
            this.Controls.Add(this.zaglavlje);
            this.Controls.Add(this.podaci);
            this.Controls.Add(this.Ponisti);
            this.Controls.Add(this.Prijava);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(473, 459);
            this.MinimumSize = new System.Drawing.Size(473, 459);
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.podaci.ResumeLayout(false);
            this.podaci.PerformLayout();
            this.zaglavlje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prijava;
        private System.Windows.Forms.Button Ponisti;
        private System.Windows.Forms.TextBox KorIme;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label KorisnickoIme;
        private System.Windows.Forms.Label Lozinka;
        private System.Windows.Forms.GroupBox podaci;
        private System.Windows.Forms.GroupBox zaglavlje;
        private System.Windows.Forms.Button btnIzlaz;
    }
}