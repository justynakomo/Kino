using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    struct MojeBazy
    {
        public static Film PrzykladowyFilm(int x)
        {
            BazaFilmow b = new BazaFilmow();

            Film f0 = new Film("Pewnego razu w Hollywood", "Quentin Tarantino", "2019", "USA/UK", 161);
            Film f1 = new Film("Pulp Fiction", "Quentin Tarantino", "2019", "USA/UK", 161);
            Film f2 = new Film("Avatar", "James Cameron", "2009", "USA/UK", 162);
            Film f3 = new Film("Niebo o północy", "George Clooney", "2020", "USA", 122);

            b.Umiesc(f0);
            b.Umiesc(f1);
            b.Umiesc(f2);
            b.Umiesc(f3);

            return b.ListaWiazanaFilmow[x];
        }

        public static Sala PrzykladowaSala(int x)
        {
            ListaSal l = new ListaSal();

            Sala s1 = new Sala("Akcja");
            Sala s2 = new Sala("Dzieciece");
            Sala s3 = new Sala("Fantasy");
            Sala s4 = new Sala("Horror");
            Sala s5 = new Sala("Komedie");

            l.Umiesc(s1);
            l.Umiesc(s2);
            l.Umiesc(s3);
            l.Umiesc(s4);
            l.Umiesc(s5);

            return l.Sale[x]; 
        }

        public static DateTime PrzykladowaData(int x)
		{
            DateTime[] data = new DateTime[10];
            //rok, miesiąc, dzien, godzina, minuta, sekunda 
            DateTime dzis = DateTime.Today;
            data[0] = new DateTime(dzis.Year, dzis.Month, dzis.Day, 13, 30, 00 );
            data[1] = new DateTime(dzis.Year, dzis.Month, dzis.Day+1, 18, 30, 00 );
            data[2] = new DateTime(dzis.Year, dzis.Month, dzis.Day+2, 16, 30, 00 );
            data[3] = new DateTime(dzis.Year, dzis.Month, dzis.Day+3, 14, 30, 00 );
            data[4] = new DateTime(dzis.Year, dzis.Month, dzis.Day+4, 11, 30, 00 );

            return data[x];
		}

        public static Seans PrzykladowySeans(int x)
		{
            Seans[] seans = new Seans[10];
            seans[0] = new Seans(Tools.WyciagnijGodzine(PrzykladowaData(1)), PrzykladowyFilm(1), PrzykladowaSala(0));
            seans[1] = new Seans(Tools.WyciagnijGodzine(PrzykladowaData(2)), PrzykladowyFilm(1), PrzykladowaSala(0));
            seans[2] = new Seans(Tools.WyciagnijGodzine(PrzykladowaData(3)), PrzykladowyFilm(2), PrzykladowaSala(1));
            seans[3] = new Seans(Tools.WyciagnijGodzine(PrzykladowaData(4)), PrzykladowyFilm(3), PrzykladowaSala(3));
        
            return seans[x];
		}

        public static List<Repertuar> MojeRepertuary()
		{
            List<Repertuar> repertuary = new List<Repertuar>();
            Repertuar temp = new Repertuar(Tools.WyciagnijDate(PrzykladowaData(0)));
            repertuary.Add(temp);
            temp.DodajSeans(PrzykladowySeans(1));
            temp.DodajSeans(PrzykladowySeans(2));
            temp.DodajSeans(PrzykladowySeans(3));

            temp = new Repertuar(Tools.WyciagnijDate(PrzykladowaData(1)));
            repertuary.Add(temp);
            temp.DodajSeans(PrzykladowySeans(0));
            temp.DodajSeans(PrzykladowySeans(1));
            temp.DodajSeans(PrzykladowySeans(2));

            temp = new Repertuar(Tools.WyciagnijDate(PrzykladowaData(2)));
            repertuary.Add(temp);
            temp.DodajSeans(PrzykladowySeans(2));
            temp.DodajSeans(PrzykladowySeans(1));
            temp.DodajSeans(PrzykladowySeans(2));
            temp.DodajSeans(PrzykladowySeans(3));
            temp.DodajSeans(PrzykladowySeans(0));

            temp = new Repertuar(Tools.WyciagnijDate(PrzykladowaData(3)));
            repertuary.Add(temp);
            temp.DodajSeans(PrzykladowySeans(0));
            temp.DodajSeans(PrzykladowySeans(1));
            temp.DodajSeans(PrzykladowySeans(2));
            temp.DodajSeans(PrzykladowySeans(3));

            return repertuary;
        }
    }
}
