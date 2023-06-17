using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class CountTheSubSequenceWithSumK
  {
    public int CountTheSubSequence(int[] array,int n, int index,int initialSum,int targetSum,List<int> ds)
    {
        if(index == n)
        {
           if(initialSum == targetSum)
          {
            return 1;
          }
          else
          {
            return 0;
          }
        }
      ds.Add(array[index]);
      initialSum += array[index];
      int left = CountTheSubSequence(array, n, index+1, initialSum, targetSum, ds);
      initialSum -= array[index];
      ds.Remove(array[index]);
      int right = CountTheSubSequence(array, n, index+1, initialSum, targetSum, ds);
      return left + right;
    }
  }
}
