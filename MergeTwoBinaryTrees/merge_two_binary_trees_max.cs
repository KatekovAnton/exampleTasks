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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        TreeNode result = null;
        result = DeepFirstMerge(t1, t2, result);
        return result;
    }
    
    private TreeNode DeepFirstMerge(TreeNode t1, TreeNode t2, TreeNode mergedNode) {
        if (t1 != null && t2 != null) {
            mergedNode = new TreeNode(t1.val + t2.val);
            mergedNode.left = DeepFirstMerge(t1.left, t2.left, mergedNode.left);
            mergedNode.right = DeepFirstMerge(t1.right, t2.right, mergedNode.right);
        }
        if (t1 != null && t2 == null) {
            mergedNode = new TreeNode(t1.val);
            mergedNode.left = DeepFirstMerge(t1.left, t2, mergedNode.left);
            mergedNode.right = DeepFirstMerge(t1.right, t2, mergedNode.right);
        }
        if (t1 == null && t2 != null) {
            mergedNode = new TreeNode(t2.val);
            mergedNode.left = DeepFirstMerge(t1, t2.left, mergedNode.left);
            mergedNode.right = DeepFirstMerge(t1, t2.right, mergedNode.right);
        } 
        
        return mergedNode;
    }
}
