using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07PersonNedarv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret et objekt af Superklassen Person
            Person person1 = new Person();

            person1.Fornavn = "Carsten";
            person1.Efternavn = "Sørensen";

            Console.WriteLine("Person - FuldtNavn (Metode) = " + person1.FuldtNavn());

            // Opret et objekt af den nedarvede klasse Elev
            Elev elev1 = new Elev() { Efternavn = "Sørensen", Fornavn = "Carsten", Klasselokale = "Rum 3" };
            Console.WriteLine("Elev - FuldtNavn (Metode) = " + elev1.FuldtNavn() + " Lokale: " + elev1.Klasselokale);

            // Opret et objekt af den nedarvede klasse Instruktør
            Instruktør instruktør1 = new Instruktør() { Efternavn = "Cronberg", Fornavn = "Michell", NøgleId = 7 };
            Console.WriteLine("Instruktør - FuldtNavn (Metode) = " + instruktør1.FuldtNavn() + " har NøgleID: " + instruktør1.NøgleId);



        }
    }
}
