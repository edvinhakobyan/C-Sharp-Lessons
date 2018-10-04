using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Mini Calculator--");
            Console.WriteLine();
            Console.WriteLine("True Format Examples");
            Console.WriteLine("Addition:\t 525 + 32.35");
            Console.WriteLine("Subtraction:\t 525 - 32.35");
            Console.WriteLine("Multiplication:\t 525 * 32.35");
            Console.WriteLine("Division:\t 525 / 32.35");
            Console.WriteLine("Exponents:\t 525 ^ 32.35");
            Console.WriteLine("Modulus:\t 525 % 32");


            Console.WriteLine(new string('=',Console.WindowWidth-2));


            char[] oporSymbols = new char[] { ' ','+', '-', '*', '/', '%', '^' };  
            String inputString;
            String[] stringArray;
            Double leftNum;
            Double rightNum;
            Boolean flag = true;

            while (flag)
            {
                while (true)
                {
                    inputString = Console.ReadLine();

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    stringArray = inputString.Split(oporSymbols, StringSplitOptions.RemoveEmptyEntries);

                    if (TrueText(inputString) && stringArray.Length == 2 &&
                        Double.TryParse(stringArray[0], out leftNum) &&
                        Double.TryParse(stringArray[1], out rightNum))
                        break;
                    else
                        Console.WriteLine("-Bed Text-");
                }
                
                for (int i = 1; i < oporSymbols.Length; i++)
                    if (inputString.Contains(oporSymbols[i]))
                        Console.WriteLine($"{stringArray[0]} {oporSymbols[i]} { stringArray[1]} = {Result(leftNum, rightNum, oporSymbols[i])}");

                //if (Console.ReadKey().Key == ConsoleKey.Escape)
                //    flag = false;
            }
        }

        private static Double Result(double left, double right, char v)
        {
            switch (v)
            {
                case '+': return left + right; 
                case '-': return left - right; 
                case '*': return left * right; 
                case '/': return left / right; 
                case '^': return Math.Pow(left, right);
                default : return left % right;
            }
        }

        private static bool TrueText(string oporationString )
        {
            int opor_Count = 0;
            for(int i = 0; i < oporationString.Length; i++) 
                if ((oporationString[i] == '+' || oporationString[i] == '-' ||
                    oporationString[i] == '*' || oporationString[i] == '/' ||
                    oporationString[i] == '%' || oporationString[i] == '^') &&
                    ++opor_Count > 1)
                    return false;
            return true;
        }
    }
}
