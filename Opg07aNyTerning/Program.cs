using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07aNyTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning terning1 = new Terning();

            Udskriv();  // blank linje
            terning1.Skriv();
            terning1.Ryst();
            terning1.Skriv();
            // Her kalder jeg terning med Snyd = True ==> ALTID en 6 efter Ryst!!
            Terning terning2 = new Terning(true);

            Udskriv();  // blank linje
            terning2.Skriv();
            terning2.Ryst();
            terning2.Skriv();

        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }

    }
}
