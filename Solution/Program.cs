using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP;
using BoxingAndUnboxing;
using ICloneableSol;
using IEnumerable_IEnumerator;
using TypeСonversions;
using LINQ;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
restart:         Console.WriteLine("Какое задание хотите запустить?\n");
            Console.WriteLine("1)Задание по теме №3 (приёмы ООП)");
            Console.WriteLine("2)Задание по теме №4(Демонстрация работы интерфейса ICloneable)");
            Console.WriteLine("3)Задание по теме №5 (Приведение типов)");
            Console.WriteLine("4)Задание по теме №6 (Упаковка и распаковка)");
            Console.WriteLine("5)Задание по теме №7 (IEnumerable and Enumerator)");
            Console.WriteLine("6)Задание по теме №8(IQueryable)");
            Console.WriteLine("7)Задание по теме №9(IComparable)");
            Console.WriteLine("8)Задание по теме №9(2)(IComparer)");
            Console.WriteLine("9)Выйти из программы");
            Console.WriteLine("\nВведите число от 1 до 9 для запуска задания: ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("\nЗадание по теме №3 (приёмы ООП)\n");
                        OOP.Program.Main();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nДемонстрация работы интерфейса ICloneable\n");
                        ICloneableSol.Program.Main();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nЗадание по теме №5 (Приведение типов)\n");
                        TypeСonversions.Program.Main();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nЗадание по теме №6 (Упаковка и распаковка)\n");
                        BoxingAndUnboxing.Program.Main();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\nЗадание по теме №7 (IEnumerable and Enumerator)\n");
                        IEnumerable_IEnumerator.Program.Main();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("\nЗадание по теме №8(IQueryable)\n");
                        LINQ.Program.Main();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("\nЗадание по теме №9(IComparable)\n");
                        CompareCircle.Program.Main();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("\nЗадание по теме №9(2)(IComparer)\n");
                        ComparerPersons.Program.Main();
                        break;
                    }
                case 9:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели недопустимое число. Нажмите Enter для продолжения.");
                        Console.ReadLine();
                        Console.Clear();
                        goto restart;
                    }      
            }

            Console.WriteLine("\nЕщё хотите проверить задания?");
            Console.WriteLine("1) Да       2)Нет");
            string str = Console.ReadLine();
            if (str == "1")
            {
                Console.Clear();
                goto restart;
            }
        }
    }
}
