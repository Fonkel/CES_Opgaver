using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07vare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare vare1 = new Vare();
            vare1.Navn = "joggingsko";
            vare1.Pris = 125.75;
            Console.WriteLine("Vare oprettet: " + vare1.Navn + " - " + vare1.Pris + " Pris incl. moms: " + vare1.PrisMedMoms());

            Console.WriteLine(" ");

            Vare vare2 = new Vare("Sko", 75);
            Console.WriteLine("Vare oprettet: " + vare2.Navn + " - " + vare2.Pris + " Pris incl. moms: " + vare2.PrisMedMoms());
        }
    }
}
