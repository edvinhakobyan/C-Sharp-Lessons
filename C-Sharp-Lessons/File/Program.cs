using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllFiles(@"C:\");
        }


        public static void PrintAllFiles(string directory)
        {
            try
            {
                foreach (string File_Pat in Directory.GetFiles(directory))
                    Console.WriteLine(File_Pat);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                foreach (string subdirectory in Directory.GetDirectories(directory))
                    PrintAllFiles(subdirectory);
            }
            catch (Exception e){ Console.WriteLine(e.Message);}
        }
    }
}
