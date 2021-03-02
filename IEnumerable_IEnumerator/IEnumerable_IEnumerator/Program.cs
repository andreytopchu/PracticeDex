using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerable_IEnumerator
{
    public class Program
    {
        public static void Main()
        {
            Car[] carsArray = new Car[3]
            {
               new Car("Легковой автомобиль"),new Car("Грузовой автомобиль"),new Car("Пикап"),
            };

            AutoPark carsList = new AutoPark(carsArray);

            Console.WriteLine("Автомобили в парке:\n");

            foreach (Car car in carsList)
            {
                Console.WriteLine(car.Type);
            }
            // Давай уберём закомментированный код ниже, создадим экземпляр AutoParkEnum enumerator и сделаем while(enumerator.MoveNext()){...} 
            //int i = 0;
            //while (i < carsArray.Length)
            //{
            //    Console.WriteLine(carsArray[i].Type);
            //    i++;
            //}
        }
    }
}
