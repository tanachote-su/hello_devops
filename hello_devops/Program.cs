using System;
using System.Threading;

namespace hello_devops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("");
            //Console.WriteLine("Press anykey to exit.");
            //Console.ReadLine();
            int seq = 0;
            while (true)
            {
                Console.WriteLine($"#{++seq} {DateTime.Now}");
                Thread.Sleep(1000);
            }
        }
    }
}
