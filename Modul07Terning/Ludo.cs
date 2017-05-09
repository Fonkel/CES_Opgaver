using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07Terning
{
    class Ludo : Terning
    {
        // hvis værdien af terningen er 3
        public bool erGlobus()
        {
            if (this.Værdi == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // udskriv terningens værdi
        public bool erStjerne()
        {
            if (this.Værdi == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public Ludo(): base()
        {
        }

        public Ludo(int defaultværdi): base(defaultværdi)
        {

        }
    }
}
