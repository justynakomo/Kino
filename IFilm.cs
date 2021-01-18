using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    interface IFilm
    {
        void Umiesc(Film t);
        Film Pobierz();
        void Wyczysc();
        int PodajIlosc();
        Film PodajBiezacy();
    }
}
