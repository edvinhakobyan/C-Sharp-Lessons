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
            string[] File_Pats = Directory.GetFiles(directory);

            foreach (string File_Pat in File_Pats)
            {
                Console.WriteLine(File_Pat);
            }

            string[] subdirectoryEntries = Directory.GetDirectories(directory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                PrintAllFiles(subdirectory);
            }

        }
    }
}
