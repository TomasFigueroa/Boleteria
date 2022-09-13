using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Ticket
    {
        private int ctdPlatea;
        private int ctdPopularSur;
        private int ctdPopularNorte;

        const int VALOR_PLATEA = 5000;
        const int VALOR_SUR = 3500;
        const int VALOR_NORTE = 2500;



        public Ticket()
        {

        }

        public int CtdPlatea { get; set; }

        public int CtdPopularSur { get; set; }

        public int CtdPopularNorte { get; set; }

        public int Calcular()
        {

            int total = 0;
            total = (CtdPlatea * VALOR_PLATEA) + (CtdPopularNorte * VALOR_NORTE) + (CtdPopularSur * VALOR_SUR);


            return total;

        }

    }
}
