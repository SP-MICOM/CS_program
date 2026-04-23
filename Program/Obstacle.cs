
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

internal class Obstacle
{
    public int x;
    public int y;

    public void Translate(int x, int y)
    {
        this.x = x;
        this.y = y;

        Console.WriteLine("x : ", x, "y : ", y);
    }
}
