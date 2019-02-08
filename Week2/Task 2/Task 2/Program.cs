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
        static bool Solve(int n)
        {
            if (n == 1) return false;
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Laura\source\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int[] a = System.IO.File.ReadAllText(@"C:\Users\Laura\source\input.txt").Split(' ').Select(n => int.Parse(n)).ToArray();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Laura\source\output.txt"))
            {
                foreach (int n in a)
                {
                    if (Solve(n))
                    {
                        file.Write(n+" ");
                    }
                }

            }
            string line = sr.ReadLine();
            sr.Close();
            fs.Close();
        }
    }
}