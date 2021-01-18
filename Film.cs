using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    public class Film
    {
        private string tytul;
        private string rezyser;
        private string rokProdukcji;
        private string krajProdukcji;
        private decimal czasTrwania;

        public string Tytul { get => tytul; set => tytul = value; }
        public string Rezyser { get => rezyser; set => rezyser = value; }
        public string RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public decimal CzasTrwania { get => czasTrwania; set => czasTrwania = value; }
        public string KrajProdukcji { get => krajProdukcji; set => krajProdukcji = value; }

        public Film()
        {

        }

        public Film(string tytul, string rezyser, string rokProdukcji, string krajProdukcji, decimal czasTrwania) : this()
        {
            Tytul = tytul;
            Rezyser = rezyser;
            RokProdukcji = rokProdukcji;
            KrajProdukcji = krajProdukcji;
            CzasTrwania = czasTrwania;
        }

        public override string ToString()
        {
            string zero = CzasTrwania % 60 < 10 ? "0" : "";
            return $"{Tytul}, Reż. {Rezyser}, {RokProdukcji}, {KrajProdukcji}, czas trwania: {(int)(CzasTrwania/60)}:{(CzasTrwania % 60)}"+ zero +" godziny";
        }

        private string KonwertujCzasTrwania() => ((int)( CzasTrwania / 60 )).ToString() + ":" +(CzasTrwania % 60).ToString();

        public string KrotkieInfo()
		{
            string temp = Tytul;
            return temp;
        }

        public string Info()
        {
            string temp = "Tytuł: "+ Tytul + "\n";
            temp += "Reżyser: " + Rezyser + "\n";
            temp += "Rok produkcji: " + RokProdukcji + "\n";
            temp += "Kraj Produkcji: " + KrajProdukcji + "\n";
            temp += "Czas trwania: " + KonwertujCzasTrwania() + "h \n";
            return temp;
        }
    }
}
