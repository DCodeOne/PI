using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Izvjestaj
{
    public partial class UlaznicaIspis : Form
    {
        private int idUlaznice;

        public UlaznicaIspis(int ulaznicaId)
        {
            InitializeComponent();
            idUlaznice = ulaznicaId;


            Ulaznice ulaznica = Ulaznice.DohvatiUlaznicu(idUlaznice);
            Projekcija projekcija = Projekcija.DohvatiProjekciju(ulaznica.IdProjekcije);
            Dvorana dvorana = Dvorana.DohvatiDvoranu(projekcija.BrojDvorane);
            Film film = Film.DohvatiFilm(projekcija.IdFilma);
            RacunUlaznica racunUlaznica = RacunUlaznica.DohvatiRacunUlaznica(idUlaznice);
            Popust popust = Popust.DohvatiPopust(racunUlaznica.IdPopusta);

            this.UlazniceBindingSource.DataSource = ulaznica;
            this.ProjekcijaBindingSource.DataSource = projekcija;
            this.DvoranaBindingSource.DataSource = dvorana;
            this.FilmBindingSource.DataSource = film;
            this.PopustBindingSource.DataSource = popust;
            this.reportViewer1.RefreshReport();
           
          
           
        }

        private void UlaznicaIspis_Load(object sender, EventArgs e)
        {
            
        }
    }
}
