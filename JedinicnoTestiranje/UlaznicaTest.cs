using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class UlaznicaTest
    {
        [TestMethod]
        public void UnesiUlaznicuTest()
        {
            PI_projekt.Ulaznice ulaznica = new PI_projekt.Ulaznice();
            PI_projekt.Projekcija projekcija = new PI_projekt.Projekcija();

            //Dohvatimo projekciju iz baze 
            projekcija = PI_projekt.Projekcija.DohvatiProjekciju(6);

            //Spremimo broj prodanih ulaznica
            int prodaneUlaznicePrije = projekcija.ProdanoUlaznica;

            //Unesemo ulaznicu u bazu
            int idUlaznice = PI_projekt.Ulaznice.UnesiUlaznicu(6, 6);

            //Ponovno dohvatimo projekciju nakon unosa
            projekcija = PI_projekt.Projekcija.DohvatiProjekciju(6);

            //Spremimo broj ulaznica poslije unosa
            int prodanoUlaznicaPoslije = projekcija.ProdanoUlaznica;


            Assert.AreEqual(prodaneUlaznicePrije + 1, prodanoUlaznicaPoslije, "Trigger ne povećava vrijednost!");

            //Vraćamo početno stanje prodanih ulaznica
            string sqlUpit = "UPDATE Projekcija SET prodano_ulaznica=prodano_ulaznica-1 WHERE id_projekcije=6;";
            PI_projekt.DB.Instance.IzvrsiUpitID(sqlUpit);

            //brišemo unesenu ulaznicu
            PI_projekt.Ulaznice.IzbrisiUlaznicu(idUlaznice);

        }
    }
}
