using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            FloatingPointInParentheses(@"dfjdhfjdhf(0.2569)=34900385$%^{.6589}fgjk<2569>cvcvv[2365.]<5698.35698> ");
            Console.WriteLine(IsTrueBrackets(Console.ReadLine()).ToString());
        }

        private static bool IsTrueBrackets(string inp)
        {
            inp = new string(inp.Where(t => (t == '(' || t == ')' || t == '{' || t == '}' ||
                                             t == '<' || t == '>' || t == '[' || t == ']')).ToArray());

            while (inp.Contains("()") || inp.Contains("{}") || inp.Contains("<>") || inp.Contains("[]"))
            {
                inp = inp.Replace("()", ""); inp = inp.Replace("{}", "");
                inp = inp.Replace("<>", ""); inp = inp.Replace("[]", "");
            }
            return inp.Length == 0;
        }

        private static void FloatingPointInParentheses(string inp)
        {
            string pattern = @"[([{<]{1}[-+]{0,1}[0-9]{0,}[.]{0,1}[0-9]{0,}[)\]}>]{1}";
            MatchCollection m = Regex.Matches(inp, pattern);
            foreach (var item in m)
                Console.WriteLine(item.ToString().Substring(1, item.ToString().Length - 2));
        }



    }
}
