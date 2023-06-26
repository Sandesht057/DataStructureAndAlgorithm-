using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class PrintLongestCommonSubSequence
  {
    public string PrintLongestComSubSeq(string s1,string s2)
    {
      int n= s1.Length;
      int m= s2.Length;

      int[][] dp = new int[n][];

      for (int i = 0; i <=n+1 ; i++)
      {
        dp[i] = new int[m+1];
        for (int j = 0; j <= m; j++)
        {
          dp[i][j] = -1;
        }
      }

      for (int x = 0; x < n; x++)
      {
        dp[x][0] = 0;
      }

      for (int y = 0; y < m; y++)
      {
        dp[0][y] = 0;
      }


      for (int index1 = 1; index1 <= n; index1++)
      {
        for (int index2 = 1; index2 <= m; index2++)
        {
          if (s1[index1-1] == s2[index2])
          {
            dp[index1][index2] = 1 + dp[index1 - 1][index2 - 1];
          }
          else
          {
            dp[index1][index2] = 0 + Math.Max(dp[index1][index2 - 1], dp[index1 - 1][index2]);
          }
        }
      }

      int len = dp[n][m];
      int o = n;
      int p = m;

      string dummyString = "";

      while (o>0&&p>0)
      {



      }





    }
  }
}
