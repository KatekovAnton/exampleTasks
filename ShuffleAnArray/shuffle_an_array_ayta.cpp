//https://leetcode.com/problems/shuffle-an-array/
class Solution {
private:
    vector<int> arr, orig_arr;
public:
    Solution(vector<int>& nums) {
        orig_arr = arr = nums;
        srand (time(NULL));
    }

    /** Resets the array to its original configuration and return it. */
    vector<int> reset() {
        arr = orig_arr;
        return arr;
    }

    /** Returns a random shuffling of the array. */
    vector<int> shuffle() {
        int len = arr.size();
        for (int i = 0; i < len; ++i) {
            int next = rand() % len;
            swap(arr[i], arr[next]);
        }
        return arr;
    }
};
