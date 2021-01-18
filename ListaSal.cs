using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    class ListaSal :IListaSal
    {
        private int liczbaSal;
        private List<Sala> sale = new List<Sala>();

        public int LiczbaSal { get => liczbaSal; set => liczbaSal = value; }
        internal List<Sala> Sale { get => sale; set => sale = value; }

        public ListaSal()
        {
            LiczbaSal = 0;

        }

        public void Umiesc(Sala s)
        {
            LiczbaSal++;
            sale.Add(s);
        }

        public void Wyczysc()
        {
            sale.Clear();
        }

        public int IloscSal()
        {
            return sale.Count();
        }

        
    }
}
