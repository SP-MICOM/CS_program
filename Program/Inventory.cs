using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Inventory<T> : IEnumerable
    {
        private T[] list;
        private int count;

        public Inventory()
        {
            list = new T[5];
            count = 0;
        }

        public void Add(T item)
        {
            if (count < list.Length)
            {
                list[count++] = item;
            }
            else
            {
                Console.WriteLine("You cannot add any more item");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
