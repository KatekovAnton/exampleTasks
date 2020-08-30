public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1] - arr[0];
        bool sameDiff = true;
        int i = 2;
        while (i < arr.Length && sameDiff) {
            if (arr[i] - arr[i - 1] != diff) {
                sameDiff = false;
            }
            i++;
        }
        
        return sameDiff;
    }
}
