using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStock
{
  internal class BuyAndSellStockWithFees
  {

    public int BuyAndSellStockWithFee(int[] arr,int index, int n,int buy,int fee)
    {
      if(index == n)
      {
        return 0;
      }

      int profit = 0;
      if (buy == 0)
      {
        profit = Math.Max(BuyAndSellStockWithFee(arr, index + 1, n, 0,fee),
                 -arr[index] + BuyAndSellStockWithFee(arr, index + 1, n, 1,fee));
      }

      if (buy == 1)
      {
        profit = Math.Max(BuyAndSellStockWithFee(arr, index + 1, n, 1, fee),
          arr[index] - fee + BuyAndSellStockWithFee(arr, index + 1, n, 0, fee));
      }

      return profit;
    }

    public int BuyAndSellStockWithFee(int[] arr,int n,int fee)
    {

      int[][] dp = new int[n+1][];
      for(int i = 0; i <= n; i++)
      {
        dp[i] = new int[2] { 0, 0 };
      }

      for (int i = n-1; i >=0; i--)
      {
        for (int buy = 0; buy <=1 ; buy++)
        {
          if (buy == 0)
          {
            dp[i][buy] = Math.Max(dp[i + 1][0], -arr[i] + dp[i + 1][1]);
          }

          if (buy == 1)
          {
            dp[i][buy] = Math.Max(dp[i + 1][1], arr[i]-fee + dp[i + 1][0]);
          }
        }
      }
      return dp[0][0];

    }

  }
}
