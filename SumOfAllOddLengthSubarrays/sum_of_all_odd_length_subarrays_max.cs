public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
        }
        
        int subL = 3;
        while (subL <= arr.Length) {
            int i = 0;
            while (i + subL - 1 < arr.Length) {
                for (int j = 0; j < subL; j++) {
                    sum += arr[i + j];
                }
                i++;
            }
            subL += 2;
        }
        
        return sum;
    }
}
