using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07aNyTerning
{
    class Terning
    {
        public int værdi;
        private bool snyd;

        private static Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = true;
        }

        public void Skriv()
        {
            Udskriv("[" + this.værdi + "]");

        }

        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }

        //Udskriv tekst, hvis ingen værdi overføres er default = Blank!!
        static void Udskriv(string tekst = "")
        {
            Console.WriteLine(tekst);
        }


    }
}
