using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            Random random_Value = new Random(s);

            int value = 0;

            for(int i = 0; i < n; i++)
            {
                int value_between = random_Value.Next(1,7);
                value += value_between;
                
            }
            Console.WriteLine(value);
        }
    }
}
