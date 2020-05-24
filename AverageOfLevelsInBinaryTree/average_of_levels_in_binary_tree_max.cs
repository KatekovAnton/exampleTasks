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
    List<double> averages = new List<double>();
    List<int> levelCounts = new List<int>();
    
    public IList<double> AverageOfLevels(TreeNode root) {
        AverageDFS(root, 0);
        for (int i = 0; i < averages.Count; i++) {
            averages[i] /= levelCounts[i];
        }
        return averages;
    }
    
    public void AverageDFS(TreeNode node, int level) {
        if(node == null) 
            return;
        
        if (level < levelCounts.Count())
        {
            levelCounts[level]++;
            averages[level] += node.val;
        }
        else 
        {
            levelCounts.Add(1);
            averages.Add(node.val);
        }
        
        AverageDFS(node.left, level + 1);
        AverageDFS(node.right, level + 1);
    }
}
