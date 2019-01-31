using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Sorting_Algoritms
{
    public delegate void sortingAlgMethods(int[] arr);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WindowWidth = 220;
            Random rand = new Random();

            int experimentCount = 100;
            Console.WriteLine($"Experimets Count = {experimentCount} |Native         |BubbleSort     |SelectionSort  |InsertionSort  |ShellSort      |QuickSort      |mySort         ");
            File.AppendAllText("Result.txt", $"Experimets Count = {experimentCount} |Native         |BubbleSort     |SelectionSort  |InsertionSort  |ShellSort      |QuickSort      |mySort         ");
            Console.WriteLine();
            File.AppendAllText("Result.txt", Environment.NewLine);
            

            Dictionary<sortingAlgMethods, Stopwatch> times = new Dictionary<sortingAlgMethods, Stopwatch>();  // annasun oop kanstrukcia
            times.Add(new sortingAlgMethods(Native), new Stopwatch());
            times.Add(new sortingAlgMethods(BubbleSort), new Stopwatch());
            times.Add(new sortingAlgMethods(SelectionSort), new Stopwatch());
            times.Add(new sortingAlgMethods(InsertionSort), new Stopwatch());
            times.Add(new sortingAlgMethods(ShellSort), new Stopwatch());
            times.Add(new sortingAlgMethods(QuickSort), new Stopwatch());
            times.Add(new sortingAlgMethods(mysort), new Stopwatch());

            for (int arrlength = 500; arrlength < 20000; arrlength += 500) // masivi erkarutyunn a
            {
                int[] arr = new int[arrlength];
                for (int i = 0; i < experimentCount; i++) // nuyn erkarutyamb bayc random tarber masivner "experimentCount" hat
                {
                    for (int j = 0; j < arrlength; j++)  // mi hat random masiv
                        arr[j] = rand.Next(500000);


                    foreach (var item in times)  // masiv copy a anum amen algoritmi hamar u sort anum
                    {
                        item.Value.Start();
                        item.Key((int[])arr.Clone());
                        item.Value.Stop();
                    }
                }

                Console.Write($"Array Length = {arrlength,-8}");
                File.AppendAllText("Result.txt", $"Array Length = {arrlength,-8}");
                foreach (var item in times.Values)
                {
                    Console.Write($"|{item.ElapsedMilliseconds,-15}");
                    File.AppendAllText("Result.txt", $"|{item.ElapsedMilliseconds,-15}");
                    item.Restart();
                }
                Console.WriteLine();
                File.AppendAllText("Result.txt", Environment.NewLine);
            }
            Console.ReadKey();
        }

        #region Native
        public static void Native(int[] data)
        {
            Array.Sort(data);
        }
        #endregion

        #region BubbleSort
        public static void BubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = N - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (data[i] > data[i + 1])
                        swap(ref data[i], ref data[i + 1]);
        }
        #endregion

        #region SelectionSort
        public static void SelectionSort(int[] data)
        {
            int i;
            int N = data.Length;
            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    swap(ref data[i], ref data[k]);
            }
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
        #endregion

        #region InsertionSort
        public static void InsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = 1; j < N; j++)
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                    swap(ref data[i], ref data[i - 1]);
        }
        #endregion

        #region ShellSort
        public static void ShellSort(int[] data)
        {
            int[] intervals = { 1, 2, 4, 8 };
            ShellSort(data, intervals);
        }
        public static void ShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            swap(ref data[i], ref data[i - interval]);
                        }
                    }
                }
            }
        }
        #endregion

        #region QuickSort
        public static void QuickSort(int[] data)
        {
            QuickSort(data, 0, data.Length - 1);
        }
        public static void QuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x) i++;
                while (x < data[j]) j--;
                if (i <= j)
                {
                    swap(ref data[i], ref data[j]);
                    i++;
                    j--;
                }
                if (i > j) break;
            }
            if (l < j)  QuickSort(data, l, j);
            if (i < r)  QuickSort(data, i, r);
        }
        #endregion

        #region my sort
        public static void mysort(int[] a)
        {
            int[] temp = new int[a.Max()+1];
            for (int i = 0; i < a.Length; temp[a[i]]++, i++) ;
            for (int i = 0, ind = 0; i < temp.Length; i++)
                for (int j = 0; j < temp[i]; j++)
                    a[ind++] = i;
        }
        #endregion

        private static void swap(ref int a, ref int b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }
        static void print(int[] a)
        {
            foreach (var item in a)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
