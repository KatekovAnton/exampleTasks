public class Solution {
    public string DecodeString(string s) {
        var str = $"1[{s}]";
        var stack = new Stack<string>();

        var numberStr = "";
        var oneStr = "";
        foreach (var c in str) {
            if (char.IsDigit(c)) {
                if (oneStr.Length > 0) {
                    if (stack.Any() && !char.IsDigit(stack.Peek()[0])) {
                        stack.Push(stack.Pop() + oneStr);
                    } else {
                        stack.Push(oneStr);
                    }
                }
                oneStr = "";

                numberStr += c;
            } else if (c == '[') {

                if (numberStr.Length > 0) {
                    stack.Push(numberStr);
                }
                numberStr = "";

            } else if (c == ']') {
                if (!char.IsDigit(stack.Peek()[0])) {
                    oneStr = stack.Pop() + oneStr;
                }
                var tempNumber = int.Parse(stack.Pop());
                var oneDecodeString = decodeOneString(oneStr, tempNumber);

                if (stack.Any() && !char.IsDigit(stack.Peek()[0])) {
                    stack.Push(stack.Pop() + oneDecodeString);
                } else {
                    stack.Push(oneDecodeString);
                }

                oneStr = "";

            } else {
                oneStr += c;
            }
        }

        return stack.Pop();
    }

    private string decodeOneString(string str, int repeatCount) {
        var stringBuilder = new StringBuilder();
        for (int i = 0; i < repeatCount; i++) {
            stringBuilder.Append(str);
        }
        return stringBuilder.ToString();
    }
}
