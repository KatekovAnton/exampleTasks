// https://leetcode.com/problems/number-of-islands/
// time - 20 ms
// memory - 9.1Mb
// Solution uses BFS

typedef vector<vector<char>> MatrixChar;
typedef vector<vector<bool>> MatrixBool;
typedef pair<int, int> Coordinate;

class Solution {
public:
    void BFS_island(MatrixChar& grid, MatrixBool& visited, Coordinate start) {
        int height = grid.size(), width = grid[0].size();
        queue<Coordinate> to_process;
        vector<Coordinate> ngbs_shifts = {{0, 1}, {0, -1}, {1, 0}, {-1, 0}};
        auto in_bounds = [height, width](Coordinate node) {
            return node.first >= 0 && node.first < height &&
                   node.second >= 0 && node.second < width;
        };

        to_process.push(start);
        visited[start.first][start.second] = true;

        while (!to_process.empty()) {
            auto node = to_process.front();
            to_process.pop();

            for (auto ngb_shifts: ngbs_shifts) {
                Coordinate ngb(node.first + ngb_shifts.first, node.second + ngb_shifts.second);

                if (in_bounds(ngb) &&
                    !visited[ngb.first][ngb.second] &&
                    grid[ngb.first][ngb.second] == '1')
                {
                    visited[ngb.first][ngb.second] = true;
                    to_process.push(ngb);
                }
            }
        }
    }

    int numIslands(vector<vector<char>>& grid) {
        if (!grid.size()) {
            return 0;
        }

        int height = grid.size(), width = grid[0].size();
        MatrixBool visited(height, vector<bool>(width, false));


        int res = 0;
        for (int i = 0; i < height; ++i) {
            for (int j = 0; j < width; ++j) {
                if (grid[i][j] == '1' && !visited[i][j]) {
                    BFS_island(grid, visited, make_pair(i, j));
                    res++;
                }
            }
        }

        return res;
    }
};
