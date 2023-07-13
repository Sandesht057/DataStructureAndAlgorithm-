using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{


  internal class LongestStringChain
  {

    public bool Compare(string s1, string s2)
    {

      if (s2.Length != s1.Length + 1)
      {
        return false;
      }
      int first = 0;
      int second = 0;
      while (second < s2.Length)
      {
        if (first < s1.Length &&  s1[first] == s2[second])
        {
          first++;
          second++;
        }
        else
        {
          second++;
        }
      }

      if (first == s1.Length && second == s2.Length)
        return true;
      else
        return false;

    }

    public int LongestIncreasingChain(string[] arr,int n)
    {
      Array.Sort(arr);

      int[] dp = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        dp[i] = 1;
      }
  
      int maxi = 1;

      for (int i = 0; i <= n - 1; i++)
      {
        for (int prev_index = 0; prev_index <= i - 1; prev_index++)
        {
          if (Compare(arr[prev_index], arr[i]) && 1 + dp[prev_index] > dp[i])
          {
            dp[i] = 1 + dp[prev_index];
          }
        }
        if (dp[i] > maxi)
        {
          maxi = dp[i];
        }
      }
      return maxi;
    }






  }
}
