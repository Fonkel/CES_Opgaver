using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07Terning
{
    class Terning
    {
        private static Random rnd = new Random();

        private int værdi;

        public int Værdi
        {
            get { return værdi; }

            set
            {
                if (value < 1 || value > 6)
                { værdi = 1; }
                else
                { værdi = value; }
            }
        }

        // Default Constructor
        public Terning()
        {
            this.Ryst();
        }

        // Custom Constructor
        public Terning(int defaultværdi)
        {
            this.Værdi = defaultværdi;
        }

        // Ryst lige koppen kammerat
        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }

        // udskriv terningens værdi
        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");

        }


    }
}
