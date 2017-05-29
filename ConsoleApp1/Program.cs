using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 

            Run();

            }

            catch (Exception exc)
            {
                Console.WriteLine("Der er sket en uventet fejl - meddelelse: " + exc.Message);
            }
        }

        private static void Run()
        {
            Console.WriteLine("indtast 1. tal:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast 2. tal:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int resultat = tal1 + tal2;
            Console.WriteLine("resultatet er: " + resultat);

        }
    }
}