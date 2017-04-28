using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg02_Variabler
{
    class Program
    {
        // delopgave 3
        public enum filtyper
        {
            csv,
            pdf,
            txt,

        }

        //Delopgave 5
        struct Person
        {
            public int id;
            public string navn;
        }


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

            // Delopgave 3
            Console.WriteLine(" ");
            Console.WriteLine("Delopgave 3");

            filtyper ft = filtyper.csv;

            Console.WriteLine("Filtype - tekst: " + ft);
            Console.WriteLine("Filtype værdi: " + (int)ft);

            // Delopgave 4
            Console.WriteLine(" ");
            Console.WriteLine("Delopgave 4");

            DateTime date = DateTime.Now;

            Console.WriteLine("Dato: " + date);
            Console.WriteLine("Dato: " + date.ToString("ddMMyyyy"));


            // Delopgave 5
            Console.WriteLine(" ");
            Console.WriteLine("Delopgave 4");

            Person pers;

            pers.id = 1;
            pers.navn = "Carsten";

            Console.WriteLine("Id: " + pers.id);
            Console.WriteLine("Navn: " + pers.navn);



            Console.ReadKey();


        }
    }
}
