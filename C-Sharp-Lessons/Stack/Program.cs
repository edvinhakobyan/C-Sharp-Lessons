using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000000000;
            var time = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                bit4096 a = new bit4096();
            }
            Console.WriteLine(DateTime.Now - time);

            time = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                Class_bit4096 a = new Class_bit4096();
            }
            Console.WriteLine(DateTime.Now - time);
            Console.ReadKey();

        }
    }

    class Class_bit4096
    {
        bit2048 a1;
        bit2048 a2;
    }

    struct bit8388608
    {
        bit4194304 a1;
        bit4194304 a2;
    }

    struct bit4194304
    {
        bit2097152 a1;
        bit2097152 a2;
    }

    struct bit2097152
    {
        bit1048576 a1;
        bit1048576 a2;
    }

    struct bit1048576
    {
        bit524288 a1;
        bit524288 a2;
    }

    struct bit524288
    {
        bit262144 a1;
        bit262144 a2;
    }

    struct bit262144
    {
        bit131072 a1;
        bit131072 a2;
    }

    struct bit131072
    {
        bit65536 a1;
        bit65536 a2;
    }


    struct bit65536
    {
        bit32768 a1;
        bit32768 a2;
    }

    struct bit32768
    {
        bit16384 a1;
        bit16384 a2;
    }


    struct bit16384
    {
        bit8192 a1;
        bit8192 a2;
    }

    struct bit8192
    {
        bit4096 a1;
        bit4096 a2;
    }

    struct bit4096
    {
        bit2048 a1;
        bit2048 a2;
    }

    struct bit2048
    {
        bit1024 a1;
        bit1024 a2;
    }



    struct bit1024
    {
        bit512 a1;
        bit512 a2;
    }

    struct bit512
    {
        bit256 a1;
        bit256 a2;
    }

    struct bit256
    {
        bit128 a1;
        bit128 a2;
    }

    struct bit128
    {
        bit64 a1;
        bit64 a2;
    }

    struct bit64
    {
        long a1;
    }
}
