using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Interface_01
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            IDbFunktioner[] samling = new IDbFunktioner[4];

            //            Hund dyr = new Hund("Oscar");
            //            dyr.Navn = "Oscar";

            //            samling[0] = dyr;
            logger.Trace("Her starter vi (test af ÆØÅæøå)");

            samling[0] = new Hund("Fido");

            samling[1] = new Ubåd();
            samling[2] = new Ubåd();

            samling[3] = new Hund("king");

            

            foreach (var item in samling)
            {
                item.Gem();
            }
            logger.Trace("Her slutter vi");

            Console.ReadKey();

        }
    }
}
