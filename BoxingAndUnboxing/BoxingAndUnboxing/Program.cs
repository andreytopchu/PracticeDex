using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BoxingAndUnboxing
{
    public class Program
    {
        public static void Main()
        {
            

            Stopwatch stopwatch = new Stopwatch();


            int i = 1234325;
            object object1 = i;

            stopwatch.Start();

            for (int j = 0; j < 100000000; j++ )
            {
              object1 = i;
            }

            stopwatch.Stop();

            Console.WriteLine("Потрачено миллисекунд на упаковку элемента типа int: " + stopwatch.ElapsedMilliseconds);


            stopwatch.Restart();

            for (int j = 0; j < 100000000; j++)
            {
                i = (int)object1;
            }

            stopwatch.Stop();

            Console.WriteLine("Потрачено миллисекунд на распаковку элемента типа int: " + stopwatch.ElapsedMilliseconds);


            string str = "Привет мир!";//

            stopwatch.Restart();
            for (int j = 0; j < 100000000; j++)
            {
                object1 = str;
            }
            
            stopwatch.Stop();

            Console.WriteLine("Потрачено миллисекунд на упаковку элемента типа string: " + stopwatch.ElapsedMilliseconds);


            stopwatch.Restart();

            for (int j = 0; j < 100000000;j++)
            {
                str = (string)object1;
            }
            
            stopwatch.Stop();

            Console.WriteLine("Потрачено миллисекунд на распаковку элемента типа string: " + stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
