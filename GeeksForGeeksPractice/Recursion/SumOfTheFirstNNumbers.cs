using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class SumOfTheFirstNNumbers
  {
     public decimal SumValue(int N,int sum)
     {
        if (N == 0)
        {
          return sum;
        }
        sum += N;
        return SumValue(N - 1,sum);

     }

    public decimal SumValueAnotherApproach(int N)
    {
      if (N == 1)
      {
        return N;
      }
      return N+ SumValueAnotherApproach(N - 1);
    }


  }
}
