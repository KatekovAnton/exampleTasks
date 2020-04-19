//https://leetcode.com/problems/maximum-subarray/submissions/
//T - 4 ms, memory - 7.1 mb
class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int res = nums[0], sum = 0;
        for (int num: nums) {
            sum += num;
            res = max(sum, res);
            sum = max(sum, 0);
        }
        return res;
    }
};
