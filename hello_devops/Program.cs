using System;
using System.Reflection;
using System.Threading;

namespace hello_devops
{
    public class Program
    {
        public static void Main()
        {

            string comName = Environment.MachineName.ToString();
            string appName = Assembly.GetEntryAssembly().GetName().Name;
            string appVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
            string userName = "Tony";
            int seq = 0;
            while (true)
            {
                Console.WriteLine($"#{++seq} {DateTime.Now} => {appName}@{comName} V{appVersion}");
                Console.WriteLine($"\tMy name is {userName}");
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}
