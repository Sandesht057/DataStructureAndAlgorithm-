using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class PrintAllSubsetOfNaturalNumber
    {
        public void FindSubset(List<int> set,int n)
        {
            if (n == 0)
            {
                PrintSubset(set);
                return;
            }
            set.Add(n);
            FindSubset(set, n - 1);
            set.Remove(set.Count - 1);
            FindSubset(set, n - 1);
        }
        public void PrintSubset(List<int> set)
        {
            for (int i = 0; i < set.Count; i++)
            {
                Console.WriteLine("" + set[i]);
            }
        }
    }
}
