using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class PrintAllSubSequenceOfString
    {
        List<string> resultString = new List<string>();
        public void PrintSubSequence(string inputString, string newString,int index)
        {
            if (index == inputString.Length)
            {
                Console.WriteLine("newString", newString);
                return;
            }

            char currentChar = inputString[index];
            PrintSubSequence(inputString,  newString + currentChar,index+1);
            PrintSubSequence(inputString, newString , index + 1);

        }
    }
}
