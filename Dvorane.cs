using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    public class Dvorana
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje mjerne jedinice
        /// </summary>
        public Dvorana()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Artikl.</param>
        public Dvorana(DbDataReader dr)
        {
            if (dr != null)
            {
                BrojDvorane = int.Parse(dr["broj_dvorane"].ToString());
                BrojSjedala = int.Parse(dr["broj_sjedala"].ToString());
                Naziv = dr["naziv"].ToString();

            }

        }

        #endregion

        #region Private Fields

        private int broj_dvorane;
        private int broj_sjedala;
        private string naziv;



        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator dvorane.
        /// </summary>
        public int BrojDvorane
        {
            get
            {
                return broj_dvorane;
            }
            set
            {
                if (broj_dvorane != value)
                {
                    broj_dvorane = value;
                }
            }
        }

        /// <summary>
        /// Ukupni broj sjedala u dvorani
        /// </summary>
        public int BrojSjedala
        {
            get
            {
                return broj_sjedala;
            }
            set
            {
                if (broj_sjedala != value)
                {
                    broj_sjedala = value;
                }
            }
        }

        /// <summary>
        /// Naziv dvorane
        /// </summary>
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }


        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve dvorane i vraća ih u obliku liste
        /// </summary>
        /// <returns>Lista mjernih jedinica</returns>
        public static List<Dvorana> DohvatiDvorane()
        {
            List<Dvorana> lista = new List<Dvorana>();
            string sqlUpit = "SELECT * FROM Dvorana";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Dvorana dvorana = new Dvorana(dr);
                lista.Add(dvorana);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Dohvaća dvoranu s odgovarajućim brojem iz baze podataka 
        /// </summary>
        /// <param name="brojDvorane">Id artikla tipa integer</param>
        /// <returns>Vraća objekt tipa Dvorana ukoliko dvorana postoji u bazi, a ako ne postoji vraća null</returns>
        public static Dvorana DohvatiDvoranu(int brojDvorane)
        {
            Dvorana dvorana = new Dvorana();
            string sqlUpit = "SELECT * FROM Dvorana WHERE broj_dvorane=" + brojDvorane + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                dvorana = new Dvorana(dr);

            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return dvorana;
        }

        /// <summary>
        /// Dodaje novu dvoranu u bazu podataka
        /// </summary>
        /// <param name="novaDvorana">Objekt klase Dvorana sa podacima</param>
        /// <returns>Vraća broj zahvaćeni redova, int</returns>
        public static int DodajDvoranu(Dvorana novaDvorana)
        {

            string sqlUpit = "INSERT INTO Dvorana ('naziv','broj_sjedala') VALUES ('"
                            + novaDvorana.Naziv + "','" + novaDvorana.BrojSjedala + "');";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);

            return izvrsenUpit;
        }

        /// <summary>
        /// Ažurira dvoranu u bazi podataka
        /// </summary>
        /// <param name="dvorana">Objekt klase Dvorana sa novim podacima</param>
        /// <returns>Vraća broj zahvaćeni redova</returns>
        public static int AzurirajDvoranu(Dvorana dvorana)
        {
            string sqlUpit = "UPDATE  Dvorana SET naziv='" + dvorana.Naziv + "' , broj_sjedala=" + dvorana.BrojSjedala
                + " WHERE broj_dvorane=" + dvorana.BrojDvorane + ";";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);

            return izvrsenUpit;
        }


        #endregion
    }
}
