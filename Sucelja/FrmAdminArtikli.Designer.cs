namespace PI_projekt.Sucelja
{
    partial class FrmAdminArtikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminArtikli));
            this.dgvSviArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.btnOsvjeziArtikle = new System.Windows.Forms.Button();
            this.btnAzurirajArtikl = new System.Windows.Forms.Button();
            this.lblSviArtikli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviArtikli
            // 
            this.dgvSviArtikli.AllowUserToAddRows = false;
            this.dgvSviArtikli.AllowUserToDeleteRows = false;
            this.dgvSviArtikli.AllowUserToResizeColumns = false;
            this.dgvSviArtikli.AllowUserToResizeRows = false;
            this.dgvSviArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSviArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikli.Location = new System.Drawing.Point(14, 40);
            this.dgvSviArtikli.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSviArtikli.MultiSelect = false;
            this.dgvSviArtikli.Name = "dgvSviArtikli";
            this.dgvSviArtikli.ReadOnly = true;
            this.dgvSviArtikli.RowHeadersVisible = false;
            this.dgvSviArtikli.RowTemplate.Height = 24;
            this.dgvSviArtikli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSviArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviArtikli.Size = new System.Drawing.Size(305, 235);
            this.dgvSviArtikli.TabIndex = 0;
            this.dgvSviArtikli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviArtikli_CellClick);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajArtikl.Location = new System.Drawing.Point(155, 290);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(80, 35);
            this.btnDodajArtikl.TabIndex = 1;
            this.btnDodajArtikl.Text = "Dodaj";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // btnOsvjeziArtikle
            // 
            this.btnOsvjeziArtikle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjeziArtikle.Location = new System.Drawing.Point(71, 290);
            this.btnOsvjeziArtikle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOsvjeziArtikle.Name = "btnOsvjeziArtikle";
            this.btnOsvjeziArtikle.Size = new System.Drawing.Size(80, 35);
            this.btnOsvjeziArtikle.TabIndex = 2;
            this.btnOsvjeziArtikle.Text = "Osvježi";
            this.btnOsvjeziArtikle.UseVisualStyleBackColor = true;
            this.btnOsvjeziArtikle.Click += new System.EventHandler(this.btnOsvjeziArtikle_Click);
            // 
            // btnAzurirajArtikl
            // 
            this.btnAzurirajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajArtikl.Location = new System.Drawing.Point(239, 290);
            this.btnAzurirajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzurirajArtikl.Name = "btnAzurirajArtikl";
            this.btnAzurirajArtikl.Size = new System.Drawing.Size(80, 35);
            this.btnAzurirajArtikl.TabIndex = 3;
            this.btnAzurirajArtikl.Text = "Ažuriraj";
            this.btnAzurirajArtikl.UseVisualStyleBackColor = true;
            this.btnAzurirajArtikl.Click += new System.EventHandler(this.btnAzurirajArtikl_Click);
            // 
            // lblSviArtikli
            // 
            this.lblSviArtikli.AutoSize = true;
            this.lblSviArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSviArtikli.Location = new System.Drawing.Point(10, 11);
            this.lblSviArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSviArtikli.Name = "lblSviArtikli";
            this.lblSviArtikli.Size = new System.Drawing.Size(163, 20);
            this.lblSviArtikli.TabIndex = 5;
            this.lblSviArtikli.Text = "Prikaz svih artikala:";
            // 
            // FrmAdminArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 337);
            this.Controls.Add(this.lblSviArtikli);
            this.Controls.Add(this.btnAzurirajArtikl);
            this.Controls.Add(this.btnOsvjeziArtikle);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.dgvSviArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdminArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.FrmAdminArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviArtikli;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Button btnOsvjeziArtikle;
        private System.Windows.Forms.Button btnAzurirajArtikl;
        private System.Windows.Forms.Label lblSviArtikli;
    }
}