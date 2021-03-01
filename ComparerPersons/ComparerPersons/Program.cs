using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparerPersons
{
   public class Program
    {
       public static void Main()
        {
           CompPersons<Person> cp = new CompPersons<Person>();
           List<Person> persons = new List<Person>();

           persons.Add(new Person("Валентин", 26, "Microsoft"));
           persons.Add(new Person("Дмитрий", 29, "Apple"));
           persons.Add(new Person("Константин", 30, "Ubisoft"));
           persons.Add(new Person("Георгий", 20, "Dell Technologes"));
           persons.Add(new Person("Андрей", 43, "IBM"));
           persons.Add(new Person("Николай", 36, "Oracle"));
           persons.Add(new Person("Григорий", 28, "Fujitsu"));

           Console.WriteLine("Исходный список людей: ");
           foreach (var person in persons)
           {
               person.PrintInfo();
           }

           Console.WriteLine("\nЛюди отсортированы по возрасту:");
           persons.Sort(cp);
           foreach (var person in persons)
           {
               person.PrintInfo();
           }

           Console.ReadLine();
        }
    }
}
