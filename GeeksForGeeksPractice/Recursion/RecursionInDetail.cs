using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.Recursion
{
  public class RecursionInDetail
  {
    public void PrintValue(int n)
    {
      if (n < 1)
      {
        return;
      }
      else
      {
        Console.WriteLine("FirtstValue" + n);
        PrintValue(n - 1);
        Console.WriteLine("SecondValue" + n);
      }
    }
  }
}
