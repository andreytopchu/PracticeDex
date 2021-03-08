using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureLib
{
   public static class FigureProgram
    {
        private static Figure[] figuresArray = new Figure[100];

        public static void GenerateFigure()
        {
            Random rnd = new Random();

            for (int i = 0; i < figuresArray.Length; i++)
            {
                switch (rnd.Next(1,4))
                {
                    case 1:
                        figuresArray[i] = new Circle(rnd.Next(1, 15));
                        break;
                    case 2:
                        figuresArray[i] = new Square(rnd.Next(1, 15));
                        break;
                    case 3:
                        while (figuresArray[i] == null)
                        {
                            try
                            {
                                figuresArray[i] = new Triangle((rnd.Next(1, 9)), rnd.Next(1, 9), rnd.Next(1, 9));
                            }
                            catch (Exception)
                            {
                            }
                        }
                        break;
                }
            }
        }

        public static void RunDemo()
        {
            GenerateFigure();



            Console.WriteLine("Начальный массив (неотсортированный): ");
            foreach (var figure in figuresArray)
            {
                Console.WriteLine(figure.ToString() + " с площадью: " + figure.CalcArea());
            }
            Console.WriteLine();

            Array.Sort(figuresArray, new AreaFigureComparer());

            Console.WriteLine("Отсортированный массив по площади: ");
            foreach (var figure in figuresArray)
            {
                Console.WriteLine(figure.ToString() + " с площадью: " + figure.CalcArea());
            }
            Console.WriteLine();

            Array.Sort(figuresArray, new PerimetrFigureComparer());
            Console.WriteLine("Отсортированный массив по периметру: ");
            foreach (var figure in figuresArray)
            {
                Console.WriteLine(figure.ToString() + " с периметром: " + figure.CalcPerimetr());
            }
            Console.WriteLine();


        }

        public static void RunProgram()
        {
            RunDemo();
            Console.ReadLine();
        }
    }
}
