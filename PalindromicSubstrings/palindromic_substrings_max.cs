public class Solution {
    public int CountSubstrings(string s) {
        int result = 0;
        for (int i = 0; i < 2 * s.Length - 1; i++) {
            int left = i / 2;
            int right = left + i % 2;
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                result++;
                left--;
                right++;
            }
        }
        
        return result;
    }
}
