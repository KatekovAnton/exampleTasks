public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int count = 0;
        while(i >= 0 && s[i] == ' ') {
            i--;
        }
        
        while(i >= 0 && s[i] != ' ') {
            count++;
            i--;
        }
        
        return count;
    }
}
