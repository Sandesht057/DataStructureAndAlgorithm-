using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming
{
  internal class MaximumNoOfMeritNinjaEarn
  {

    public int MaxiMumNoOfMeritNinjaEarn(int day,int last, int[][] points)
    {
        if (day == 0)
        {
          int max = 0;
          for (int i = 0; i <= 2; i++)
          {
            if (i != last)
            {
              int  res = points[0][i];
              max = Math.Max(max, points[0][i]);
            }
          }
          return max;
        }

        int maxi = 0;
        for(int i=0; i <= 2; i++)
        {
          if (i != last)
          {
            int activity = points[day][i] + MaxiMumNoOfMeritNinjaEarn(day - 1, i, points);
            maxi = Math.Max(maxi, activity);
          }
        }
        return maxi;
     }

    public int FindMaximumFromArray(int index, int[] arr)
    {

      if (index == 0)
      {
        return arr[index];
      }
      int max1 = 0;
      int item = FindMaximumFromArray(index - 1, arr);
      max1 = Math.Max(item, arr[index]);
      return max1; 
    }

    public int FindFromall(int[][]arr,int  days)
    {
      int max = 0;
      for (int i = 0; i <days ; i++)
      {
        int particularMax = FindMaximumFromArray(arr[i].Length-1, arr[i]);
        max = Math.Max(max, particularMax);
      }
      return max;
    }



  }

}
