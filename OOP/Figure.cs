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
            if (lenght > 0 && width > 0)
            {
                Length = lenght;
                Width = width;
            }
            else
                throw new ArgumentException("Ошибка ввода данных!");
        }
        public abstract double Square();
    }
}
