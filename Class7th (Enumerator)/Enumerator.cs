using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

    internal class Enumerator<T> : IEnumerator
    {
        private T[] items;
        private int count;
        private int position = -1;

        public Enumerator(T[] itmes, int count)
        {
            this.items = itmes;
            this.count = count;
        }

        public object Current => items[position];

        public bool MoveNext()
        {
            position++;

            return position < count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
