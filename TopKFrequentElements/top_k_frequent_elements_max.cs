public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary <int, int> freqMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!freqMap.ContainsKey(nums[i])) {
                freqMap.Add(nums[i], 1);
            }
            else {
                freqMap[nums[i]]++;
            }
        }
        
        for (int i = 0; i < k; i++) {
            int maxFreq = 0;
            int maxFreqKey = -1;
            foreach(var freq in freqMap) {
                if (freq.Value > maxFreq) {
                    maxFreq = freq.Value;
                    maxFreqKey = freq.Key;
                }
            }
            freqMap.Remove(maxFreqKey);
            result[i] = maxFreqKey;
        }
        
        return result;
    }
}
