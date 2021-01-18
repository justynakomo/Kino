using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    public class Sala
    {
        private string nazwaSali;   
        private List<Miejsce> miejsca = new List<Miejsce>();

        public string NazwaSali
        {
            get { return nazwaSali; }
            set { nazwaSali = value; }
        }

        public List<Miejsce> Miejsca => miejsca;

        public Sala()
        { 

		}

        public Sala(string nazwaSali)
        {
            miejsca = new List<Miejsce>(30);
            GenerowanieMiejsc();
            NazwaSali = nazwaSali;
        }

        public override string ToString()
        {
            return "Nazwa sali: " + NazwaSali.ToString();
        }

        public string NazwaSciezki()
        {
            return "NazwaSali_" + NazwaSali.ToString();
        }

        public void GenerowanieMiejsc()
        {
            int totalRow = 3;
            int totalCol = 10;
            for (int i = 0; i < totalRow; i++)
            {
                for (int y = 0; y < totalCol; y++)
                {
                    Miejsca.Add(new Miejsce(i + 1, y + 1));
                }
            }
        }

        public void PrintSeats()
        {
            foreach (var item in miejsca)
            {
                Console.WriteLine($" {miejsca.IndexOf(item) + 1}. Row: {item.Row}. Col: {item.Col}. Status: {item.Status}");
            }
        }

        internal void PrintCompleteSeats()
        {
            Console.WriteLine("Miejsca: " + miejsca.Count+ToString());

            PrintSeats();
        }
    }

}
