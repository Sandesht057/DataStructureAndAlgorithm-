using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintSubSequenceWhoseSumIsSum
  {
    public bool PirntSubSumIsSum(int[] array,int index,int initailSum,int targetSum, int n, List<int> ds)
    {
      if (index == n)
      {
        if (initailSum == targetSum)
        {
          string[] result = ds.Select(i => i.ToString()).ToArray();
          Console.WriteLine(String.Join(", ", result));
          return true;
        }
        else
        {
          return false;
        }     
      }
      ds.Add(array[index]);
      initailSum += array[index];
      if (PirntSubSumIsSum(array, index+1, initailSum, targetSum, n, ds) == true)
      {
        return true;
      }
      initailSum -= array[index];
      ds.Remove(array[index]);

      if(PirntSubSumIsSum(array, index+1, initailSum, targetSum, n, ds) == true)
      {
        return true;
      }
      return false;

    }
  }
}
