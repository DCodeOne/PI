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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminFilmovi));
            this.lblSviFilmovi = new System.Windows.Forms.Label();
            this.dgvSviFilmovi = new System.Windows.Forms.DataGridView();
            this.btnFilmoviOsvjezi = new System.Windows.Forms.Button();
            this.btnFilmoviDodaj = new System.Windows.Forms.Button();
            this.btnFilmoviAzuriraj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSviFilmovi
            // 
            this.lblSviFilmovi.AutoSize = true;
            this.lblSviFilmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSviFilmovi.Location = new System.Drawing.Point(13, 12);
            this.lblSviFilmovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSviFilmovi.Name = "lblSviFilmovi";
            this.lblSviFilmovi.Size = new System.Drawing.Size(203, 24);
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
            this.dgvSviFilmovi.Location = new System.Drawing.Point(13, 49);
            this.dgvSviFilmovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSviFilmovi.MultiSelect = false;
            this.dgvSviFilmovi.Name = "dgvSviFilmovi";
            this.dgvSviFilmovi.ReadOnly = true;
            this.dgvSviFilmovi.RowHeadersVisible = false;
            this.dgvSviFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviFilmovi.Size = new System.Drawing.Size(856, 289);
            this.dgvSviFilmovi.TabIndex = 29;
            this.dgvSviFilmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviFilmovi_CellClick);
            // 
            // btnFilmoviOsvjezi
            // 
            this.btnFilmoviOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviOsvjezi.Location = new System.Drawing.Point(420, 359);
            this.btnFilmoviOsvjezi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilmoviOsvjezi.Name = "btnFilmoviOsvjezi";
            this.btnFilmoviOsvjezi.Size = new System.Drawing.Size(107, 43);
            this.btnFilmoviOsvjezi.TabIndex = 31;
            this.btnFilmoviOsvjezi.Text = "Osvježi";
            this.btnFilmoviOsvjezi.UseVisualStyleBackColor = true;
            this.btnFilmoviOsvjezi.Click += new System.EventHandler(this.btnFilmoviOsvjezi_Click_1);
            // 
            // btnFilmoviDodaj
            // 
            this.btnFilmoviDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviDodaj.Location = new System.Drawing.Point(535, 359);
            this.btnFilmoviDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilmoviDodaj.Name = "btnFilmoviDodaj";
            this.btnFilmoviDodaj.Size = new System.Drawing.Size(107, 43);
            this.btnFilmoviDodaj.TabIndex = 32;
            this.btnFilmoviDodaj.Text = "Dodaj";
            this.btnFilmoviDodaj.UseVisualStyleBackColor = true;
            this.btnFilmoviDodaj.Click += new System.EventHandler(this.btnFilmoviDodaj_Click);
            // 
            // btnFilmoviAzuriraj
            // 
            this.btnFilmoviAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmoviAzuriraj.Location = new System.Drawing.Point(650, 359);
            this.btnFilmoviAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilmoviAzuriraj.Name = "btnFilmoviAzuriraj";
            this.btnFilmoviAzuriraj.Size = new System.Drawing.Size(107, 43);
            this.btnFilmoviAzuriraj.TabIndex = 33;
            this.btnFilmoviAzuriraj.Text = "Ažuriraj";
            this.btnFilmoviAzuriraj.UseVisualStyleBackColor = true;
            this.btnFilmoviAzuriraj.Click += new System.EventHandler(this.btnFilmoviAzuriraj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(765, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 34;
            this.button1.Text = "Obriši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdminFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFilmoviAzuriraj);
            this.Controls.Add(this.btnFilmoviDodaj);
            this.Controls.Add(this.btnFilmoviOsvjezi);
            this.Controls.Add(this.dgvSviFilmovi);
            this.Controls.Add(this.lblSviFilmovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}