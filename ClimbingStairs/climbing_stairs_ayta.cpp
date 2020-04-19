// https://leetcode.com/problems/climbing-stairs/submissions/
// time - 0ms
// memory - 6.2ms

class Solution {
public:
    int climbStairs(int n) {
        vector<int> dynamic(n + 1, 1);
        if (n < 2) {
            return 1;
        }
        for (int i = 2; i <= n; ++i) {
            dynamic[i] = dynamic[i - 1] + dynamic[i - 2];
        }
        return dynamic[n];
    }
};
