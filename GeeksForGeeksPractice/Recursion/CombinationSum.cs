using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  internal class CombinationSum
  {
      public void FindCombinationSum(int[] arr,int[] set,  int target,int index)
      {

        if(index == arr.Length)
        {
          if (printTargetMatchSubSet(arr, set, target))
          {
            PrintSubset(arr,set, arr.Length);
          }
          return;
        }

        set[index] = 1;
        FindCombinationSum(arr, set, target, index+1);

        set[index] = 0;
        FindCombinationSum(arr, set, target, index+1);
      }

      public void FindCombinationSumTakeOwn(int[] arr, List<int> set, int target, int index,List<List<int>> result)
      {
        if(index == arr.Length)
        {
          if (target == 0)
          {
            result.Add(new List<int>(set));
          }
          return;
        }
        if (arr[index] <= target)
        {
          set.Add(arr[index]);
          FindCombinationSumTakeOwn(arr, set, target - arr[index], index,result);
          set.RemoveAt(set.Count()-1);
        }
        FindCombinationSumTakeOwn(arr, set, target, index + 1,result);
      }

    
      bool printTargetMatchSubSet(int[] arr,int[] subset, int target)
      {
          int sum = 0;
          for (int i = 0; i < arr.Length; i++)
          {
        
              if (subset[i] == 1)
              {
                sum += arr[i];
              }
          }
          if (target == sum)
          {
            return true;
          }
          return false;
      }

      public void PrintSubset(int[] arr,  int[] subset, int n)
      {
        Console.Write("{ ");
        for (int i = 0; i < n; i++)
        {
          if (subset[i] == 1)
          {
            Console.Write(arr[i] + " ");
          }
        }
        Console.WriteLine("}");
      }


  }
}
