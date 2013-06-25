using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad sa podacima o artiklima
    /// </summary>
    public class Artikl
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje artikla.
        /// </summary>
        public Artikl()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Artikl.</param>
        public Artikl(DbDataReader dr)
        {
            if (dr != null)
            {
                IdArtikla = int.Parse(dr["id_artikla"].ToString());
                Naziv = dr["naziv"].ToString();
                Cijena = float.Parse(dr["cijena"].ToString());
                IdMjerneJedinice = int.Parse(dr["id_mjerne_jedinice"].ToString());
            }
        }

        #endregion

        #region Private Fields

        private int id_artikla;
        private string naziv;
        private float cijena;
        private int id_mjerne_jedinice;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator artikla.
        /// </summary>
        public int IdArtikla
        {
            get
            {
                return id_artikla;
            }
            set
            {
                if (id_artikla != value)
                {
                    id_artikla = value;
                }
            }
        }

        /// <summary>
        /// Naziv artikla.
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

        /// <summary>
        /// Cijena artikla.
        /// </summary>
        public float Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if (cijena != value)
                {
                    cijena = value;
                }
            }
        }

        /// <summary>
        /// Mjerna jedinica artikla (vanjski ključ).
        /// </summary>
        public int IdMjerneJedinice
        {
            get
            {
                return id_mjerne_jedinice;
            }
            set
            {
                if (id_mjerne_jedinice != value)
                {
                    id_mjerne_jedinice = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metoda koja dohvaća sve artikle iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista artikala.</returns>
        public static List<Artikl> DohvatiArtikle()
        {
            List<Artikl> lista = new List<Artikl>();
            string sqlUpit = "SELECT * FROM Artikl";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikl artikl = new Artikl(dr);
                lista.Add(artikl);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Metoda koja dohvaća artikl iz sa odgovarajućim id-em iz baze podataka 
        /// </summary>
        /// <param name="idArtikla">Id artikla tipa integer</param>
        /// <returns>Vraća objekt tipa Artikli ukoliko artikl postoji u bazi, a ako ne postoji vraća null</returns>
        public static Artikl DohvatiArtikl(int idArtikla)
        {
            Artikl artikl = new Artikl();
            string sqlUpit = "SELECT * FROM Artikl WHERE id_artikla="+idArtikla+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                artikl = new Artikl(dr);
                
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return artikl;
        }

        /// <summary>
        /// Metoda koja dodaje novi artikl u bazu
        /// </summary>
        /// <param name="noviArtikl">Objekt klase artikl</param>
        /// <returns>Vraća int, broj zahvaćenih redova upitom</returns>
        public static int DodajArtikl(Artikl noviArtikl)
        {
            
            string sqlUpit = "INSERT INTO Artikl ('naziv','cijena','id_mjerne_jedinice') VALUES ('" 
                            + noviArtikl.Naziv + "','"+Kino.PretvoriCijenu(noviArtikl.Cijena)+"', '"+noviArtikl.IdMjerneJedinice+"');";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);

            return izvrsenUpit;
        }

        /// <summary>
        /// Metoda koja ažurira artikl u bazi podakaka
        /// </summary>
        /// <param name="artikl">Objekt klase Artikl</param>
        /// <returns>Broj zahvaćenih redova</returns>
        public static int AzurirajArtikl(Artikl artikl)
        {
            string sqlUpit = "UPDATE Artikl SET naziv='" + artikl.Naziv + "' , cijena='" + Kino.PretvoriCijenu(artikl.Cijena)
                + "' ,id_mjerne_jedinice=" + artikl.IdMjerneJedinice + " WHERE id_artikla=" + artikl.IdArtikla + ";";
            int izvrsenUpit = DB.Instance.IzvrsiUpit(sqlUpit);

            return izvrsenUpit;
        }
        #endregion
    }
}
