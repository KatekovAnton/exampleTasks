// https://leetcode.com/problems/island-perimeter/

public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter = 0;
        for(int i = 0; i < grid.Length; i++)
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1) 
                {
                    int sides = 0;
                    if ((i > 0 && grid[i - 1][j] == 0) || i == 0)
                        sides++;
                    if ((j > 0 && grid[i][j - 1] == 0) || j == 0)
                        sides++;
                    if ((i < grid.Length - 1 && grid[i + 1][j] == 0) || i == grid.Length - 1)
                        sides++;
                    if ((j < grid[0].Length - 1 && grid[i][j + 1] == 0) || j == grid[0].Length - 1)
                        sides++;
                    perimeter += sides;
                }
            }
        return perimeter;
    }
}
