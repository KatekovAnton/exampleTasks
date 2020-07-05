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
    
    public (int, int) Traverse(TreeNode node) {
        if (node == null) {
            return (0, 0);
        }
        var choice = (0, 0);
        var left = Traverse(node.left);
        var right = Traverse(node.right);
        choice.Item1 = node.val + left.Item2 + right.Item2;
        choice.Item2 = Math.Max(left.Item1, left.Item2) + Math.Max(right.Item1, right.Item2);
        
        return choice;
    }
    
    public int Rob(TreeNode root) {
        var choice = (0, 0);
        if (root != null) {
            choice = Traverse(root);   
        }
        return Math.Max(choice.Item1, choice.Item2);
    }
}
