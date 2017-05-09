using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg7Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning terning1 = new Terning();

            Udskriv();  // blank linje
            Udskriv("Terning1 viser: " + terning1.værdi);

            Terning terning2 = new Terning(5);

            Udskriv();  // blank linje
            Udskriv("Terning2 viser: " + terning2.værdi);

            terning2 = terning1;
            Udskriv();  // blank linje
            Udskriv("Terning1 viser: " + terning1.værdi + " Terning2 viser: " + terning2.værdi);

            terning1.værdi = 1;
            Udskriv();  // blank linje
            Udskriv("Terning1 viser: " + terning1.værdi + " Terning2 viser: " + terning2.værdi);

            terning2.værdi = 3;
            Udskriv();  // blank linje
            Udskriv("Terning1 viser: " + terning1.værdi + " Terning2 viser: " + terning2.værdi);
        }


        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }

    }
}
