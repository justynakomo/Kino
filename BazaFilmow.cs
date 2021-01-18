using System;
using System.Collections.Generic;

namespace po
{
    public class BazaFilmow
    {
        private int iloscFilmow;
        List<Film> listaFilmow;

        public int IloscFilmow { get => iloscFilmow; set => iloscFilmow = value; }
        internal List<Film> ListaWiazanaFilmow { get => listaFilmow; set => listaFilmow = value; }

        public BazaFilmow()
        {
            iloscFilmow = 0;
            listaFilmow = new List<Film>();
        }

        public Film Usun(int x = 0)
        {
            if (iloscFilmow == 0)
            {
                throw new Exception();
            }

            iloscFilmow--;
            Film temp = new Film();
            listaFilmow.RemoveAt(x);
            return temp;
        }

        public int PodajIlosc()
        {
            return listaFilmow.Count;
        }

        public void Umiesc(Film t)
        {
            iloscFilmow++;
            listaFilmow.Add(t);
        }

        public void Wyczysc()
        {
            listaFilmow.Clear();
        }
    }
}
