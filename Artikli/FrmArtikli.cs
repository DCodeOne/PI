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

        /// <summary>
        /// Konstruktor za FrmArtikli ukoliko se pristupa direktno iz izbornika prodavača
        /// </summary>
        public FrmArtikli()
        {
            InitializeComponent();
        }


        public FrmArtikli(List<int> listaIdUlaznicaArg, int idPopustArg)
        {
            InitializeComponent();
            odabraniPopust = Popust.DohvatiPopust(idPopustArg);
            listaIdUlaznica = listaIdUlaznicaArg;
        }

        private float CijenaUkupno = 0;
        private int IdNacinaPlacanja = 1;
        List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
        List<Artikl> listaOdabranihArtikala = new List<Artikl>();
        public List<int> listaKolicina = new List<int>();
        List<NaciniPlacanja> listaNacinaPlacanja = NaciniPlacanja.DohvatiNacinePlacanja();

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
            foreach (NaciniPlacanja NacinPlacanja in listaNacinaPlacanja)
            {
                nacinPlacanja.Items.Add(NacinPlacanja.Naziv);
            }
            nacinPlacanja.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavke();
        }

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
                Kino.KreirajRacun(zaposlenik.OIB, IdNacinaPlacanja, listaOdabranihArtikala, listaKolicina, listaIdUlaznica, odabraniPopust);
                MessageBox.Show("OIB zaposlenika: " + zaposlenik.OIB.ToString());
            }
        }

        private void OsvjeziArtikle()
        {
            foreach (Artikl artikl in listaArtikala)
            {
                naziv.Items.Add(artikl.Naziv);
            }
        }

        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            jedinicnaCijena.Text = listaArtikala[naziv.SelectedIndex].Cijena.ToString() + " kn";
            kolicinaNum.Value = 1;
        }

        private int redak = 0;
        private void DodajStavke()
        {
            try
            {
                int stupac = 0;
                this.Stavke.Rows.Add();
                listaOdabranihArtikala.Add(listaArtikala[naziv.SelectedIndex]);
                this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[naziv.SelectedIndex].Naziv;
                this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[naziv.SelectedIndex].Cijena;
                listaKolicina.Add((int)kolicinaNum.Value);
                this.Stavke.Rows[redak++].Cells[stupac++].Value = kolicinaNum.Value;
                CijenaUkupno += listaArtikala[naziv.SelectedIndex].Cijena * Convert.ToInt32(kolicinaNum.Value);
                ukupanIznos.Text = CijenaUkupno.ToString() + " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Niste odabrali artikl.");
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            Stavke.Rows.Clear();
            listaOdabranihArtikala.Clear();
            listaKolicina.Clear();
            redak = 0;
            ukupanIznos.Text = "0,00 kn";
            kolicinaNum.Value = 1;
        }

        private void nacinPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NaciniPlacanja nacin in listaNacinaPlacanja)
            {
                if (nacin.Naziv == nacinPlacanja.Text)
                {
                    IdNacinaPlacanja = nacin.IdNacinaPlacanja;
                }
            }
        }             
    }
}
