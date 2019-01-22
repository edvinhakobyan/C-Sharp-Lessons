using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Tree tree = new Tree();
        for (int i = 0; i < 100; i++)
        {
            Node temp = new Node(rand.Next(1000));
            tree.Add_Node_Non_Recursiv(temp);
        }
        tree.Print(null);

        Console.ReadKey();

    }
}
