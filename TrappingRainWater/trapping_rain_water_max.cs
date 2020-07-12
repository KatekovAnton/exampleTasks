public class Solution {
    public int Trap(int[] height) {
        int trapSum = 0;
        int maxIdx = -1;
        int maxHeight = 0;
        for (int i = 0; i < height.Length; i++) {
            if (height[i] > maxHeight) {
                maxIdx = i;
                maxHeight = height[i];
            }
        }
        int left = maxIdx;
        int right = maxIdx;
        while (left > 0 || right < height.Length - 1) {
            int maxLeftIdx = -1;
            int maxLeft = 0;
            for (int i = left - 1; i >= 0; i--) {
                if (height[i] >= maxLeft) {
                    maxLeftIdx = i;
                    maxLeft = height[i];
                }
            }
            if (maxLeftIdx != -1) {
                for (int i = maxLeftIdx + 1; i < left; i++) {
                    trapSum += height[maxLeftIdx] - height[i];
                }
                left = maxLeftIdx;
            }
            int maxRightIdx = -1;
            int maxRight = 0;
            for (int i = right + 1; i < height.Length; i++) {
                if (height[i] >= maxRight) {
                    maxRightIdx = i;
                    maxRight = height[i];
                }
            }
            if (maxRightIdx != -1) {
                for (int i = right + 1; i < maxRightIdx; i++) {
                    trapSum += height[maxRightIdx] - height[i];
                }
                right = maxRightIdx;
            }
        }
        
        return trapSum;
    }
}
