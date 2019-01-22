using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Tree
{
    Node Top;

    public Tree()
    {
        Top = null;
    }

    public Tree(Node root)
    {
        Top = root;
    }

    public Tree(int rootValue)
    {
        Top = new Node(rootValue);
    }

    public void Add_Node_Non_Recursiv(int Value)
    {
        if (Top == null)
        {
            Top = new Node(Value);
            return;
        }
        Node Current = Top;
        bool flag = false;
        do
        {
            if (Value < Current.Value)
            {
                if (Current.Left == null)
                {
                    Current.Left = new Node(Value);
                    flag = true;
                }
                else
                {
                    Current = Current.Left;
                }
            }
            if (Value >= Current.Value)
            {
                if (Current.Right == null)
                {
                    Current.Right = new Node(Value);
                    flag = true;
                }
                else
                {
                    Current = Current.Right;
                }
            }
        } while (!flag);
    }

    public void Add_Node_Recursiv(int Value)
    {


    }

    public void Print(Node nod, ref string s)
    {
        if (nod == null)
        {
            nod = Top;
        }
        if (nod.Left != null)
        {
            Print(nod.Left, ref s);
            Console.Write(nod.Value.ToString() + " ");
        }
        else
        {
            Console.Write(nod.Value.ToString() + " ");
        }
        if (nod.Right != null)
        {
            Print(nod.Right, ref s);
        }
    }
}
