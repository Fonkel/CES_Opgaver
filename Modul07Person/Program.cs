using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Fornavn = "Carsten";
            person1.Efternavn = "Sørensen";

            Console.WriteLine("FuldtNavn (Metode) = " + person1.FuldtNavn());
            Console.WriteLine("FuldeNavn (property) = " + person1.FuldeNavn);
        }
    }
}
