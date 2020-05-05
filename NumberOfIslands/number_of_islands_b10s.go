// https://leetcode.com/problems/number-of-islands/
// https://play.golang.org/p/CAsoDW3rzch
package main

import (
	"fmt"
	"strconv"
	"strings"
)

func main() {
	grid := [][]byte{{'1', '1', '1'}, {'0', '1', '0'}, {'1', '1', '1'}}
	grid = [][]byte{{'1', '0', '1', '1', '1'}, {'1', '0', '1', '0', '1'}, {'1', '1', '1', '0', '1'}}

	fmt.Println(numIslands(grid))
}

func numIslands(grid [][]byte) int {
	islands := 0
	discovered := map[string]bool{}
	//fmt.Println(grid)
	for i, _ := range grid {
		for j, _ := range grid[i] {
			//fmt.Println("iter")
			// small step for man, big for ppl
			if grid[i][j] == '1' {
				//fmt.Println("yay, new island!", i, j)
				islands++
				if i+1 < len(grid) && grid[i+1][j] == '1' {
					//fmt.Printf("%d:%d", i, j)
					discovered[fmt.Sprintf("%d:%d", i+1, j)] = true
					//grid[i+1][j] = '2'
				}
				if j+1 < len(grid[i]) && grid[i][j+1] == '1' {
					discovered[fmt.Sprintf("%d:%d", i, j+1)] = true
					//grid[i][j+1] = '2'
				}
			}

			for {
				if len(discovered) == 0 {
					//fmt.Println("no place to discover")
					break
				}
				for k := range discovered {
					delete(discovered, k)
					res := strings.Split(k, ":")
					row, _ := strconv.Atoi(res[0])
					col, _ := strconv.Atoi(res[1])
					//fmt.Println(k)
					grid[row][col] = '2'
					if row+1 < len(grid) && grid[row+1][col] == '1' {
						discovered[fmt.Sprintf("%d:%d", row+1, col)] = true
					}
					if row-1 >= 0 && grid[row-1][col] == '1' {
						discovered[fmt.Sprintf("%d:%d", row-1, col)] = true
					}
					if col+1 < len(grid[row]) && grid[row][col+1] == '1' {
						discovered[fmt.Sprintf("%d:%d", row, col+1)] = true
					}
					if col-1 >= 0 && grid[row][col-1] == '1' {
						discovered[fmt.Sprintf("%d:%d", row, col-1)] = true
					}

				}
			}

		}
	}
	//fmt.Println(grid)
	return islands
}
