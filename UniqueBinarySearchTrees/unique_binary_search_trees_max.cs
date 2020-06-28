public class Solution {
    public int NumTrees(int n) {
        int[] numBSTs = new int[n + 1];
        numBSTs[0] = numBSTs[1] = 1;
        for (int i = 2; i <= n; i++)
            for (int j = 1; j <= i; j++)
                numBSTs[i] += numBSTs[j - 1] * numBSTs[i - j];
        
        return numBSTs[n];
    }
}
