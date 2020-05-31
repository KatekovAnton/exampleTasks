public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, (x, y) => (x[0] != y[0]) ? y[0]-x[0] : x[1]-y[1]);
        List<int[]> result = new List<int[]>();
        for(int i = 0; i < people.Length; i++) {
            result.Insert(people[i][1], people[i]);
        }
        return result.ToArray();
    }
}
