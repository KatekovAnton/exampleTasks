/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> sums = new List<int>();
    
    public int MaxLevelSum(TreeNode root) {
        DFS(root, 0);
        int max = int.MinValue;
        int maxI = -1;
        for (int i = 0; i < sums.Count; i++) {
            if (sums[i] > max) {
                maxI = i;
                max = sums[i];
            }
        }
        
        return maxI + 1;
    }
    
    public void DFS(TreeNode node, int level) {
        if(node == null) 
            return;
        
        if (level < sums.Count())
        {
            sums[level] += node.val;
        }
        else 
        {
            sums.Add(node.val);
        }
        
        DFS(node.left, level + 1);
        DFS(node.right, level + 1);
    }
}
