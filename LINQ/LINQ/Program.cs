using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Node[] node = new Node[100];
            for (int i = 0; i < 100; i++)
            {
                node[i] = new Node(GenerateString(rand,7), i + 1, GenerateDate(rand));
                Console.WriteLine(node[i]);
            }
            Console.ReadLine();
        }

        public static char GenerateChar(Random rng)
        {
            return (char)(rng.Next('a', 'z' + 1));
        }

        public static string GenerateString(Random rng, int length)
        {
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
            {
                letters[i] = GenerateChar(rng);
            }
            return new string(letters);
        }

        public static DateTime GenerateDate(Random rnd)
        {
            DateTime start = new DateTime(2021, 2, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(rnd.Next(range));
        }

    }
}
