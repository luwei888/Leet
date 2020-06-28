using LeetCode._3._101_150;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeBestTime_121 = new TradeBestTime_121();

            Console.WriteLine(DateTimeOffset.Now.Second + "+" + DateTimeOffset.Now.Millisecond);

            Console.WriteLine(tradeBestTime_121.MyRun());

            Console.WriteLine(DateTimeOffset.Now.Second + "+" + DateTimeOffset.Now.Millisecond);

            Console.WriteLine(DateTimeOffset.Now.Second + "+" + DateTimeOffset.Now.Millisecond);

            Console.WriteLine(tradeBestTime_121.BestRun());

            Console.WriteLine(DateTimeOffset.Now.Second + "+" + DateTimeOffset.Now.Millisecond);
        }
    }
}
