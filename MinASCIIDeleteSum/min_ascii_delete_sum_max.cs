public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int[][] dp = new int[s1.Length + 1][];
        for (int i = 0; i <= s1.Length; i++) {
            dp[i] = new int[s2.Length + 1];
        }
        for (int i = s1.Length - 1; i >= 0; --i) {
            dp[i][s2.Length] = dp[i + 1][s2.Length] + (int)s1[i];
        }
        for (int j = s2.Length - 1; j >= 0; --j) {
            dp[s1.Length][j] = dp[s1.Length][j + 1] + (int)s2[j];
        }
        for (int i = s1.Length - 1; i >= 0; --i) {
            for (int j = s2.Length - 1; j >= 0; --j) {
                if (s1[i] == s2[j]) {
                    dp[i][j] = dp[i + 1][j + 1];
                } else {
                    dp[i][j] = Math.Min(dp[i + 1][j] + (int)s1[i], dp[i][j + 1] + (int)s2[j]);
                }
            }
        }
        
        return dp[0][0];
    }
}
