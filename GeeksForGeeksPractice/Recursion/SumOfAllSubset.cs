using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  internal class SumOfAllSubset
  {
    public void SumOfAllSubSet(int[] array,int index, List<List<int>>res , List<int> path)
    {

      if(index == array.Length)
      {
        res.Add(new List<int>(path));
        return;
      }

      for (int i=index; i<array.Length; i++)
      {





      }


    }

  }
}
