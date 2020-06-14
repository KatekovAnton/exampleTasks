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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> output = new List<int>();
        if (root == null) 
            return output;
        
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Peek().left != null) {
            stack.Push(stack.Peek().left); 
        }
        
        while(stack.Count() != 0) { 
            TreeNode currentNode = stack.Pop();
            output.Add(currentNode.val);
            if (currentNode.right != null) {
                stack.Push(currentNode.right);
                while (stack.Peek().left != null) {
                    stack.Push(stack.Peek().left); 
                }
            }
        }
        
        return output;
    }
}
