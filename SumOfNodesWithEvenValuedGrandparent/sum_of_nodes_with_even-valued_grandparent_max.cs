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
    private int sum = 0;
    
    private void DFS(TreeNode curr, List<int> path) {
        path.Add(curr.val);
        if (path.Count() >= 3 && path[path.Count() - 3] % 2 == 0) {
            sum += curr.val;
        }
        if (curr.left != null) {
            DFS(curr.left, new List<int>(path));
        }
        if (curr.right != null) {
            DFS(curr.right, new List<int>(path));
        }
    }
    
    public int SumEvenGrandparent(TreeNode root) {
        DFS(root, new List<int>());
        return sum;
    }
}
