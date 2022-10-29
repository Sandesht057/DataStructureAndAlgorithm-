using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class MoveAllXtoTheEndOfTheString
    {
        int count = 0;
        public string RecursiveApproach(string inputString,int index,string resultString)
        {

            if(index == inputString.Length - 1)
            {
                for (int i = 0; i < count; i++)
                {
                    resultString += "X";
                }
                return resultString;
            }
            if('X' == inputString[index])
            {
                count++;
            }
            else
            {
                resultString += inputString[index];
            }

            return RecursiveApproach(inputString, index + 1, resultString);
        }
    }
}
