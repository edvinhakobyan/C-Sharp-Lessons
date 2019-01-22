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
        Left = null;
        Right = null;
    }

    //public static bool operator ==(Node left, Node right)
    //{
    //    if (left == null && right == null) return true;
    //    return left.Value == right.Value;
    //}
    //public static bool operator !=(Node left, Node right) { return !(left == right); }
    //public static bool operator >(Node left, Node right) { return left.Value > right.Value; }
    //public static bool operator <(Node left, Node right) { return !(left > right); }
    //public static bool operator >=(Node left, Node right) { return left.Value >= right.Value; }
    //public static bool operator <=(Node left, Node right) { return left.Value <= right.Value; }
}

