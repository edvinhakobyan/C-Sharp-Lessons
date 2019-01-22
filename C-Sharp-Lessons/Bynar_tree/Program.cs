using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        string s = "";

        Tree tree = new Tree(15);


        for (int i = 0; i < 100; i++)
        {
            tree.Add_Node_Non_Recursiv(rand.Next(1000));
        }

        tree.Print(null, ref s);

        Console.ReadKey();
        
    }
}
