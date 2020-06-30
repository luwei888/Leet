using System;
using System.Runtime.ExceptionServices;

namespace LeetCode._3._101_150
{
    /// <summary>
    /// 121.买卖股票的最佳时机
    /// </summary>
    class TradeBestTime_121
    {

        public int[] Arrays { get; set; }

        public TradeBestTime_121()
        {
            Arrays = new int[10000];
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Arrays[i] = random.Next(1, 500);
            }
        }

        public int MyRun()
        {
            int temp = 0;
            for (int i = 0; i < Arrays.Length; i++)
            {
                for (int j = i + 1; j < Arrays.Length; j++)
                {
                    var test = Arrays[j] - Arrays[i];
                    if (test > temp)
                    {
                        temp = test;
                    }
                }
            }
            return temp;
        }

        public int BestRun()
        {
            int minPrice = int.MaxValue;
            int maxPrice = 0;
            for (int i = 0; i < Arrays.Length; i++)
            {
                if (Arrays[i] < minPrice)
                {
                    minPrice = Arrays[i];
                }
                else if (Arrays[i] - minPrice > maxPrice)
                {
                    maxPrice = Arrays[i] - minPrice;
                }
            }
            return maxPrice;
        }
    }
}
