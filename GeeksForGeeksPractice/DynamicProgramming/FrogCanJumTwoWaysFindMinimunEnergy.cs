using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class FrogCanJumTwoWaysFindMinimunEnergy
  {
    public int FindMinimumEnergy(int n, int[] height)
    {

      if(n == 0)
      {
        return 0;
      }
      int minimumEnergyFromJumpTwo = int.MaxValue;
      int funReturnn = FindMinimumEnergy(n - 1, height);
      int minimunEnergyFromJumpOne = funReturnn + Math.Abs(height[n] - height[n-1]);
      if (n > 1)
      {
        int funReturnn1 = FindMinimumEnergy(n - 2, height);
        minimumEnergyFromJumpTwo = funReturnn1 + Math.Abs(height[n] - height[n - 2]);
      }
      return Math.Min(minimunEnergyFromJumpOne, minimumEnergyFromJumpTwo);
    }


    public int FindMinimumEnergyMemoization(int n, int[] height, int[] dp)
    {

      if (n == 0)
      {
        return 0;
      }
      if (dp[n] != -1) return dp[n];

      int minimumEnergyFromJumpTwo = int.MaxValue;
      int funReturnn = FindMinimumEnergyMemoization(n - 1, height,dp);
      int minimunEnergyFromJumpOne = funReturnn + Math.Abs(height[n] - height[n - 1]);
      if (n > 1)
      {
        int funReturnn1 = FindMinimumEnergyMemoization(n - 2, height,dp);
        minimumEnergyFromJumpTwo = funReturnn1 + Math.Abs(height[n] - height[n - 2]);
      }
      return  dp[n]= Math.Min(minimunEnergyFromJumpOne, minimumEnergyFromJumpTwo);
    }


    public int FindMinimumEnergyTabulation(int n, int[] height, int[] dp)
    {

      dp[0] = 0;

      for(int ind=1; ind<n; ind++)
      {
        int jumpTwo = int.MaxValue;
        int jumpOne = dp[ind - 1] + Math.Abs(height[ind] - height[ind - 1]);

        if (ind > 1)
          jumpTwo = dp[ind - 2] + Math.Abs(height[ind] - height[ind - 2]);

        dp[ind] = Math.Min(jumpOne, jumpTwo);

      }

      return dp[n];
    }

  }
}
