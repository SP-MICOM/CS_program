using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Barracks
    {
        private int index = 0;
        private Soldier[] soldiers = new Soldier[5];

        public void Create(int select)
        {

        }

        public void Battle()
        {
            foreach(Soldier element in soldiers)
            {
                element.Attack();
            }
        }
    }
}
