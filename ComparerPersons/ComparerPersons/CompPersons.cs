using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparerPersons
{
   public class CompPersons<T>:IComparer<T>
        where T: Person
    {
        public int Compare(T x, T y)
        {
            if (x.Age < y.Age)
                return 1;
            if (x.Age > y.Age)
                return -1;
            else return 0;
        }
    }
}
