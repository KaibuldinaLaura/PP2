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
            FileStream fs = File.Create(@"C:\Users\Laura\source\TestFile.txt"); //creating file
            fs.Close(); //closeing this file
            File.Copy(@"C:\Users\Laura\source\TestFile.txt", @"C:\Users\Laura\source\repos\TestFile.txt", true); //copying this file
            StreamWriter file = new StreamWriter(@"C:\Users\Laura\source\TestFile.txt"); //initializing a new file
            file.Close(); //closing this file
            File.Delete(@"C:\Users\Laura\source\TestFile.txt"); //deleting original file
        }
    }
}
