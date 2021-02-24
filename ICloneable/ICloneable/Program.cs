using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICloneableSol
{
   public class Program
    {
       public static void Main()
       {    
            Person p1 = new Person { Name = "Alex", Age = 23, Address = new Address { Street = "K.Marks str.", NumberOfHouse = 156 } };
            Person p2 = new Person { Name = "Nick", Age = 20, Address = new Address { Street = "Lenina str.", NumberOfHouse = 20 } };

            Person p3 = (Person) p1.Clone();

            //p1.PrintInfo();
            //p2.PrintInfo();
            //p3.PrintInfo();

            List<Person> personsList = new List<Person>();

            personsList.Add(p1);
            personsList.Add(p2);
            personsList.Add(p3);

            personsList[2] = (Person)p2.Clone(); //p3 = p2;
            Person p4 = (Person)p2.Clone();
            personsList.Add(p4);
            personsList[3] = p1; //p4 = p1;

            Console.WriteLine("Вывод данных о людях");
            for (int i = 0; i < personsList.Count; i++)
            {
                personsList[i].PrintInfo();
            }

            //выводя список, должны получить вывод p1,p2,p2,p1
       }

    }
}
