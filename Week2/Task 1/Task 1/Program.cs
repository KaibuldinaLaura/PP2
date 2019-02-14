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
        static void Solve(string str) //writing function
        {
            bool ok = true;
            for (int i = 0; i < str.Length; ++i) //array, that running over our string
            {
                if (str[str.Length - 1 - i] != str[i]) //if our string is not pollindrom
                {
                    ok = false; //it will be false
                    break;
                }
            }

            if (ok) //if our string is pollindrome
            {
                Console.WriteLine("Yes"); //output yes
            }
            else //if our string isn't pollindrome
            {
                Console.WriteLine("No"); //output no
            }
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Laura\source\ex1.txt", FileMode.Open, FileAccess.Read); //open file
            StreamReader sr = new StreamReader(fs); 
            string line = sr.ReadLine(); //read text from file
            Solve(line); //checking pollindrome or not
            sr.Close(); 
            fs.Close(); //close file
        }
    }
}