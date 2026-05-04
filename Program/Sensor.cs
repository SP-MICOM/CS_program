using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Sensor
    {
        public void Detect(Product product)
        {
            product.Describe();
        }
    }
}
