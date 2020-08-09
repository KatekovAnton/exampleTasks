public class MinStack {
    
    private Stack<(int item, int min)> stack;

    /** initialize your data structure here. */
    public MinStack() {
        stack = new Stack<(int, int)>();
    }
    
    public void Push(int x) {
        if (stack.Count() == 0) {
            stack.Push((item: x, min: x));
        } else {
            stack.Push((item: x, min: Math.Min(x, stack.Peek().min)));
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().item;
    }
    
    public int GetMin() {
        return stack.Peek().min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
