public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        int setCount = (int)Math.Pow(2, nums.Length);
        List<IList<int>> subSets = new List<IList<int>>();
        for (int i = 0; i < setCount; i++) {
            IList<int> subSet = new List<int>();
            for (int j = 0; j < nums.Length; j++) {
                if ((i & (1 << j)) > 0) {
                    subSet.Add(nums[j]);
                }
            }
            subSets.Add(subSet);
        }
        
        return subSets;
    }
}
