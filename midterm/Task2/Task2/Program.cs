using System;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Substr);
            Thread th2 = new Thread(Time);
            th1.Start();
            th2.Start();
        }

        static void Substr()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    Console.WriteLine(s.Substring(i, j - i + 1));
                }
            }
            Console.WriteLine("End.");
        }

        static void Time()
        {
            string curTimeLong = DateTime.Now.ToLongTimeString();
            Console.WriteLine(curTimeLong);
        }
    }
}