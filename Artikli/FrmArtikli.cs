using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Artikli
{
    public partial class FrmArtikli : Form
    {
        public FrmArtikli()
        {
            InitializeComponent();
        }
        private float CijenaUkupno = 0;
        List<Artikl> listaArtikala = Artikl.DohvatiArtikle();

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavke();
        }

        private void Dalje_Click(object sender, EventArgs e)
        {

        }

        private void OsvjeziArtikle()
        {
            int brojac = 0;
            foreach (Artikl Id in listaArtikala)
            {
                Naziv.Items.Add(listaArtikala[brojac].Naziv);
                brojac++;
            }
        }

        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cijena_box.Text = listaArtikala[Naziv.SelectedIndex].Cijena.ToString() + " kn";
        }

        private void DodajStavke()
        {
            try
            {
                Stavke.Text += listaArtikala[Naziv.SelectedIndex].Naziv + "\t Cijena: " + listaArtikala[Naziv.SelectedIndex].Cijena + "\t Količina:" + KolicinaBox.Text + "\r\n";
                CijenaUkupno += listaArtikala[Naziv.SelectedIndex].Cijena * Convert.ToInt32(KolicinaBox.Text);
                Ukupno.Text = CijenaUkupno.ToString() + " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Niste odabrali artikl.");
            }
        }

        private void KolicinaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(KolicinaBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Količina ne smije biti slovo. Unesite broj.");
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            Stavke.Text = "";
            Ukupno.Text = "0,00 kn";
        }
    }
}
