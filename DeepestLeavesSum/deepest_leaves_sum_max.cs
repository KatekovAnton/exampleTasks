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
    List<int> leavesValues = new List<int>();
    int maxDepth = 0;
    
    public int DeepestLeavesSum(TreeNode root) {
        int sum = 0;
        DFS(root, 0);
        for (int i = 0; i < leavesValues.Count(); i++)
            sum += leavesValues[i];
        
        return sum;    
    }
    
    public void DFS(TreeNode node, int depth) {
        if(node == null) 
            return;
        
        if (depth > maxDepth)
        {
            leavesValues.Clear();
            maxDepth = depth;
        }
        if (depth == maxDepth)
        {
            leavesValues.Add(node.val);
        }
        
        DFS(node.left, depth + 1);
        DFS(node.right, depth + 1);
    }
}
