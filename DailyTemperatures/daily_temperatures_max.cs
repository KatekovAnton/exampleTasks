public class Solution {
    public int[] DailyTemperatures(int[] T) {
        int[] resultIdxs = new int[T.Length];
        Stack<int> stack = new Stack<int>();
        for (int i = T.Length - 1; i >= 0; --i) {
            while (stack.Count() != 0 && T[i] >= T[stack.Peek()]) 
                stack.Pop();
            resultIdxs[i] = stack.Count() == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }
        return resultIdxs;
    }
}
