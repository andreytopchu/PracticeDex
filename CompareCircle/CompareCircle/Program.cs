using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CompareCircle
{
    public class Program
    {
        public static void Main()
        {
            ArrayList circles = new ArrayList();
            Random rnd = new Random();

            for (int i = 1; i <= 10 ; i++)
            {
                int radius = rnd.Next(1, 11);
                circles.Add(new Circle(radius));
            }

            circles.Sort();

            foreach (var circle in circles)
            {
                Console.WriteLine(circle.ToString());
            }

            Console.ReadLine();
        }
    }
}
