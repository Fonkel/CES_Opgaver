using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Kort
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke kortbunke = new Bunke();
            kortbunke.TilFøjkort(new Kort() { Kulør = "Spar", Værdi = 7 });
            kortbunke.TilFøjkort(new Kort() { Kulør = "Hjerter", Værdi = 10 });
            kortbunke.TilFøjkort(new Kort() { Kulør = "Ruder", Værdi = 1 });
            kortbunke.TilFøjkort(new Kort() { Kulør = "klør", Værdi = 5 });

            kortbunke.vis();
            Console.WriteLine("");
            Console.WriteLine("Et kort trækkes fra bunken");
            Console.WriteLine("");

            var kort = kortbunke.Fjernkort();
            Console.WriteLine("");
            Console.WriteLine("Kortet var: " + kort);

            Console.WriteLine("");
            Console.WriteLine("Og bunken indeholder nu:");
            kortbunke.vis();


            Console.WriteLine("***");
            Console.WriteLine("Tryk en taste");
            Console.ReadKey();

        }
    }
}
