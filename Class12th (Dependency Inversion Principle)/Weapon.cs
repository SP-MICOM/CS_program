using System;
using System.Collections.Generic;
using System.Text;

internal abstract class Weapon
{
    protected int damage;
    protected int range;

    public abstract void Attack();
}
