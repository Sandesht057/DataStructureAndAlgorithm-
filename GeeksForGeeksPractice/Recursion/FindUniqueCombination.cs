using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class FindUniqueCombination
  {
    public void findUniqueCombo(int index, int[] arr,int target,List<List<int>>ans,List<int>ds)
    {
      if (target == 0)
      {
        ans.Add(new List<int>(ds));
        return;
      }

      for (int i = index; i < arr.Length; i++)
      {
        
        if (i > index && arr[i] == arr[i - 1]) continue;
        if (arr[i] > target) break;

        ds.Add(arr[i]);
        findUniqueCombo(i + 1, arr, target - arr[i], ans, ds);
        ds.RemoveAt(ds.Count - 1);
      }

    }
  }
}
