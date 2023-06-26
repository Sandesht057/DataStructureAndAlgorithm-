using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class RoadCuttingProblem
  {
      public int FindBestPrice(int[] arr,int n,int index)
      {
        if (index == 0)
        {
          return arr[0] * n;
        }
        int notTaken = FindBestPrice(arr, n, index - 1);
        int taken = 0;
        if (arr[index] <= n)
        {
          taken = FindBestPrice(arr, n, index);
        }
        return Math.Max(notTaken, taken);
      }

  }
}
