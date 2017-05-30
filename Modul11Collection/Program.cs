using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // generisk liste der arbejder med Person objecter
            Console.WriteLine("generisk liste der arbejder med Person objecter");

            List<Person> personer = new List<Person>();
            personer.Add(new Person { Id = 020250, Navn = "Ole Olsen" });
            personer.Add(new Person { Id = 281061, Navn = "Carsten Sørensen" });
            personer.Add(new Person { Id = 190263, Navn = "Marianne Axelsen" });

            foreach (var person in personer)
            {
                Console.WriteLine("Person med ID = " + person.Id + " hedder: " + person.Navn);
            }

            Console.WriteLine("");
            Console.WriteLine("Efter sortering");

            personer.Sort();
            foreach (var person in personer)
            {
                Console.WriteLine("Person med ID = " + person.Id + " hedder: " + person.Navn);
            }


            Console.WriteLine("");
            Console.WriteLine("generisk Dictionary der arbejder med Person objecter");

            // generisk Dictionary der arbejder med Person objecter
            Dictionary<int, Person> personer2 = new Dictionary<int, Person>();
            personer2.Add(1, new Person { Id = 020250, Navn = "Ole Olsen" });
            personer2.Add(2, new Person { Id = 281061, Navn = "Carsten Sørensen" });
            personer2.Add(3, new Person { Id = 190263, Navn = "Marianne Axelsen" });


            for (int ix1 = 1; ix1 <= personer2.Count; ix1++)

            {
                var p2 = personer2[ix1];
                Console.WriteLine("Række: " + ix1 + "Person med ID = " + p2.Id + " hedder: " + p2.Navn);
            }

            
            Console.WriteLine("Tryk en taste");
            Console.ReadKey();


        }
    }
}
