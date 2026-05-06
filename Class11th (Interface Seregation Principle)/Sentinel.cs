using Program;
using System;
using System.Collections.Generic;
using System.Text;

internal class Sentinel : Interface.IDamageable, Interface.ITellable
{
    private int health;

    public Sentinel()
    {
        health = 100;
    }

    public void Damage(int damage)
    {
        health -= damage;

        Console.WriteLine("Sentinel's HP : " + health);
    }

    public void Talk()
    {
        Console.WriteLine("Sentinel : I would like to report");
    }
}