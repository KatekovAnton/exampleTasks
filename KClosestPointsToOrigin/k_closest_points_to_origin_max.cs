public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        List<double> dists = new List<double>();
        List<int[]> kPoints = new List<int[]>();
        int i = 0;
        for (i = 0; i < points.Length; i++) {
            dists.Add(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
        }
        dists.Sort();
        double maxDist = dists[K - 1];
        i = 0;
        while (i < points.Length && K > 0) {
            if (Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2) <= maxDist) {
                kPoints.Add(points[i]);
                K--;
            }
            i++;
        }
        
        return kPoints.ToArray();
    }
}
