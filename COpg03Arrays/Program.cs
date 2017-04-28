using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COpg03Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maanedsloen = new int[12];
            double sum = 0;

            for (int i = 0; i < maanedsloen.Length; i++)
            {
                maanedsloen[i] = 15000 + (i * 500);
                sum = sum + maanedsloen[i];
                Console.WriteLine("Månedsløn: " + i + " " + maanedsloen[i]);

            }

            Console.WriteLine("Sum månedsløn: " + sum);
            Console.WriteLine("Gennemsnitlig månedsløn: " + (sum / maanedsloen.Length));

            Console.WriteLine("");
            Console.WriteLine("SORT - faldende");

            Array.Reverse(maanedsloen);
            for (int i = 0; i < maanedsloen.Length; i++)
            {
                Console.WriteLine("Månedsløn: " + i + " " + maanedsloen[i]);

            }


            Console.WriteLine("");
            Console.WriteLine("SORT - stigende");
            Array.Sort(maanedsloen);
            for (int i = 0; i < maanedsloen.Length; i++)
            {
                Console.WriteLine("Månedsløn: " + i + " " + maanedsloen[i]);

            }


            Console.ReadKey();



        }
    }
}
