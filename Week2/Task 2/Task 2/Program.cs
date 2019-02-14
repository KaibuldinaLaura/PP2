using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static bool Solve(int n) //function, that check number if it's prime
        {
            if (n == 1) return false; //because 1 isn't prime
            for (int d = 2; d * d <= n; d++) 
            {
                if (n % d == 0) return false; //because prime numbers can divide by 1 or they
            }
            return true; //because in other cases number is prime
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Laura\source\input.txt", FileMode.Open, FileAccess.Read); //open file
            StreamReader sr = new StreamReader(fs); //read file
            int[] a = File.ReadAllText(@"C:\Users\Laura\source\input.txt").Split(' ').Select(n => int.Parse(n)).ToArray(); //read each numer and create array from them

            using (StreamWriter file = new StreamWriter(@"C:\Users\Laura\source\output.txt")) //opening file for output
            {
                foreach (int n in a) //for each element in array
                {
                    if (Solve(n)) //if it's prime
                    {
                        file.Write(n+" "); //write it in our output file
                    }
                }

            }
            string line = sr.ReadLine(); //read output file
            sr.Close(); //close it
            fs.Close(); //close input file
        }
    }
}