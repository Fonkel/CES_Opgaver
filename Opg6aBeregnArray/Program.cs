using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6aBeregnArray
{
    struct ArrayRes
    {
        public double sum;
        public double gennemsnit;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSortArray(test);

            Udskriv();  // blank linje
            Udskriv("Sum:" + res.sum);
            Udskriv();  // blank linje
            Udskriv("Gennemsnit:" + res.gennemsnit);

        }
        static ArrayRes BeregnOgSortArray(int[] test) 
        {
            double sum = 0;
            double gns = 0;
            ArrayRes lc_arrayres;

            Udskriv("FØR sortering"); // Dette er en test
            for (int i = 0; i < test.Length; i++)
            {
                sum = sum + test[i];
                Udskriv("Tal i TEST: " + i + " " + test[i]);
            }

            gns = sum / test.Length;
            lc_arrayres.sum = sum;
            lc_arrayres.gennemsnit = gns;

            Udskriv();  // blank linje

            // Sorter tallene
            Array.Sort(test);

            Udskriv("EFTER sortering"); // Dette er en test
            for (int i = 0; i < test.Length; i++)
            {
                Udskriv("Tal i TEST: " + i + " " + test[i]);

            }

            return lc_arrayres;



        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }


    }
}
