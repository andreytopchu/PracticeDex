using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCircle
{
    public class Circle:IComparable
    {
        public int Radius { get; private set; }
        public double Square { get; private set; }

        public Circle(int r)
        {
            Radius = r;
            Square = CalcSquare(r);
        }

        private double CalcSquare(double radius)
        {
            return Math.PI*Math.Pow(radius,2);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)  throw new ArgumentException("Аргумент не может быть null");

            if(obj is Circle) 
                obj as Circle; 
            else 
                throw new ArgumentException("Объект не является кругом");
            
        }

        public override string ToString()
        {
            return "Круг с радиусом "+this.Radius+" имеет площадь "+Math.Round(this.Square,2);
        }
    }
}
