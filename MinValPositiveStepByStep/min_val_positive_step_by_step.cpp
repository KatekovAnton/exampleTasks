// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/submissions/
// runtime - 0 ms
// memory - 7.6 mb

class Solution {
public:
    int minStartValue(vector<int>& nums) {
        int min_v = nums[0], s = 0;
        for (int num: nums) {
            s += num;
            min_v = min(min_v, s);
        }
        return max(1, 1 - min_v);
    }
};
