using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICloneableSol
{
    class Person:ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        //упс.. закоментированный код. Можем от него избавиться?
        //поверхностное клонирование
        //public object Clone()
        //{
        //    return new Person { Name = this.Name, Age = this.Age, Adress = this.Adress };
        //} 
        
        //поверхностное автоматическое клонирование
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        //глубокое клонирование
        //public object Clone()
        //{
        //    Adress adress = new Adress { Street = this.Adress.Street, NumberOfHouse = this.Adress.NumberOfHouse };
        //    return new Person
        //    {
        //        Name = this.Name,
        //        Age = this.Age,
        //        Adress = adress
        //    };
        //}

        //упрощенный вариант глубокого клонирования
        public object Clone()
        {
            Person person = (Person)this.MemberwiseClone();
            person.Address = (Address)this.Address.Clone();

            return person;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имя: " + this.Name + "\nВозраст: " + this.Age + "\nАдрес: \nУлица: " + this.Address.Street + "\nНомер дома: " + this.Address.NumberOfHouse+"\n");
        }
    }
}
