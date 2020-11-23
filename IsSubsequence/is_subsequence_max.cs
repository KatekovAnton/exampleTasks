public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s == "")
            return true;
        if (t == "")
            return false;
        int k = 0;
        for (int i = 0; i < t.Length && k < s.Length; i++) {
            if (t[i] == s[k])
                k++;
        }
        if (k == s.Length)
            return true;
        return false;
    }
}
