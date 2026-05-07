using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Knife : Weapon
    {
        public Knife()
        {
            damage = 10;
            range = 1;
        }

        public override void Attack()
        {
            Console.WriteLine("Attacked that use the knife : " + damage);
            Console.WriteLine("Reach : " + range);
        }
    }
}
