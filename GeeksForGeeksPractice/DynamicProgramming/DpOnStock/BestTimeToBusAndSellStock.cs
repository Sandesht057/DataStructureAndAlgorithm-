using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStock
{
  internal class BestTimeToBusAndSellStock
  {

    public int FindMaximumProfit(int[] arr)
    {
      int min = arr[0];
      int max = 0;

      for (int i = 1; i < arr.Length; i++)
      {

          int currentProfit = arr[i]-min;
          max = Math.Max(max, currentProfit);
          min = Math.Min(min, arr[i]);
      }
      return max;
    }




  }
}
