// https://leetcode.com/problems/longest-increasing-subsequence/
// DP
class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        int size = nums.size(), res = 0;
        if (size < 1) {
            return 0;
        }
        vector<int> dp(size, 1);
        for (int i = size - 1; i >= 0; --i) {
            int max_so_far = 0;
            for (int j = i + 1; j < size; ++j) {
                if (nums[j] > nums[i] && max_so_far < dp[j]) {
                    max_so_far = dp[j];
                }
            }
            dp[i] = max_so_far + 1;
            if (dp[i] > res) {
                res = dp[i];
            }
        }
        return res;
    }
};
