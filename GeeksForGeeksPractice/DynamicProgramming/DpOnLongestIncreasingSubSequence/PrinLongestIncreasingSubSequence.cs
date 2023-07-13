using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class PrinLongestIncreasingSubSequence
  {
    public string LongestIncreasingSubSequence(int[] arr, int n)
    {
      int[] dp = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        dp[i] = 1;
      }

      int[] hash = new int[n];
      for (int index = 0; index < n; index++)
      {
        hash[index] = index;
        for (int prevIndex = 0; prevIndex < index; prevIndex++)
        {
          if (arr[prevIndex] < arr[index] )
          {
            dp[index] = Math.Max(1 + dp[prevIndex], dp[index]);
            hash[index] = prevIndex;
          }             
        }
      }

      int ans = -1;
      int lastIndex = -1;

      for (int k = 0; k < n-1; k++)
      {
        if (dp[k] > ans)
        {
          ans = dp[k];
          lastIndex = k;
        }
      }

      List<int> tem = new List<int>();
      tem.Add( arr[lastIndex]);

      while (hash[lastIndex]!= lastIndex)
      {
        lastIndex = hash[lastIndex];
        tem.Add(arr[lastIndex]);
      }

      string str = "";
      for (int i = tem.Count - 1; i >= 0; i--)
      {
        str += tem[i];
      }
      return str;

    }
  }
}
