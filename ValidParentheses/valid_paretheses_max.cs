using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        bool isOk = true;
        for (int i = 0; i < s.Length && isOk; i++) {
            if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                stack.Push(s[i]);
            else if (stack.Count() == 0)
                isOk = false;
            else {
                char top = stack.Peek();
                if ((s[i] == '}' && top == '{') || 
                    (s[i] == ']' && top == '[') || 
                    (s[i] == ')' && top == '('))
                    stack.Pop();
                else
                    isOk = false;   
            }
        }
        if (stack.Count() != 0)
            isOk = false;
        return isOk;
    }
}
    class Program
    { 
        static void Main(string[] args)
        {
            string s = "{}{}{{[]}}(())";
            Solution solver = new Solution();
            bool isOk = solver.IsValid(s);
            Console.WriteLine(isOk);
        }
    }
}

