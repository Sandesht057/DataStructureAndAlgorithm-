using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class KnapSackProblem
  {

     public int KnapSackSolution(int[] wt, int[] val, int W, int index)
    {

      if (index == 0)
      {
        if (wt[0] <= W)
        {
          return val[0];
        }
        return 0;
      }
      int max = (int)Math.Pow(-10,9);
      int notTaken = KnapSackSolution(wt, val, W, index - 1);
      int Taken = (int)Math.Pow(-10,9);
      if (wt[index] <= W)
      {
        Taken = val[index] + KnapSackSolution(wt, val, W - wt[index], index - 1);
      }
      max = Math.Max(notTaken, Taken);

      return max;
    }


  }
}
