using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Kort
{
    class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();
        public void TilFøjkort(Kort k)
        {
            bunke.Push(k);
        }
        public Kort Fjernkort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();

            return null;
        }

        public void vis()
        {
            foreach (var kort in bunke)
            {
                Console.WriteLine(kort);
            }
        }
    }
}
