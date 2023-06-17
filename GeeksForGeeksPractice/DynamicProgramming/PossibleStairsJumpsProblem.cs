using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  public  class PossibleStairsJumpsProblem
  {

    public  int FindOutMaximumPossibleWayToClimbStairs(int n)
    {
      if (n == 0)
      {
        return 1;
      }

      if (n == 1)
      {
        return 1;
      }

      int left = FindOutMaximumPossibleWayToClimbStairs(n - 1);
      int right = FindOutMaximumPossibleWayToClimbStairs(n - 2);
      return left + right;
    }


  }
}
