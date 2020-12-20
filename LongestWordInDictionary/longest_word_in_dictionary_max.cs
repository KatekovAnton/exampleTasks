public class Node {
    public char Letter;
    public Dictionary<char, Node> Children = new Dictionary<char, Node>();
    public int End;
    
    public Node(char letter){
        this.Letter = letter;
    }
}

public class Trie {
    public Node Root;
    public string[] Words;
    
    public Trie() {
        Root = new Node('0');
    }
    
    public void Insert(String word, int index) {
        Node cur = Root;
        foreach(char letter in word.ToCharArray()) {
            if (!cur.Children.ContainsKey(letter)) {
                cur.Children.Add(letter, new Node(letter));
            }
            cur = cur.Children[letter];
        }
        cur.End = index;
    }

    public string DFS() {
        string ans = "";
        Stack<Node> stack = new Stack<Node>();
        stack.Push(Root);
        while (stack.Count() != 0) {
            Node node = stack.Pop();
            if (node.End > 0 || node == Root) {
                if (node != Root) {
                    string word = Words[node.End - 1];
                    if (word.Length > ans.Length ||
                            word.Length == ans.Length && string.Compare(word, ans) < 0) {
                        ans = word;
                    }
                }
                foreach (Node newNode in node.Children.Values) {
                    stack.Push(newNode);
                }
            }
        }
        return ans;
    }
}

public class Solution {
    public string LongestWord(string[] words) {
        Trie trie = new Trie();
        int index = 1;
        foreach (string word in words) {
            trie.Insert(word, index);
            index++;
        }
        trie.Words = words;
        return trie.DFS();        
    }
}
