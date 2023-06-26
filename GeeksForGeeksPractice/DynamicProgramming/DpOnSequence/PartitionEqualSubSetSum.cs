using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnSequence
{
  internal class PartitionEqualSubSetSum
  {

    public bool subsetsumUtil(int ind, int target, int[] arr)
    {
      if (target == 0)
        return true;

      if (ind == 0)
        return arr[0] == target;

      bool notTaken = subsetsumUtil(ind - 1, target, arr);
      bool taken = false;

      if (arr[ind] <= target)
      {
        taken = subsetsumUtil(ind - 1, target - arr[ind], arr);
      }
      return taken || notTaken;
    }

    public bool CanPartition(int  n, int[] arr)
    {
      int totalSum = 0;
      for (int i = 0; i < n; i++)
      {
        totalSum += arr[i];
      }

      if (totalSum % 2 == 1) return false;
      else
      {
        int k = totalSum / 2;
        return subsetsumUtil(n - 1, k, arr);
      }
    }

  }
}
