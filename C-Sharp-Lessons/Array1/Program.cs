using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortArray(new int[] { 3, 2, 3, 0 }, false);
        }





        static int[] SortArray(int[] arr, bool flag)
        {
            int[] ret = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                ret[i] = arr[i];
            }



            for (int i = 0; i < arr.Length; i++)
            {
                bool f = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        arr[j] ^= arr[j + 1];
                        arr[j + 1] ^= arr[j + 1];
                        arr[j] ^= arr[j + 1];
                        f = !f;
                    }
                }
                if (f) break;
            }








            if (flag)
                return ret;
            else
            {
                Array.Reverse(ret);
                return ret; 
            }
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }

        static int[] CrateRandomIntArray(int Length, int minValue, int maxVal)
        {
            Random rand = new Random();

            int[] ret = new int[Length];

            for (int i = 0; i < Length; i++)
                ret[i] = rand.Next(0, 100);

            return ret;
        }
    }
}
