using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Func<int, int> m = new Func<int, int>(my);

        Task<int> mytask = new Task<int>(new Func<int>(my));
        int[] a = new int[3] { 1,2,3};
        mu m = new mu();
        foreach (var item in m)
        {
            Console.WriteLine(item);
        }
        

    }


    static public int my(int a)
    {
        return 0;
    }
}

class mu : IEnumerable
{

    public static void mymet()
    {

    }

    int[] a = new int[] { 1,2,3,4,5,6,7,8,9};

    public IEnumerator GetEnumerator()
    {

        foreach (var item in a)
        {
            yield return item;
        }
    }
}
