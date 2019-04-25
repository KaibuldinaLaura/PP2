using System;
using System.Threading;

class Output
{
    public void value()
    {
        Thread t = Thread.CurrentThread;
        Console.WriteLine("The name of the current " + "thread is: " + t.Name);
    }
}

public class Program
{ 
    static public void Main()
    { 
        Output obj = new Output();

        Thread t1 = new Thread(obj.value);
        Thread t2 = new Thread(obj.value);
        Thread t3 = new Thread(obj.value);
   
        t1.Name = "Thread 1";
        t2.Name = "Thread 2";
        t3.Name = "Thread 3";

        t1.Start();
        t2.Start();
        t3.Start();
    }
}