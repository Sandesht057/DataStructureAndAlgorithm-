using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class FrogCanJumpKSteps
  {
    public int FindMinimumEnergyWithKStep(int n, int[] arr,int k)
    {

      if (n == 0)
      {
        return 0;
      }
      int minEnergry = int.MaxValue;
      for (int i = 1; i <= k; i++)
      {
        if (n - i >= 0)
        {
          int jumpEnergy=  FindMinimumEnergyWithKStep(n - i, arr, k) + Math.Abs(arr[n] - arr[n - i]);

         minEnergry= Math.Min(minEnergry, jumpEnergy);
        }
      }
      return minEnergry;
    }




  }
}
