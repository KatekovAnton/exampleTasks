// DFS
// https://leetcode.com/problems/course-schedule-ii/submissions/
class Solution {
public:
    bool DFS(int start, vector<vector<int>>& graph, vector<bool> &visited, vector<int> &traverse, set<int> cycle) {
        cycle.insert(start);
        visited[start] = true;

            for (int ngb: graph[start]) {
                if (cycle.count(ngb)) {
                    return false;
                }
                if (visited[ngb]) {
                    continue;
                }
                if (!DFS(ngb, graph, visited, traverse, cycle)) {
                    return false;
                }
            }

            traverse.push_back(start);

        return true;
    }

    vector<int> findOrder(int numCourses, vector<vector<int>>& prerequisites) {
        vector<bool> visited(numCourses, false);
        vector<int> traverse;
        vector<vector<int>> graph(numCourses, vector<int>());
        for (auto &p: prerequisites) {
            graph[p[0]].push_back(p[1]);
        }

        for (int i = 0; i < numCourses; ++i) {
            if (!visited[i]) {
                set<int> cycle;
                if (!DFS(i, graph, visited, traverse, cycle)) {
                    return {};
                }
            }
        }
        return traverse;
    }
};
