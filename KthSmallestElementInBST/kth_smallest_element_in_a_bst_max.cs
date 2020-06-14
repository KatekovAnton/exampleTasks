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
    
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        TreeNode currentNode = root;
        
        while(stack.Count != 0 && k != 0) {
            while(currentNode != null) {
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }
            currentNode = stack.Pop();
            k--;
            if (k != 0) {
               currentNode = currentNode.right; 
            }
        }
        
        return currentNode.val;
    }
}
