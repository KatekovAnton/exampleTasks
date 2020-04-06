// https://leetcode.com/problems/permutations
using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class Solution {
        private IList<IList<int>> perms = new List<IList<int>>();

        private void doPermutations(List<int> currentPerm, List<int> nums)
        {
            if (nums.Count == 0)
            {
                perms.Add(currentPerm);
            }
            else
            {
                for (int i = 0; i < nums.Count; i++) 
                {
                    List<int> newPerm = new List<int>(currentPerm);
                    List<int> newNums = new List<int>(nums);
                    newPerm.Add(nums[i]);
                    newNums.RemoveAt(i);
                    doPermutations(newPerm, newNums);
                }
            }
        }
        
        public IList<IList<int>> Permute(int[] nums) {
            doPermutations(new List<int>(), nums.ToList());
            return perms;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3};
            Solution solver = new Solution();
            IList<IList<int>> permutations = solver.Permute(nums);
            foreach (IList<int> permutation in permutations)
            {
                foreach(int element in permutation)
                    Console.Write(element + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
