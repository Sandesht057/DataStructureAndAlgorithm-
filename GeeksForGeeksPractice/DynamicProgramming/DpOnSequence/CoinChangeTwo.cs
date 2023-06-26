using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class CoinChangeTwo
  {

     public int CountWaysToChangeUtil(int[] arr,int index,int target)
     {

      if (index == 0)
      {
        if (target%arr[0]==0)
        {
          return 1;
        }
        return 0;
      }

      int notTaken = CountWaysToChangeUtil(arr, index - 1, target);
      int taken = 0;
      if (arr[index] <= target)
      {
        taken = CountWaysToChangeUtil(arr, index, target - arr[index]);
      }

      return notTaken + taken;
     }
  }
}
