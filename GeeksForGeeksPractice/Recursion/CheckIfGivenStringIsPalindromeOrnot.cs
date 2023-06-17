using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksPractice.Recursion
{
  public class CheckIfGivenStringIsPalindromeOrnot
  {
     public bool IsPalindrome(int[] array,int index)
    {
      if (index > array.Length / 2)
      {
        return true;
      }
      if (array[index]!= array[array.Length - index - 1])
      {
        return false;
      }
      return IsPalindrome(array, index + 1);

    }
  }
}
