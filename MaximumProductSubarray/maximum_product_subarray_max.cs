public class Solution {
    private List<int> dp = new List<int>();
    
    public int MaxProduct(int[] nums) {
        int max = int.MinValue;
        int product = 1;
        for (int i = 0; i < nums.Length; i++) {
            product *= nums[i];
            if (product > max) {
                max = product;
            }
            if (product == 0) {
                product = 1;
            }
        }
        
        product = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            product *= nums[i];
            if (product > max) {
                max = product;
            }
            if (product == 0) {
                product = 1;
            }
        }
        
        return max;
    }
}
