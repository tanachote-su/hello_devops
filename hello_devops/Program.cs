using System;
using System.Threading;

namespace hello_devops
{
    public class Program
    {
        const string title="Release1";
        public static void Main()
        {

            int seq = 0;
            while (true)
            {
                Console.WriteLine($"#{++seq} {DateTime.Now} => {title}");
                Thread.Sleep(1000);
            }
        }
    }
}
