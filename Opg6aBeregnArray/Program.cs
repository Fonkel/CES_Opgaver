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

            Console.WriteLine("Sum:" + res.sum);
            Console.WriteLine("Gennemsnit:" + res.gennemsnit);

        }
        static ArrayRes BeregnOgSortArray(int[] test) 
        {
            double sum = 0;
            double gns = 0;
            ArrayRes lc_arrayres;

            for (int i = 0; i < test.Length; i++)
            {
                sum = sum + test[i];
            }

            gns = sum / test.Length;
            lc_arrayres.sum = sum;
            lc_arrayres.gennemsnit = gns;

            // Sorter tallene
            Array.Sort(test);

            return lc_arrayres;



        }
    }
}
