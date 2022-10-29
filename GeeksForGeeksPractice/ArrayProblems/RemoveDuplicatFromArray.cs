using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class RemoveDuplicatFromArray
    {
        public int RemoveDuplicate(int[] nums)
        {
            int count = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                    count++;
                }
            }
            return count;
        }
    }
}
