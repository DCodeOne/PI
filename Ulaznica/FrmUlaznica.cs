using PI_projekt.Sucelja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Ulaznica
{
    public partial class FrmUlaznica : Form
    {

        //lista filmova
        private List<Film> filmovi = new List<Film>();
        private List<Projekcija> projekcije = new List<Projekcija>();
        private List<VrstaProjekcije> vrsteProjekcije = new List<VrstaProjekcije>();
        private List<Zanrovi> zanrovi = new List<Zanrovi>();
        private List<int> zauzetaMjesta = new List<int>();
        private List<int> odabranaMjesta = new List<int>();
        private List<Popust> popusti = new List<Popust>();
        private Projekcija odabranaProjekcija = new Projekcija();
        private Film odabraniFilm = new Film();
        private int idProjekcije = 0;
        private Popust odabraniPopust;
        private float ukupno = 0;
        private float popust = 0;
        private float suma = 0;
        

        private void Osvjezi()
        {
            cbDatum.Items.Clear();
            txtDvorana.Clear();
            txtFilm.Clear();
            txtCijena.Clear();
            txtBrojMjesta.Clear();
            txtProdanoUlaznica.Clear();
            txtVrijemeTrajanja.Clear();
            lbZanr.Items.Clear();
            lbVrstaProjekcije.Items.Clear();
            lbSlobodna.Items.Clear();
            lbOdabrana.Items.Clear();
            idProjekcije = 0;
            odabraniFilm = null;
            odabranaMjesta = null;
            zauzetaMjesta = null;
            txtSuma.Clear();
        
        }
        private void UracunajPopust()
        {
            ukupno = lbOdabrana.Items.Count * odabranaProjekcija.Cijena;
            suma = ukupno - (odabraniPopust.PopustPostotak * ukupno);
            popust = odabraniPopust.PopustPostotak * 100;
            txtSuma.Text = ukupno.ToString();
            txtPopust.Text = popust.ToString() + "%";
            txtUkupno.Text = suma.ToString();
        }

        private void PostaviDetalje()
        {

        }

        public FrmUlaznica()
        {
            InitializeComponent();
           
            popusti = Popust.DohvatiPopuste();
            foreach (Popust popust in popusti)
            {
                cbPopust.Items.Add(popust.Naziv);
            }
            cbPopust.SelectedIndex = cbPopust.FindStringExact("Bez Popusta");

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUlaznica_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProdavac prodavac = new FrmProdavac();
            prodavac.Show();
        }

        private void FrmUlaznica_Load(object sender, EventArgs e)
        {
           
            // filmovi = Film.DohvatiAktualneFilmove();
            filmovi = Film.DohvatiFilmove();
            foreach (Film film in filmovi)
            {
                cbNazivProjekcije.Items.Add(film.Naziv);
            }

        }

        private void cbNazivProjekcije_SelectedIndexChanged(object sender, EventArgs e)
        {

            Osvjezi();
            odabraniFilm = filmovi[cbNazivProjekcije.SelectedIndex];
            projekcije = Projekcija.DohvatiProjekcijeFilm(odabraniFilm.IdFilma);
            foreach (Projekcija projekcija in projekcije)
            {
                cbDatum.Items.Add(projekcija.Datum);
            }
            //obrisi sve iz ostalih boxova
        }

        private void cbDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            idProjekcije = projekcije[cbDatum.SelectedIndex].IdProjekcije;
            foreach (Projekcija projekcija2 in projekcije)
            {
                if (projekcija2.IdProjekcije == idProjekcije)
                {
                    odabranaProjekcija = projekcija2;
                }

  //napravi metodu koja ce dohvatit za taj ID dvorane Naziv dvorane umjesto linije ispod!!!
                txtDvorana.Text = odabranaProjekcija.BrojDvorane.ToString();
                txtFilm.Text = odabraniFilm.Naziv;
                txtCijena.Text = odabranaProjekcija.Cijena.ToString();
                txtBrojMjesta.Text = odabranaProjekcija.BrojMjesta.ToString();
                txtProdanoUlaznica.Text = odabranaProjekcija.ProdanoUlaznica.ToString();
                txtVrijemeTrajanja.Text = odabranaProjekcija.VrijemeTrajanja.ToString();

                //dohvaćamo žanrove i vrste projekcije za odabrani film/projekciju
                vrsteProjekcije = VrstaProjekcije.DohvatiVrste(idProjekcije);
                zanrovi = Zanrovi.DohvatiZanrove(odabraniFilm.IdFilma);
                //popunjavano list box vrste projekcije i žanr
                lbZanr.Items.Clear();
                lbVrstaProjekcije.Items.Clear();
                foreach (Zanrovi zanr in zanrovi)
                {
                    lbZanr.Items.Add(zanr.Naziv);
                }
                foreach (VrstaProjekcije vrsta in vrsteProjekcije)
                {
                    lbVrstaProjekcije.Items.Add(vrsta.Naziv);
                }

                //dohvaćamo slobodna mjesta u lbSlobodna mjesta
                zauzetaMjesta = Ulaznice.DohvatiUlazniceProjekciju(idProjekcije);
                
                for(int i=1;i<=odabranaProjekcija.BrojMjesta;i++)
                {
                    if (!zauzetaMjesta.Contains(i))
                        lbSlobodna.Items.Add(i);
                }


            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lbSlobodna.SelectedItem != null)
            {
                lbOdabrana.Items.Add(lbSlobodna.SelectedItem);
                lbSlobodna.Items.Remove(lbSlobodna.SelectedItem);
                //lbSlobodna.Sorted = true;
                UracunajPopust();

            }
            else
            {
                MessageBox.Show("Odaberi sjedalo!");
            }

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lbOdabrana.SelectedItem != null)
            {
                lbSlobodna.Items.Add(lbOdabrana.SelectedItem);
                lbOdabrana.Items.Remove(lbOdabrana.SelectedItem);
                //lbOdabrana.Sorted = true;
                UracunajPopust();
                
            }
            else
            {
                MessageBox.Show("Odaberi sjedalo!");
            }
        }

        private void Dalje_Click(object sender, EventArgs e)
        {
            if (lbOdabrana.Items.Count > 0 && odabranaProjekcija!=null)
            {
                List<int> odabranaSjedala = new List<int>();
                List<int> listaIdUlaznica = new List<int>();
                for (int i = 0; i < lbOdabrana.Items.Count; i++)
                {
                    
                    odabranaSjedala.Add(int.Parse(lbOdabrana.Items[i].ToString()));
                }
                Kino.IzradiUlaznicu(odabranaSjedala, odabranaProjekcija);
            }
            else
            {
                MessageBox.Show("Odaberije projekciju i sjedalo!");
            }
        }

        private void cbPopust_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniPopust = popusti[cbPopust.SelectedIndex];
            UracunajPopust();
        }

    }
}
