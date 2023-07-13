using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class LongestIncreasingSubSequence
  {

      public int LISSofar(int[] arr,int n,int index,int previousIndex)
      {
          if(index == n)
          {
            return 0;
          }

          int notTaken = 0 + LISSofar(arr, n, index+1,previousIndex);
          int taken = 0;
          if(previousIndex ==-1 || arr[index] > arr[previousIndex])
          {
            taken = 1 + LISSofar(arr, n, index + 1, index);
          }
          return Math.Max(notTaken, taken);
      }

      public int LongestIncreasingSubsequenceTabulation(int[] arr,int n)
      {
          int[][] dp = new int[n+1][];
          for (int i = 0; i <=n ; i++)
          {
            dp[i] = new int[n + 1];
          }

          for (int i = n-1; i>=0; i--)
          {
            for (int j = i-1;  j>=-1; j--)
            {
              int notTaken = 0 + dp[i + 1][j+1];
              int Taken = 0;

              if(j==-1 || arr[i] > arr[j])
              {
                Taken = 1 + dp[i + 1][i + 1];
              }

              dp[i][j+1] = Math.Max(notTaken, Taken);
            }

          }
          return dp[0][0];
      }

      public int LongestIncreasingSubSeq(int[] arr,int n)
      {
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
          dp[i] = 1;
        }

        for (int index = 0; index < n; index++)
        {
          for (int previousIndex = 0; previousIndex < index ; previousIndex++)
          {
            if (arr[previousIndex] < arr[index])
            {
              dp[index] = Math.Max(dp[index], 1 + dp[previousIndex]);
            }
          }
        }

        int ans = -1;
        for (int i = 0; i < n-1; i++)
        {
          ans = Math.Max(ans, dp[i]);
        }

        return ans;

      }


    public  int LongestIncreasingSubsequence(int[] arr)
    {
      int n = arr.Length;
      int[] dp = new int[n];

      for (int i = 0; i < n; i++)
      {
        dp[i] = 1;
      }

      for (int i = 0; i < n; i++)
      {
        for (int prev_index = 0; prev_index < i; prev_index++)
        {
          if (arr[prev_index] < arr[i])
          {
            dp[i] = Math.Max(dp[i], 1 + dp[prev_index]);
          }
        }
      }

      int ans = -1;

      for (int i = 0; i < n; i++)
      {
        ans = Math.Max(ans, dp[i]);
      }

      return ans;
    }




  }
}
