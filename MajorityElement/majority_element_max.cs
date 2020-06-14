public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!map.ContainsKey(nums[i])) {
                map.Add(nums[i], 0);
            } else {
                map[nums[i]]++;
            }
        }
        
        return map.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
    }
}
