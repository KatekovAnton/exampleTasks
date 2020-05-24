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
    private int diameter = 1;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null)
            return 0;
        
        FindDiameter(root);
        return diameter - 1;
    }
    
    private int FindDiameter(TreeNode node) {
        int leftDepth = node.left != null ? FindDiameter(node.left) : 0;
        int rightDepth = node.right != null ? FindDiameter(node.right) : 0;
        int distance = leftDepth + rightDepth + 1;
        if (distance > diameter) {
            diameter = distance;
        }
        
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
