using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnLongestIncreasingSubSequence
{
  internal class LongestDivisibleSubSet
  {
      public int LongestDivisibleSubSetUtil(int[] arr,int n,int index,int previousIndex)
      {

        if (n == index)
        {
          return 0;
        }

        int notTaken = LongestDivisibleSubSetUtil(arr, n, index + 1,previousIndex);
        int Taken = 0;
        if(previousIndex ==-1 || arr[index] % arr[previousIndex] ==0)
        {
          Taken = 1+ LongestDivisibleSubSetUtil(arr, n, index + 1, previousIndex);
        }
        return Math.Max(notTaken, Taken);
      }
    public  List<int> DivisibleSet(List<int> arr)
    {
      int n = arr.Count;
      arr.Sort();

      int[] dp = new int[n];
      int[] hash = new int[n];

      for (int i = 0; i <= n - 1; i++)
      {
        hash[i] = i; 
        for (int prev_index = 0; prev_index <= i - 1; prev_index++)
        {
          if (arr[i] % arr[prev_index] == 0 && 1 + dp[prev_index] > dp[i])
          {
            dp[i] = 1 + dp[prev_index];
            hash[i] = prev_index;
          }
        }
      }

      int ans = -1;
      int lastIndex = -1;

      for (int i = 0; i <= n - 1; i++)
      {
        if (dp[i] > ans)
        {
          ans = dp[i];
          lastIndex = i;
        }
      }

      List<int> temp = new List<int>();
      temp.Add(arr[lastIndex]);

      while (hash[lastIndex] != lastIndex) 
      {
        lastIndex = hash[lastIndex];
        temp.Add(arr[lastIndex]);
      }
      temp.Reverse();

      return temp;
    }


    public string LongestDivisibleSubSetMemo(int[] arr, int n)
    {

      int[] dp = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        dp[i] = 1;
      }
      int[] hash = new int[n];
      for (int i = 0; i <= n - 1; i++)
      {
        hash[i] = i;
        for (int prev_index = 0; prev_index <= i - 1; prev_index++)
        {

          if (arr[i] % arr[prev_index] == 0 && 1 + dp[prev_index] > dp[i])
          {
            dp[i] = 1 + dp[prev_index];
            hash[i] = prev_index;
          }
        }
      }


      int ans = -1;
      int lastIndex = -1;

      for (int k = 0; k < n - 1; k++)
      {
        if (dp[k] > ans)
        {
          ans = dp[k];
          lastIndex = k;
        }
      }

      List<int> tem = new List<int>();
      tem.Add(arr[lastIndex]);

      while (hash[lastIndex] != lastIndex)
      {
        lastIndex = hash[lastIndex];
        tem.Add(arr[lastIndex]);
      }

      string str = "";
      for (int i = tem.Count - 1; i >= 0; i--)
      {
        str += tem[i];
      }
      return str;

    }





  }
}
