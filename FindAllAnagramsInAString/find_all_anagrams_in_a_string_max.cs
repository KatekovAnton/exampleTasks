public class Solution {
    private int[] countLetters(string s) {
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i]- 'a']++;
        }
        return count;
    }
    
    private bool checkAnagram(int[] countStr, int[] countP) {
        bool isSame = true;
        for (int i = 0; i < countP.Length && isSame; i++) {
            if (countStr[i] != countP[i]) {
                isSame = false;
            }
        }
        
        return isSame;
    }
    
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> idxs = new List<int>();
        
        int[] countP = countLetters(p);
        for (int i = 0; i <= s.Length - p.Length; i++) {
            string subStr = s.Substring(i, p.Length);
            int[] countStr = countLetters(subStr);
            if (checkAnagram(countStr, countP)) {
               idxs.Add(i); 
            }
        }
        
        return idxs;
    }
}
