using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintLienarllyFrom1toN
  {
    public void PrintNumber(int N)
    {
      if (N == 0)
      {
        return;
      } 
      PrintNumber(N - 1);
      Console.WriteLine(N);
    }

    public void PrintNumberSecondApproach(int i,  int N)
    {
      if ( i >N)
      {
        return;
      }
      Console.WriteLine(i);
      PrintNumberSecondApproach(i+1,  N);
      
    }


  }
}
