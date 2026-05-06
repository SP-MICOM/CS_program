using Program;
using System;
using System.Collections.Generic;
using System.Text;

internal class Seller : Interface.ISellable, Interface.ITellable
{
    public void Sell()
    {
        Console.WriteLine("1. Potion");
        Console.WriteLine("2. Matchestick");
        Console.WriteLine("3. Humus Stone");
    }

    public void Talk()
    {
        Console.WriteLine("Seller : Buy something?");
    }
}