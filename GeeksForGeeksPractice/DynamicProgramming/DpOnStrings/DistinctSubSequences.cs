using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class DistinctSubSequences
  {
     public int FindDistinctSubSequence(string s1,string s2,int index1, int index2)
     {
        if (index2 < 0)
        {
          return 1;
        }

        if (index1 < 0)
        {
          return 0;
        }

        if (s1[index1] == s2[index2])
        {
          return FindDistinctSubSequence(s1, s2, index1 - 1, index2 - 1) + FindDistinctSubSequence(s1, s2, index1 - 1, index2);
        }
        else
        {
          return FindDistinctSubSequence(s1, s2, index1 - 1, index2);
        }
     }

     public int FindDistinctSubSeqMemoization(string s1,string s2,int m, int n)
    {

      int[][] dp = new int[m+1][];

      for (int i = 0; i <= m; i++)
      {
        dp[i] = new int[n + 1];
      }

      for (int x = 0; x <= m; x++)
      {
        dp[x][0] = 1;

      }

      for (int y = 1; y <= n; y++)
      {
        dp[0][y] = 0;
      }


      for (int k = 1; k <=m ; k++)
      {
        for (int l = 1; l <=n; l++)
        {
          if (s1[k-1] == s2[l-1])
          {

            dp[k][l] = dp[k - 1][l - 1] + dp[k - 1][l];
          }
          else
          {
            dp[k][l] = dp[k - 1][l];
          }
        }
      }
      return dp[m][n];

    }

    public int SubsequenceCounting(string s1, string s2, int n, int m)
    {
      int[,] dp = new int[n + 1, m + 1];

      for (int i = 0; i < n + 1; i++)
      {
        dp[i, 0] = 1;
      }
      for (int i = 1; i < m + 1; i++)
      {
        dp[0, i] = 0;
      }

      for (int i = 1; i < n + 1; i++)
      {
        for (int j = 1; j < m + 1; j++)
        {
          if (s1[i - 1] == s2[j - 1])
            dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j]) ;
          else
            dp[i, j] = dp[i - 1, j];
        }
      }

      return dp[n, m];
    }



  }
}
