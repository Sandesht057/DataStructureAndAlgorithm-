using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class LongestCommonSebSequence
  {

    public int LongestCommonSubQUntil(string s1,string s2,int index1,int index2)
    {
      if(index1<0|| index2 < 0)
      {
        return 0;
      }

      if (s1[index1] == s2[index2])
      {
        return 1 + LongestCommonSubQUntil(s1, s2, index1 - 1, index2 - 1);
      }
      else
      {
        return 0 + Math.Max(LongestCommonSubQUntil(s1,s2,index1,index2-1),LongestCommonSubQUntil(s1,s2,index1-1,index2));
      }
    }

    public int LongestCommonSubQUntilMemo(string s1, string s2, int index1, int index2, int[][] dp)
    {
      if (index1 < 0 || index2 < 0)
      {
        return 0;
      }

      if (dp[index1][index2] != -1)
      {
        return dp[index1][index2];
      }

      if (s1[index1] == s2[index2])
      {
        return 1 + LongestCommonSubQUntilMemo(s1, s2, index1 - 1, index2 - 1,dp);
      }
      else
      {
        return 0 + Math.Max(LongestCommonSubQUntilMemo(s1, s2, index1, index2 - 1,dp), LongestCommonSubQUntilMemo(s1, s2, index1 - 1, index2,dp));
      }
    }

    public int LongestCommonSubTabulation(string s1,string s2, int[][] dp,int m,int n)
    {
      for (int i = 0; i <=n ; i++)
      {
        dp[i][0] = 0;
      }

      for (int j = 0; j <=m ; j++)
      {
        dp[0][j] = 0;
      }

      for (int ind = 1; ind <= m; ind++)
      {
        for (int ind1 = 1; ind1 <= n; ind1++)
        {
          if (s1[ind-1] == s2[ind1-1])
          {
            dp[ind][ind1] = 1 + dp[ind - 1][ind1 - 1];
          }
          else
          {
            dp[ind][ind1] = 0 + Math.Max(dp[ind - 1][ind1], dp[ind][ind1 - 1]);
          }
        }
      }
      return dp[n][m];
    }

    public int LCS(string s1,string s2)
    {
      int m = s1.Length;
      int n = s2.Length;

      int[][] dp = new int[m+1][];
      for (int i = 0; i <= m; i++)
      {
        dp[i] = new int[n+1];
        for (int j = 0; j <= n; j++)
        {
          dp[i][j] = -1;
        }
      }

      //return LongestCommonSubQUntil(s1, s2, m - 1, n - 1);
     // return LongestCommonSubQUntil(s1, s2, m - 1, n - 1);
      return LongestCommonSubTabulation(s1, s2,dp, m, n);
    }

  }
}
