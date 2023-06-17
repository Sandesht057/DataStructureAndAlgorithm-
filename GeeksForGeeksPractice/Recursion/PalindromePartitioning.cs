using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class PalindromePartitioning
  {

    public void Solution(string s,int index,  List<string>path, List<List<string>> res)
    {
      if (index == s.Length)
      {
        res.Add( new List<string>(path));
        return;
      }
      for (int i=index; i<s.Length; i++)
      {
        if (IsPalindromeOrNot(s, index, i))
        {
          path.Add(s.Substring(index, i - index + 1));                                      
          Solution(s, i + 1, path, res);
          path.RemoveAt(path.Count-1);
        }
      }
    }

    bool IsPalindromeOrNot(string s, int start, int end)
    {

      while(start <= end)
      {
        if (s[start++] != s[end--])
        {
          return false ;
        }
      }
      return true;

    }


  }
}

