class TrieNode {
    public TrieNode[] children = new TrieNode[26];
    public bool isEndOfWord = false;
}

public class Trie {
    private TrieNode root;

    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieNode node = root;
        for(int i = 0; i < word.Length; i++) {
            int index = word[i] - 'a';
            if (node.children[index] == null) {
                node.children[index] = new TrieNode();
            }
            node = node.children[index];
        }
        node.isEndOfWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        TrieNode node = root;
        int i = 0;
        bool isInTree = true;
        while(i != word.Length && isInTree) {
            int index = word[i] - 'a';
            if (node.children[index] == null) {
                isInTree = false;
            } else {
                node = node.children[index];
            }
            i++;
        }
        
        return isInTree && node.isEndOfWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode node = root;
        int i = 0;
        bool isInTree = true;
        while(i != prefix.Length && isInTree) {
            int index = prefix[i] - 'a';
            if (node.children[index] == null) {
                isInTree = false;
            } else {
                node = node.children[index];
            }
            i++;
        }
        
        return isInTree;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
