using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indtast navn
            Console.WriteLine("Indtast dit navn");

            String Navn = Console.ReadLine();

            //Oversæt til store bogstaver
            String NavnStoreBogstaver = Navn.ToUpper();

            Console.WriteLine("Du indtastede: " + Navn);
            Console.WriteLine("Oversat til store bogstaver: " + NavnStoreBogstaver);

            Console.ReadKey();
        }
    }
}
