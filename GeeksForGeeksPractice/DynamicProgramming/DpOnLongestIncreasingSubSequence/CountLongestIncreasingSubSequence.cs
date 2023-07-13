using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class CountLongestIncreasingSubSequence
  {

    public int CountLIS(int[] arr, int n)
    {
      int[] dp = new int[n];

      int[] ct = new int[n];

      for (int i = 0; i < n; i++)
      {
        dp[i] = 1;
        ct[i] = 1;
      }

      int maxi = 1;
      for (int index = 0; index < n; index++)
      {
        for (int prevIndex = 0; prevIndex <= index-1; prevIndex++)
        {

          if (arr[prevIndex] < arr[index] && dp[prevIndex]+1 > dp[index])
          {
            dp[index] = dp[prevIndex] + 1;
            ct[index] = ct[prevIndex];
          }
          else if (arr[prevIndex] < arr[index]  && dp[prevIndex]+1 == dp[index])
          {
            ct[index] = ct[index] + ct[prevIndex];
          }
        }
        maxi = Math.Max(maxi, dp[index]);

      }

      int nos = 0;
      for (int i = 0; i < n; i++)
      {
        if (dp[i] == maxi)
        {
          nos += ct[i];
        }
      }

      return nos;

    }


  }
}
