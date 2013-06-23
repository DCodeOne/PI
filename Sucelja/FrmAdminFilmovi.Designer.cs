namespace PI_projekt.Sucelja
{
    partial class FrmAdminFilmovi
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
            this.lblSviFilmovi = new System.Windows.Forms.Label();
            this.dgvSviFilmovi = new System.Windows.Forms.DataGridView();
            this.btnFilmoviOsvjezi = new System.Windows.Forms.Button();
            this.btnFilmoviDodaj = new System.Windows.Forms.Button();
            this.btnFilmoviAzuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSviFilmovi
            // 
            this.lblSviFilmovi.AutoSize = true;
            this.lblSviFilmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSviFilmovi.Location = new System.Drawing.Point(10, 10);
            this.lblSviFilmovi.Name = "lblSviFilmovi";
            this.lblSviFilmovi.Size = new System.Drawing.Size(164, 18);
            this.lblSviFilmovi.TabIndex = 28;
            this.lblSviFilmovi.Text = "Pregled svih filmova:";
            // 
            // dgvSviFilmovi
            // 
            this.dgvSviFilmovi.AllowUserToAddRows = false;
            this.dgvSviFilmovi.AllowUserToDeleteRows = false;
            this.dgvSviFilmovi.AllowUserToResizeColumns = false;
            this.dgvSviFilmovi.AllowUserToResizeRows = false;
            this.dgvSviFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSviFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviFilmovi.Location = new System.Drawing.Point(10, 40);
            this.dgvSviFilmovi.MultiSelect = false;
            this.dgvSviFilmovi.Name = "dgvSviFilmovi";
            this.dgvSviFilmovi.ReadOnly = true;
            this.dgvSviFilmovi.RowHeadersVisible = false;
            this.dgvSviFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviFilmovi.Size = new System.Drawing.Size(642, 235);
            this.dgvSviFilmovi.TabIndex = 29;
            this.dgvSviFilmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviFilmovi_CellClick);
            // 
            // btnFilmoviOsvjezi
            // 
            this.btnFilmoviOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviOsvjezi.Location = new System.Drawing.Point(400, 290);
            this.btnFilmoviOsvjezi.Name = "btnFilmoviOsvjezi";
            this.btnFilmoviOsvjezi.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviOsvjezi.TabIndex = 31;
            this.btnFilmoviOsvjezi.Text = "Osvježi";
            this.btnFilmoviOsvjezi.UseVisualStyleBackColor = true;
            this.btnFilmoviOsvjezi.Click += new System.EventHandler(this.btnFilmoviOsvjezi_Click_1);
            // 
            // btnFilmoviDodaj
            // 
            this.btnFilmoviDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodaj.Location = new System.Drawing.Point(486, 290);
            this.btnFilmoviDodaj.Name = "btnFilmoviDodaj";
            this.btnFilmoviDodaj.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviDodaj.TabIndex = 32;
            this.btnFilmoviDodaj.Text = "Dodaj";
            this.btnFilmoviDodaj.UseVisualStyleBackColor = true;
            this.btnFilmoviDodaj.Click += new System.EventHandler(this.btnFilmoviDodaj_Click);
            // 
            // btnFilmoviAzuriraj
            // 
            this.btnFilmoviAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviAzuriraj.Location = new System.Drawing.Point(572, 290);
            this.btnFilmoviAzuriraj.Name = "btnFilmoviAzuriraj";
            this.btnFilmoviAzuriraj.Size = new System.Drawing.Size(80, 35);
            this.btnFilmoviAzuriraj.TabIndex = 33;
            this.btnFilmoviAzuriraj.Text = "Ažuriraj";
            this.btnFilmoviAzuriraj.UseVisualStyleBackColor = true;
            this.btnFilmoviAzuriraj.Click += new System.EventHandler(this.btnFilmoviAzuriraj_Click);
            // 
            // FrmAdminFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.btnFilmoviAzuriraj);
            this.Controls.Add(this.btnFilmoviDodaj);
            this.Controls.Add(this.btnFilmoviOsvjezi);
            this.Controls.Add(this.dgvSviFilmovi);
            this.Controls.Add(this.lblSviFilmovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminFilmovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.FrmAdminFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSviFilmovi;
        private System.Windows.Forms.DataGridView dgvSviFilmovi;
        private System.Windows.Forms.Button btnFilmoviOsvjezi;
        private System.Windows.Forms.Button btnFilmoviDodaj;
        private System.Windows.Forms.Button btnFilmoviAzuriraj;
    }
}