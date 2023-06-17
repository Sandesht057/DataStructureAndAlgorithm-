using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class ReverseArray
  {
      public int[] ReverseArrayUsingRecursion(int[] array,int left,int right)
      {
        if (left >= right)
        {
          return array;
        }
        swap(array, left, right);
        return ReverseArrayUsingRecursion(array, left+1, right-1);
      }


    public int[] ReverseArrayUsingSinglePointer(int[] array, int index)
    {
      if (index >= array.Length/2)
      {
        return array;
      }
      swap(array, index, array.Length-index-1);
      return ReverseArrayUsingSinglePointer(array, index);
    }

    void swap(int[] arr,int l, int r)
    {
      int temp = arr[l];
      arr[l] = arr[r];
      arr[r] = temp;
    }
  }
}
