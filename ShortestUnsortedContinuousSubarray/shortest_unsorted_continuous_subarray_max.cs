public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        if (nums.Length <= 1) {
            return 0;
        }
        int left = nums.Length - 1;
        int right = 0;
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] < nums[i]) {
                    right = Math.Max(right, j);
                    left = Math.Min(left, i);
                }
            }
        }
        
        return right - left < 0 ? 0 : right - left + 1;
    }
}
