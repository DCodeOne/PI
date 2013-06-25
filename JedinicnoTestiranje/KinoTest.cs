using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class KinoTest
    {
        [TestMethod]
        public void IzracunajPopustTest()
        {
            //Testiranje slučaja kada je količina nula
            int kolicina = 0;
            float cijena = (float)12.99;
            float popust = (float)0.19;

            List<decimal> listaPopust = PI_projekt.Kino.IzracunajPopust(kolicina, cijena, popust);

            Assert.AreEqual(-1, listaPopust[0], "Suma nije točna!");
            Assert.AreEqual(-1, listaPopust[1], "Postotak nije točan!");
            Assert.AreEqual(-1, listaPopust[2], "Ukupna cijena nije točna!");

            //Testiranje slučaja kada je popust negativan broj
            kolicina = 2;
            cijena = (float)12.99;
            popust = (float)-0.19;
            List<decimal> listaPopust2 = PI_projekt.Kino.IzracunajPopust(kolicina, cijena, popust);

            Assert.AreEqual(-1, listaPopust2[0], "Suma nije točna!");
            Assert.AreEqual(-1, listaPopust2[1], "Postotak nije točan!");
            Assert.AreEqual(-1, listaPopust2[2], "Ukupna cijena nije točna!");

            //Testiranje slučaja kada je cijena negativan broj
            kolicina = 2;
            cijena = (float)-12.99;
            popust = (float)0.19;
            List<decimal> listaPopust3 = PI_projekt.Kino.IzracunajPopust(kolicina, cijena, popust);

            Assert.AreEqual(-1, listaPopust3[0], "Suma nije točna!");
            Assert.AreEqual(-1, listaPopust3[1], "Postotak nije točan!");
            Assert.AreEqual(-1, listaPopust3[2], "Ukupna cijena nije točna!");

            //Testiranje slučaja kada popust nula
            kolicina = 2;
            cijena = (float)12.99;
            popust = (float)0.00;
            List<decimal> listaPopust4 = PI_projekt.Kino.IzracunajPopust(kolicina, cijena, popust);



            Assert.AreEqual((decimal)25.98, listaPopust4[0], "Suma nije točna!");
            Assert.AreEqual(0, listaPopust4[1], "Postotak nije točan!");
            Assert.AreEqual((decimal)25.98, listaPopust4[2], "Ukupna cijena nije točna!");

            //Testiranje valjanog slučaja
            kolicina = 5;
            cijena = (float)12.60;
            popust = (float)0.20;
            List<decimal> listaPopust5 = PI_projekt.Kino.IzracunajPopust(kolicina, cijena, popust);

            Assert.AreEqual((decimal)63, listaPopust5[0], "Suma nije točna!");
            Assert.AreEqual(20, listaPopust5[1], "Postotak nije točan!");
            Assert.AreEqual((decimal)50.4, listaPopust5[2], "Ukupna cijena nije točna!");
        }


        [TestMethod]
        public void PretvoriCijenuTest()
        {
            float cijena = float.Parse("22,16");
            float cijena2 = float.Parse("13,9");
            float cijena3 = float.Parse("0,0");
            float cijena4 = float.Parse("10,55");

            string povratnaCijena1 = PI_projekt.Kino.PretvoriCijenu(cijena);
            Assert.AreEqual("22.16", povratnaCijena1, "Parsiranje cijene nije točno!");

            string povratnaCijena2 = PI_projekt.Kino.PretvoriCijenu(cijena2);
            Assert.AreEqual("13.9", povratnaCijena2, "Parsiranje cijene nije točno!");

            string povratnaCijena3 = PI_projekt.Kino.PretvoriCijenu(cijena3);
            Assert.AreEqual("0", povratnaCijena3, "Parsiranje cijene nije točno!");

            string povratnaCijena4 = PI_projekt.Kino.PretvoriCijenu(cijena4);
            Assert.AreEqual("10.55", povratnaCijena4, "Parsiranje cijene nije točno!");


        }


        [TestMethod]
        public void ProvjeriKorisnikaTest()
        {
            string korisnickoIme1 = "";
            string lozinka1 = "12341";

            int provjera1 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme1, lozinka1);
            Assert.AreEqual(-1, provjera1, "Provjera korisničkog imena i lozinke nije valjana!");

            string korisnickoIme2 = "admin";
            string lozinka2 = "";

            int provjera2 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme2, lozinka2);
            Assert.AreEqual(-2, provjera2, "Provjera korisničkog imena i lozinke nije valjana!");

            string korisnickoIme3 = "admin23";
            string lozinka3 = "admin";

            int provjera3 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme3, lozinka3);
            Assert.AreEqual(-1, provjera3, "Provjera korisničkog imena i lozinke nije valjana!");

            string korisnickoIme4 = "admin";
            string lozinka4 = "admin";

            int provjera4 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme4, lozinka4);
            Assert.AreEqual(2, provjera4, "Provjera korisničkog imena i lozinke nije valjana!");

            string korisnickoIme5 = "user";
            string lozinka5 = "user";

            int provjera5 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme5, lozinka5);
            Assert.AreEqual(1, provjera5, "Provjera korisničkog imena i lozinke nije valjana!");

            string korisnickoIme6 = "";
            string lozinka6 = "";

            int provjera6 = PI_projekt.Kino.ProvjeriKorisnika(korisnickoIme6, lozinka6);
            Assert.AreEqual(-1, provjera6, "Provjera korisničkog imena i lozinke nije valjana!");

        }


        [TestMethod]
        public void PretvoriDatumTest()
        {
            DateTime datum1 = DateTime.Parse("26.06.2013. 12:00:12");
            string datum1Povratna = PI_projekt.Kino.PretvoriDatum(datum1);

            Assert.AreEqual("2013-06-26 12:00:12", datum1Povratna, "Datum nije pravilno parsiran!");

            DateTime datum2 = DateTime.Parse("1.1.2000. 00:00:00");
            string datum2Povratna = PI_projekt.Kino.PretvoriDatum(datum2);

            Assert.AreEqual("2000-01-01 00:00:00", datum2Povratna, "Datum nije pravilno parsiran!");
        }


    }
}
