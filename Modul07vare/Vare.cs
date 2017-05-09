using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07vare
{
    class Vare
    {


        // Property Navn
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Du er nu ved at hente Navn: " + navn);
                return navn;
            }

            set
            {
                Console.WriteLine("Du er nu ved at ændre Navn til : " + value);
                navn = value;
            }
        }
        // Property Pris
        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Du er nu ved at hente Pris: " + pris);
                return pris;
            }
            set
            {
                Console.WriteLine("Du er nu ved at ændre Pris til : " + value);
                pris = value;
            }
        }

        //Constructors
        public Vare()
        {
            this.Navn = "";
            this.Pris = 0;
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;


        }
        //Metode PrisMedmoms
        public double PrisMedMoms()
        {
            return pris * 1.25;
        }
    }
}
