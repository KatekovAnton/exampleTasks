public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        bool toeplitz = true;
        for (int startJ = 0; startJ < matrix[0].Length && toeplitz; startJ++) {
            int i = 0;
            int j = startJ;
            while (i < matrix.Length && j < matrix[0].Length && toeplitz) {
                if (matrix[i][j] != matrix[0][startJ]) {
                    toeplitz = false;
                }
                i++;
                j++;
            }
        }
        for (int startI = 1; startI < matrix.Length && toeplitz; startI++) {
            int i = startI;
            int j = 0;
            while (i < matrix.Length && j < matrix[0].Length && toeplitz) {
                if (matrix[i][j] != matrix[startI][0]) {
                    toeplitz = false;
                }
                i++;
                j++;
            }
        }
        
        return toeplitz;
    }
}
