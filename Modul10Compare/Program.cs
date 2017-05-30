using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Compare
{
    class program
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[3];

            logger.Trace("Her starter vi");

            hunde[0] = new Hund() { Alder = 10, Navn = "Rollo" };
            hunde[1] = new Hund() { Alder = 7, Navn = "Abott" };
            hunde[2] = new Hund() { Alder = 15, Navn = "King" };

            logger.Trace("Her sorterer vi");
            Array.Sort(hunde);

            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            logger.Trace("Her slutter vi");

            Console.ReadKey();

        }

        class Hund : IComparable

        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            public int CompareTo(object obj)
            //{
            //    Hund h = obj as Hund;
            //    if (h.Alder < this.Alder)
            //        return -1;
            //    if (h.Alder > this.Alder)
            //        return 1;

            //    return 0;
            //}
            //public int CompareTo(object obj)
            {
                int i = 0;
                Hund h = obj as Hund;

                i = string.Compare(h.Navn, this.Navn);

                // Sorter stigende på navn
                i = i * -1;

                return i;
                // return string.Compare(h.Navn, this.Navn);
                //    if (h.Navn < this.Navn)
                //        return -1;
                //    if (h.Navn > this.Navn)
                //        return 1;

                //    return 0;

            }
            //}
        }
    }
}
