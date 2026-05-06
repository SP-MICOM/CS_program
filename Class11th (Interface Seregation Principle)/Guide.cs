using Program;
using System;
using System.Collections.Generic;
using System.Text;

internal class Guide : Interface.ITellable
{
    public void Talk()
    {
        Console.WriteLine("Guide : Hello! Welcome to village!");
    }
}
