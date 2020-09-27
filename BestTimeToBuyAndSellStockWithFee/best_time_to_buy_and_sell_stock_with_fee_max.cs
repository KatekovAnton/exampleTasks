public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int sell = 0;
        int buy = -prices[0];
        for(int i = 1; i < prices.Length; i++) {
            sell = Math.Max(sell, buy + prices[i] - fee);
            buy = Math.Max(buy, sell - prices[i]);
        }
        
        return sell;
    }
}
