using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class Solution {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int localMax = 0;
            int result = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                localMax = Math.Max(nums[i], nums[i] + localMax);
                if (localMax > result)
                    result = localMax;
            }
                
            return result;
        }
}
    class Program
    { 
        static void Main(string[] args)
        {
            int[] nums = new int[] {-2, 1, -3, 4, -1, 2};
            Solution solver = new Solution();
            int sum = solver.MaxSubArray(nums);
            Console.WriteLine(sum);
        }
    }
}

