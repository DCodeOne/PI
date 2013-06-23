using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class RacunArtikl
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za RacunArtikl
        /// </summary>
        public RacunArtikl()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za stavke_racuna.</param>
        public RacunArtikl(DbDataReader dr)
        {
            if (dr != null)
            {
                IdRacuna = int.Parse(dr["id_racuna"].ToString());
                IdArtikla = int.Parse(dr["id_artikla"].ToString());
                Kolicina = int.Parse(dr["kolicina"].ToString());
            }

        }

        #endregion

        #region Private Fields

        private int id_racuna;
        private int id_artikla;
        private int kolicina;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator računa
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
        /// Jedinstveni identifikator artikla
        /// </summary>
        public int IdArtikla
        {
            get
            {
                return id_artikla;
            }
            private set
            {
                if (id_artikla != value)
                {
                    id_artikla = value;
                }
            }
        }

        /// <summary>
        /// Količina (artikala)
        /// </summary>
        public int Kolicina
        {
            get
            {
                return kolicina;
            }
            private set
            {
                if (kolicina != value)
                {
                    kolicina = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća stavke svih računa
        /// </summary>
        /// <returns>Lista stavki svih računa (artikli)</returns>
        public static List<RacunArtikl> DohvatiSveRacunArtikl()
        {
            List<RacunArtikl> lista = new List<RacunArtikl>();
            string sqlUpit = "SELECT * from stavka_racuna;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RacunArtikl artikl = new RacunArtikl(dr);
                lista.Add(artikl);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća stavke (artikle) za određeni račun
        /// </summary>
        /// <param name="idRacuna">Id računa za kojeg se dohvaćaju sve stavke</param>
        /// <returns></returns>
        public static List<RacunArtikl> DohvatiSveRacunArtikl(int idRacuna)
        {
            List<RacunArtikl> lista = new List<RacunArtikl>();
            string sqlUpit = "SELECT * from stavke_racuna WHERE id_racuna=" + idRacuna + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RacunArtikl artikl = new RacunArtikl(dr);
                lista.Add(artikl);
            }
            dr.Close();
            return lista;
        }

        public static void UnesiRacunArtikl(int IdRacuna, int IdArtikla, int Kolicina)
        {
            string sqlUpit = "INSERT INTO stavka_racuna VALUES (" + IdRacuna + ", " + IdArtikla + ", " + Kolicina + ");";
            int idRacuna = DB.Instance.IzvrsiUpitID(sqlUpit);
        }

        #endregion
    }
}
