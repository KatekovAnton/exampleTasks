public class Solution {
    Dictionary<int, int> dist;
    public int NetworkDelayTime(int[][] times, int N, int K) {
        Dictionary<int, List<int[]>> graph = new Dictionary<int, List<int[]>>();
        foreach (int[] edge in times) {
            if (!graph.ContainsKey(edge[0])) {
                graph.Add(edge[0], new List<int[]>());
            }
            graph[edge[0]].Add(new int[] {edge[1], edge[2]});
        }
        dist = new Dictionary<int, int>();
        for (int node = 1; node <= N; ++node)
            dist.Add(node, int.MaxValue);

        dist[K] = 0;
        bool[] seen = new bool[N+1];

        while (true) {
            int candNode = -1;
            int candDist = int.MaxValue;
            for (int i = 1; i <= N; ++i) {
                if (!seen[i] && dist[i] < candDist) {
                    candDist = dist[i];
                    candNode = i;
                }
            }

            if (candNode < 0) break;
            seen[candNode] = true;
            if (graph.ContainsKey(candNode))
                foreach (int[] info in graph[candNode])
                    dist[info[0]] = Math.Min(dist[info[0]], dist[candNode] + info[1]);
        }

        int ans = 0;
        foreach (int cand in dist.Values) {
            if (cand == int.MaxValue) 
                return -1;
            ans = Math.Max(ans, cand);
        }
        return ans;
    }
}
