public class Solution {
    public int MaximumSum(int[] arr) {
        int[][] dp = new int[arr.Length][];
        for (int i = 0; i < dp.Length; i++) {
            dp[i] = new int[2];
        }
        
        dp[0][0] = arr[0];
        dp[0][1] = arr[0];
        int maxSum = arr[0];
        
        for (int i = 1; i < arr.Length; i++) {
            dp[i][0] = Math.Max(dp[i-1][0] + arr[i], arr[i]);
            dp[i][1] = Math.Max(Math.Max(dp[i-1][1] + arr[i], dp[i-1][0]), arr[i]);
            maxSum = Math.Max(maxSum, Math.Max(dp[i][0], dp[i][1]));
        }
        
        return maxSum;
    }
}
