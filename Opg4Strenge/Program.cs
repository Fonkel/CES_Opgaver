using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg4Strenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Carsten";
            string efternavn = "Sørensen";
            string samletnavn;
            string navnStort;
            string navnlille;
            string delAfNavn;

            samletnavn = fornavn + " " + efternavn;
            navnStort = samletnavn.ToUpper();
            navnlille = samletnavn.ToLower();
            delAfNavn = samletnavn.Substring(3, 4);

            Console.WriteLine("Fornavn: " + fornavn);
            Console.WriteLine("Efternavn: " + efternavn);
            Console.WriteLine("Samlet navn: " + samletnavn);

            Console.WriteLine("Samlet navn med STORT: " + navnStort);
            Console.WriteLine("Samlet navn med småt: " + navnlille);
            Console.WriteLine("Udpluk af samlet navn: " + delAfNavn);
            

            Console.ReadKey();

        }
    }
}
