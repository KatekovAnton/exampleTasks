public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int row = 0, col = matrix.GetLength(1) - 1;

        while(row <= matrix.GetLength(0) - 1 && col >= 0)
            if (matrix[row, col] == target)
                return true;
            else if (matrix[row, col] < target)
                row++;
            else if (matrix[row, col] > target)
                col--;

            return false;
    }
}
