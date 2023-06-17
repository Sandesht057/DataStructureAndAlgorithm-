using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PrintNameNTimes
  {
    public  void PrintName(int N)
    {
      if (N == 0)
      {
        return;
      }
      Console.WriteLine("My Name is Sandes Thapa");
      PrintName(N - 1);
    }
  }


}
