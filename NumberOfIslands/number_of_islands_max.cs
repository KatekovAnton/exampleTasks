// https://leetcode.com/problems/number-of-islands/

public class Solution {
    public void removeIsland(char[][] grid, int i, int j)
    {
        if(!(i < 0 || i > grid.Length - 1 || j < 0 || j > grid[0].Length - 1 || grid[i][j] == '0'))
        {
            grid[i][j] = '0';
            removeIsland(grid, i - 1, j);
            removeIsland(grid, i + 1, j);
            removeIsland(grid, i, j - 1);
            removeIsland(grid, i, j + 1);
        }   
    }
    
    public int NumIslands(char[][] grid) {
        int islands = 0;
        for(int i = 0; i < grid.Length; i++)
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1') 
                {
                    islands++;
                    removeIsland(grid, i, j);
                }
            }
        return islands;
    }
}
