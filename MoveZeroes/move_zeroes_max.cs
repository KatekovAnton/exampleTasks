public class Solution {
    public void MoveZeroes(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == 0) {
                int j = i + 1;
                while (nums[j] == 0 && j < nums.Length - 1) {
                    j++;
                }
                nums[i] = nums[j];
                nums[j] = 0;
            }
        }
    }
}
