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

    public void Add_Node_Non_Recursiv(Node _in)
    {
        if (Top == null)
        {
            Top = _in;
            return;
        }

        Node Current = Top;
        bool flag = false;

        do
        {
            if (_in.Value < Current.Value)
            {
                if (Current.Left == null)
                {
                    Current.Left = _in;
                    flag = true;
                }
                else
                    Current = Current.Left;
            }
            if (_in.Value >= Current.Value)
            {
                if (Current.Right == null)
                {
                    Current.Right = _in;
                    flag = true;
                }
                else
                    Current = Current.Right;
            }
        } while (!flag);
    }

    public void Add_Node_Recursiv(int Value)
    {


    }

    public void Print(Node nod)
    {
        if (nod == null)
        {
            nod = Top;
        }
        if (nod.Left != null)
        {
            Print(nod.Left);
            Console.Write(nod.Value + " ");
        }
        else
        {
            Console.Write(nod.Value + " ");
        }
        if (nod.Right != null)
        {
            Print(nod.Right);
        }
    }
}
