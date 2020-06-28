public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);
        bool found = false;
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i - 1] == nums[i]) {
                found = true;
                result = nums[i];
            }
        }
        
        return result;
    }
}
