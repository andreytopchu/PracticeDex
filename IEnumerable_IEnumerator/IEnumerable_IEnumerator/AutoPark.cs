using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IEnumerable_IEnumerator
{
    class AutoPark : IEnumerable
    {
        private Car[] _cars;

        public AutoPark(Car[] cars)
        {
            _cars = new Car[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                _cars[i] = cars[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public AutoParkEnum GetEnumerator()
        {
            return new AutoParkEnum(_cars);
        }
    }
}
