using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Enumerator<T>
    {
        public int position;
        public int count;
        public T[] items;

        public Enumerator(T[] list, int counter)
        {
            position = -1;
            count = 0;

            foreach (T element in list)
            {
                items[count++] = element;
            }
        }
    }
}
