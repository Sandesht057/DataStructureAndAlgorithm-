using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class KnapSackWithInfiniteSupply
  {

    public int KnapSackInfiniteSupply(int[] arr, int[] val,int W,int index)
    {
      if (index == 0)
      {
        if (arr[0] <= W)
        {
          return (W / arr[0]) * val[0];
        }
        return 0;
      }

      int notTaken = 0+ KnapSackInfiniteSupply(arr, val, W, index - 1);
      int Taken = 0;
      if (arr[index] <= W)
      {
        Taken = val[index] + KnapSackInfiniteSupply(arr,val,W-arr[index],index);
      }
      return Math.Max(notTaken, Taken);
    }



  }
}
