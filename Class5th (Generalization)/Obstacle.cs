
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

internal class Obstacle
{
    private int x;
    private int y;

    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;

        Console.SetCursorPosition(this.x * 2, this.y);
    }

    public void Render()
    {
        Console.Write("▣");
    }
}
