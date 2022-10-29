using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class RemoveDuplicateInString
    {
        bool[] mapArray = new bool[26];
        public void RecursiveApproach(string userInputString, int index, string resultString)
        {

            if(index == userInputString.Length - 1)
            {
                Console.WriteLine("newString", resultString);
                return;
            }
            if (mapArray[userInputString[index] - 'a'])
            {
                RecursiveApproach(userInputString, index + 1, resultString);
            }
            else
            {
                resultString += userInputString[index];
                mapArray[userInputString[index] - 'a'] = true;
                RecursiveApproach(userInputString, index + 1, resultString);
            }

        
            
        }
    }
}
