using System;
using System.Diagnostics;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            System.Threading.Thread.Sleep(600);
            crono2.Start();
            System.Threading.Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();

            Console.WriteLine("Crono 1: " + )



        }
    }
}
