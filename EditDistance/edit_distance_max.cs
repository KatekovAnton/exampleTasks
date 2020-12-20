public class Solution {
    public int MinDistance(string word1, string word2) {
        int n = word1.Length;
        int m = word2.Length;
        int[,] distanceMatrix = new int[n + 1, m + 1];
 
        if (n == 0) {
            return m;
        }
        if (m == 0) {
            return n;
        }
 
        for (int i = 0; i <= n; i++) {
            distanceMatrix[i, 0] = i;
        }
        for (int j = 0; j <= m; j++) {
            distanceMatrix[0, j] = j;
        }
 
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= m; j++) {
                int cost = (word2[j - 1] == word1[i - 1]) ? 0 : 1;
                distanceMatrix[i, j] = Math.Min(
                    Math.Min(distanceMatrix[i - 1, j] + 1, distanceMatrix[i, j - 1] + 1),
                    distanceMatrix[i - 1, j - 1] + cost);
            }
        }
        return distanceMatrix[n, m];
    }
}
