using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTrueBrackets(Console.ReadLine()).ToString());
        }

        private static bool IsTrueBrackets(string inp)
        {
            string list = "";
            for (int i = 0; i < inp.Length; i++)
            {
                if (inp[i] == '(' || inp[i] == ')' || inp[i] == '{' || inp[i] == '}' ||
                   inp[i] == '<' || inp[i] == '>' || inp[i] == '[' || inp[i] == ']')
                { list += inp[i]; }
            }
                
            while (true)
            {
                int count = 0;
                if (list.Contains("()")) { list = list.Replace("()", ""); ++count; }
                if (list.Contains("{}")) { list = list.Replace("{}", ""); ++count; }
                if (list.Contains("<>")) { list = list.Replace("<>", ""); ++count; }
                if (list.Contains("[]")) { list = list.Replace("[]", ""); ++count; }
                if (count == 0) break;
            }
            return list.Length == 0;
        }
    }
}
