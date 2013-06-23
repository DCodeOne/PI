namespace PI_projekt.Sucelja
{
    partial class FrmAdminDvorane
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
            this.btnDvoraneAzuriraj = new System.Windows.Forms.Button();
            this.btnDvoraneDodaj = new System.Windows.Forms.Button();
            this.btnDvoraneOsvjezi = new System.Windows.Forms.Button();
            this.dgvSveDvorane = new System.Windows.Forms.DataGridView();
            this.lblDvorane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDvoraneAzuriraj
            // 
            this.btnDvoraneAzuriraj.FlatAppearance.BorderSize = 2;
            this.btnDvoraneAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDvoraneAzuriraj.Location = new System.Drawing.Point(195, 290);
            this.btnDvoraneAzuriraj.Name = "btnDvoraneAzuriraj";
            this.btnDvoraneAzuriraj.Size = new System.Drawing.Size(80, 35);
            this.btnDvoraneAzuriraj.TabIndex = 1;
            this.btnDvoraneAzuriraj.Text = "Ažuriraj";
            this.btnDvoraneAzuriraj.UseVisualStyleBackColor = true;
            this.btnDvoraneAzuriraj.Click += new System.EventHandler(this.btnDvoraneAzuriraj_Click);
            // 
            // btnDvoraneDodaj
            // 
            this.btnDvoraneDodaj.FlatAppearance.BorderSize = 2;
            this.btnDvoraneDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDvoraneDodaj.Location = new System.Drawing.Point(109, 290);
            this.btnDvoraneDodaj.Name = "btnDvoraneDodaj";
            this.btnDvoraneDodaj.Size = new System.Drawing.Size(80, 35);
            this.btnDvoraneDodaj.TabIndex = 2;
            this.btnDvoraneDodaj.Text = "Dodaj";
            this.btnDvoraneDodaj.UseVisualStyleBackColor = true;
            this.btnDvoraneDodaj.Click += new System.EventHandler(this.btnDvoraneDodaj_Click);
            // 
            // btnDvoraneOsvjezi
            // 
            this.btnDvoraneOsvjezi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDvoraneOsvjezi.FlatAppearance.BorderSize = 2;
            this.btnDvoraneOsvjezi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDvoraneOsvjezi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDvoraneOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDvoraneOsvjezi.Location = new System.Drawing.Point(26, 290);
            this.btnDvoraneOsvjezi.Name = "btnDvoraneOsvjezi";
            this.btnDvoraneOsvjezi.Size = new System.Drawing.Size(80, 35);
            this.btnDvoraneOsvjezi.TabIndex = 3;
            this.btnDvoraneOsvjezi.Text = "Osvježi";
            this.btnDvoraneOsvjezi.UseVisualStyleBackColor = true;
            this.btnDvoraneOsvjezi.Click += new System.EventHandler(this.btnDvoraneOsvjezi_Click);
            // 
            // dgvSveDvorane
            // 
            this.dgvSveDvorane.AllowUserToAddRows = false;
            this.dgvSveDvorane.AllowUserToDeleteRows = false;
            this.dgvSveDvorane.AllowUserToResizeColumns = false;
            this.dgvSveDvorane.AllowUserToResizeRows = false;
            this.dgvSveDvorane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSveDvorane.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSveDvorane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveDvorane.Location = new System.Drawing.Point(10, 40);
            this.dgvSveDvorane.MultiSelect = false;
            this.dgvSveDvorane.Name = "dgvSveDvorane";
            this.dgvSveDvorane.ReadOnly = true;
            this.dgvSveDvorane.RowHeadersVisible = false;
            this.dgvSveDvorane.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSveDvorane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSveDvorane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSveDvorane.Size = new System.Drawing.Size(265, 235);
            this.dgvSveDvorane.TabIndex = 0;
            this.dgvSveDvorane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSveDvorane_CellClick);
            // 
            // lblDvorane
            // 
            this.lblDvorane.AutoSize = true;
            this.lblDvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDvorane.Location = new System.Drawing.Point(10, 10);
            this.lblDvorane.Name = "lblDvorane";
            this.lblDvorane.Size = new System.Drawing.Size(170, 18);
            this.lblDvorane.TabIndex = 5;
            this.lblDvorane.Text = "Pregled svih dvorana:";
            // 
            // FrmAdminDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.lblDvorane);
            this.Controls.Add(this.dgvSveDvorane);
            this.Controls.Add(this.btnDvoraneOsvjezi);
            this.Controls.Add(this.btnDvoraneDodaj);
            this.Controls.Add(this.btnDvoraneAzuriraj);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminDvorane";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dvorane";
            this.Load += new System.EventHandler(this.FrmAdminDvorane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDvoraneAzuriraj;
        private System.Windows.Forms.Button btnDvoraneDodaj;
        private System.Windows.Forms.Button btnDvoraneOsvjezi;
        private System.Windows.Forms.DataGridView dgvSveDvorane;
        private System.Windows.Forms.Label lblDvorane;
    }
}