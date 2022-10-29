using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.StringRealtedProblem
{
    public class PrintAllPermutationOfString
    {

        List<string> permutationOfString = new List<string>();
        public void PrintPermutation(string userInput,string permutation)
        {
            if(userInput.Length == 0)
            {
                Console.WriteLine("print", permutation);
                return;
            }
            for (int i = 0; i < userInput.Length; i++)
            {
                char currentChar = userInput[i];
                string leftSubString = userInput.Substring(0, i);
                string RightSubString = userInput.Substring(i + 1);
                string newString = leftSubString + RightSubString;
                PrintPermutation(newString, permutation + currentChar);

            }
        }

        public void PermutationOfStringIterativeApprovach(string givenString,int l, int r)
        {
            if (l == r)
            {
                permutationOfString.Add(givenString);
            }

            for (int i = l; i <=r ; i++)
            {
                givenString = Swap(givenString, l, i);
                PermutationOfStringIterativeApprovach(givenString, l+1, r);
                givenString = Swap(givenString, l, i);
            }
        }

        string Swap(string givenString,int l , int r)
        {
            char[] stringList = givenString.ToCharArray();
            char temp = stringList[l];
            stringList[l] = stringList[r];
            stringList[r] = temp;
            string newString = new string(stringList);
            return newString;
        }

    }
}
