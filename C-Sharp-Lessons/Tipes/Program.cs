using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WindowWidth = 150;
            string x_str, y_str;
            while (true)
            {
                Console.Write("X = ");
                x_str = Console.ReadLine();

                Console.Write("Y = ");
                y_str = Console.ReadLine();

                if (Type(x_str) == "error" || Type(y_str) == "error")
                    Console.WriteLine("Enter a correct values");
                else
                    break;
            }

            String X_tipe = Type(x_str);
            String Y_tipe = Type(y_str);

            Console.WriteLine();

            Console.WriteLine($"We can use type <{X_tipe}> for variable X");
            Console.WriteLine($"We can use type <{Y_tipe}> for variable Y");

            Console.WriteLine();


            sbyte byte_;
            short short_;
            int int_;
            long long_;
            double double_;

            Console.WriteLine($"Binary Representation of variable X:");
            switch (X_tipe)
            {
                case "sbyte":
                    byte_ = Convert.ToSByte(x_str);
                    show_bynary(Convert.ToString(byte_, 2).PadLeft(8, '0'));
                    break;
                case "short":
                    short_ = Convert.ToInt16(x_str);
                    show_bynary(Convert.ToString(short_, 2).PadLeft(16, '0'));
                    break;
                case "int":
                    int_ = Convert.ToInt32(x_str);
                    show_bynary(Convert.ToString(int_, 2).PadLeft(32, '0'));
                    break;
                case "long":
                    long_ = Convert.ToInt64(x_str);
                    show_bynary(Convert.ToString(long_, 2).PadLeft(64, '0'));
                    break;
                default:
                    double_ = Convert.ToDouble(x_str);
                    Console.WriteLine("Now is very difficult for me:)");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine($"Binary Representation of variable Y:");
            switch (Y_tipe)
            {
                case "sbyte":
                    byte_ = Convert.ToSByte(y_str);
                    show_bynary(Convert.ToString(byte_, 2).PadLeft(8, '0'));
                    break;
                case "short":
                    short_ = Convert.ToInt16(y_str);
                    show_bynary(Convert.ToString(short_, 2).PadLeft(16, '0'));
                    break;
                case "int":
                    int_ = Convert.ToInt32(y_str);
                    show_bynary(Convert.ToString(int_, 2).PadLeft(32, '0'));
                    break;
                case "long":
                    long_ = Convert.ToInt64(y_str);
                    show_bynary(Convert.ToString(long_, 2).PadLeft(64, '0'));
                    break;
                default:
                    double_ = Convert.ToDouble(y_str);
                    Console.WriteLine("Now is very difficult for me:)");
                    break;
            }
            Console.ReadKey();
        }

        public static string Type(string num_str)
        {
            sbyte xbyte;
            short xshort;
            int xint;
            long xlong;
            double xdouble;

            if (sbyte.TryParse(num_str, out xbyte))
                return "sbyte";
            else if (short.TryParse(num_str, out xshort))
                return "short";
            else if (int.TryParse(num_str, out xint))
                return "int";
            else if (long.TryParse(num_str, out xlong))
                return "long";
            else if (double.TryParse(num_str, out xdouble))
                return "double";
            else
                return "error";
        }

        public static void show_bynary(string a)
        {
            for (int i = 0; i < 2 * a.Length + 1; i++)
            {
                if (i % 2 == 0)
                    Console.Write('+');
                else
                    Console.Write('-');
            }
            Console.WriteLine();

            Console.Write('|');
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1')
                    Console.Write('1');
                else
                    Console.Write('0');
                Console.Write('|');
            }

            Console.WriteLine();
            for (int i = 0; i < 2 * a.Length + 1; i++)
            {
                if (i % 2 == 0)
                    Console.Write('+');
                else
                    Console.Write('-');
            }

            Console.WriteLine();
        }



    }
}
