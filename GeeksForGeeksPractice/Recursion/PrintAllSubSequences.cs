using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintAllSubSequences
  {
    public void PrintSubsequence(int[] arr,int n,int index, List<int>  ds)
    {
      if (n ==index)
      {
        string[] result = ds.Select(i => i.ToString()).ToArray();
        Console.WriteLine(String.Join(", ", result));
        if(ds.Count == 0)
        {
          Console.WriteLine("");
        }
        return;

      }

      ds.Add(arr[index]);
      PrintSubsequence(arr, n, index + 1, ds);
      ds.Remove(arr[index]);
      PrintSubsequence(arr, n, index + 1, ds);
    }
  }
}
