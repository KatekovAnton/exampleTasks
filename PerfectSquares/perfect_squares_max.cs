public class Solution {    
    public int NumSquares(int n) {
	    int[] dp = new int[n + 1];

	    for(int i = 1; i <= n; i++)
	    {
		    dp[i] = int.MaxValue;
            int j = 1;
            while (j * j <= i) {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                j++;
            }           
	    }

	    return dp[n];
    }
}
