using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public abstract class Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Figure(double lenght, double width)
        {            
            Lenght = lenght;
            Width = width;
        }
        protected abstract double Square();
    }
}
