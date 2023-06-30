using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class MinInsertionToMakePalindrome
  {
    public static string ReverseString(string str)
    {
      char[] charArray = str.ToCharArray();
      Array.Reverse(charArray);
      return string.Join("", charArray);
    }

    public int MinInsertion(string s)
    {
      string s1 = ReverseString(s);
      int n = s.Length;

      LongestPalindromicSubSequence lps = new LongestPalindromicSubSequence();
      return n-lps.LPS(s1);
    }


  }
}
