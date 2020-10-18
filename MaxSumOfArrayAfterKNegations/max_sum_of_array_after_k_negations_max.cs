public class Solution {
    public int LargestSumAfterKNegations(int[] A, int K) {
        for (int i = 0; i < K; i++) {
            int min = int.MaxValue;
            int minJ = -1;
            for (int j = 0; j < A.Length; j++) {
                if (A[j] < min) {
                    min = A[j];
                    minJ = j;
                }
            }
            A[minJ] = -A[minJ];
        }
        
        int sum = 0;
        for (int i = 0; i < A.Length; i++) {
            sum += A[i];
        }
        
        return sum;
    }
}
