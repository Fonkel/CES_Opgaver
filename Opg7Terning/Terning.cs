using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg7Terning
{
    class Terning
    {
        public int værdi;
        public Terning()
        {
            this.værdi = new Random().Next(1, 7);
        }

        public Terning(int n)
        {
            this.værdi = n;
        }

    }
}
