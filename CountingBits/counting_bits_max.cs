public class Solution {
    public int[] CountBits(int num) {
        int[] results = new int[num + 1];
        int powerOffset = 1;
        for(int i = 1; i <= num; i++) {
            if (powerOffset * 2 == i) {
                powerOffset *= 2;
            }
            results[i] = results[i - powerOffset] + 1;
        }
        
        return results;
    }
}
