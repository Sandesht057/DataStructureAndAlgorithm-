using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class LongestIncreasingSubSeQUsingBinarySearch
  {
    public int LongestIncSubSeQByBinarySearch(int[] arr,int n)
    {
      List<int> temp = new List<int>();
      temp.Add(arr[0]);

      int k = 1;
      for (int i = k; i < arr.Length; i++)
      {
        if (arr[i] > temp[temp.Count - 1])
        {
          temp.Add(arr[i]);
          k++;
        }
        else
        {
          int index = Array.BinarySearch(temp.ToArray(),arr[i]);
          if (index < 0)
          {
            index = ~index;
          }
          temp[index] = arr[i];
        }
      }
      return k;
    }
  }
}
