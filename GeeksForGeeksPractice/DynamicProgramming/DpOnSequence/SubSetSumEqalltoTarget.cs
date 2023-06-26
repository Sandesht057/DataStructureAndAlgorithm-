using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class SubSetSumEqalltoTarget
  {
    public bool FindSubSetSum(int n, int[] arr, int target)
    {

      if (target == 0)
      {
        return true;
      }

      if (n == 0)
      {
        return false;
      }

      bool notTaken = FindSubSetSum(n - 1, arr, target);
      bool taken = false;

      if (arr[n] <= target)
      {
        taken = FindSubSetSum(n - 1, arr, target - arr[n]);
      }
      return notTaken || taken;

    }

    public bool FindSubSetSumTabulation(int n, int[] arr, int k)
    {
      bool[][] dp = new bool[n][];
      for (int i = 0; i < n; i++)
      {
        dp[i] = new bool[k+1];
        dp[i][0] = true;
      }

      if (arr[0]<=k)
      {
        dp[0][arr[0]] = true;
      }

      for (int ind = 1; ind < n; ind++)
      {
        for (int target = 1; target <= k; target++)
        {

          bool notTaken = dp[ind - 1][target];
          bool taken = false;
          if (arr[ind] <= target)
            taken = dp[ind - 1][target - arr[ind]];

          dp[ind][target] = notTaken || taken;
        }
      }
      return dp[n - 1][k];

    }

    public bool FindSubSetSumMemoization(int n, int[] arr, int target, int[][] dp)
    {

      if (target == 0)
      {
        return true;
      }

      if (n == 0)
      {
        return false;
      }

      if (dp[n][target] != -1)
      {
        return  dp[n][target]==1?true:false;
      }

      bool notTaken = FindSubSetSumMemoization(n - 1, arr, target, dp);
      bool taken = false;

      if (arr[n] <= target)
      {
        taken = FindSubSetSumMemoization(n - 1, arr, target - arr[n], dp);
      }

      dp[n][target] = notTaken || taken ? 1 : 0;
      return  notTaken || taken ;
    }




  }
}
