namespace PI_projekt.Izvjestaj
{
    partial class UlaznicaIspis
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DvoranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UlazniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PopustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DvoranaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlazniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopustBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DvoranaBindingSource
            // 
            this.DvoranaBindingSource.DataSource = typeof(PI_projekt.Dvorana);
            // 
            // FilmBindingSource
            // 
            this.FilmBindingSource.DataSource = typeof(PI_projekt.Film);
            // 
            // UlazniceBindingSource
            // 
            this.UlazniceBindingSource.DataSource = typeof(PI_projekt.Ulaznice);
            // 
            // ProjekcijaBindingSource
            // 
            this.ProjekcijaBindingSource.DataSource = typeof(PI_projekt.Projekcija);
            // 
            // PopustBindingSource
            // 
            this.PopustBindingSource.DataSource = typeof(PI_projekt.Popust);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "dsDvorana";
            reportDataSource6.Value = this.DvoranaBindingSource;
            reportDataSource7.Name = "dsFilm";
            reportDataSource7.Value = this.FilmBindingSource;
            reportDataSource8.Name = "dsUlaznice";
            reportDataSource8.Value = this.UlazniceBindingSource;
            reportDataSource9.Name = "dsProjekcija";
            reportDataSource9.Value = this.ProjekcijaBindingSource;
            reportDataSource10.Name = "dsPopust";
            reportDataSource10.Value = this.PopustBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptUlaznicaIspis.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(556, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // UlaznicaIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 368);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UlaznicaIspis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UlaznicaIspis";
            this.Load += new System.EventHandler(this.UlaznicaIspis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvoranaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlazniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjekcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopustBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DvoranaBindingSource;
        private System.Windows.Forms.BindingSource FilmBindingSource;
        private System.Windows.Forms.BindingSource UlazniceBindingSource;
        private System.Windows.Forms.BindingSource ProjekcijaBindingSource;
        private System.Windows.Forms.BindingSource PopustBindingSource;
    }
}