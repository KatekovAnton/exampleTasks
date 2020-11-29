public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> newIntervals = new List<int[]>();
        int i = 0;
        int n = intervals.Length;
        while(i < n && intervals[i][1] < newInterval[0]) {
            newIntervals.Add(intervals[i]);
            i++;
        }
        
        if (i < n && intervals[i][0] <= newInterval[0]) {
            newInterval[0] = intervals[i][0];
        }
        
        while (i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        newIntervals.Add(newInterval);
        
        while(i < n) {
            newIntervals.Add(intervals[i]);
            i++;
        }
        
        return newIntervals.ToArray();
    }
}
