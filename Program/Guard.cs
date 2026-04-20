using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Guard : Soldier
    {
        public Guard()
        {
            health = 300;
            defense = 8;
        }

        public override void Attack()
        {
            Console.WriteLine("Guard Attack");
        }
    }
}
