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
    private int result = 0;
    
    public int PathSum(TreeNode root, int sum)
    {
        DFS(root, sum, new List<int>());
        return this.result;
    }

    public void DFS(TreeNode node, int target, List<int> prevSum)
    {
        if (node == null)
            return;

        List<int> curSum = new List<int>();

        curSum.Add(node.val);

        foreach (var item in prevSum)
            curSum.Add(item + node.val);

        foreach (var item in curSum)
            if (item == target)
                this.result++;

        DFS(node.right, target, curSum);
        DFS(node.left, target, curSum);
    }
}
