using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rect1 = new Rectangle(10, 10);
            Rectangle rect2 = new Rectangle(8, 7);
            Parallelepiped par1 = new Parallelepiped(15, 12, 10);
            Parallelepiped par2 = new Parallelepiped(10, 10, 10);
            Console.WriteLine("Информация о фигурах:\n");
            rect1.PrintInfo();
            rect2.PrintInfo();
            par1.PrintInfo();
            par2.PrintInfo();
        }

    }
}
