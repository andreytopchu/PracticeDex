using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICloneableSol
{
    class Address:ICloneable
    {
        public string Street { get; set; }
        public int NumberOfHouse { get; set; }

        public object Clone() 
        {
            return this.MemberwiseClone();
        }

        public void PrintInfo()
        {
            Console.WriteLine("\nАдрес: \nУлица: "+this.Street+"\nНомер дома: "+this.NumberOfHouse);
        }

    }
}
