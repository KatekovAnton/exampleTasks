public class Solution {
    private List<IList<int>> combos = new List<IList<int>>();
    
    private void FindCombo(int[] candidates, int target, int current, List<int> combo) {
        if (target == 0) {
            combos.Add(new List<int>(combo));
        }
        else {
            for (int i = current; i < candidates.Length && candidates[i] <= target; i++) {
                combo.Add(candidates[i]);
                FindCombo(candidates, target - candidates[i], i, combo);
                combo.RemoveAt(combo.Count() - 1);
            }            
        }
    }
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        FindCombo(candidates, target, 0, new List<int>());
        
        return combos;
    }
}
