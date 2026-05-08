using System;
using System.Collections.Generic;
using System.Text;

internal class Grenade : Weapon
{
    public Grenade()
    {
        damage = 100;
        range = 10;
    }

    public override void Attack()
    {
        Console.WriteLine("Attacked that use the Grenade : " + damage);
        Console.WriteLine("Reach : " + range);
    }
}
