using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.DynamicProgramming.DpOnStrings
{
  internal class WildCardMatching
  {
    bool isAllStar(string s1,int i)
    {
      for (int j = 0; j < i; j++)
      {
        if (s1[i] != '*')
          return false;
      }
      return true;
    }


     public bool WildCardMatch(string s1,string s2,int i,int j)
    {

      if (j < 0 && i <0)
      {
        return true;
      }

      if (i < 0 && j >=0)
      {
        return false;
      }

      if(i>=0 && j < 0)
      {
        return isAllStar(s1, i);
      }

      if (s1[i] == s2[j] || s1[i] == '?')
      {
        return WildCardMatch(s1, s2, i - 1, j - 1);
      }
      else
      {
        if (s1[i] == '*')
        {
          return WildCardMatch(s1, s2, i - 1, j) || WildCardMatch(s1,s2,i,j-1);
        }
        return false;
      }

    }
  }
}
