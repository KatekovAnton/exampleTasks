using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class Solution {
        public int MinStartValue(int[] nums)
        {
            int min = Int32.MaxValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                min = Math.Min(min, sum);
            }
            

            return Math.Max(1, -min + 1);
        }
}
    class Program
    { 
        static void Main(string[] args)
        {
            int[] nums = new int[] {-2, 1, -3, 4, -1, 2};
            Solution solver = new Solution();
            int sum = solver.MinStartValue(nums);
            Console.WriteLine(sum);
        }
    }
}

