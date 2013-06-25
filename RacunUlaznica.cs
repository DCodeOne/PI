using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad računima i ulaznicama
    /// </summary>

    class RacunUlaznica
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za racuna ulaznice
        /// </summary>
        public RacunUlaznica()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public RacunUlaznica(DbDataReader dr)
        {
            if (dr != null)
            {
                IdRacuna= int.Parse(dr["id_racuna"].ToString());
                IdUlaznice= int.Parse(dr["id_karte"].ToString());
                IdPopusta = int.Parse(dr["id_popusta"].ToString()); 
            }

        }

        #endregion

        #region Private Fields

        private int id_racuna;
        private int id_ulaznice;
        private int id_popusta;
     
        #endregion

        #region Properties


        
        /// <summary>
        /// Jedinstveni identifikator ulaznice
        /// </summary>
        public int IdUlaznice
        {
            get
            {
                return id_ulaznice;
            }
            private set
            {
                if (id_ulaznice != value)
                {
                    id_ulaznice = value;
                }
            }
        }

        /// <summary>
        /// Jedinstveni računa
        /// </summary>
        public int IdRacuna
        {
            get
            {
                return id_racuna;
            }
            private set
            {
                if (id_racuna != value)
                {
                    id_racuna = value;
                }
            }
        }
        /// <summary>
        /// Popust
        /// </summary>
        public int IdPopusta
        {
            get
            {
                return id_popusta;
            }
            private set
            {
                if (id_popusta != value)
                {
                    id_popusta = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metoda koja dohvaća stavke svih ulaznica
        /// </summary>
        /// <returns>Lista stavki svih racun ulaznica</returns>
        public static List<RacunUlaznica> DohvatiSveRacunUlaznica()
        {
            List<RacunUlaznica> lista = new List<RacunUlaznica>();
            string sqlUpit = "SELECT * from racun_karta;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RacunUlaznica ulaznica = new RacunUlaznica(dr);
                lista.Add(ulaznica);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Metoda koja dohvaća račun__ulaznica za određenu ulaznicu
        /// </summary>
        /// <returns>Lista stavki svih racun ulaznica</returns>
        public static RacunUlaznica DohvatiRacunUlaznica(int idUlaznice)
        {
            RacunUlaznica racunUlaznica = new RacunUlaznica();
            string sqlUpit = "SELECT * from racun_karta WHERE id_karte="+idUlaznice+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                racunUlaznica = new RacunUlaznica(dr);
               
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return racunUlaznica;
        }
        /// <summary>
        /// Metoda koja dohvaća stavke svih ulaznica za određeni račun
        /// </summary>
        /// <param name="idRacuna">Id računa za kojeg se dohvacaju sve stavke ulaznica</param>
        /// <returns></stavke ulaznica za račun>
        public static List<RacunUlaznica> DohvatiSveRacunUlaznica(int idRacuna)
        {
            List<RacunUlaznica> lista = new List<RacunUlaznica>();
            string sqlUpit = "SELECT * from racun_karta WHERE id_racuna="+idRacuna+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RacunUlaznica ulaznica = new RacunUlaznica(dr);
                lista.Add(ulaznica);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Metoda koja unosi račune, ulaznice i popust
        /// </summary>
        /// <param name="IdRacuna"></param>
        /// <param name="IdKarte"></param>
        /// <param name="Popust"></param>
        public static void UnesiRacunUlaznica(int IdRacuna, int IdKarte, int Popust)
        {
            string sqlUpit = "INSERT INTO racun_karta VALUES (" + IdRacuna + ", " + IdKarte + ", " + Popust + ");";
            int idRacuna = DB.Instance.IzvrsiUpitID(sqlUpit);
        }
        
        #endregion
    }
}
