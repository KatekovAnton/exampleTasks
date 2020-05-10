public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int iVal = Int32.MaxValue;
        int jVal = Int32.MaxValue;
        bool foundTriplet = false;
      
      for (int idx = 0; idx < nums.Length && !foundTriplet; idx++) {
        if (nums[idx] > jVal) {
            foundTriplet = true;   
        } else if (nums[idx] < iVal) {
            iVal = nums[idx];
        } else if (nums[idx] > iVal && nums[idx] < jVal) {
            jVal = nums[idx];
        }
      }
      
      return foundTriplet;
    }
}