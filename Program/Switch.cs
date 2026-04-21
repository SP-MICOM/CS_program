using System;
using System.Collections.Generic;
using System.Text;

internal class Switch : ISelectable
{
    public void Select()
    {
        Console.WriteLine("pushed the switch...");
    }
}
