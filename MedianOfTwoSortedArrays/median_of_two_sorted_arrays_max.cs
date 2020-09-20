public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {  
        int l = nums1.Length + nums2.Length;
        int size = size = l / 2 + 1;
        double[] half = new double[size];
        int i = 0;
        int j = 0;
        int k = 0;
        while (k < size) {
            if (i < nums1.Length && (j >= nums2.Length || nums1[i] <= nums2[j])) {
                half[k] = nums1[i];
                k++;
                i++;
            } else if (j < nums2.Length) {
                half[k] = nums2[j];
                k++;
                j++;
            }
        }
        
        double median = 0;
        if (l % 2 == 0) {
            median = (half[size - 1] + half[size - 2]) / 2;
        } else {
            median = half[size - 1];
        }
        
        return median;
    }
}
