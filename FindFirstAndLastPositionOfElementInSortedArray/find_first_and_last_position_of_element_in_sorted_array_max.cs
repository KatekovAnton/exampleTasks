public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums == null || nums.Length == 0){
            return new int[]{-1,-1};
        }

        int left = 0, right = nums.Length - 1;
        int mid = 0;
        while(left <= right){
            mid = left + (right - left)/2;
            if(nums[mid] == target){
                break;
            }else if(nums[mid] > target){
                right = mid - 1;
            }else{
                left = mid + 1;
            }
        }
        int[] ans = new int[]{-1,-1};
        
        if(nums[mid] == target){
            int l = mid, r = mid;
            while(l >= 0 && nums[l] == target){
                ans[0] = l--;
            }
            while(r < nums.Length && nums[r] == target){
                ans[1] = r++;
            }
        }
        return ans;
    }
}
