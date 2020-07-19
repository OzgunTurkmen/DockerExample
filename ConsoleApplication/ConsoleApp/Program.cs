using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Hello World! " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
