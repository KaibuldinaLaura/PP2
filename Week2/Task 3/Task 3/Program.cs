using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo fsi, int k) //creating function, that write in console all the files and directories that are located in ​string path​
        {
            string s = new string(' ', k); 
            Console.WriteLine(s + fsi.Name); 

            if (fsi.GetType() == typeof(DirectoryInfo)) //if we get info from folder
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos(); //array, which contain directories
                for (int i = 0; i < arr.Length; ++i) //run over array
                {
                    PrintInfo(arr[i], k + 4); //output every directory
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Laura\source"); //method for creating, moving, and enumerating through directories
            PrintInfo(dir, 0);
        }       
    }
}
