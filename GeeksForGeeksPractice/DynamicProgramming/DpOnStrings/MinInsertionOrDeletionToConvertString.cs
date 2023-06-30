using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class MinInsertionOrDeletionToConvertString
  {

    public int MinInsertionOrDeletionToCnvString(string s1, string s2)
    {
      int n = s1.Length;
      int m = s2.Length;
      LongestCommonSebSequence lps = new LongestCommonSebSequence();
      int k= lps.LCS(s1,s2);
      return n - k + m - k;
    }

  }
}
