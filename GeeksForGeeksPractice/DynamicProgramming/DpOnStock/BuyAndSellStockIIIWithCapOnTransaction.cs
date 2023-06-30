using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStock
{
  internal class BuyAndSellStockIIIWithCapOnTransaction
  {
    public int BuyAndSellStockWithCapOnTran(int[] arr,int buy,int cap, int index, int n)
    {
      if(index == n || cap==0)
      {
        return 0;
      }

      int profit=0;

      if (buy == 0)
      {
        profit = Math.Max( BuyAndSellStockWithCapOnTran(arr, 0, cap, index + 1, n),
                -arr[index] + BuyAndSellStockWithCapOnTran(arr, 1, cap, index + 1, n));
      }

      if (buy == 1)
      {
        profit = Math.Max(BuyAndSellStockWithCapOnTran(arr, 1, cap, index + 1, n), arr[index]
                + BuyAndSellStockWithCapOnTran(arr, 0, cap - 1, index + 1, n));
      }

      return profit;  
    }

    public int BuyAnsSellStockWithCapOnTranTabulation(int[] arr)
    {
      int x = arr.Length;

      int[][][] dp = new int[x + 1][][];

      for (int i = 0; i < x+1; i++)
      {
        dp[i] = new int[2][];
        for (int j = 0; j <=1 ; j++)
        {
          dp[i][j] = new int[3] {0,0,0};
        }
      }

      for (int ind = x-1; ind >=0 ; ind--)
      {
        for (int buy = 0; buy <=1; buy++)
        {
          for (int cap = 1; cap <=2; cap++)
          {
            if(buy ==0)
            {
              dp[ind][buy][cap] = Math.Max(dp[ind + 1][0][cap], -arr[ind] + dp[ind + 1][1][cap]);
            }

            if (buy == 1)
            {
              dp[ind][buy][cap] = Math.Max(dp[ind + 1][1][cap], arr[ind] + dp[ind + 1][0][cap - 1]);
            }
     
          }
        }
      }

      return dp[0][0][2];
    }



  }
}
