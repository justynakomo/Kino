using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{ 
    public enum StanMiejsca
    {
        Pusty, Zarezerwowany
    }

    public class Miejsce
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public StanMiejsca Status { get; set; }

        public Miejsce()
		{

		}

        public Miejsce(int row, int col)
        {
            Row = row;
            Col = col;
			Status = StanMiejsca.Pusty;
        }

        public void ZakupMiejsce()
		{
            Status = StanMiejsca.Zarezerwowany;
        }
    }
}
