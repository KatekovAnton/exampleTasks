public class Solution {
    public int LongestMountain(int[] arr) {
        int left = 0;
        int maxLength = 0;
        
        while (left < arr.Length) {
            int right = left;
            if (right + 1 < arr.Length && arr[right] < arr[right + 1]) {
                while (right + 1 < arr.Length && arr[right] < arr[right + 1]) {
                    right++;
                }
                if (right + 1 < arr.Length && arr[right] > arr[right + 1]) {
                    while (right + 1 < arr.Length && arr[right] > arr[right + 1]) {
                        right++;
                    }
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
            }
            left = Math.Max(left + 1, right);
        }
        
        return maxLength;
    }
}
