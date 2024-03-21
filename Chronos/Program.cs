using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();

            float tempoCrono1 = (float) crono1.Elapsed.TotalSeconds;
            float tempoCrono2 = (float) crono2.Elapsed.TotalSeconds;

            Console.WriteLine($"Crono 1: {tempoCrono1:f3}");
            Console.WriteLine($"Crono 2: {tempoCrono2:f3}");




        }
    }
}
