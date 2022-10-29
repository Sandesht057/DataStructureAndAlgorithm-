
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public  class SubsetofNnaturalNo
    {
        public void FindSubset(int n, List<int> list)
        {

            if (n == 0)
            {
                PrintSubset(list);
                return;
            }

            list.Add(n);
            FindSubset(n - 1, list);
            list.Remove(list.Count - 1);
            FindSubset(n - 1, list);
        }

        public void PrintSubset(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("" + list[i]);
            }
        }
    }
}
