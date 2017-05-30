using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Delegate
{
    class Program
    {

        public delegate int BeregnDelegate(int a, int b);

        static void Main(string[] args)
        {
            int resultat = beregner(1, 1, plus);
            Console.WriteLine(resultat);

            resultat = beregner(1, 1, minus);
            Console.WriteLine(resultat);

            resultat = beregner(2, 3, potens);
            Console.WriteLine(resultat);

            resultat = beregner(17, 4, rest);
            Console.WriteLine(resultat);

        }

        public static int beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }

        //PLUS beregning
        public static int plus(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = ");
            return a + b;
        }

        //MINUS beregning
        public static int minus(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = ");
            return a - b;
        }

        //DIVIDER beregning
        public static int divider(int a, int b)
        {
            Console.WriteLine(a + " / " + b + " = ");
            return a / b;
        }

        //GANGE beregning
        public static int gange(int a, int b)
        {
            Console.WriteLine(a + " * " + b + " = ");
            return a * b;
        }

        //POTENS beregning
        public static int potens(int a, int b)
        {
            double res = 0;
            int p2 = 1;
            int rest = 0;

            Console.WriteLine(a + " ** " + b + " = ");

            res = Math.Pow(a, b);
            p2 = Convert.ToInt32(res);
            res = Math.DivRem(a, b, out rest);
            //for (int ix1 = 1; ix1 <= b; ix1++)

            //{
            //    p2 = p2 * a;
            //}


            return p2;
        }

        //REST ved division beregning
        public static int rest(int a, int b)
        {
            double res = 0;
            int p2 = 1;
            int rest = 0;

            Console.WriteLine(a + " / " + b + " giver rest = ");

            res = Math.DivRem(a, b, out rest);
            p2 = Convert.ToInt32(res);

            return p2;
        }
    }
}
