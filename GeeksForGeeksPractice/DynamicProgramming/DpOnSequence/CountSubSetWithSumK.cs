using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class CountSubSetWithSumK
  {
       public int CountSubSet(int[] arr,int index,int target)
       {       
          if(target == 0)
          {
            return 1;
          }

          if (index == 0)
          {
            if (arr[0] == target)
            {
              return 1;
            }
            return 0;
          }

          int notTaken = CountSubSet(arr, index - 1, target);
          int taken = 0;

          if (arr[index] <= target)
          {
            taken = CountSubSet(arr, index - 1, target - arr[index]);
          }
          return notTaken + taken;
       }


      public int CountSubSetMatchK(int[] arr,int target)
      {
          int n = arr.Length;

          int[][] dp = new int[n][];
          for (int i = 0; i < n; i++)
          {
            dp[i] = new int[target + 1];
            dp[i][0] = 1;
          }

          if (arr[0] <= target)
          {
            dp[0][arr[0]] = 1;
          }

          for (int x = 1; x < n; x++)
          {
            for (int j = 1; j <= target; j++)
            {
              int notTaken = dp[x - 1][j];

              int taken = 0;
              if (arr[x] <= j)
              {
                taken = dp[x - 1][j - arr[x]];
              }

              dp[x][j] = notTaken+taken;

            }
          }
          return dp[n - 1][target];
      }

      public  int FindWays(int[] num, int k)
      {
        int n = num.Length;
        int[,] dp = new int[n, k + 1];

        for (int i = 0; i < n; i++)
        {
          dp[i, 0] = 1;
        }

        if (num[0] <= k)
          dp[0, num[0]] = 1;

        for (int ind = 1; ind < n; ind++)
        {
          for (int target = 1; target <= k; target++)
          {
            int notTaken = dp[ind - 1, target];

            int taken = 0;
            if (num[ind] <= target)
              taken = dp[ind - 1, target - num[ind]];

            dp[ind, target] = notTaken + taken;
          }
        }

        return dp[n - 1, k];
      }





  }
}
