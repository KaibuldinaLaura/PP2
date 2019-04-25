using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class MyThread
        {
            Thread threadField;

            public MyThread(string name)
            {
                threadField = new Thread(this.startThread);
                threadField.Name = name;
                threadField.Start();
            }

            void startThread()
            {
                for (int i = 1; i < 8; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(0);
                }
            }
        }
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread12");

            Console.Read();
        }
    }
}