using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class MinimumPathSumInGrid
  {

    public int FindMinimumSumUniquePath(int[][] arr,int i,int j)
    {

      if (i == 0 && j == 0)
      {
        return arr[0][0];
      }

      if(i<0 || j < 0)
      {
        return (int)Math.Pow(10,9);
      }
      var res = FindMinimumSumUniquePath(arr, i - 1, j);
      var gres = arr[i][j];
      int moveUpward = gres+res;
      int moveleft = arr[i][j] + FindMinimumSumUniquePath(arr, i, j - 1);
      return Math.Min(moveUpward, moveleft); ;
    }

    public int FindMinimumSumUniquePathTabulation(int[][] arr, int i, int j, int[][]dp)
    {

      if (i == 0 && j == 0)
      {
        return arr[0][0];
      }

      if (i < 0 || j < 0)
      {
        return (int)Math.Pow(10, 9);
      }

      if (dp[i][j] != -1)
      {
        return dp[i][j];
      }

      var res = FindMinimumSumUniquePathTabulation(arr, i - 1, j,dp);
      var gres = arr[i][j];
      int moveUpward = gres + res;
      int moveleft = arr[i][j] + FindMinimumSumUniquePathTabulation(arr, i, j - 1,dp);
      return dp[i][j]= Math.Min(moveUpward, moveleft); ;
    }

    public int FindMinimumSumUniquePathWithSpaceOpt(int[][] arr, int x, int y)
    {

      int[] prev = new int[y];
      for (int i = 0; i < x; i++)
      {
        int[] current = new int[y];
        for (int j = 0; j < y; j++)
        {
          if(i==0 && j == 0)
          {
              current[j] = arr[i][j];
          }
          else
          {
            int down = arr[i][j];
            if (i > 0)
            {
              down += prev[j];
            }
            else
            {
              down += (int)Math.Pow(10, 9);
            }

            int right = arr[i][j];
            if (j > 0)
            {
              right += current[j-1];
            }
            else
            {
              right += (int)Math.Pow(10, 9);
            }
            current[j] = Math.Min(down, right);
          }
        }
        prev = current;
      }
      return prev[y - 1];
    }






  }
}
