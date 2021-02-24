using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP;
using BoxingAndUnboxing;
using ICloneableSol;
using IEnumerable_IEnumerator;
using TypeСonversions;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
m1:         Console.WriteLine("Какое задание хотите запустить?\n");
            Console.WriteLine("1)Задание по теме №3");
            Console.WriteLine("2)Задание по теме №4");
            Console.WriteLine("3)Задание по теме №5");
            Console.WriteLine("4)Задание по теме №6");
            Console.WriteLine("5)Задание по теме №7");
            Console.WriteLine("6)Выйти из программы");
            Console.WriteLine("\nВведите число от 1 до 6 для запуска задания: ");
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
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели недопустимое число. Нажмите Enter для продолжения.");
                        Console.ReadLine();
                        Console.Clear();
                        goto m1;
                    }      
            }

            Console.WriteLine("\nЕщё хотите проверить задания?");
            Console.WriteLine("1) Да       2)Нет");
            string str = Console.ReadLine();
            if (str == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
