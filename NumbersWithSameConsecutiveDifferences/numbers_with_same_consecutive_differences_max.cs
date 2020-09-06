public class Solution {
    List<int> nums = new List<int>();
    
    private void DFS(int N, int num, int K) {
        if (N == 0) {
            nums.Add(num);
            return;
        }
        
        List<int> children = new List<int>();
        
        int parent = num % 10;
        children.Add(parent + K);
        if (K != 0)
            children.Add(parent - K);
        
        foreach (int child in children) {
            if (child >= 0 && child < 10)
                DFS(N - 1, num * 10 + child, K);
        }
    }
    
    public int[] NumsSameConsecDiff(int N, int K) {
        if (N == 1)
            return new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        for (int i = 1; i < 10; i++)
            DFS(N - 1, i, K);
        
        return nums.ToArray();
    }
}
