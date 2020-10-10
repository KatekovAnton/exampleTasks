public class Solution {
    private int num = 0;
    
    private void UpTeam(int[] rating, int count, int i) {
        if (count == 3) {
            num++;
        } else if (count < 3) {
            for (int j = i + 1; j < rating.Length; j++) {
                if (rating[j] > rating[i])
                    UpTeam(rating, count + 1, j);
            }
        }
    }
    
    private void DownTeam(int[] rating, int count, int i) {
        if (count == 3) {
            num++;
        } else if (count < 3) {
            for (int j = i + 1; j < rating.Length; j++) {
                if (rating[j] < rating[i])
                    DownTeam(rating, count + 1, j);
            }
        }
    }
    
    public int NumTeams(int[] rating) {
        for (int i = 0; i < rating.Length - 2; i++) {
            UpTeam(rating, 1, i);
            DownTeam(rating, 1, i);
        }
        
        return num;
    }
}
