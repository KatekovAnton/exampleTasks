public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        Array.Sort(difficulty, profit);
        Array.Sort(worker);
        
        int i = 0, j = 0, maxProfit = 0, gains = 0;
        
        while(j < worker.Length)
        {
            if(i < difficulty.Length && difficulty[i] <= worker[j])
            {
                maxProfit = Math.Max(maxProfit, profit[i]);
                i++;
            }
            else
            {
                gains += maxProfit;
                j++;
            }
        }
        return gains;
    }
}
