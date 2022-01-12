using System;
using System.Reflection;
using System.Threading;

namespace hello_devops
{
    public class Program
    {
        const string title="Create Pipeline from Jekinsfile";
        public static void Main()
        {
            string appVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();

            int seq = 0;
            while (true)
            {
                Console.WriteLine($"#{++seq} {DateTime.Now} => {title} V{appVersion}");
                Thread.Sleep(1000);
            }
        }
    }
}
