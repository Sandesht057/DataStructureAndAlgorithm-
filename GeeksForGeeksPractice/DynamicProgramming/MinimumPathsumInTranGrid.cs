using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class MinimumPathsumInTrangularGrid
  {

    public int MinimumPathInTrangle(int[][] matrix,int i, int j,int n, int[][] dp)
    {
     

      if (i == n)
      {
        return matrix[i][j];
      }

      if (dp[i][j] != -1)
      {
        return dp[i][j];
      }

      int down =  matrix[i][j] + MinimumPathInTrangle(matrix, i +1,j,n,dp);
      int downLeft = matrix[i][j] + MinimumPathInTrangle(matrix,i+1,j+1,n,dp);
      return dp[i][j]= Math.Min(down, downLeft);
    }



  }
}
