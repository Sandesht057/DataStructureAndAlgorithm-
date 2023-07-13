using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class LongextBitonicSubSequence
  {
    public int LongestBitonicSubSeq(int[] arr, int n)
    {
      int[] dp = new int[n];
      int[] dp1 = new int[n];

      for (int i = 0; i < n; i++)
      {
        dp[i] = 1;
      }

      for (int i = 0; i < n; i++)
      {
        dp1[i] = 1;
      }

      for (int index = 0; index < n; index++)
      {
        for (int prevIndex = 0; prevIndex < index-1; prevIndex++)
        {
          if (arr[prevIndex] < arr[index])
          {
            dp[index] = Math.Max(dp[index], 1 + dp[prevIndex]);
          }
        }
      }


      for (int index = n-1; index >=0 ; index--)
      {
        for (int prevIndex = n-1; prevIndex >index; prevIndex--)
        {

          if (arr[prevIndex] < arr[index])
          {
            dp1[index] = Math.Max(dp1[index], 1 + dp1[prevIndex]);
          }

        }
      }

      int maxi = 1;
      for (int i = 0; i < n; i++)
      {
        maxi = Math.Max(maxi, dp[i] +dp1[i]-1);
      }
      return maxi;


    }

  }
}
