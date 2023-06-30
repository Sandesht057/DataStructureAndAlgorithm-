using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStock
{
  internal class BuyAndSellStockII
  {
    public int FindMaxProfit(int[] arr,int index,int n, int buy)
    {
      if (index == n)
      {
        return 0;
      }

      int profit=0;

      if (buy == 0)
      {
        profit= Math.Max( 0+ FindMaxProfit(arr, index + 1, n, 0),
          -arr[index] + FindMaxProfit(arr, index + 1, n, 1));
      }

      if (buy == 1)
      {
        profit= Math.Max(  FindMaxProfit(arr, index+1, n, 1),
         arr[index] + FindMaxProfit(arr, index + 1, n, 0));

      }
      return profit;
    }

    public int FindMaxProfitTabulation(int[] arr, int n)
    {
      int[][] dp = new int[n + 1][];
      for (int i = 0; i <= n; i++)
      {
        dp[i] = new int[2];
        for (int j = 0; j < 2; j++)
        {
          dp[i][j] = -1;
        }
      }

      dp[n][0] = dp[n][1] = 0;

      int profit = 0;

      for (int ind = n-1; ind >=0; ind--)
      {
        for (int buy = 0; buy <= 1; buy++)
        {
          if (buy == 0)
          {
            profit = Math.Max(0 + dp[ind + 1][0], -arr[ind] + dp[ind + 1][1]);
          }

          if (buy == 1)
          {
            profit = Math.Max(0 + dp[ind + 1][1], arr[ind] + dp[ind + 1][0]);
          }

          dp[ind][buy] = profit;
        }
      }

      return dp[0][0];

    }





  }
}
