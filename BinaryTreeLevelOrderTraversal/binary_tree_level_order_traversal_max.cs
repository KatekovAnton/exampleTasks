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
    private List<IList<int>> valuesByLevels = new List<IList<int>>();
    
    private void Traverse(TreeNode node, int level) {
        if (valuesByLevels.Count() <= level) {
            valuesByLevels.Add(new List<int>());
        }
        
        if (node.left != null) {
            Traverse(node.left, level + 1);
        }
        if (node.right != null) {
            Traverse(node.right, level + 1); 
        }
        
        valuesByLevels[level].Add(node.val);
    }
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root != null) {    
            Traverse(root, 0);   
        }
        return valuesByLevels;
    }
}
