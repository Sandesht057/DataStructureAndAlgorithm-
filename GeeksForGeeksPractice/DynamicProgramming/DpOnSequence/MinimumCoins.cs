using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class MinimumCoins
  {

    public int FindMinimumCoins(int[] arr, int target,int index)
    {

      if (index == 0)
      {
        if (target%arr[0] == 0)
        {
          return target / arr[0];
        }
        return (int)Math.Pow(10, 9);
      }

      int notTaken = 0+ FindMinimumCoins(arr, target, index - 1);
      int Taken = (int)Math.Pow(10,9);
      if (arr[index] <= target)
      {
        Taken = 1+ FindMinimumCoins(arr, target - arr[index], index);
      }
      return Math.Min(notTaken, Taken);

    }

  }
}
