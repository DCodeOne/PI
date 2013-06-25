using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Sucelja;

namespace PI_projekt.Artikli
{
    public partial class FrmArtikli : Form
    {
        //postavimo na null i -1 i kasnije kod kreiranja računa ukoliko su te vrijednosti i dalje iste tada nema kupljenih ulaznica
        private List<int> listaIdUlaznica = null;
        private Popust  odabraniPopust = null;
        private float ukupnaCijenaUlaznica = 0;

        /// <summary>
        /// Konstruktor za FrmArtikli ukoliko se pristupa direktno iz izbornika prodavača
        /// </summary>
        public FrmArtikli()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pokretanje forme FrmArtikli
        /// </summary>
        /// <param name="listaIdUlaznicaArg"></param>
        /// <param name="idPopustArg"></param>
        /// <param name="ukupno"></param>
        public FrmArtikli(List<int> listaIdUlaznicaArg, int idPopustArg, float ukupno)
        {
            InitializeComponent();
            odabraniPopust = Popust.DohvatiPopust(idPopustArg);
            listaIdUlaznica = listaIdUlaznicaArg;
            ukupnaCijenaUlaznica = ukupno;
        }

        private float CijenaUkupno = 0;
        private int IdNacinaPlacanja = 1;
        List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
        List<Artikl> listaOdabranihArtikala = new List<Artikl>();
        public List<int> listaKolicina = new List<int>();
        List<NaciniPlacanja> listaNacinaPlacanja = NaciniPlacanja.DohvatiNacinePlacanja();

        /// <summary>
        /// Metoda koja se pokreće kod pokretanja forme (osvježavnjae artikla)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
            foreach (NaciniPlacanja NacinPlacanja in listaNacinaPlacanja)
            {
                cbNacinPlacanja.Items.Add(NacinPlacanja.Naziv);
            }
            cbNacinPlacanja.SelectedIndex = 0;
        }

        /// <summary>
        /// Klikom na gumb dodaju se stavke 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavke();
        }

        /// <summary>
        /// Gumb dalje otvara račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dalje_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenik = Zaposlenici.DohvatiZaposlenika2(Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik);
            if (listaIdUlaznica == null && listaOdabranihArtikala.Count == 0)
            {
                string message = "Unijeli ste račun bez stavki.";
                string caption = "Greška!";
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption);
            }
            else
            {
                Kino.KreirajRacun(zaposlenik.OIB, IdNacinaPlacanja, listaOdabranihArtikala, listaKolicina, listaIdUlaznica, odabraniPopust, ukupnaCijenaUlaznica, CijenaUkupno);
            }
            this.Close();
        }

        /// <summary>
        /// Metoda za osvježavanje liste artikala
        /// </summary>
        private void OsvjeziArtikle()
        {
            foreach (Artikl artikl in listaArtikala)
            {
                cbNaziv.Items.Add(artikl.Naziv);
            }
        }

        /// <summary>
        /// Metoda za daohvaćanje naziva artikla prema ID-u
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCijena.Text = listaArtikala[cbNaziv.SelectedIndex].Cijena.ToString() + " kn";
            numKolicina.Value = 1;
        }

        private int redak = 0;

        /// <summary>
        /// Metoda za dodavanje stavaka
        /// </summary>
        private void DodajStavke()
        {
            try
            {
                bool unosArtikla = true;
                int brojOdabranih = listaOdabranihArtikala.Count();
                for (int i = 0; i < brojOdabranih; i++)
                {
                    if (this.Stavke.Rows[i].Cells[0].Value.ToString() == listaArtikala[cbNaziv.SelectedIndex].Naziv)
                    {
                        int Kolicina = int.Parse(this.Stavke.Rows[i].Cells[2].Value.ToString());
                        Kolicina += (int)numKolicina.Value;
                        this.Stavke.Rows[i].Cells[2].Value = Kolicina;
                        CijenaUkupno += listaArtikala[cbNaziv.SelectedIndex].Cijena * Convert.ToInt32(numKolicina.Value);
                        txtUkupanIznos.Text = CijenaUkupno.ToString() + " kn";
                        listaKolicina[i] = Kolicina;
                        unosArtikla = false;
                    }
                }
                if (unosArtikla)
                {
                    int stupac = 0;
                    this.Stavke.Rows.Add();
                    listaOdabranihArtikala.Add(listaArtikala[cbNaziv.SelectedIndex]);
                    this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[cbNaziv.SelectedIndex].Naziv;
                    this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[cbNaziv.SelectedIndex].Cijena;
                    listaKolicina.Add((int)numKolicina.Value);
                    this.Stavke.Rows[redak++].Cells[stupac].Value = numKolicina.Value;
                    CijenaUkupno += listaArtikala[cbNaziv.SelectedIndex].Cijena * Convert.ToInt32(numKolicina.Value);
                    txtUkupanIznos.Text = CijenaUkupno.ToString() + " kn";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Niste odabrali artikl.");
            }
        }

        /// <summary>
        /// Gumb za poništavanje (pražnjenje) liste odabranih stavki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ponisti_Click(object sender, EventArgs e)
        {
            Stavke.Rows.Clear();
            listaOdabranihArtikala.Clear();
            listaKolicina.Clear();
            redak = 0;
            txtUkupanIznos.Text = "0,00 kn";
            numKolicina.Value = 1;
        }

        /// <summary>
        /// Odabir načina plaćanja prema ID-u selektiranog (naziv)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacinPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NaciniPlacanja nacin in listaNacinaPlacanja)
            {
                if (nacin.Naziv == cbNacinPlacanja.Text)
                {
                    IdNacinaPlacanja = nacin.IdNacinaPlacanja;
                }
            }
        }
    }
}