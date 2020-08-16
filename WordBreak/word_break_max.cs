public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        int len = s.Length;
        bool[] f = new bool[len + 1];
        f[0] = true;
        for (int i = 1; i < len + 1; i++)
            for (int j = 0; j < i; j++)
                if (f[j] && wordDict.Contains(s.Substring(j, i - j))){
                    f[i] = true;
                    break;
                }
        return f[len];
    }
}
