using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class GridUniquePath
  {
    public int FindGridUniquePath(int[][] arr,int i, int j)
    {

      if (i < 0 || j < 0)
      {
        return 0;
      }
      if (i==0 || j == 0)
      {
        return 1;
      }
      int down = FindGridUniquePath(arr,i-1,j);
      int right = FindGridUniquePath(arr, i , j-1);
      return down + right;
    }

  }
}
