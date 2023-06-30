using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStock
{
  internal class BuyandSellStockWithCooldown
  {
    public int FindProfitWithCooldown(int[] arr,int index, int n,int buy)
    {
      if(index >= n)
      {
        return 0;
      }

      int profit = 0;

      if (buy == 0)
      {
        profit = Math.Max(0+FindProfitWithCooldown(arr, index + 1, n, 0), -arr[index] + FindProfitWithCooldown(arr, index + 1, n, 1));
      }

      if (buy == 1)
      {
        profit = Math.Max(0+FindProfitWithCooldown(arr, index + 1, n, 1), arr[index] + FindProfitWithCooldown(arr, index + 2, n, 0));
      }

      return profit;
    }

    public int FindProfitWithCooldownTabulation(int[] arr, int n)
    {
      int[][] dp = new int[n+2][];

      for (int i = 0; i <n+2 ; i++)
      {
        dp[i] = new int[2] {0,0 };
      }

      for (int i = n-1; i >=0; i--)
      {
        for (int buy = 0; buy <=1 ; buy++)
        {
            if(buy == 0)
            {
              dp[i][buy] = Math.Max(0+dp[i + 1][0], -arr[i] + dp[i + 1][1]);
            }

            if(buy == 1)
            {
              dp[i][buy] = Math.Max(0+dp[i + 1][1], arr[i] + dp[i + 2][0]);
            }
        }
      }

      return dp[0][0];

    }
  }
}
