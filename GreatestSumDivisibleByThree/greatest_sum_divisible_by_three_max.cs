public class Solution 
{
    public int MaxSumDivThree(int[] nums) 
    {
        var dp = new int[3];
        foreach(var num in nums)
        {
            var dpTemp = (int[]) dp.Clone();
            for(int i = 0; i < 3; i++)
            {
                int index = (dp[i] + num) % 3;
                dpTemp[index] = Math.Max(dpTemp[index], dp[i] + num);
            }
            dp = dpTemp;
        }
        return dp[0];
    }
}

