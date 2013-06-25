using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Sucelja
{
    public partial class FrmAdminFilmoviDodaj : Form
    {
        private Film filmAzuriraj = null;
        private int idFilma = -1;

        /// <summary>
        /// Lista koja prikazuje moguće žanrove i lista koja pokazuje koji su od ponuđenih
        /// žanrova odabrani
        /// </summary>
        List<Zanrovi> listaZanrova = new List<Zanrovi>();
        List<int> listaOdabranih = new List<int>();
        
        /// <summary>
        /// Konstruktor koji se poziva u slučaju dodavanja novog filma
        /// </summary>
        /// 
        public FrmAdminFilmoviDodaj()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojećeg filma
        /// </summary>
        /// <param name="odabraniFilm"></param>
        public FrmAdminFilmoviDodaj(int odabraniFilm)
        {
            InitializeComponent();
            filmAzuriraj = Film.DohvatiFilm(odabraniFilm);
            
            txtDodajFilmNaziv.Text = filmAzuriraj.Naziv.ToString();
            txtFilmoviDodajTrajanje.Text = filmAzuriraj.VrijemeTrajanja.ToString();
            txtFilmoviDodajRedatelj.Text = filmAzuriraj.Redatelj.ToString();
            txtFilmoviDodajGodina.Text = filmAzuriraj.Godina.ToString();
            txtFilmoviDodajGlumci.Text = filmAzuriraj.Glumci.ToString();
            txtFilmoviDodajSinopsis.Text = filmAzuriraj.Sinopsis.ToString();
            idFilma = odabraniFilm;
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme, ukoliko se radi o ažuriranju filma tada formu popunjava sa postojećim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminFilmDodaj_Load(object sender, EventArgs e)
        {
            listaZanrova = Zanrovi.DohvatiZanrove();

            this.ActiveControl = txtDodajFilmNaziv;
           
            //ukoliko se radi o ažuriranju
            if (filmAzuriraj != null)
            {

                txtDodajFilmNaziv.Text = filmAzuriraj.Naziv.ToString();
                txtFilmoviDodajTrajanje.Text = filmAzuriraj.VrijemeTrajanja.ToString();
                txtFilmoviDodajRedatelj.Text = filmAzuriraj.Redatelj.ToString();
                txtFilmoviDodajGodina.Text = filmAzuriraj.Godina.ToString();
                txtFilmoviDodajGlumci.Text = filmAzuriraj.Glumci.ToString();
                txtFilmoviDodajSinopsis.Text = filmAzuriraj.Sinopsis.ToString();

                //Ubacujemo u listu sve Id.e prethodno odabranih žanrova
                List<Zanrovi> azurirajListaZanrova = new List<Zanrovi>(Zanrovi.DohvatiZanrove(idFilma));
                List<int> azurirajListaZanrovaID = new List<int>();
                foreach (Zanrovi zanr in azurirajListaZanrova)
                {
                    azurirajListaZanrovaID.Add(zanr.IdZanra);
                }
              
                //prilikom popunjavanja je li već žanr odabran od prije, ukoliko je onda ga stavljamo u lbOdabran, a ako nije onda ga stavljamo u lbSviŽanrovi
                foreach (Zanrovi zanr in listaZanrova)
                {
                    if (!azurirajListaZanrovaID.Contains(int.Parse(zanr.IdZanra.ToString())))
                    {
                        lbFilmoviDodajZanrovi.Items.Add(zanr);
                    }
                    else
                    {
                        lbFilmoviDodajZanroviOdabrani.Items.Add(zanr);
                    }
                }
              
            }
            else //ako je otvoren obrazac za dodavanje
            {
                foreach (Zanrovi zanr in listaZanrova)
                {
                    lbFilmoviDodajZanrovi.Items.Add(zanr);
                }
            }
        }

        /// <summary>
        /// Dodaje žanr za film koji se unosi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajDodajLb_Click(object sender, EventArgs e)
        {
            if (lbFilmoviDodajZanrovi.SelectedItem != null)
            {
                lbFilmoviDodajZanroviOdabrani.Items.Add(lbFilmoviDodajZanrovi.SelectedItem);
                lbFilmoviDodajZanrovi.Items.Remove(lbFilmoviDodajZanrovi.SelectedItem);                
            }
            else
            {
                MessageBox.Show("Greška! Odaberite Žanr.");
            }
        }
        /// <summary>
        /// Uklanja žanr za film koji se unosi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajOdustaniLb_Click(object sender, EventArgs e)
        {
            if (lbFilmoviDodajZanroviOdabrani.SelectedItem != null)
            {
                lbFilmoviDodajZanrovi.Items.Add(lbFilmoviDodajZanroviOdabrani.SelectedItem);
                lbFilmoviDodajZanroviOdabrani.Items.Remove(lbFilmoviDodajZanroviOdabrani.SelectedItem);
            }
            else
            {
                MessageBox.Show("Greška! Odaberite Žanr.");
            }
        } 

        /// <summary>
        /// Odustajanje od dodavanja novog filma prilikom klika na tipku odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Dodavanje novog filma prilikom klika na tipku spremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajSpremi_Click(object sender, EventArgs e)
        {
            Film noviFilm = new Film();
            try
            {
                //Prolazimo kroz svaku odabranu vrstu projekcije iz lbOdabrane i 
                //spremamo u pomoćnu listu lbFilmoviDodajZanroviOdabrani listu ID-a svih odabranih žanrova projekcija 
                noviFilm.Naziv = txtDodajFilmNaziv.Text.ToString();
                noviFilm.VrijemeTrajanja = int.Parse(txtFilmoviDodajTrajanje.Text.ToString());
                noviFilm.Redatelj = txtFilmoviDodajRedatelj.Text.ToString();
                noviFilm.Godina = int.Parse(txtFilmoviDodajGodina.Text.ToString());
                noviFilm.Glumci = txtFilmoviDodajGlumci.Text.ToString();
                noviFilm.Sinopsis = txtFilmoviDodajSinopsis.Text.ToString();
                if (noviFilm.Naziv == "" || noviFilm.VrijemeTrajanja == 0 || noviFilm.Redatelj == ""
                    || noviFilm.Godina == 0 || noviFilm.Glumci == "" || noviFilm.Sinopsis == "")
                {
                    MessageBox.Show("Greška! Pogrešan unos podataka.");
                }
                else
                {
                    if (lbFilmoviDodajZanroviOdabrani.Items.Count > 0)
                    {
                        foreach (Zanrovi zanr in lbFilmoviDodajZanroviOdabrani.Items)
                        {
                            listaOdabranih.Add(zanr.IdZanra);
                        }
                        if (filmAzuriraj != null)
                        {
                            noviFilm.IdFilma = filmAzuriraj.IdFilma;
                            Film.AzurirajFilm(noviFilm);
                            FilmZanrovi.AzurirajZanrove(noviFilm.IdFilma, listaOdabranih);
                        }
                        else
                        {
                            int IdDodanogFilma = Film.DodajFilm(noviFilm);
                            FilmZanrovi.UnesiZanrove(IdDodanogFilma, listaOdabranih);
                        }
                        this.Close();
                    }
                    else //ako korisnik nije unio žanrove ispisuje se poruka o pogrešci
                    {
                        MessageBox.Show("Greška! Odaberite žanr.");
                    }
                }
            }
            catch {
                MessageBox.Show("Greška! Pogrešan unos podataka.");
            }
        }   
    }
}
