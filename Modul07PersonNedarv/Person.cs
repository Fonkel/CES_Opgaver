using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07PersonNedarv
{
    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }

            set
            {
                if (value.Length < 4)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
            }
        }

        private string fuldenavn;

        public string FuldeNavn
        {
            get
            {
                //fuldenavn = this.Fornavn + " " + this.Efternavn;
                //return fuldenavn;

                return this.Fornavn + " " + this.Efternavn;
            }
            //set { fuldenavn = value; }
        }


        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.efternavn;

        }

    }
}
