using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparerPersons
{
   public class CompPersons<T>:IComparer<T> // CompPersons -> PersonComparer
        where T: Person
    {
        public int Compare(T x, T y) // а если x и y null?
        {
            if (x.Age < y.Age)
                return 1;
            if (x.Age > y.Age)
                return -1;
            else return 0;
        }
    }
}
