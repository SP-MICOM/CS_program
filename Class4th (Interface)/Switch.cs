using System;
using System.Collections.Generic;
using System.Text;

internal class Switch : ISelectable, IActivatable
{
    private bool power;

    public void Select()
    {
        Console.WriteLine("Select the Switch...");
    }

    public void Activate()
    {
        power = !power;

        if (power)
        {
            Console.WriteLine("The Room Light is ON");
        }
        else
        {
            Console.WriteLine("The Room Light is OFF");
        }
    }
}
