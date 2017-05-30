using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Collection
{
    class Person : IComparable
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public int CompareTo(object obj)
        {
            int i = 0;
            Person p1 = obj as Person;

            i = string.Compare(p1.Navn, this.Navn);

            // Sorter stigende på navn
            i = i * -1;

            return i;
        }
    }
}
