using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class CountPartitionsWithGivenDifference
  {

    int mod = (int)(Math.Pow(10, 9) + 7);

    public int CountPartitionWithDifference(int[] arr, int diff)
    {
      int totalSum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        totalSum += arr[i];
      }
      if (totalSum < diff) return 0;
      if ((totalSum - diff) % 2 == 1) return 0;
      int target = (totalSum - diff) / 2;
      return CountPossiblePartition(arr, arr.Length - 1, target);
    }


    public int CountPossiblePartition(int[] arr,int index, int target)
    {

      if (index == 0)
      {
          if(target==0 && arr[0] == 0)
          {
            return 2;
          }
          if(target==0 && arr[0] == target)
          {
            return 1;
          }
        return 0;
      }
      int notTaken = CountPossiblePartition(arr, index - 1, target);
      int taken = 0;
      if (arr[index] <= target)
      {
        taken = CountPossiblePartition(arr, index - 1, target - arr[index]);
      }
      return (notTaken + taken) %mod;
    }

    public int findWaysUtil(int ind, int target, int[] arr, int[][] dp)
    {

      if (ind == 0)
      {
        if (target == 0 && arr[0] == 0)
          return 2;
        if (target == 0 || target == arr[0])
          return 1;
        return 0;
      }

      if (dp[ind][target] != -1)
        return dp[ind][target];

      int notTaken = findWaysUtil(ind - 1, target, arr, dp);

      int taken = 0;
      if (arr[ind] <= target)
        taken = findWaysUtil(ind - 1, target - arr[ind], arr, dp);

      return dp[ind][target] = notTaken + taken;
    }

    public int findWays(int[] num, int k)
    {
      int n = num.Length;
      int[][] dp= new int[n][];
      for (int i = 0; i < n; i++)
      {
        dp[i] = new int[k + 1];
        for (int j = 0; j < k+1; j++)
        {
          dp[i][j] = -1;
        }
      }
      return findWaysUtil(n - 1, k, num, dp);
    }


  }
}
