using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Program
{
    internal class Character
    {
        private int currentCount;
        private List<Weapon> weapons;

        public Character()
        {
            weapons = new List<Weapon>();
        }

        public void Acquire(Weapon weapon)
        {
            if (weapons.Count < 3)
            {
                weapons.Add(weapon);
            }
            else
            {
                Console.WriteLine("Can't Acquire the weapon anymore.");
            }
        }

        public void Swap()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    currentCount = currentCount + 1;

                    if (weapons.Count <= currentCount)
                    {
                        currentCount = 0;
                    }
                }
            }
        }

        public void Attack()
        {
            if (weapons.Count > 0)
            {
                weapons[currentCount].Attack();
            }
            else
            {
                Console.WriteLine("You don't have weapon.");
            }
        }
    }
}
