using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class FibonacciNumber
  {
     public int PrintFibonacci(int N)
    {
      if (N<=1)
      {
        return N;
      }
      int left = PrintFibonacci(N - 1);
      int right = PrintFibonacci(N - 2);
      return left + right;

    }
  }
}
