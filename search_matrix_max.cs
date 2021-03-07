public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        if (target < matrix[0][0] || target > matrix[n - 1][m - 1]) {
            return false;
        }
        for (int i = 0; i < n; i++) {
            if (target >= matrix[i][0] && target <= matrix[i][m - 1]) {
                for (int j = 0; j < m; j++) {
                    if (target == matrix[i][j]) {
                        return true;
                    }
                }                
            }
        }
        
        return false;
    }
}
