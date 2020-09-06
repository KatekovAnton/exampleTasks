public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if (nums.Length < 2)
            return nums.Length;
        
        int[] rise = new int[nums.Length];
        int[] fall = new int[nums.Length];
        
        for (int i = 1; i < nums.Length; i++) {
            for(int j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    rise[i] = Math.Max(rise[i], fall[j] + 1);
                } else if (nums[i] < nums[j]) {
                    fall[i] = Math.Max(fall[i], rise[j] + 1);
                }
            }
        }
        return 1 + Math.Max(fall[nums.Length - 1], rise[nums.Length - 1]);
    }
}
