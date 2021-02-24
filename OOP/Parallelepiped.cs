using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Parallelepiped:Rectangle
    {
        public double Height { get; set; }

        public Parallelepiped(double c, double a, double b):base(a,b)
        {
            Height = c;
        }

        protected override double Square()
        {
            return (base.Square()*2+Height*base.Length*2+Height*base.Width*2);
        }

        protected double Volume()
        {
            return base.Square() * Height;
        }

        public override void  PrintInfo()
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
