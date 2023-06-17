using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class FindGridUniquePathWithBlockage
  {

    public int FindPathWithBlockage(int[][] arr, int i, int j)
    {

      if (i>=0 && j>=0 && arr[i][j]==-1)
      {
        return 0;
      }
      if (i == 0 || j == 0)
      {
        return 1;
      }
      if (i < 0 || j < 0)
      {
        return 0;
      }
      int up = 0;
      int left = 0;
      up = FindPathWithBlockage(arr, i - 1, j);
      left = FindPathWithBlockage(arr, i, j - 1);
      return up + left;
    }
  }
}
