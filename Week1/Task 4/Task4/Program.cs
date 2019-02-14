using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine()); //input size of array
            for (int i = 1; i <= n; i++) //array
            {
                for (int j = 1; j <= i; j++) //2d array
                {
                    Console.Write("[*]"); //writing stars
                }
                Console.WriteLine(); //writing enter
            }
        }
    }
}
