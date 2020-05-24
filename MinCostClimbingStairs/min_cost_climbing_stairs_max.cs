public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int costJump1 = 0;
        int costJump2 = 0;
        int bestJumpCost = 0;
        for (int i = cost.Length - 1; i >= 0; i--) 
        {
            bestJumpCost = cost[i] + Math.Min(costJump1, costJump2);
            costJump1 = costJump2;
            costJump2 = bestJumpCost;
        }
        
        return Math.Min(costJump1, costJump2);
    }
}
