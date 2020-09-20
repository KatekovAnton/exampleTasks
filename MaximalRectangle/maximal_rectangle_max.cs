public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return 0;
        
        int result = 0;
        int[] heights = new int[matrix[0].Length];
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
                if (matrix[i][j] == '1')
                    heights[j] += 1;
                else
                    heights[j] = 0;
            
            Stack<int> s = new Stack<int>();
            
            for (int k = 0; k <= heights.Length; k++)
            {
                int cur = k == heights.Length ? 0 : heights[k];
                
                while (s.Count > 0 && heights[s.Peek()] > cur)
                {
                    int h = heights[s.Pop()],
                        w = k - 1 - (s.Count == 0 ? -1 : s.Peek());
                    
                    result = Math.Max(result, h * w);
                }
                
                s.Push(k);
            }
        }
        
        return result;
    }
}
