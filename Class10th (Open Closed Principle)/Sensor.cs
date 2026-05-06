using System;
using System.Collections.Generic;
using System.Text;

internal class Sensor
{
    public void Detect(Product product)
    {
        product.Describe();
    }
}