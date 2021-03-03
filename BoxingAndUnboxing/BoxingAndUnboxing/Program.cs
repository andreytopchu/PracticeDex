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
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            Stopwatch stopwatch3 = new Stopwatch();
            Stopwatch stopwatch4 = new Stopwatch();

            int i = 12345678;

            stopwatch1.Start();
            //упаковка
            object o = i;
            stopwatch1.Stop();

            stopwatch2.Start();
            //распаковка
            i = (int)o;
            stopwatch2.Stop();

            string str = "Привет мир!";

            stopwatch3.Start();
            //упаковка
            object obj = str;
            stopwatch3.Stop();

            stopwatch4.Start();
            //распаковка
            str = (string)obj;
            stopwatch4.Stop();  

            Console.WriteLine("Потрачено тактов на упаковку элемента типа int: " + stopwatch1.Elapsed);
            Console.WriteLine("Потрачено тактов на распаковку элемента типа int: " + stopwatch2.Elapsed);

            Console.WriteLine("Потрачено тактов на упаковку элемента типа string: " + stopwatch3.Elapsed);
            Console.WriteLine("Потрачено тактов на распаковку элемента типа string: " + stopwatch4.Elapsed);
             
        }
    }
}
