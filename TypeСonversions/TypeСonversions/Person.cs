using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeСonversions
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public static implicit operator Person(string str) //Можем проверить аргумент на null?
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return new Person { FirstName = words[0], SecondName = words[1] };
        }

        public static explicit operator string(Person person) //Можем проверить аргумент на null?
        {
            string str = person.FirstName + " " + person.SecondName;
            return str;
        }

        public override string ToString()
        {
            return FirstName+" "+SecondName;
        }

        public override bool Equals(object obj) //Можем сначала проверить аргумент на null?
        {
            if (obj.GetType() != this.GetType()) return false;

            Person person = (Person)obj;
            return (this.FirstName == person.FirstName&&this.SecondName==person.SecondName);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
