using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg02_Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delopgave 1
            Console.WriteLine("Delopgave 1");

            int heltal = 10;

            Console.WriteLine("heltal initieret: " + heltal);

            heltal++;

            Console.WriteLine("heltal plus 1: " + heltal);

            heltal--;

            Console.WriteLine("heltal minus 1: " + heltal);

            heltal += 20;

            Console.WriteLine("heltal plus 20: " + heltal);

            // Delopgave 2
            Console.WriteLine(" ");
            Console.WriteLine("Delopgave 2");

            Double kommatal = 12.5;

            Console.WriteLine("heltal initieret: " + kommatal);

            kommatal++;

            Console.WriteLine("heltal plus 1: " + kommatal);

            kommatal--;

            Console.WriteLine("heltal minus 1: " + kommatal);

            kommatal *= 2;

            Console.WriteLine("heltal plus 20: " + kommatal);

            Console.ReadKey();


        }
    }
}
