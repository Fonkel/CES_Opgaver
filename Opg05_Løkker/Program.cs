using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg05_Løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            for (int ix1 = 1; ix1 <= 10; ix1++)
            {
                for (int ix2 = 1; ix2 <= 10; ix2++)
                {
                    result = (ix1 * ix2);
                    if (result > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    } 
                        else
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write( result + "\t");
                }
                Console.WriteLine(" ");

            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" ");
            Console.WriteLine("Tast Enter for at afslutte");
            Console.ReadKey();

        }
    }
}
