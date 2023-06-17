using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  internal class CombinationSumII
  {
    public void FindAllUniqueCombination(int[] array, int index,int target,  List<int> ds,   List<List<int>> res)
    {

      if (target == 0)
      {
        res.Add(new List<int>(ds));
        return;
      }

      for (int i=index; i<array.Length;i++)
      {
        if (i > index && array[i] == array[i - 1]) continue;
        if (array[i] > target) break;

        ds.Add(array[i]);
        FindAllUniqueCombination(array, i+1,target-array[i], ds, res);
        ds.RemoveAt(ds.Count - 1);

      }
    }


    public void FindCombinations(int ind, int[] arr, int target, List<List<int>> ans, List<int> ds)
    {
      if (target == 0)
      {
        ans.Add(new List<int>(ds));
        return;
      }

      for (int i = ind; i < arr.Length; i++)
      {
        if (i > ind && arr[i] == arr[i - 1]) continue;
        if (arr[i] > target) break;

        ds.Add(arr[i]);
        FindCombinations(i + 1, arr, target - arr[i], ans, ds);
        ds.RemoveAt(ds.Count - 1);
      }
    }


  }
}
