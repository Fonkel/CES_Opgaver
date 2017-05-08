using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 31.415
            Udskriv();  // blank linje

            Udskriv("Dette er en test"); // Dette er en test
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);    // 25.0875
                                        //                                // Optional parameter
            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4);    // 25.0875
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);     // 15.000

        }


        //Udskriv summen af to tal
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        // Beregn areal af en cirkel med angivet radius
        static double BeregnAreal(int a)
        {
            return (a * a) * Math.PI;
        }
        
        
        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst) ;
        }

        // Beregn Moms
        static double BeregnMoms(double beloeb, double momssats = 0.25)
        {
            return (beloeb*25) / 100;
        }

        // Beregn gennemsnitsløn
        static double Gennemsnit(int[]løn)
        {
            double sum = 0;

            for (int i = 0; i < løn.Length; i++)
            {
                sum = sum + løn[i];
            }

            return sum / løn.Length;

        }


    }

}
