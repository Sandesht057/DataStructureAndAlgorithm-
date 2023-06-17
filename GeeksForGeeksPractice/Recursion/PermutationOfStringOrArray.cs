using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PermutationOfStringOrArray
  {
    public void RecurPermutation(int[] array, List<int> ds, List<List<int>> ans, bool[]freq)
    {
       if(ds.Count == array.Length)
        {
          ans.Add(new List<int>(ds));
          return;
        }

      for (int i = 0; i < array.Length; i++)
      {
        if (!freq[i])
        {
          freq[i] = true;
          ds.Add(array[i]);
          RecurPermutation(array, ds, ans, freq);
          ds.RemoveAt(ds.Count - 1);
          freq[i] = false;

        }
      }
    }


    public void RecurPermute(int index, int[] nums, List<List<int>> ans)
    {
      if (index == nums.Length)
      {
        // copy the ds to ans
        List<int> ds = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
          ds.Add(nums[i]);
        }
        ans.Add(new List<int>(ds));
        return;
      }
      for (int i = index; i < nums.Length; i++)
      {
        Swap(i, index, nums);
        RecurPermute(index + 1, nums, ans);
        Swap(i, index, nums);
      }
    }

    private void Swap(int i, int j, int[] nums)
    {
      int t = nums[i];
      nums[i] = nums[j];
      nums[j] = t;
    }


    public void RecurPermutationBySwapping(int[] array,int index,List<List<int>>ans)
    {
      if (index == array.Length)
      {
        List<int> ds = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
          ds.Add(array[i]);
        }
        ans.Add(new List<int>(ds));
        return;
      }

      for (int i = index; i < array.Length; i++)
      {
        swap(array, i,index);
        RecurPermutationBySwapping(array,index+1,ans);
        swap(array, i, index);


      }
    }

    void swap(int[] array, int left, int right)
    {
      int temp = array[left];
      array[left] = array[right];
      array[right] = temp;

    }




  }
}
