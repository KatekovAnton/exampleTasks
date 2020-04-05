using System;

namespace Test
{
    class Program
    { 
        public static int BiValLength(int[] nums) {
            if (nums.Length <= 2)
                return nums.Length;
            int maxLength = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int length = 1;
                int second = -1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (second == -1 && nums[i] != nums[j])
                    {
                        length++;
                        second = nums[j];
                    }
                    else if (nums[j] == nums[i] || nums[j] == second)
                        length++;
                    else
                        break;
                }
                if (length > maxLength)
                    maxLength = length;
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {4, 2, 2, 4, 2};
            Console.WriteLine(Program.BiValLength(nums));
        }
    }
}
