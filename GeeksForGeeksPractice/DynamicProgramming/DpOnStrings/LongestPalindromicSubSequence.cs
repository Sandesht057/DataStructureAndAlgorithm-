using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class LongestPalindromicSubSequence
  {

    public int LongestPalindromicSubSeq(string s1,string s2,  int ind1,int ind2)
    {
      if (ind1 < 0 || ind2 < 0)
      {
        return 0;
      }

      if (s1[ind1] == s2[ind2])
      {
        return 1 + LongestPalindromicSubSeq(s1, s2, ind1 - 1, ind2 - 1);
      }
      else
      {
        return 0 + Math.Max(LongestPalindromicSubSeq(s1, s2, ind1 - 1, ind2), LongestPalindromicSubSeq(s1, s2, ind1, ind2 - 1));
      }
    }

    public int LongestPalindromicSubSeqTabulation(string s1,string s2,int n, int m)
    {
      int[][] dp = new int[n+1][];
      for (int i = 0; i <= n; i++)
      {
        dp[i] = new int[m+1];
        for (int j = 0; j <= m; j++)
        {
          dp[i][j] = -1;
        }
      }

      for (int x = 0; x <= n; x++)
      {
        dp[x][0] = 0;
      }

      for (int y = 0; y <=m; y++)
      {
        dp[0][y] = 0;
      }

      for (int u = 1; u <= n; u++)
      {
        for (int v = 1; v <= m; v++)
        {
          if (s1[u-1] == s2[v-1])
          {
            dp[u][v] = 1 + dp[u - 1][v - 1];
          }
          else
          {
            dp[u][v] = Math.Max(dp[u][v - 1], dp[u - 1][v]);
          }
        }
      }
      return dp[n][m];
    }

    public static string ReverseString(string str)
    {
      char[] charArray = str.ToCharArray();
      Array.Reverse(charArray);
      return string.Join("", charArray);
    }

    public int LPS(string s1)
    {
      int n = s1.Length;

      string s2 = ReverseString(s1);

      int m = s2.Length;
      return LongestPalindromicSubSeqTabulation(s1, s2, n, m);
    }


  }
}
