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
            RotateArrayClockwise(
            new int[,]
            {
                {1, 2,3,4 },
                {5,6,7,8 },
                {1,2,3,4 },
            });

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

        private static int[,] RotateArrayClockwise(int[,] src)
        {
            int height = src.GetUpperBound(0) + 1; //width
            int width = src.GetUpperBound(1) + 1;
            int[,] dst = new int[width, height];

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    //Left rotate
                    //int newRow = col;
                    //int newCol = width - (row + 1);

                    //Right Rotate
                    int newRow = height-(col + 1);
                    int newCol = row;

                    dst[newCol, newRow] = src[col, row];
                }
            }

            return dst;
        }
    }
}
