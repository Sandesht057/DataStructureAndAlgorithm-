using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class PrintOfStringInReverse
    {
        public string PrintReverseStringIterativeApproach(String inputValue)
        {
            string reverseString = "";           
            for (int i = inputValue.Length-1; i >=0; i--)
            {
                reverseString += inputValue[i];
            }
            return reverseString;
        }

        public string reverseStringValue = "";
        public string PrintReverseStringRecursiveApproach(string inputValue,int index)
        {

            if (index == 0)
            {
                //Console.WriteLine(inputValue[index]);
               return  reverseStringValue += inputValue[index];
                
            }
            // Console.WriteLine(inputValue[index]);
            reverseStringValue += inputValue[index];
            PrintReverseStringRecursiveApproach(inputValue, index - 1);
            return reverseStringValue;
        }

    }
}
