using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeСonversions
{
    public class Program
    {
        public static void Main()
        {
            Person person1 = new Person { FirstName = "Володя", SecondName = "Александров" };

            string str = (string)person1;
            Console.WriteLine(str);

            str = "Дмитрий Донской";

            Person person2 = (Person)str;
            Console.WriteLine(person2.ToString());

            if (str == (string)person2)
            {
                Console.WriteLine("Данные в строке соответсвуют данным человека");
            }


            if (person2.Equals((Person)str))
            {
                Console.WriteLine("Метод Equals считает, что данная строка соответсвуют человеку");
            }

        }
    }
}
