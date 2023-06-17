using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintingSubSequencesWhoseSumIsK
  {
    public void PrintSubK(int[] array,int index,int n, int initialSum, int target,List<int>ds)
    {
      if(index == n)
      {
        if (initialSum == target)
        {
          string[] result = ds.Select(i => i.ToString()).ToArray();
          Console.WriteLine(String.Join(", ", result));
        }
        return;
      }
      ds.Add(array[index]);
      initialSum += array[index];
      PrintSubK(array, index + 1,n, initialSum, target, ds);
      ds.Remove(array[index]);
      initialSum -= array[index];
      PrintSubK(array, index + 1, n, initialSum, target, ds);
    }

  }
}
