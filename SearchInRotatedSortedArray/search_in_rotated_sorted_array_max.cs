public class Solution {
    public int Search(int[] nums, int target) {
        if (target == nums[0]) {
            return 0;
        }
        if (target < nums[0]) {
            int i = nums.Length - 1;
            while (i > 0 && nums[i] > target) {
                i--;
            }
            if (target == nums[i]) {
                return i;
            }
        } else {
            int i = 0;
            while (i < nums.Length - 1 && nums[i] < target) {
                i++;
            }
            if (target == nums[i]) {
                return i;
            }
        } 
        return -1;
    }
}
