public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length <= 1) {
            return true;
        }
        List<int> paths = new List<int>();
        for (int i = nums.Length - 2; i >= 0; i--) {
            if (nums[i] + i >= nums.Length - 1) {
                paths.Add(i);
            }
        }
        bool canJump = paths.Contains(0);
        while (paths.Count() != 0 && !canJump) {
            for (int i = 0; i < paths.Count(); i++) {
                bool pathFound = false;
                for (int j = paths[i] - 1; j >= 0; j--) {
                    if (nums[j] + j >= paths[i]) {
                        paths[i] = j;
                        pathFound = true;
                    }
                }
                if (!pathFound) {
                    paths.Remove(paths[i]);
                }
            }
            if (paths.Contains(0)) {
                canJump = true;
            }
        }
        
        return canJump;
    }
}
