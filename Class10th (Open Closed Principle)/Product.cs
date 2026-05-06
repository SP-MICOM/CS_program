using System;
using System.Collections.Generic;
using System.Text;

internal abstract class Product
{
    protected string manual;
    protected int price;

    public void Describe()
    {
        Console.WriteLine("Price : " + price);
        Console.WriteLine("Manual : " + manual);

        Console.WriteLine();
    }
}