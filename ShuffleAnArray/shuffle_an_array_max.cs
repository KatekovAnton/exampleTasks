public class Solution {
    
    private int[] nums;
    private int[] shuffled;
    private Random random;

    public Solution(int[] nums) {
        this.nums = (int[])nums.Clone();
        shuffled = nums;
        random = new Random();
        
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for (int i = 0; i < nums.Length; i++) {
            int j = random.Next(0, nums.Length);
            int temp = shuffled[i];
            shuffled[i] = shuffled[j];
            shuffled[j] = temp;
        }
        return shuffled;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */