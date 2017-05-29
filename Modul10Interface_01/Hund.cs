using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Interface_01
{
    class Hund: IDbFunktioner
    {
        public string Navn { get; set; }

        //Constructors
        public Hund()
        {
        }

        public Hund(string navn)
        {
            this.Navn = navn;
        }

            public void Gem()
        {
            Console.WriteLine("Her gemmer jeg en Hund: " + this.Navn);
        }

    }
}
