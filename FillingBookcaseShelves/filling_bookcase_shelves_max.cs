public class Solution {
    private int[][] b;
    private int[] memo;
    
    public int MinHeightShelves(int[][] books, int shelf_width) {
        b = books;
        memo = new int[b.Length + 1];
        int r = dp(shelf_width, 0);
        return r;
    }
    
    private int dp(int sw, int i) {
        if(i>= b.Length)
            return 0;
        
        if(memo[i] != 0)
            return memo[i];
        
        int ch = b[i][1];
        
        if(i == b.Length - 1)
            return ch;
        
        int cw = sw;
        int ans = int.MaxValue;
        for(int k = i; k < b.Length && (cw - b[k][0]) >= 0; k++) { 
            cw -= b[k][0];
            ch = Math.Max(ch, b[k][1]);
            ans = Math.Min(ans, ch + dp(sw, k+1));
        }
        
        memo[i] = ans;
        return ans;
    }
}
