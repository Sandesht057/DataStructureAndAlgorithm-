
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public  class PrintUniqueSubsequenceofString
    {
        public HashSet<string> resultSet = new HashSet<string>();
        public void RecursiveApproach(string inputString,int index, string newString)
        {
            if (index == inputString.Length)
            {
                if (!resultSet.Contains(newString))
                {
                    resultSet.Add(newString);
                }
                return;
            }

            Char currentChar = inputString[index];
            RecursiveApproach(inputString, index + 1, newString + currentChar);
            RecursiveApproach(inputString, index + 1, newString);

        }


    }
}
