// https://leetcode.com/problems/permutations
// runtime: 12ms
// memory: 7.3 MB
#include <vector>

class Solution {
public:
    vector<vector<int>> permute(vector<int>& nums) {
        vector<vector<int>> perms;

        if (nums.size() == 1) {
            perms.push_back(nums);
        } else if (nums.size() > 1) {
            auto slice_but_last = vector<int>(nums.begin(), nums.begin() + nums.size() -1);
            auto perms_prev = permute(slice_but_last);

            for (const vector<int> &perm_prev: perms_prev) {
                for (int i = 0; i < perm_prev.size() + 1; ++i) {
                    auto current_perm(perm_prev);
                    current_perm.insert(current_perm.begin() + i, nums.back());
                    perms.emplace_back(current_perm);
                }
            }
        }

        return perms;
    }
};
