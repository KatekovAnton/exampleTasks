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
    private List<TreeNode> visited = new List<TreeNode>();
    
    public void Traverse(TreeNode node) {
        visited.Add(node);
        if (node.left != null) {
            Traverse(node.left);
        }
        if (node.right != null) {
            Traverse(node.right);
        }
    }
    
    public void Flatten(TreeNode root) {
        if (root == null) {
            return;
        }
        Traverse(root);
        
        for (int i = 0; i < visited.Count() - 1; i++) {
            visited[i].left = null;
            visited[i].right = visited[i + 1];
        }
    }
}
