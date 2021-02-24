﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Rectangle:Figure
    {
        

        //прямоугольник
        public Rectangle(double a, double b):base(a,b)
        {            
        }

        //квадрат
        public Rectangle(double a)
        {
            Length = a;
            Width = a;
        }

        protected override double Square()
        {
            return this.Length * this.Width;
        }

        public virtual void PrintInfo()
        {
            if(Length==Width)
                Console.WriteLine("Фигура: квадрат");
            else
                Console.WriteLine("Фигура: прямоугольник");
            Console.WriteLine("Ширина: {0}",Width);
            Console.WriteLine("Длина: {0}",Length);
            Console.WriteLine("Площадь: {0}\n",Square());
        }
    }
}
