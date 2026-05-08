using System;
using System.Collections.Generic;
using System.Text;

    internal class Dragon : Enemy, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Dragon fly.");
        }
    }
