using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class _3SumArrayProblem
    {
        //brute Force approach
        List<dynamic> result = new List<dynamic>();
        int[] resultArray = new int[3];
        public void ThreeSumArrayProblem(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    for (int k = j+1; k < length; k++)
                    {
                        if(array[i]!=array[j] && array[i]!=array[k] && array[j] != array[k])
                        {
                            if(array[i]+array[j]+array[k] == 0)
                            {
                                resultArray[0] = array[i];
                                resultArray[1] = array[j];
                                resultArray[2] = array[k];
                                result.Add(resultArray);
                            }
                        }
                    }
                }
            }

        }
    }
}
