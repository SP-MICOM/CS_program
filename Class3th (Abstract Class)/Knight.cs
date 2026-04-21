using System;
using System.Collections.Generic;
using System.Text;

    internal class Knight : Soldier
    {
        public Knight()
        {
            health = 200;
            defense = 5;

        }

        public override void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
