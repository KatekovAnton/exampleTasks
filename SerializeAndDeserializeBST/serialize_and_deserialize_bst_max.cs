/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) 
            return "#,";
        return root.val + "," + serialize(root.left) + serialize(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        int startIndex = 0;
        return traverse(data.Split(','), ref startIndex);
    }
    
    private TreeNode traverse(string[] split, ref int index) {
        if (split[index] == "#") 
            return null;
        
        TreeNode root = new TreeNode(int.Parse(split[index]));
        if (++index < split.Length) 
            root.left = traverse(split,ref index);
        if(++index < split.Length) 
            root.right = traverse(split,ref index);
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;
