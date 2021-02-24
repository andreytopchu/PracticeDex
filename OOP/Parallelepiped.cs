using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Parallelepiped:_3dFigure
    {
        public Rectangle Rect1 { get; private set;}
        public Rectangle Rect2 { get; private set;}
        public Rectangle Rect3 { get; private set; }

        public Parallelepiped(double a, double b,double c ):base(a,b,c)
        {
            Rect1 = new Rectangle(a, b);
            Rect2 = new Rectangle(b, c);
            Rect3 = new Rectangle(a, c);
        }

        public override double Square()
        {
            return Rect1.Square() * 2 + Rect2.Square() * 2 + Rect3.Square() * 2;
        }

        protected override double Volume()
        {
            return base.Height*base.Length*base.Width;
        }

        public void PrintInfo()
        {
            if (Length == Width&&Length==Height)
                Console.WriteLine("Фигура: куб");
            else
                Console.WriteLine("Фигура: параллелепипед");
            Console.WriteLine("Ширина: {0}", Width);
            Console.WriteLine("Длина: {0}", Length);
            Console.WriteLine("Высота: {0}",Height);
            Console.WriteLine("Площадь поверхности: {0}", Square());
            Console.WriteLine("Объем: {0}\n",Volume());
        }
    }
}
