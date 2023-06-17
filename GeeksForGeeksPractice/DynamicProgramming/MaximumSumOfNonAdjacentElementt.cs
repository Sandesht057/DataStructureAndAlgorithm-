using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class MaximumSumOfNonAdjacentElementt
  {
     public int MaiximumSumOfNonAdjacent(int[] arr,int index)
     {
        if(index == 0)
        {
          return arr[0];
        }
        if(index < 0)
        {
          return 0;
        }
        int take = MaiximumSumOfNonAdjacent(arr,index-2) + arr[index];
        int nonTake = MaiximumSumOfNonAdjacent(arr, index - 1) + 0;
        return Math.Max(take, nonTake);
     }

      public int MaiximumSumOfNonAdjacentTabulation(int[] arr, int index, int[] dp)
      {
        if (index == 0)
        {
          return arr[0];
        }
        if (index < 0)
        {
          return 0;
        }

        if (dp[index] != -1) {
          return dp[index];
        }

        int take = MaiximumSumOfNonAdjacentTabulation(arr, index - 2,dp) + arr[index];
        int nonTake = MaiximumSumOfNonAdjacentTabulation(arr, index - 1,dp) + 0;
        return  dp[index]= Math.Max(take, nonTake);
      }

      public int MaximumSumOfNonAdjacentMemoization(int[] arr, int index, int[] dp)
      {
        dp[0] = arr[0];

        for (int  i=1; i<index;i++)
        {
          int pick = arr[i];
          if (i > 1)
          {
            pick += dp[i - 2];
          }
          int nonpick = 0 + dp[i - 1];

          dp[i] = Math.Max(pick, nonpick);

        }
        return dp[index - 1];
      }

  }
}
