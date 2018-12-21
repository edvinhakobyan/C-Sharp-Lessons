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
            FileStream fl = new FileStream(@"All_File_Pats", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fl);
            PrintAllFiles(@"C:\", writer);
            writer.Close();
        }

        public static void PrintAllFiles(string directory, StreamWriter writer)
        {
            try
            {
                foreach (string File_Pat in Directory.GetFiles(directory))
                {
                    writer.WriteLine(File_Pat);
                    Console.WriteLine(File_Pat);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                foreach (string subdirectory in Directory.GetDirectories(directory))
                    PrintAllFiles(subdirectory, writer);
            }
            catch (Exception e){ Console.WriteLine(e.Message);}
        }
    }
}
