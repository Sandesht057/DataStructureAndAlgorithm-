using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class NinjaAndHisFriends
  {

    public int maximumColocolate(int[][] matrix,int i, int j1,int j2, int n, int m, int[][][] grid)
    {
      if(j1<0 || j2<0 || j1>=m || j2 >= m)
      {
        return (int)Math.Pow(-10, 9);
      }

      if (i == n - 1)
      {
        if (j1 == j2)
        {
          return matrix[i][j1];
        }
        else
        {
          return matrix[i][j1] + matrix[i][j2];
        }
      }

      if (grid[i][j1][j2] != -1)
      {
        return grid[i][j1][j2];
      }

      int maxi = int.MinValue;
      for(int d1=-1; d1 <= 1; d1++)
      {
        for (int d2 = -1; d2 <=1; d2++)
        {
          int ans;
          if (j1 == j2)
          {
            ans = matrix[i][j1] + maximumColocolate(matrix, i, j1+d1, j2+d2, n, m, grid);
          }
          else
          {
            ans = matrix[i][j1] + matrix[i][j2] + maximumColocolate(matrix, i, j1+d1, j2+d2, n, m, grid);
          }
          maxi = Math.Max(maxi, ans);
        }
      }
      return grid[i][j1][j2] = maxi;
    }

    public int NinjaAndHisFriend(int[][] matrix,int i, int j1,int  j2,int n, int m)
    {
      if( j1<0 || j2<0 || j1>=m || j2 >= m)
      {
        return (int)Math.Pow(-10, 9);
      }

      if (i == n - 1)
      {
        if (j1==j2)
        {
          return matrix[i][j1];
        }
        else
        {
          return matrix[i][j1] + matrix[i][j2];
        }
      }

      int maxi = int.MinValue;
      for (int d1=-1; d1<=1;d1++)
      {
        for (int d2 = -1; d2 <= 1; d2++)
        {
          int ans;
          if (j1 == j2)
          {
            ans = matrix[i][j1] + NinjaAndHisFriend(matrix, i + 1, j1 + d1, j2 + d2, n, m);
          }
          else
          {
            ans = matrix[i][j1] + matrix[i][j2] + NinjaAndHisFriend(matrix, i + 1, j1 + d1, j2 + d2, n, m);
          }
          maxi = Math.Max(maxi, ans);
        }
      }
      return maxi;
    }







  }

}
