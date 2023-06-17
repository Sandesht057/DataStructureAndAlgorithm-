using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintInTermsOfNto1
  {
    public void PrintNumber(int N, int i)
    {
      if (i>N)
      {
        return;
      }
      Console.WriteLine(N);
      PrintNumber(N - 1, i);
    }
  }
}
