using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning terning1 = new Terning();

            terning1.Skriv();
            terning1.Ryst();
            terning1.Skriv();

            Udskriv();

            Terning terning2 = new Terning(3);
            terning2.Skriv();
            terning2.Ryst();
            terning2.Skriv();

            Udskriv();
            Udskriv("Nu spiller vi LUDO");

            Ludo ludo1 = new Ludo();
            ludo1.Skriv();
            //symbol(ludo1.erGlobus(), ludo1.erStjerne());

            ludo1.Ryst();

            ludo1.Skriv();
            //symbol(ludo1.erGlobus(), ludo1.erStjerne());



        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        //static void symbol(bool gl, bool st)
        //{
        //    if (gl == true)
        //    {
        //        Udskriv("Det svarer til at slå Globus");
        //    }
        //    else
        //    if (st == true)
        //    {
        //        Udskriv("Det svarer til at slå Stjerne");
        //    }
        //}

    }
}
