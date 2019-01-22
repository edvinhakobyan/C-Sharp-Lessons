using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int Value)
    {
        this.Value = Value;
        this.Left = null;
        this.Right = null;
    }
}

