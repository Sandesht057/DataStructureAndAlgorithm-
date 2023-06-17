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
                //res.Add(new List<int>(set));
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

        public void GenerateSubsets(int[] subset, int index, int n)
        {
          if (index == n)
          {
            PrintSubset(subset, n);
            return;
          }
          subset[index] = 1;
          GenerateSubsets(subset, index + 1, n);

          subset[index] = 0;
          GenerateSubsets(subset, index + 1, n);
        }

        public  void PrintSubset(int[] subset, int n)
        {
          Console.Write("{ ");
          for (int i = 0; i < n; i++)
          {
            if (subset[i] == 1)
            {
              Console.Write((i + 1) + " ");
            }
          }
          Console.WriteLine("}");
        }



  }
}
