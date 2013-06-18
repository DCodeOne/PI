using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Popust
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje popusta
        /// </summary>
        public Popust()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Artikl.</param>
        public Popust(DbDataReader dr)
        {
            if (dr != null)
            {
                IdPopusta = int.Parse(dr["id_popusta"].ToString());
                PopustPostotak = float.Parse(dr["popust"].ToString());
                Naziv = dr["naziv"].ToString();

            }

        }

        #endregion

        #region Private Fields

        private int id_popusta;
        private float popustPostotak;
        private string naziv;



        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator popusta
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

        /// <summary>
        /// Ukupni popust u postotcima
        /// </summary>
        public float PopustPostotak
        {
            get
            {
                return popustPostotak;
            }
            private set
            {
                if (popustPostotak != value)
                {
                    popustPostotak = value;
                }
            }
        }

        /// <summary>
        /// Naziv popusta
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
        /// Dohvaća sve popuste
        /// </summary>
        /// <returns>Lista mjernih jedinica</returns>
        public static List<Popust> DohvatiPopuste()
        {
            List<Popust> lista = new List<Popust>();
            string sqlUpit = "SELECT * FROM Popust";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Popust popust = new Popust(dr);
                lista.Add(popust);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

       

        #endregion
    }
}
