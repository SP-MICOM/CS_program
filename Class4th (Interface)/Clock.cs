using System;
using System.Collections.Generic;
using System.Text;

internal class Clock : ISelectable, IActivatable
{
    public void Select()
    {
        Console.WriteLine("The Clock is running");
    }

    public void Activate()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Time : " + now.ToString("HH:mm:ss"));
    }
}