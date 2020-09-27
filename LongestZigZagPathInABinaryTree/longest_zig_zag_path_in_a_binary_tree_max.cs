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
    public int maxPath = 0;
    
    public void maxZigZag(TreeNode node, bool isLeft, int path) {
        maxPath = Math.Max(maxPath, path);
        if (node == null) {
            return;
        }
        maxZigZag(node.left, true, !isLeft ? path + 1 : 0); 
        maxZigZag(node.right, false, isLeft ? path + 1 : 0);
    }
    
    public int LongestZigZag(TreeNode root) {
        if (root == null) {
            return 0;
        }
        maxZigZag(root.left, true, 0);
        maxZigZag(root.right, false, 0);
        
        return maxPath;
    }
}
