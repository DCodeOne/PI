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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DvoranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UlazniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PopustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DvoranaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlazniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopustBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDvorana";
            reportDataSource1.Value = this.DvoranaBindingSource;
            reportDataSource2.Name = "dsFilm";
            reportDataSource2.Value = this.FilmBindingSource;
            reportDataSource3.Name = "dsUlaznice";
            reportDataSource3.Value = this.UlazniceBindingSource;
            reportDataSource4.Name = "dsProjekcija";
            reportDataSource4.Value = this.ProjekcijaBindingSource;
            reportDataSource5.Name = "dsPopust";
            reportDataSource5.Value = this.PopustBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptUlaznicaIspis.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 453);
            this.reportViewer1.TabIndex = 0;
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
            // UlaznicaIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UlaznicaIspis";
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