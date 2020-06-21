public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.GetLength(0);
        int i,j;
        i=j=0;
        while (j<=n/2)
        {
            i=j;
            while(i<n-1-j)
            {
                int t = matrix[i][j];
                matrix[i][j] = matrix[n-1-j][i];
                matrix[n-1-j][i] = matrix[n-1-i][n-1-j];
                matrix[n-1-i][n-1-j] = matrix[j][n-1-i];
                matrix[j][n-1-i]=t; 
                i++;
            }
            j++;
        }
    }
}
