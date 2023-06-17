using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class FindCombinationWithDuplicateValue
  {

    public void FindCombination(int[] array,int index,int target,List<List<int>>ans,List<int> ds)
    {
      if(index == array.Length)
      {
        if (target == 0)
        {
          ans.Add(new List<int>(ds));
        }
        return;
      }
      if (array[index] <= target)
      {
        ds.Add(array[index]);
        FindCombination(array, index, target - array[index], ans, ds);
        ds.RemoveAt(ds.Count-1);
      }
      FindCombination(array, index+1, target, ans, ds);
    }

  }
}
