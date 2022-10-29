using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class _2SumProblem
    {
        int[] finalArray = new int[2];

        //Bruet Force solution
        public void FindSum(int[] array, int n)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (array[i] +array[j] == n)
                    {
                        finalArray[0] = array[i];
                        finalArray[1] = array[j];
                    }
                }
            }
        }

        //Optimize solution
        public void UsingHashMap(int[] arry,int n)
        {
            int length = arry.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < length; i++)
            {
                map.Add(arry[i], i);
            }
            for (int i = 0; i < length; i++)
            {
                int remaining = n-arry[i];

                if (map.ContainsKey(remaining) && map[remaining] != i)
                {
                    finalArray[0] = i;
                    finalArray[1] = map[remaining];
                }
            }
        }





    }
}
