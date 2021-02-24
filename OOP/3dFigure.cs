using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public abstract class _3dFigure:Figure
    {
        public double Height { get; private set; }

        public _3dFigure(double lenght, double width, double height)
            : base(lenght, width)
        {
            if (height>0)
            {
                Height = height;
            }
            else
                throw new ArgumentException("Ошибка ввода данных!");
        }


        protected abstract double Volume();
    }
}
