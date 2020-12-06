public class Solution {
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, delegate(int[] pair1, int[] pair2) {
                    return pair1[0] - pair2[0];
        });
        int[] dp = new int[pairs.Length];
        dp[pairs.Length - 1] = 1;
        for (int i = pairs.Length - 2; i >= 0; i--) {
            for (int j = pairs.Length - 1; j > i; j--) {
                if (pairs[i][1] < pairs[j][0]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        int maxChain = 0;
        for (int i = 0; i < dp.Length; i++) {
            if (dp[i] > maxChain) {
                maxChain = dp[i];
            }
        }
        return maxChain;
    }
}
