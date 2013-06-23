namespace PI_projekt.Izvjestaj
{
    partial class RacunIzvjestaj
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDBDataSet = new PI_projekt.KinoDBDataSet();
            this.nacinplacanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunkartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.RacunTableAdapter();
            this.nacin_placanjaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.Nacin_placanjaTableAdapter();
            this.zaposlenikTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.artiklTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ArtiklTableAdapter();
            this.mjerna_jedinicaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.stavka_racunaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.stavka_racunaTableAdapter();
            this.kartaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.KartaTableAdapter();
            this.racun_kartaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.racun_kartaTableAdapter();
            this.projekcijaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ProjekcijaTableAdapter();
            this.filmTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.FilmTableAdapter();
            this.popustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popustTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.PopustTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinplacanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunkartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popustBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Racun";
            reportDataSource1.Value = this.racunBindingSource;
            reportDataSource2.Name = "NacinPlacanja";
            reportDataSource2.Value = this.nacinplacanjaBindingSource;
            reportDataSource3.Name = "Zaposlenik";
            reportDataSource3.Value = this.zaposlenikBindingSource;
            reportDataSource4.Name = "Artikl";
            reportDataSource4.Value = this.artiklBindingSource;
            reportDataSource5.Name = "MjernaJedinica";
            reportDataSource5.Value = this.mjernajedinicaBindingSource;
            reportDataSource6.Name = "StavkaRacuna";
            reportDataSource6.Value = this.stavkaracunaBindingSource;
            reportDataSource7.Name = "Karta";
            reportDataSource7.Value = this.kartaBindingSource;
            reportDataSource8.Name = "RacunKarta";
            reportDataSource8.Value = this.racunkartaBindingSource;
            reportDataSource9.Name = "Projekcija";
            reportDataSource9.Value = this.projekcijaBindingSource;
            reportDataSource10.Name = "Film";
            reportDataSource10.Value = this.filmBindingSource;
            reportDataSource11.Name = "Popust";
            reportDataSource11.Value = this.popustBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // kinoDBDataSet
            // 
            this.kinoDBDataSet.DataSetName = "KinoDBDataSet";
            this.kinoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nacinplacanjaBindingSource
            // 
            this.nacinplacanjaBindingSource.DataMember = "Nacin_placanja";
            this.nacinplacanjaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataMember = "Karta";
            this.kartaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // racunkartaBindingSource
            // 
            this.racunkartaBindingSource.DataMember = "racun_karta";
            this.racunkartaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // projekcijaBindingSource
            // 
            this.projekcijaBindingSource.DataMember = "Projekcija";
            this.projekcijaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // nacin_placanjaTableAdapter
            // 
            this.nacin_placanjaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // kartaTableAdapter
            // 
            this.kartaTableAdapter.ClearBeforeFill = true;
            // 
            // racun_kartaTableAdapter
            // 
            this.racun_kartaTableAdapter.ClearBeforeFill = true;
            // 
            // projekcijaTableAdapter
            // 
            this.projekcijaTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // popustBindingSource
            // 
            this.popustBindingSource.DataMember = "Popust";
            this.popustBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // popustTableAdapter
            // 
            this.popustTableAdapter.ClearBeforeFill = true;
            // 
            // RacunIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RacunIzvjestaj";
            this.Text = "RacunIzvjestaj";
            this.Load += new System.EventHandler(this.RacunIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinplacanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunkartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popustBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private KinoDBDataSet kinoDBDataSet;
        private KinoDBDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource nacinplacanjaBindingSource;
        private KinoDBDataSetTableAdapters.Nacin_placanjaTableAdapter nacin_placanjaTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private KinoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private KinoDBDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private KinoDBDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private KinoDBDataSetTableAdapters.stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.BindingSource kartaBindingSource;
        private System.Windows.Forms.BindingSource racunkartaBindingSource;
        private KinoDBDataSetTableAdapters.KartaTableAdapter kartaTableAdapter;
        private KinoDBDataSetTableAdapters.racun_kartaTableAdapter racun_kartaTableAdapter;
        private System.Windows.Forms.BindingSource projekcijaBindingSource;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private KinoDBDataSetTableAdapters.ProjekcijaTableAdapter projekcijaTableAdapter;
        private KinoDBDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource popustBindingSource;
        private KinoDBDataSetTableAdapters.PopustTableAdapter popustTableAdapter;
    }
}