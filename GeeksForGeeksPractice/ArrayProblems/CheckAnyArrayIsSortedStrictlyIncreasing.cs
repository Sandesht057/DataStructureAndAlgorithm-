using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class CheckAnyArrayIsSortedStrictlyIncreasing
    {
        public bool RecursiveApproachCheck(int[]  array,int index)
        {

            if(index == array.Length-1)
            {
                return true;
            }
            if(array[index] >= array[index+1])
            {
                return false;
            }
            return RecursiveApproachCheck(array, index + 1);

        }






    }
}
