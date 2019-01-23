using System;

class Program
{
    static void Main()
    {
        Console.WindowWidth = 180;
        Random rand = new Random();

        Tree tree = new Tree();
        Node r = null;
        for (int i = 0; i < 100000000; i++)
        {
            Node temp = new Node(rand.Next(1000000000));
            tree.AddR_Node_Recursiv(ref r,temp);
        }
        tree.Print(null);

        Console.ReadKey();

    }
}
