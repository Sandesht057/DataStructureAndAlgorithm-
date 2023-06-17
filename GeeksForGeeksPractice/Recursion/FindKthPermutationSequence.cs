using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  internal class FindKthPermutationSequence
  {

    public void swap(char[] s,int i,int j)
    {
      char temp = s[i];
      s[i] = s[j];
      s[j] = temp;
    }

    public void FindPermutaion(char[] data, int index,List<string>res)
    {
      if(data.Length == index)
      {
        String st = new string(data);
        res.Add(st);
        return;
      }

      for (int i=index; i<data.Length; i++)
      {
        swap(data, index, i);
        FindPermutaion(data, index + 1, res);
        swap(data, index, i);
      }

    }

  }
}
