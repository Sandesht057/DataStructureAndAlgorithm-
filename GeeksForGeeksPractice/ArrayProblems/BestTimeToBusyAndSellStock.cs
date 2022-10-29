using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class BestTimeToBusyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maximumProfit = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                int result = prices[i] - prices[i+1];
                if (result < 0)
                {
                    maximumProfit += Math.Abs(result);
                }
            }
            return maximumProfit;
        }
    }
}
