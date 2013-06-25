using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Artikli;
using PI_projekt.Ulaznica;
using System.Threading;

namespace PI_projekt.Sucelja
{
    public partial class FrmProdavac : Form
    {
        Thread dretvaProjekcije = new Thread(DretvaProvjeriProjekcije);
        private bool pom = false; 
        public FrmProdavac()
        {
            InitializeComponent();
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }


        /// <summary>
        /// Event koji poziva formu FrmPocetna kada korisnik u glavnom izborniku pod mogućnosti Opcije odabere Odjava
        /// </summary>

        int odjavljivanje = 0;
        
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {

            odjavljivanje = 1;
            pom = true;
            odjava();
        }

        /// <summary>
        /// Metoda koja služi za odjavu iz aplikacije
        /// </summary>
        private void odjava()
        {
            if (odjavljivanje == 1)
            {
                string message = "Želite li se odjaviti iz sustava?";
                string caption = "Odjava iz sustava";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Prikaz poruke o odjavi (Message Box)
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    dretvaProjekcije.Abort();
                    _shouldStop = false;
                    FrmPocetna pocetna = new FrmPocetna();
                    this.Close();
                    pocetna.Show();

                }
            }
        }

        /// <summary>
        /// Event koji zatvara otvorenu formu kada korisnik u glavnom izborniku pod mogućnosti Opcije odabere Izlaz
        /// </summary>
        int izlaz = 0;
        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            izlaz = 1;
            pom = true;
            izlazak();
        }

        /// <summary>
        ///  /// Metoda koja služi za izlaz iz aplikacije
        /// </summary>
        private void izlazak()
        {
            if (izlaz == 1)
            {
                dretvaProjekcije.Abort();
                Application.Exit();
            }
        }  
            
        /// <summary>
        /// Event koji poziva FrmUlaznica kada korisnik u glavnom izborniku pod mogućnosti Sifarnici odabere Ulaznica 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciUlaznica_MouseUp(object sender, MouseEventArgs e)
        {
            Ulaznica.FrmUlaznica Odabir = new Ulaznica.FrmUlaznica();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        /// <summary>
        /// Event koji poziva FrmArtikli kada korisnik u glavnom izborniku pod mogućnosti Sifarnici odabere Artikli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli.FrmArtikli Odabir = new Artikli.FrmArtikli();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        private static volatile bool _shouldStop;

        /// <summary>
        /// Metoda za pozivanje dretve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProdavac_Load(object sender, EventArgs e)
        {
            _shouldStop = false;
            dretvaProjekcije.Start();   
        }

        /// <summary>
        /// Dretva koja provjerava zauzeće projekcija
        /// </summary>
        private static void DretvaProvjeriProjekcije()
        {
            Thread.Sleep(5000);   //odgodimo izvršavanje dretve prilikom pokretanja
            List<int> listaIdPrikazanihProjekcija = new List<int>();

            while (!_shouldStop)
            {
                List<Projekcija> listaPopunjenihProjekcija = Projekcija.ProvjeriProjekcije();
                if (listaPopunjenihProjekcija.Count > 0)
                {
                    foreach (Projekcija projekcija in listaPopunjenihProjekcija)
                    {
                        if (!listaIdPrikazanihProjekcija.Contains(projekcija.IdProjekcije))
                        {
                            listaIdPrikazanihProjekcija.Add(projekcija.IdProjekcije);
                            Film film = Film.DohvatiFilm(projekcija.IdFilma);

                            string poruka = film.Naziv + "\nVrijeme: " + projekcija.Datum + "\nPreostalo sjedala: " + (projekcija.BrojMjesta - projekcija.ProdanoUlaznica).ToString();
                            CustomMessageBox.ShowBox(poruka);
                        }
                    }
                }
                if (!_shouldStop) Thread.Sleep(10000);
            }
            
        }

        /// <summary>
        /// /// Metoda za zatvaranje trenutno otvorene forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProdavac_FormClosed(object sender, FormClosedEventArgs e)
        {
           izlaz = 1;
           if (!pom)
            {
                izlazak();
            } 
        }         
    }
}
