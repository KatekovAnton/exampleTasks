public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = "";
        if (strs.Length == 0) {
            return prefix;
        }
        int minLength = 201;
        for (int i = 0; i < strs.Length; i++) {
            minLength = Math.Min(strs[i].Length, minLength);
        }
        int j = 0;
        bool isCommonFound = true;
        while (j < minLength && isCommonFound) {
            char common = strs[0][j];
            for (int i = 0; i < strs.Length && isCommonFound; i++) {
                if (strs[i][j] != common) {
                    isCommonFound = false;
                }
            }
            if (isCommonFound) {
                prefix += common;
            }
            j++;
        }
        
        return prefix;
    }
}
