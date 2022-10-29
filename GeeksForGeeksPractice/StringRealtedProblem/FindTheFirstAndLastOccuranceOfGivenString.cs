using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class FindTheFirstAndLastOccuranceOfGivenString
    {
        int firstOccurance=-1, lastOccurance = -1;
        int[] resultArray = new int[2];
        public int[] RecursiveApproach(string inputString,char givenString,int index)
        {
            if(index == inputString.Length)
            {
                resultArray[0] = firstOccurance;
                resultArray[1] = lastOccurance;
                return resultArray;
            }
            if(inputString[index] == givenString)
            {
                if (firstOccurance == -1)
                {
                    firstOccurance = index;
                }
                else
                {
                    lastOccurance = index;
                }
            }
            RecursiveApproach(inputString, givenString, index + 1);
   
            return resultArray;
        }

        public int[] IterativeApproach(string inputString,char givenString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] == givenString)
                {
                    if(firstOccurance == -1)
                    {
                        firstOccurance = i;
                    }
                    else
                    {
                        lastOccurance = i;
                    }
                    
                }
            }
            resultArray[0] = firstOccurance;
            resultArray[1] = lastOccurance;
            return resultArray;
        }
    }
}
