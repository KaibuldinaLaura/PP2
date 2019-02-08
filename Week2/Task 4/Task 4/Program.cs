using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create(@"C:\Users\Laura\source\TestFile.txt");
            fs.Close();
            File.Copy(@"C:\Users\Laura\source\TestFile.txt", @"C:\Users\Laura\source\repos\TestFile.txt", true);
            StreamWriter file = new StreamWriter(@"C:\Users\Laura\source\TestFile.txt");
            file.Close();
            File.Delete(@"C:\Users\Laura\source\TestFile.txt");
        }
    }
}
