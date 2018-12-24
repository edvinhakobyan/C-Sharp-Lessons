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
            inp = new string( inp.Where(t => (t == '(' || t == ')' || t == '{' || t == '}' ||
                                        t == '<' || t == '>' || t == '[' || t == ']')).ToArray());

            while (inp.Contains("()") || inp.Contains("{}") || inp.Contains("<>") || inp.Contains("[]"))
            {
                inp = inp.Replace("()", ""); inp = inp.Replace("{}", "");
                inp = inp.Replace("<>", ""); inp = inp.Replace("[]", "");
            }
            return inp.Length == 0;
        }
    }
}
