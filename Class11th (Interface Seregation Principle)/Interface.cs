using System;
using System.Collections.Generic;
using System.Text;

internal interface Interface
{
    internal interface IDamageable
    {
        public void Damage(int damage);
    }

    internal interface ITellable
    {
        public void Talk();
    }

    internal interface ISellable
    {
        public void Sell();
    }
}