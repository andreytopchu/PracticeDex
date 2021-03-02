﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IEnumerable_IEnumerator
{
    class AutoParkEnum:IEnumerator //AutoParkEnum -> AutoParkEnumerator
    {
        public Car[] _cars;
        int position = -1;

        public AutoParkEnum(Car[] list)
        {
            _cars = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _cars.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _cars[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
