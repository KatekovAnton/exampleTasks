//https://leetcode.com/problems/maximum-subarray/submissions/
// Solution with prefixes
// Time 8ms
// space 7.4 mb
class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        vector<int> prefix;
        int s = 0;
        for (int num: nums) {
            s += num;
            prefix.push_back(s);
        }

        int cur_min = 0, res = INT_MIN;
        for (int i = 0; i < prefix.size(); ++i) {
            res = max(res, prefix[i] - cur_min);
            cur_min = min(prefix[i], cur_min);
        }
        return res;
    }
};
