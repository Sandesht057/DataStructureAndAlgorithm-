using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class MaximumFallingPathSum
  {

    public int FindMaxOfAll(int[][] matrix, int k)
    {
      int minimum = (int)Math.Pow(-10, 9);
      for (int i = 0; i < k; i++)
      {
        minimum = Math.Max(minimum, MaximumFallingPath(matrix, k-i, i,k));
      }
      return minimum;
    }

    public int MaximumFallingPath(int[][] matrix, int x, int y,int M)
    {
      if(y<0 || y>=M)
      {
        return (int)Math.Pow(-10, 9);
      }

      if (x == 0)
      {
        return matrix[0][y];
      }

      int down = matrix[x][y] + MaximumFallingPath(matrix, x - 1, y,M);
      int leftdown = matrix[x][y] + MaximumFallingPath(matrix, x - 1, y - 1,M);
      int rightdown = matrix[x][y] + MaximumFallingPath(matrix, x - 1, y + 1,M);

      return Math.Max(down, Math.Max(leftdown, rightdown));
    }

    public int FindMaxofallMemoization(int[][]matrix,int M, int[][]dp)
    {
      int minValue = (int)Math.Pow(-10, 9);
      for (int i = 0; i < M; i++)
      {
        minValue = Math.Max(minValue, GetMaxUtil(M - 1, i, M,matrix, dp));
      }
      return minValue;
    }


    public int FindMaxofallMemoizationTwo(int[][] matrix, int M, int[][] dp)
    {
      int minValue = (int)Math.Pow(-10, 9);
      for (int i = 0; i < M; i++)
      {
         minValue = Math.Max(minValue, MaximumFallingPathMemoization(matrix, M-1, i, M, dp));
      }
      return minValue;
    }


    public int MaximumFallingPathMemoization(int[][]matrix,int x, int y,int M, int[][]dp)
    {

       if(y<0 || y >= M)
       {
          return (int)Math.Pow(-10, 9);
       }

      if (x == 0)
      {
        return matrix[0][y];
      }

      if (dp[x][y] != -1)
      {
        return dp[x][y];
      }

      int up = matrix[x][y] + MaximumFallingPathMemoization(matrix, x-1, y, M, dp);
      int leftDiagonal = matrix[x][y] + MaximumFallingPathMemoization(matrix, x - 1, y-1, M, dp);
      int rightDiagonal = matrix[x][y] + MaximumFallingPathMemoization(matrix, x - 1, y+1, M, dp);

      return dp[x][y]= Math.Max(up, Math.Max(leftDiagonal, rightDiagonal));
    }

    public int GetMaxUtil(int i, int j, int m, int[][] matrix, int[][] dp)
    {
      // Base Conditions
      if (j < 0 || j >= m)
        return (int)Math.Pow(-10, 9);
      if (i == 0)
        return matrix[0][j];

      if (dp[i][j] != -1) return dp[i][j];

      int up = matrix[i][j] + GetMaxUtil(i - 1, j, m, matrix, dp);
      int leftDiagonal = matrix[i][j] + GetMaxUtil(i - 1, j - 1, m, matrix, dp);
      int rightDiagonal = matrix[i][j] + GetMaxUtil(i - 1, j + 1, m, matrix, dp);

      return dp[i][j] = Math.Max(up, Math.Max(leftDiagonal, rightDiagonal));
    }

    public int GetMaxPathSumTabulation(int[][] matrix)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;

        int[][] dp= new int[n][];
        for (int i = 0; i < n; i++)
        {
          dp[i] = new int[m];  
          dp[0][i] = matrix[0][i];
        }

        for (int i = 1; i < n; i++)
        {
          for (int j = 0; j < m; j++)
          {
            int up = matrix[i][j] + dp[i - 1][j];

            int leftDiagonal = matrix[i][j];
            if (j - 1 >= 0) leftDiagonal += dp[i - 1][j - 1];
            else leftDiagonal += (int)Math.Pow(-10, 9);

            int rightDiagonal = matrix[i][j];
            if (j + 1 < m) rightDiagonal += dp[i - 1][j + 1];
            else rightDiagonal += (int)Math.Pow(-10, 9);

            dp[i][j] = Math.Max(up, Math.Max(leftDiagonal, rightDiagonal));

          }
        }
        int maxi = int.MinValue;
        for (int i = 0; i < m; i++)
        {
          maxi = Math.Max(maxi, dp[n - 1][i]);
        }
        return maxi;
    }




  }
}
