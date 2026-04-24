using System;
using System.Collections.Generic;
using System.Text;

internal class Factory<T> where T : new()
{
    private T[] objects;
    private int count;

    public Factory(int size = 5)
    {
        objects = new T[size];
    }

    public T Instantiate()
    {
        if (count >= objects.Length)
        {
            Console.WriteLine("No more can be created");

            return default(T);
        }

        T clone = new T();

        objects[count] = clone;

        return objects[count++];
    }
}