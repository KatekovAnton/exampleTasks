public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> nums = new List<int>();
        for (int i = left; i <= right; i++) {
            int num = i;
            bool isSelfDiv = true;
            while (num > 0 && isSelfDiv) {
                int div = num % 10;
                if (div == 0 || i % div != 0) {
                    isSelfDiv = false;
                }
                num /= 10;
            }
            if (isSelfDiv) {
                nums.Add(i);
            }
        }
        return nums;
    }
}
