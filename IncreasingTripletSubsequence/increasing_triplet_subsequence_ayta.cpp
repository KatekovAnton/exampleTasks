//https://leetcode.com/problems/increasing-triplet-subsequence/submissions/

class Solution {
public:
    bool increasingTriplet(vector<int>& nums) {
        vector<int> triplet(2, INT_MAX);
        for (int i = 0; i < nums.size(); ++i) {
            if (nums[i] <= triplet[0]) {
                triplet[0] = nums[i];
            } else if (nums[i] <= triplet[1]) {
                triplet[1] = nums[i];
            } else if (nums[i] > triplet[1]) {
                return true;
            }
        }
        return false;
    }
};
