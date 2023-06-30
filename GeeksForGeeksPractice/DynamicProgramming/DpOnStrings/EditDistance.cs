using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class EditDistance
  {
    public int EditDistanceUtil(string s1,string s2, int i, int j)
    {
      if (i < 0)
      {
        return j + 1;
      }

      if (j < 0)
      {
        return i + 1;
      }

      if (s1[i] == s2[j])
      {
        return 0+ EditDistanceUtil(s1,s2,i-1,j-1);
      }
      else
      {
        return 1+Math.Min(EditDistanceUtil(s1, s2, i-1, j - 1), Math.Min(EditDistanceUtil(s1, s2, i - 1, j), EditDistanceUtil(s1, s2, i, j - 1)));
      }

    }


    public int EditDistanceUtilmemoization(string s1, string s2, int i, int j, int[][] dp)
    {
      if (i < 0)
      {
        return j + 1;
      }

      if (j < 0)
      {
        return i + 1;
      }

      if (dp[i][j] !=-1)
      {
        return dp[i][j];
      }

      if (s1[i] == s2[j])
      {
        return dp[i][j] = 0 + EditDistanceUtilmemoization(s1, s2, i - 1, j - 1,dp);
      }
      else
      {
        return dp[i][j] =1 + Math.Min(EditDistanceUtilmemoization(s1, s2, i - 1, j - 1,dp),
                   Math.Min(EditDistanceUtilmemoization(s1, s2, i - 1, j,dp),
                   EditDistanceUtilmemoization(s1, s2, i, j - 1,dp)));
      }

    }

    public int EditDistanceTabulation(string s1,string s2,int m, int n)
    {
      int[][] dp = new int[m+1][];

      for (int i = 0; i <= m; i++)
      {
        dp[i] = new int[n + 1];
      }

      for (int i = 0; i <=m ; i++)
      {
        dp[i][0] = i;
      }

      for (int j = 0; j <= n; j++)
      {
        dp[0][j] = j;
      }


      for (int k = 1; k <=m ; k++)
      {
        for (int l = 1; l <= n; l++)
        {
          if (s1[k-1] == s2[l - 1])
          {
            dp[k][l] = 0+dp[k - 1][l - 1];
          }
          else
          {
            dp[k][l] = 1 + Math.Min(dp[k - 1][l - 1], Math.Min(dp[k][l - 1], dp[k - 1][l]));
          }

        }
      }
      return dp[m][n];

    }
 

  }
}
