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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) 
            return null;
        return BuildTree(preorder, inorder, 0, 0, inorder.Length - 1);
    }
    
    private TreeNode BuildTree(int[] preorder, int[] inorder, int preorderIndex, int start, int end) {
        if (start > end) 
            return null;
        TreeNode node = new TreeNode(preorder[preorderIndex]);
        int inorderIndex = findInorderIndex(inorder, start, end, preorder[preorderIndex]);
        int leftTreeSize = inorderIndex - start;
        int rightTreeSize = end - inorderIndex;
        node.left = BuildTree(preorder, inorder, preorderIndex + 1, start, inorderIndex - 1);
        node.right = BuildTree(preorder, inorder, preorderIndex + leftTreeSize + 1, inorderIndex + 1, end);
        return node;
    }
    
    private int findInorderIndex(int[] inorder, int start, int end, int key) {
        while (start < end && inorder[start] != key) {
            start++;
        }
        return start;
    }
}
