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

            string[] split = new string[2];

            samletnavn = fornavn + " " + efternavn;
            navnStort = samletnavn.ToUpper();
            navnlille = samletnavn.ToLower();
            delAfNavn = samletnavn.Substring(3, 4);

            split = samletnavn.Split(' ');

            Console.WriteLine("Fornavn: " + fornavn);
            Console.WriteLine("Efternavn: " + efternavn);
            Console.WriteLine("Samlet navn: " + samletnavn);

            Console.WriteLine("Samlet navn med STORT: " + navnStort);
            Console.WriteLine("Samlet navn med småt: " + navnlille);
            Console.WriteLine("Udpluk af samlet navn: " + delAfNavn);


            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine("Del af navn: " + i + " " + split[i]);


            }

            foreach (var element in split)
            {
                Console.WriteLine("Del af navn: " + element);

            }


            Console.ReadKey();

        }
    }
}
