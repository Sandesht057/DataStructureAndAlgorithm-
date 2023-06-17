using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class FactorialOfN
  {
    public decimal FindFactorial(int N)
    {
      if (N == 1)
      {
        return 1;
      }

      return N * FindFactorial(N - 1);
    }

  }
}
