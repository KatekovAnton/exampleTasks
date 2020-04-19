class Solution {
public:
    bool isValid(string s) {
        stack<int> open_brackets;
        for (char c: s) {
            if (c == '(' || c == '{' || c == '[') {
                open_brackets.push(c);
            } else {
                if (open_brackets.size() < 1) {
                    return false;
                }
                char top_c = open_brackets.top();
                open_brackets.pop();
                if (top_c == '(' && c != ')') {
                    return false;
                } else if (top_c == '{' && c != '}') {
                    return false;
                } else if (top_c == '[' && c != ']') {
                    return false;
                }
            }

        }
        if (open_brackets.size() != 0)
            return false;
        return true;

    }
};
