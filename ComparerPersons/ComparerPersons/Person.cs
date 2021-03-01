using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparerPersons
{
   public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Work { get; private set; }

        public Person(string name, int age, string work)
        {
            if (age>0)
            {
                Name = name;
                Age = age;
                Work = work;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имя: {0,-10}   Возраст: {1,-2}   Место работы: {2,-15}",this.Name,this.Age,this.Work);
        }
    }
}
