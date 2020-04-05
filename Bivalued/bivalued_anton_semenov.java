import java.util.*;

public class BiValue {

    public static void main(String[] args) {
        int[][] tests = {
                {4, 2, 2, 4, 2}, // 5
                {1, 2, 3, 2}, // 3
                {0, 5, 4, 4, 5, 12}, // 4
                {4, 4}, // 2
                {0, 3, 3, 7, 3, 7, 3, 5, 3, 11, 1} // 6
        };
        for (int[] test: tests) {
            System.out.println(solutionK(test, 2));
        }
    }

    public static int solution(int[] nums) {
        Integer v1 = null;
        Integer v1LastI = null;
        Integer v2 = null;
        Integer v2LastI = null;

        int i = 0;
        int max = 0;
        int acc = 0;

        while (i < nums.length) {
            int v = nums[i];
            if (v1 == null) {
                v1 = v;
            } else if ((v1 != v) && (v2 == null)) {
                v2 = v;
            }

            if (v1.equals(v)) {
                v1LastI = i;
                acc += 1;
            } else if (v2.equals(v)) {
                v2LastI = i;
                acc += 1;
            } else {
                int closestI = Math.max(v1LastI, v2LastI);
                int farthestI = Math.min(v1LastI, v2LastI);
                int closestV = nums[closestI];

                if (v1.equals(closestV)) {
                    v2 = v;
                    v2LastI = i;
                } else {
                    v1 = v;
                    v1LastI = i;
                }

                acc = i - farthestI;
            }
            max = Math.max(acc, max);
            i += 1;
        }
        return max;
    }

    public static int solutionK(int[] nums, int k) {
        HashMap<Integer, Integer> uniquesLastIndices = new HashMap<>();

        if (nums.length <= k) {
            return nums.length;
        }

        uniquesLastIndices.put(nums[0], 0);
        int i = 1;
        int max = 1;
        int acc = 1;

        while (i < nums.length) {
            int v = nums[i];
            if (uniquesLastIndices.containsKey(v) || uniquesLastIndices.size() < k) {
                acc += 1;
                uniquesLastIndices.put(v, i);
            } else {
                Map.Entry<Integer, Integer> furthestPair = uniquesLastIndices.entrySet().stream().min(Map.Entry.comparingByValue()).get();
                uniquesLastIndices.remove(furthestPair.getValue());
                uniquesLastIndices.put(v, i);
                acc = i - furthestPair.getValue();
            }
            max = Math.max(acc, max);
            i += 1;
        }
        return max;
    }
}
