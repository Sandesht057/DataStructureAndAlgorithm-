using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class PartitionSetInto2subsetWithMinSumDiff
  {
    //public bool MinAbsoluteSum(int[] arr, int index, int target, int[][] dp)
    //{
    //  if (target == 0)
    //    return dp[index][target] = true;
    //  if (index == 0)
    //    return arr[0] == target;
    //  bool notTaken = MinAbsoluteSum(arr,  index - 1, target,dp);
    //  bool taken = false;
    //  if (arr[0] <= target)
    //  {
    //    taken = MinAbsoluteSum(arr, index - 1, target - arr[index],dp);
    //  }
    //  return notTaken || taken;
    //}

    public int MinSubsetSumDifference(int[] arr, int  n)
    {

      int totalsum= 0;

      for (int i = 0; i < n; i++)
      {
        totalsum += arr[i];
      }


      int[][] dp =  new int[n][];
      for (int i = 0; i <n ; i++)
      {
        dp[i] = new int[totalsum];
        for (int j = 0; j < totalsum; j++)
        {
          dp[i][j] = -1;
        }
      }

      for (int i = 0; i < totalsum; i++)
      {
        //bool dummy = MinAbsoluteSum(arr, n, n - 1,dp);
      }

      int mini = int.MinValue;

      for (int i = 0; i <= totalsum; i++)
      {
        if (dp[n - 1][i] != 0)
        {
          int diff = Math.Abs(i - (totalsum - i));
          mini = Math.Min(mini, diff);
        }
      }
      return mini;

    }


  }
}
