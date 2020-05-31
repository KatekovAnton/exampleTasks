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
    
    public int MaxDepth(TreeNode root) {
        return root != null ? DFS(root, 1) : 0;
    }
    
    private int DFS(TreeNode node, int depth) {
        if (node.left == null && node.right == null)
            return depth;
        
        depth++;
        int depthLeft = depth;
        int depthRight = depth;
        
        if (node.left != null)
            depthLeft = DFS(node.left, depth);
        if (node.right != null)
            depthRight = DFS(node.right, depth);
        
        return Math.Max(depthLeft, depthRight);
    }
}
