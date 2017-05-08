using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6bOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(1, 2);

            Udskriv();  // blank linje
            Udskriv("Sum:" + res);

            res = LægSammen(1, 2, 3);

            Udskriv();  // blank linje
            Udskriv("Sum:" + res);

            res = LægSammen(1, 2, 3, 4 );

            Udskriv();  // blank linje
            Udskriv("Sum:" + res);
        }

        //Udskriv summen af to tal
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static int LægSammen(int a, int b, int c)
        {
            int res = LægSammen(a, b);

            return LægSammen(res, c);
        }

        static int LægSammen(int a, int b, int c, int d)
        {
            int res = LægSammen(a, b, c);
            return LægSammen(res, d);
        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }

    }
}
